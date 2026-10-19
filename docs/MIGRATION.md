# From Windows Forms to the web: Relay CRM on Wisej.NET 4.2

This repository holds the same CRM twice:

| App | Project | Runs |
|---|---|---|
| The classic desktop app | `src/RelayCrm.WinForms` | Windows Forms, .NET 10 (Windows) |
| The same app on the web | `src/RelayCrm.Wisej` | Wisej.NET 4.2, ASP.NET Core, any browser |

Both use `src/RelayCrm.Core` (data, business rules, SQLite database) without a single change. The Wisej app was
not rewritten: it is the WinForms source code, migrated in two commits that follow the official guide,
[Wisej.NET migration](https://docs.iceteagroup.com/migration/):

1. **Lift** (`Migrate RelayCrm.WinForms to Wisej.NET 4.2 (step 1: lift)`): copy the WinForms sources, replace the
   namespace, fix what does not compile. The result runs in the browser and looks like the desktop app.
2. **Modernize** (`Modernize the migrated app with Wisej.NET 4.2 (step 2)`): the "optimizations after migration" of
   the guide and the new Wisej.NET 4.2 controls give it the look and the interaction of a modern web app.

`git diff 1fb6c44~1 1fb6c44 -- src/RelayCrm.Wisej` shows step 1, `git diff 1fb6c44 fe6edac` shows step 2.

---

## Step 1 — Lift

### What the guide says, and what we did

| Guide page | What we did |
|---|---|
| [WinForms Migration First Steps](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/winforms-to-wisej) — new SDK project | New `src/RelayCrm.Wisej/RelayCrm.Wisej.csproj` (`Microsoft.NET.Sdk.Web`, `Wisej-4` 4.2.0-test.1, targets `net8.0-windows;net10.0`, project reference to RelayCrm.Core). The WinForms `.cs` and `.Designer.cs` files were copied as they are. |
| First Steps — Startup file | `Startup.cs`: `WebApplication.CreateBuilder` with `WebRootPath = "./"`, `app.UseWisej()`, `app.UseFileServer()`. |
| First Steps — configuration files | `Default.html`, `Default.json` (`"startup": "RelayCrm.Program.Main, RelayCrm.Wisej"`), `Web.config`, `Properties/launchSettings.json` (port 5100). |
| First Steps — replacing the WinForms namespaces | `System.Windows.Forms` → `Wisej.Web` in every file (2,534 occurrences), including the designer files. |
| First Steps — compiler errors, "remove obsolete lines" | Built, then removed the WinForms-only properties the guide mentions (`.*UseVisualStyleBackColor.*\n` and friends) and fixed the other errors, file by file. |
| First Steps — Program.Main | Removed `ApplicationConfiguration.Initialize()` and the unhandled-exception mode; `Main(NameValueCollection)` reads the development switches from the URL (`?user=1&page=DealsView`); `new MainForm(options).Show()` instead of `Application.Run(...)`; the database path is `Application.MapPath("relay.db")`. |
| [Advanced Topics — Statics vs. Session Variables](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/advanced-migrations/statics-vs.-session-variables) | A static is shared by every user of a web app. The signed in user already lived in an `ISessionBag` in Core: `CurrentUser.Bag = new WisejSessionBag()` puts it in `Application.Session`. `MainForm.Instance` is kept in the session too. |
| [Advanced Topics — Modal Dialogs](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/advanced-migrations/modal-dialogs) | Every dialog was already shown in a `using` block. One difference showed up at run time: Wisej closes a modal dialog when its `DialogResult` is set only when asked to, so `Program.Main` sets `Form.AutoCloseModalDialogDefault = true` (the WinForms behavior). With that switch on, clicking a dialog's `AcceptButton` also sets `DialogResult.OK` and closes the dialog *before* the button's `Click` handler runs, which skipped validation and saving. The eight dialogs whose Save/Sign in button validates in `Click` therefore no longer set `AcceptButton`; Confirm and Filter keep it (their OK button already has `DialogResult.OK`). |
| [Advanced Topics — File Access](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/advanced-migrations/file-access) | The CSV export wrote a file chosen with a `SaveFileDialog`: in the browser it is `Application.Download(stream, "contacts.csv")`. Opening a company's website (`Process.Start`) is `Application.Navigate(url, "_blank")`. |

### The numbers

Measured against a copy of the WinForms sources where only `System.Windows.Forms` was replaced with `Wisej.Web`
(`git diff --no-index --numstat` per file):

| | |
|---|---|
| WinForms source files (`.cs`, designer files included) | 62 files, 18,768 lines |
| Files byte-identical after the namespace replace | **15 of 62**: the code of 8 dialogs (edit contact, company, deal, task, log activity, lost reason, invite user, deal detail), `Navigator`, `Notify`, `QueryFilter`, `SortableBindingList`, `ToneExtensions`, `IRefreshable`, `StageColumn.Designer.cs` |
| Lines removed or replaced | 1,501 |
| Lines added | 915 |
| **Lines unchanged** | **17,267 of 18,768 (92%)** |
| Designer files (`*.Designer.cs`) | 11,839 lines: −1,023 / +712 |
| Code files | 6,929 lines: −478 / +203 |
| New files | `Startup.cs` (25 lines), `Services/WisejSessionBag.cs` (18 lines), project and configuration files |
| RelayCrm.Core | unchanged |

### Every change of step 1, by category

Approximate line counts from the diff (a line can count in two categories).

| Category | Lines −/+ | Example |
|---|---|---|
| Namespace `System.Windows.Forms` → `Wisej.Web` | 2,534 occurrences, not counted above | `using Wisej.Web;` |
| ToolStrip family → Wisej menus, toolbars, status bar | −536 / +599 | `MenuStrip` → `MenuBar`, `ToolStripMenuItem` → `MenuItem` (`ShortcutKeys = Keys.Control \| Keys.N` → `Shortcut = Shortcut.CtrlN`), `ToolStrip` → `ToolBar` with `ToolBarButton` (separators, toggle and drop-down styles), `ToolStripTextBox`/`ToolStripComboBox` → `TextBox`/`ComboBox` hosted in a `ToolBarControl`, `ContextMenuStrip` → `ContextMenu` (`Opening` → `Popup`), `StatusStrip` → `StatusBar` with `StatusBarPanel` |
| WinForms-only designer properties deleted (the guide's regex) | −161 / 0 | `UseVisualStyleBackColor` (67), `GripStyle` (23), `BackgroundColor` (18), `FullRowSelect` (13), `UseCompatibleStateImageBehavior` (12), `HideSelection` (8), `ShowIcon`, `IntegralHeight`, `FlatStyle`, ... and the tool strip item sizes and alignments (69) |
| Charts: `WinForms.DataVisualization` (GDI+, Windows only) → Wisej 4.2 `ChartView`, `Sparkline` | −276 / +105 | `Chart`/`ChartArea`/`Series` → `ChartView`/`ChartSeries`; the data code is the same thanks to a 5-line `AddXY` extension; the hit test under the mouse became the `PointClick` event; the KPI sparkline charts became `Sparkline` controls |
| ListView | −92 / +11 | Wisej's ListView has no `ListViewGroup`: the tasks list inserts a bold header row per group, the search results show the kind by their icon; `ItemActivate` → `ItemDoubleClick` (the same handlers) |
| DataGridView | −12 / +19 | the 12-month trend drawn in `CellPainting` → `DataGridViewSparklineColumn`; `CellContentClick` → `CellClick`; `CurrentCellDirtyStateChanged` not needed (check boxes and combo boxes commit at once) |
| Toggle buttons | −19 / +33 | `ToolStripButton.Checked` → `ToolBarButton.Pushed` with `Style = ToggleButton` |
| Drag and drop | −20 / +6 | the card started the drag from `MouseMove` after `SystemInformation.DragSize`; in the browser the client starts it: `AllowDrag = true` and `OnDragStart` → `DoDragDrop` |
| Icons | −95 / +46 | the Segoe MDL2 glyphs drawn into bitmaps → the SVG files of the Wisej BootstrapIcons extension (`Icons.Prefix`/`Suffix`); `SystemIcons.Warning.ToBitmap()` → the theme icon `"messagebox-warning"` |
| Statics → session | −2 / +5 | `MainForm.Instance` in `Application.Session`, `CurrentUser.Bag = new WisejSessionBag()` |
| Files and processes | −8 / +4 | `SaveFileDialog` → `Application.Download`, `Process.Start` → `Application.Navigate` |
| Program.Main and hosting | −6 / +5 | see the table above, plus `Startup.cs` |
| Small API differences | −30 / +10 | `Cursor.Current` (11, the browser shows the loader), `LogicalToDeviceUnits` (8, CSS pixels), `e.SuppressKeyPress` (4), `MessageBox.Show(this, ...)` from a user control, `GetDisplayRange(false)` → `GetDisplayRange()`, `FirstDisplayedScrollingColumnIndex` → `FirstDisplayedColumnIndex`, `TextRenderer` → `Graphics.DrawString`, an alias for `FilterField` (Wisej 4.2 has a class of the same name) |

MainForm stays a `Form` (borderless and maximized, the main window of the browser page) rather than becoming a
`Page`: the code uses `Load`, `Shown`, `Hide`/`Show` for sign out and `FormClosed`, which a Form has, so nothing
had to change.

---

## Step 2 — Modernize

The guide's [Optimizations After Migration](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/)
and the controls new in Wisej.NET 4.2. The features are the ones of the WinForms app; the code is still the
migrated code, with designer files that stay designer files.

| WinForms piece | Wisej.NET 4.2 replacement | Guide page |
|---|---|---|
| System colors, stock look | `Themes/Relay.mixin.theme` (indigo accent, grid headers, titles) and `Themes/relay.css` (cards, buttons, toolbars) through `CssClass` and `AppearanceKey`; splash screen in `Default.html` | [Theming](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/theming) |
| Status bar messages, error message boxes | `AlertBox` toasts in `Notify` | [Alert Boxes](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/alert-boxes) |
| MenuStrip + ToolStrip + TreeView page list + StatusStrip | `NavigationBar` (overdue tasks as the badge of Tasks) and a header: page title, search box, "New" menu button, notifications, user `Avatar` with its menu; the keyboard shortcuts are `Accelerators` of the form (Alt+N, Alt+T, Alt+L, Alt+B, Alt+R, Alt+1…8: browsers keep Ctrl+N, Ctrl+T, Ctrl+L, Ctrl+1…8 and F5 for themselves) | |
| Ctrl+K search dialog (TextBox + grouped ListView) | `CommandPalette` (results grouped by kind) | |
| Dashboard KPI group boxes with labels and sparkline charts | `KpiPanel` tiles (value, caption, trend, sparkline) | |
| DataVisualization charts | `ChartView` (already in step 1) | |
| "My tasks today" ListView | `ActionCardList` | |
| "Recent activity" ListView | `Timeline` | |
| Period combo box | `SegmentedButton` | |
| Grids with colored text cells | `DataGridViewChipColumn` (stages, task status, tags), `DataGridViewAvatarColumn` (people, owners, companies), `DataGridViewSubtitleColumn`, `DataGridViewMeterColumn` (probability, share), `DataGridViewSparklineColumn` | [Enhanced DataGridView](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/enhanced-datagridview) |
| Quick filter toggle buttons with counts in the text | `ChipGroup` with counts | |
| Search boxes | watermarks (`PlaceholderText` → `Watermark` already in step 1) and a clear/search tool button | [Watermarks](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/watermarks), [Tool Buttons](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/tool-buttons) |
| "Nothing found" labels and link labels | `EmptyState` (with the "Clear the filters" action) | |
| Advanced filter dialog (combo boxes + list box of conditions) | `QueryBuilder` in the same dialog; the lists still apply the same `FilterQuery` | |
| Deals board: FlowLayoutPanel of `StageColumn` user controls with `DealCard`s, drag and drop | `KanbanBoard` (drag between stages and reorder; Lost asks the reason; the card menu stays) | |
| Activities calendar: MonthCalendar + ListView of the selected days | `SchedulerView` (month, week, day, agenda) + `Timeline` of the selected day; double-click a slot to log an activity | |
| Contact and company headers: avatar picture, colored stage label, KPI group boxes, activity ListView | `Avatar`, `ChipLabel`, `KpiPanel`, `Timeline`, `ActionCardList` for the contact's deals | |
| Deal dialog: stage path as text ("✓ Qualification › ● Discovery › ○ …") | `Stepper` | |
| Avatars drawn with GDI+ into bitmaps | SVG image sources (`Avatars.Source`), nothing drawn on the server | |
| Fixed desktop layout | `ClientProfiles.json` (Phone ≤ 767 px, Tablet ≤ 1199 px); responsive properties in `MainForm.resx`, `ContactsView.resx`, `CompaniesView.resx` (icon rail on tablets, menu button on phones, stacked filters) and a reflow of the dashboard cards on `ResponsiveProfileChanged` | [Responsive Properties](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/responsive-properties) |

Not used in this demo: [Enhanced TabControl](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/enhanced-tabcontrol),
[AllowHtml](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/allowhtml/),
[Label Wrapper](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/label-wrapper) and
[VirtualScroll](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/virtualscroll)
(the grids of Wisej load their rows on demand already).

Removed in step 2 because a 4.2 control replaces them: `Dialogs/SearchDialog`, `Views/DealCard`, `Views/StageColumn`.

---

## What stayed 100% shared

`src/RelayCrm.Core` — entities, `RelayDbContext` (SQLite), the seeder, and every service (contacts, companies,
deals, activities, tasks, dashboard, reports, settings, search, lookups, formatting) — is used by both apps as
it is. It has no reference to any user interface library: icons are Bootstrap icon names, colors are a
`Tone`, and the signed in user lives in an `ISessionBag` that the desktop app keeps per process and the web app
keeps per browser session.

---

## Running the two apps

Both apps create their SQLite database (`relay.db`) with the demo data on first start.

**Windows Forms** (Windows):

```
dotnet run --project src/RelayCrm.WinForms
```

Development switches: `--user=1` signs in without the dialog, `--page=DealsView` opens a page,
`--contact=5`, `--company=5`, `--deal=5` open a record.

**Wisej.NET 4.2** (the `Wisej-4` 4.2.0-test.1 package is a pre-release: put `wisej-4.4.2.0-test.1.nupkg` in the
`packages` folder, see `nuget.config`):

```
dotnet run --project src/RelayCrm.Wisej -f net10.0 --launch-profile RelayCrm.Wisej
```

Then open http://localhost:5100/Default.html. The same switches work in the URL:
`http://localhost:5100/Default.html?user=1&page=DealsView`.

The `net8.0-windows` target of the Wisej project is there for the Visual Studio designer only.

Screenshots of the WinForms app: `docs/winforms-*.png`.
