# Relay CRM: WPF → Wisej.NET 4.2

This project is the WPF app in `src/RelayCrm.WPF` migrated to a Wisej.NET 4.2 web app. The WPF project is the
"before" and is unchanged. The shared data layer (`src/RelayCrm.Core`) is referenced as it is.

Run it with `dotnet run --framework net10.0 --launch-profile RelayCrm` and open http://localhost:5200/Default.html.
`?user=1&page=DealsView&deal=1` replaces the WPF command line switches `--user=1 --page=DealsView --deal=1`.

Guide used: the Ice Tea Group migration guide, https://docs.iceteagroup.com/migration/

The migration has two steps. Sections 1 to 9 describe step 1, the faithful lift of the WPF app. Section 10 describes
step 2, the modernization with the Wisej.NET 4.2 controls, done the same way as for the WinForms app
(`src/RelayCrm.Wisej`, see `docs/MIGRATION.md`). Where step 2 fixed a gap of step 1, section 9 says so.

## 1. Approach

The guide lists WPF under *semi-automated modernization*. Unlike WinForms, it has no namespace swap:

- **XAML was translated by hand.** Each `.xaml` file became a Wisej `X.Designer.cs` written in the standard designer
  format, so every screen opens in the Visual Studio Wisej designer.
- **Kept:** the C# code-behind (`.xaml.cs` became `X.cs`), the services and `RelayCrm.Core`. Only the lines that use a
  WPF type were edited.
- **Names did not change.** Class names (`MainWindow`, `DashboardView`, `DealEditDialog`...), control names
  (`x:Name` became the field name) and handler names (where the event still exists) are the same. A side-by-side diff
  of the two projects shows the migration line by line.
- **The order was port first, then optimize.** The faithful port came first. A few of the guide's
  "optimizations after migration" were applied afterwards (section 7).

## 2. Checklist that was followed

1. **SDK web project.** Steps from [WinForms Migration First Steps](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/winforms-to-wisej):
   - `Microsoft.NET.Sdk.Web` targeting `net8.0-windows;net10.0`. The net8.0-windows target is for the VS designer.
   - Package `Wisej-4` 4.2.0-test.1 from the local feed.
   - `Startup.cs` with `WebApplication.CreateBuilder(... WebRootPath = "./")`, `UseWisej()`, `UseFileServer()`, `Run()`.
   - Added `Default.html`, `Default.json` (startup `RelayCrm.Program.Main`) and `Web.config`.
   - `Default.json` and `Web.config` are set to CopyToOutputDirectory Never. `relay.db*` is excluded from the content.
2. **`App.xaml` + `App.OnStartup` became `Program.Main(NameValueCollection args)`.**
   - Main opens the database, applies `?user=`, shows the modal `SignInDialog`, then sets `Application.MainPage = new MainWindow(options)`.
   - There is no `Application.Run`.
   - `StartOptions.Parse` reads the URL arguments with the same semantics as the old command line switches.
   - What was left of `App` (the error log, the unhandled exception handlers) is a small static class, `App.cs`.
     It now uses `Application.ThreadException`.
3. **`MainWindow` (Window) became a `Page`.** It keeps the menu, the toolbar with the search box and user menu, the
   navigation list, the content host and the status bar.
4. **Every Window became a `Form`, every UserControl a `UserControl`.** Each has `X.cs` + `X.Designer.cs`.
5. **Statics became session state.** See section 4 and
   [Statics vs. Session Variables](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/advanced-migrations/statics-vs.-session-variables).
6. **Modal dialogs: one style, disposed.** See section 5 and
   [Modal Dialogs](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/advanced-migrations/modal-dialogs).
7. **File access moved to the browser.** See section 5 and
   [File Access](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/advanced-migrations/file-access).
8. **Converters and DataTemplates became explicit code** (section 3).
9. **Optimizations** from [Optimizations After Migration](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/)
   (section 7).
10. **Checks:** a build of both target frameworks, then a click-through of every page and the main dialogs in the browser.

## 3. WPF → Wisej mapping as used

| WPF | Wisej | Notes |
| --- | --- | --- |
| `Window` | `Form` | `ResizeMode=NoResize` → `FormBorderStyle.Fixed`; `SizeToContent` → a fixed `ClientSize`; `Title` → `Text` |
| Main `Window` | `Page` | `Application.MainPage`; `Title` → `Page.Text` (the browser title) |
| `UserControl` | `UserControl` | |
| `Grid` (fields) | `TableLayoutPanel` | Auto/`*` columns → AutoSize/Percent |
| `DockPanel` | `Panel` + `Dock` | the last control added docks first |
| `StackPanel` | `FlowLayoutPanel` or Dock=Top panels | |
| `UniformGrid` | `TableLayoutPanel` with equal percent columns | KPI row, deal stage steps |
| `ScrollViewer` | `Panel.AutoScroll` | |
| `Border` | `Panel` with `BorderStyle.Solid` | |
| `GroupBox` | `GroupBox` | |
| `TextBlock` | `Label` | `TextTrimming` → `AutoEllipsis`; styled `Run`s → `AllowHtml` or several labels |
| `Hyperlink` | `LinkLabel` (`LinkClicked`) | in the status bar: a `StatusBarControl` hosting a LinkLabel |
| `TextBox` | `TextBox` | the hint TextBlock over the search box → `Watermark`; `AcceptsReturn` → `Multiline` |
| `ComboBox` | `ComboBox` | `ItemsSource`/`DisplayMemberPath`/`SelectedValuePath` → `DataSource`/`DisplayMember`/`ValueMember`; non editable → `DropDownList` |
| `DatePicker` | `DateTimePicker` | `SelectedDate` → `NullableValue` |
| `CheckBox`, `RadioButton` | same | `IsChecked == true` → `Checked`; `Checked` event → `CheckedChanged` (it also fires on uncheck, so the handlers test `Checked`) |
| `Button` | `Button` | `IsDefault` → `Form.AcceptButton`; `IsCancel` → `DialogResult.Cancel` + `CancelButton` |
| `DataGrid` | `DataGridView` | `DataGridTextColumn` → `DataGridViewTextBoxColumn` (`Binding` path → `DataPropertyName`); template checkbox/combo columns → `DataGridViewCheckBoxColumn`/`DataGridViewComboBoxColumn`; `MouseDoubleClick` → `CellDoubleClick` |
| Sparkline template column | `DataGridViewSparklineColumn` | Wisej 4.2 |
| `ListBox` + `DataTemplate` | `ListBox` with `AllowHtml` + `TemplateItem` HTML | `Services/TemplateItem.cs` |
| `ItemsControl` of controls | `FlowLayoutPanel`/`TableLayoutPanel` filled in code | deal board, calendar days, tag check boxes, filter rules |
| `TabControl` | `TabControl`/`TabPage` | `Header` → `Text` |
| `Menu` | `MenuBar` | `InputGestureText` → `MenuItem.Shortcut` (it works in Wisej) |
| `ContextMenu` | `ContextMenu` assigned to the control | `ContextMenuOpening` → `Popup`; right click selects the row (`RightClickSelection`/`CellMouseDown`) |
| `ToolBar` | `ToolBar` + `ToolBarButton` | a ToolBar docked Left/Right turns vertical: it sits in a Panel docked Left (`panelToolBarLeft`); the user `Menu` → a `DropDownButton` with a ContextMenu |
| `StatusBar` | `StatusBar` + `StatusBarPanel`s | |
| `Popup` | `UserPopup` (`ShowPopup(opener)`) | `IsOpen` → own flag, because `UserPopup.Visible` is always true |
| `DispatcherTimer` | `Timer` component | |
| `PreviewKeyDown` shortcuts | `MenuItem.Shortcut` + `Page.Accelerators` | Ctrl+K, F5 and Ctrl+1..8 through the menu; Alt+Left through `Accelerators`/`Accelerator` |
| Drag and drop | `AllowDrag`/`AllowDrop` + `DragStart`/`DragOver`/`DragDrop` | `DoDragDrop(row, Move)` |
| `Ellipse` avatar | Label/Panel with `CssStyle "border-radius:50%"` or avatar HTML | |
| Hand-drawn `BarChart` (OnRender) | `BarChart : ChartView` | see section 6 |
| Hand-drawn `Sparkline` | `Wisej.Web.Sparkline` | |
| `IValueConverter`s | `FmtConverter`/`ToneBrushConverter` static helpers; grid columns name them in `Tag` (`"Fmt:Money"`, `"ToneOf:CloseTone"`, `"Bold"`) applied by `GridHelper` in `CellFormatting` | |
| `Brush` | `System.Drawing.Color` | `ToBrush()` → `ToColor()`; `SystemColors.ControlTextBrush` → `Color.Empty` |
| `Mouse.OverrideCursor = Wait` | removed | Wisej shows its loader |
| `Process.Start(url)` | `Application.Navigate(url, "_blank")` | |
| `SaveFileDialog` + `File.WriteAllText` | `Application.Download(stream, name)` | |

## 4. Statics → session

| Static in WPF | After | Why |
| --- | --- | --- |
| `MainWindow.Instance` | property backed by `Application.Session["RelayCrm.MainWindow"]` | every browser has its own main page; used by `Navigator` and `Notify` |
| `CurrentUser` (Core) | `CurrentUser.Bag = new WisejSessionBag()` in `Program.Main` | Core already had an `ISessionBag` hook; the bag reads and writes `Application.Session` |
| `StartOptions` | an instance held by the session's `MainWindow` | |
| `App.ErrorLogPath`, `LostReasonDialog.CommonReasons`, `ChartColors`, `Fmt` | still static | global, user independent (the guide's "lookup data") |

A whole `Statics` wrapper class was not needed: only one class held user state in a static, and that state went behind
its own property.

## 5. Dialogs and files

- **Modal style.** One style everywhere: a blocking `ShowDialog()` inside `using`, or `DialogHelper.ShowModal(dialog)`,
  which disposes the dialog.
  - Wisej suspends the server thread, so WPF code like `if (DealEditDialog.Edit(id)) RefreshData();` and
    `ConfirmDialog.Ask(...)` is unchanged.
  - The static `Edit/Log/Ask` helpers dispose the dialog when loading fails.
  - `MessageBox.Show(owner, ..., MessageBoxButton, MessageBoxImage)` became
    `MessageBox.Show(text, caption, MessageBoxButtons, MessageBoxIcon)`. There is no owner window in a browser.
- **Wisej 4.2 gotcha 1: `DialogResult` does not close the dialog.** Wisej does not close a modal dialog when
  `DialogResult` is set, neither by code nor by a Cancel button, unless `Form.AutoCloseModalDialog` is on (the default
  is false since 3.5.6). WPF's `DialogResult = true` and `IsCancel` rely on closing.
  - `Startup.Main` calls `AppContext.SetSwitch("FormAutoCloseModalDialog", true)`.
  - Without the switch, every dialog hangs open.
- **Wisej 4.2 gotcha 2: the AcceptButton closes the dialog before validation.** Assigning `AcceptButton` sets that
  button's `DialogResult` to OK. With auto-close on, the dialog would close before the Save handler validates the input.
  - Each dialog calls `DialogHelper.KeepOpenOnAccept(this)` after `InitializeComponent()`.
  - The Save handlers set `DialogResult = DialogResult.OK` themselves, as in WPF.
- **Wisej 4.2 gotcha 3: a dialog shown before the main page is centred on (0, 0).** The sign-in dialog opens in
  `Program.Main`, before `Application.MainPage` exists, so `CenterScreen` is computed against an empty desktop and
  the dialog is half off-screen to the left.
  - `SignInDialog.SignIn` places the dialog itself from `Application.Browser.Size` (reported at session start) with
    `StartPosition = Manual`. `Anchor = AnchorStyles.None` alone was not enough: it only worked some of the time.
- **CSV export.** `CsvExport.Save(grid, fileName)` builds the same CSV (UTF-8 with BOM, visible columns, the binding
  path is now `DataPropertyName`). It sends the file with `Application.Download` instead of asking for a path with
  `SaveFileDialog`.
- **Opening a URL.** `UiHelper.OpenUrl` opens a browser tab. `mailto:` links go through `Application.Navigate`.
- **Exit and leaving the sign-in.** A web app cannot close the browser tab. Exit, and closing the sign-in dialog without
  signing in, show "You have left Relay" and call `Application.Exit()`. `"autoReload": true` in `Default.json` then
  starts a new session with the sign-in.

## 6. The chart decision

The WPF app drew its charts by hand: `Controls/BarChart.cs`, a `FrameworkElement` with `OnRender`/`DrawingContext`,
395 lines. Two options were considered:

1. **Port it to a Wisej control that paints in `OnPaint` with System.Drawing.** Rejected because:
   - System.Drawing.Common is Windows-only on .NET 6+, and the app targets `net10.0`, which would break the WSL profile.
   - Every resize, hover or tooltip would be a server round trip that sends a new image.
2. **Use the Wisej 4.2 `ChartView`.** The package contains it (with ChartSeries, ChartPoint, PointClick and
   TooltipShowing), and the previous 4.2 app used it on its dashboard and reports. Chosen.

To keep the migration visible, `BarChart` is still there. It is now a thin subclass of `ChartView` (189 lines) with the
WPF API:
- `SetData(categories, tags, params ChartSeries[])`, `PointClick(ChartPointEventArgs)` with the same `Tag`/`SeriesIndex`.
- `Horizontal`, `Stacked`, `WholeNumbers`, `EmptyText`, and `ValueFormat` (the tooltip text, set through `TooltipShowing`).
- `DashboardView` and `ReportsView` call it with the same code as in WPF. The only edits: drop `.ToMedia()`, and add a
  `using ChartSeries = RelayCrm.Controls.ChartSeries;` alias because `Wisej.Web.ChartSeries` has the same name.

Differences:
- `AxisFormat` is now a .NET format string (`"C0"`), not a `Func<double,string>`. The axis shows "$800,000", not "$800K".
- Horizontal stacked bars are drawn as stacked columns, because ChartView has no stacked bar type.

The hand-drawn `Sparkline` became the 4.2 `Sparkline` control (in `KpiTile`) and `DataGridViewSparklineColumn` (in the
companies grid).

## 7. Optimizations applied after the port

- **AlertBox** ([Alert Boxes](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/alert-boxes)):
  `Notify.Info/Success/Warning` show a toast at the bottom right. The status bar still shows the last message for
  8 seconds, as in WPF. Errors stay message boxes.
- **Theme** ([Theming](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/theming)):
  `FluentLight-5`, close to the Windows look of the WPF app. It is set in `Default.json` and `Web.config`.
- **Watermark** ([Watermarks](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/watermarks)):
  the search box hint, which was a TextBlock laid over the TextBox.
- **AllowHtml** ([AllowHtml](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/allowhtml/)):
  the list templates, the navigation badge, and the task group headers.
- **Virtual scrolling** ([VirtualScroll](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/virtualscroll)):
  DataGridView already renders only the visible rows. The big list grids (contacts, companies, deals, activities,
  tasks) set `KeepSameRowHeight = true`.
- **Wisej 4.2 controls:** `ChartView` (behind `BarChart`), `Sparkline`, `DataGridViewSparklineColumn`.
- **Responsive properties: not applied.** The fixed desktop layout is kept, to stay comparable with WPF.

## 8. Carried over vs. rewritten

Line counts are `wc -l`. "Kept" means WPF lines that `diff` leaves unchanged.

| Code-behind | WPF | Wisej | Kept |
| --- | ---: | ---: | ---: |
| MainWindow | 565 | 625 | 435 (76%) |
| DashboardView | 281 | 294 | 252 (89%) |
| ContactsView / ContactDetailView | 240 / 222 | 245 / 223 | 86% / 84% |
| CompaniesView / CompanyDetailView | 270 / 292 | 286 / 297 | 86% / 85% |
| DealsView | 392 | 466 | 290 (73%) |
| ActivitiesView / TasksView / ReportsView | 286 / 162 / 200 | 372 / 204 / 206 | 81% / 72% / 88% |
| SettingsView | 440 | 486 | 370 (84%) |
| 10 dialogs | 1,485 | 1,703 | 1,305 (88%) |
| KpiTile | 77 | 92 | 56 (72%) |
| **All code-behind** | **4,912** | **5,499** | **4,112 (83%)** |

- **Services:**
  - `QueryFilter` and `IRefreshable` are kept verbatim.
  - About 70% of `Navigator`, `Notify`, `CsvExport`, `ToneExtensions` and `DialogHelper` is kept.
  - `RelayCrm.Core` is unchanged (0 lines).
- **Rewritten by hand:**
  - All of the UI markup: 2,152 lines of XAML became 11,455 lines of designer code. Designer code is verbose: one
    statement per property.
  - The chart (section 6).
  - The DataTemplates, as HTML templates (`TemplateItem`) or controls built in code: the deal board, the calendar, the
    rule rows.
  - The converters (`GridHelper`, `FmtConverter`, `ToneBrushConverter`).
  - Drag and drop on the deal board: the WPF mouse tracking became the Wisej DragStart/DragDrop events.
  - The search popup.
- **New helpers:** `GridHelper` (82 lines), `TemplateItem` (86), `WisejSessionBag` (17), `Startup` (38).

### Typical mechanical edits in code-behind

- `using System.Windows*` → `using Wisej.Web`.
- `RoutedEventArgs` → `EventArgs`.
- `Visibility = ...Collapsed` → `Visible = false`.
- `ItemsSource` → `DataSource`.
- `Content`/`Title` → `Text`.
- `IsEnabled` → `Enabled`.
- `ToolTip` → `ToolTipText`.
- `Foreground = x.ToBrush()` → `ForeColor = x.ToColor()`.
- `DialogResult = true` → `DialogResult.OK`.
- `Loaded` → `Load`.
- `UiHelper.RowItem<T>(MouseButtonEventArgs)` → `UiHelper.RowItem<T>(grid, DataGridViewCellEventArgs)`.

## 9. Known gaps

- **Charts:**
  - Axis ticks show full amounts ("$800,000"), not the compact "$800K".
  - Horizontal stacked bars (activity per user) are stacked columns.
  - An all-zero series shows a $0–$1 axis instead of WPF's hand-drawn scale.
- **Row height.** FluentLight draws grid rows 32 px high (WPF 24 px). `TasksView` sizes its per-group grids for 32 px
  rows. The other grids just show fewer rows per screen. *Step 2: the grids with avatar and chip columns are 40 to 48 px
  high on purpose; `TasksView` sizes its groups for 40 px rows.*
- **Sorting.** Header-click sorting by `SortMemberPath` is not ported. The grids are bound to plain `List<T>`.
- **Deal board drag and drop.**
  - The drop position is "above the card under the pointer, or at the end of the column". WPF used half-card precision.
    *Closed in step 2: the KanbanBoard inserts the card where it is dropped.*
  - Cards have a fixed size (210×76), so titles end with an ellipsis instead of wrapping. *Still true for the
    KanbanBoard cards of step 2.*
- **Small layout differences.** Fixed dialog heights replace `SizeToContent`, and docked panels ignore `Margin`. Examples:
  - CompanyEditDialog keeps a row for the duplicate-name warning.
  - The activity timeline descriptions are one line. *Closed in step 2: the Timeline control wraps them.*
- **Menus.** The `_` access keys are dropped. *Step 2: there is no menu bar any more (section 10).*
- **Shortcuts.** F5, Ctrl+K and Ctrl+1..8 are captured by the page (the browser does not reload). Alt+Left is handled
  through `Accelerators`. *Step 2: F5, Alt+Left and Ctrl+1..8 are all page `Accelerators`; Ctrl+K is the
  `Shortcut` of the CommandPalette.*
- **Settings stages grid.** Typing "50%" in the Probability column raises the grid's DataError, where WPF showed a red
  border.
- **Same-session reloads.** Opening a new URL in the same browser tab reuses the Wisej session, so `?user=`/`?page=`
  only apply to a new session.
- **Tests.** No automated UI tests. Verification was a manual click-through in the browser.

## 10. Step 2: modernize with Wisej.NET 4.2

Step 2 applies the guide's [Optimizations After Migration](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/)
and the controls that are new in Wisej.NET 4.2 to the lifted code. It follows the WinForms step 2 (`src/RelayCrm.Wisej`,
commit `fe6edac`, `docs/MIGRATION.md`): the same theme mixin, stylesheet, splash, client profiles and avatar images,
adapted to the class names of this project. The feature set is still the one of the WPF app, and the designer files
are still designer files: every screen keeps its UI in `InitializeComponent` and opens in the Visual Studio designer.

### 10.1 Step-1 pieces and their 4.2 replacements

| Step 1 piece | Wisej.NET 4.2 replacement | Why |
| --- | --- | --- |
| FluentLight-5 with system colours | FluentLight-5 plus `Themes/Relay.mixin.theme` (indigo accent, grid headers, page and card titles), embedded as `RelayCrm.WpfToWisej42.Themes.Relay.mixin.theme`, and `Themes/relay.css` (cards, primary and secondary buttons, toolbars, search boxes), used through `CssClass` and `AppearanceKey`. `Default.html` has the Relay splash and loads the stylesheet. Guide: [Theming](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/theming) | One look for every page, defined once, instead of colours set control by control. |
| `MainWindow`: MenuBar, ToolBar, nav ListBox with an HTML badge, StatusBar | `Wisej.Web.Ext.NavigationBar` (package Wisej-4-NavigationBar) and a header panel: page title, Back button, search box, "New" menu button, notifications button, user `Avatar` with its menu (Profile, Settings, About, Sign out, Exit). The overdue count is the `InfoText` badge of the Tasks item and the number on the notifications button. | The navigation of a web app. The menu bar and the toolbar duplicated each other. |
| `MenuItem.Shortcut` (F5, Ctrl+K, Ctrl+1..8) and `Accelerators` (Alt+Left) | Page `Accelerators` for F5, Alt+Left and Ctrl+1..8; Ctrl+K is the `Shortcut` of the CommandPalette | The shortcuts had to move with the menu bar. They are still the WPF ones. |
| Search box with a `UserPopup` and an HTML ListBox | `CommandPalette` (Ctrl+K, `FilterMode = Server`, the results of `SearchService.Search` grouped as Pages, Contacts, Companies, Deals) | A built-in palette with keyboard navigation instead of a hand-made popup and its `IsOpen` flag. |
| `Notify`: a toast plus the status bar text; errors in a message box | `AlertBox` toasts in the top right corner for info, success, warning and error. Warnings and errors are still message boxes while there is no main page (sign-in). Guide: [Alert Boxes](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/alert-boxes) | The status bar is gone, and toasts do not block. |
| Dashboard `KpiTile` user controls | `KpiPanel` cards (icon, value, caption, trend, sparkline, `Clickable`) | A 4.2 control does what the user control did. `Controls/KpiTile*` are deleted. |
| Dashboard `BarChart` (ChartView subclass with the WPF API) | Plain `ChartView`s with their series in the designer; `Services/ChartStyle.cs` sets the palette, a round axis maximum and the money tooltip | The series are now visible and editable in the designer. `BarChart` stays for the reports. |
| Dashboard tasks: HTML `ListBox` | `ActionCardList` (title, description, meta, icon and badge with their tones) | The XAML item template as a control, clickable. |
| Dashboard activity: HTML `ListBox` of `TimelineEntry` | `Timeline` (time, icon, tone, title, description) | Same reason. `Services/TimelineEntry.cs` is deleted. |
| Period `ComboBox` | `SegmentedButton` | One click instead of opening a list. |
| Dashboard grids | `DataGridViewSubtitleColumn` (deal and company), `DataGridViewMeterColumn` (probability), `DataGridViewAvatarColumn` (company). Guide: [Enhanced DataGridView](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/enhanced-datagridview) | Denser and easier to scan. |
| Contacts/Companies quick filter `RadioButton`s with the count in the text | `ChipGroup` with `ShowCounts` and `Segment.Count` | The counts are data, not text. |
| Contacts/Companies grids with coloured text (`Tone:` column tags) | Avatar columns (name, owner); chip columns (stage with a `ToneMap`, first tag) | The WPF colours as chips. |
| Empty-list panels (Label + LinkLabel) | `EmptyState` with the "Clear the filters" action (`GridHelper.ShowEmpty`) | One control with icon, title, description and action. |
| Search box with a watermark | The same watermark plus a clear tool button (`ComponentTool`). Guides: [Watermarks](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/watermarks), [Tool Buttons](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/tool-buttons) | Clearing the search was select-and-delete. |
| `AdvancedFilterDialog`: one TableLayoutPanel of combo boxes per rule, built in code | `QueryBuilder` in the same dialog (all/any, rules, preview). The dialog maps the app's `FilterField`s to the builder and builds the same `FilterQuery`, so `QueryFilter` and the lists are unchanged. Rules without a value are still skipped. | About 200 lines of rule-row code replaced by a control. |
| Deals board: TableLayoutPanel of stage panels with HTML label cards, DragStart/DragDrop | `KanbanBoard` (one `KanbanColumn` per stage, `StatusMember = Status`, `OrderMember = BoardOrder`) in a horizontally scrolling panel. `CardMoving` asks the lost reason and cancels the move when the question is cancelled; `CardMoved` saves with `DealService.MoveToStage`; the card context menu (Open, Edit, Move to) is kept. | Drag, reorder and the card layout are done by the control. |
| Deals Board/List radio buttons; grid with coloured text | `SegmentedButton`; chip columns (stage, expected close with `ToneMember = CloseTone`), meter column (probability), avatar column (owner) | |
| Activities: 7×6 month grid built in code, ◀ Today ▶ buttons | `SchedulerView` (month, week, work week, day, agenda and timeline views with their own navigation; read-only: no create, move or resize) and a `Timeline` of the clicked day with "Plan a meeting on this day". A double-click on an appointment opens the related record; a double-click on a day plans a meeting. The type radio buttons became a `ChipGroup`, and the list got chip (type) and avatar (user) columns. | About 150 lines of calendar code replaced by a control with more views. |
| Tasks: radio buttons; groups as GroupBoxes | `SegmentedButton` (My tasks / Everybody's), groups as cards, priority chip column, assignee avatar column, `EmptyState` with a "New task..." action | Theme, chips and avatars where they fit. |
| Reports | Theme (card, toolbar, grids) and an avatar column for the users; the charts stay `BarChart` | Theme and avatars only, as in the WinForms step 2. |
| Settings: round Panel + Label avatar, HTML avatar column | `Avatar` in the profile preview, avatar column for the users, chip column for the tags, themed buttons and grids | Avatars as a control. |
| Contact and company detail pages | `Avatar` (SVG of the initials in the record's colour), `ChipLabel` for the stage, `KpiPanel` for the company KPIs, `Timeline` grouped by day (the company's "Show more" button became the Timeline's `LoadMore`), `ActionCardList` for the contact's deals, `EmptyState`s, chip and avatar columns | Same as the WinForms detail pages. |
| `DealDetailDialog`: stage steps as coloured labels; HTML lists | `Stepper` (completed, active, pending; skipped stages and an error step for a lost deal), `ChipLabel`, `ActionCardList` for contacts and tasks, `Timeline`, `EmptyState`s | The stage path as a control. |
| Avatars as HTML (`TemplateItem.WithAvatar`) or round labels | `Services/Avatars.cs`: SVG data URLs for the `Avatar` control; the grids use `DataGridViewAvatarColumn` | Nothing is drawn on the server; the browser draws them. |
| Fixed desktop layout (step 1: "Responsive properties: not applied") | `ClientProfiles.json` (Phone ≤ 767 px, Tablet ≤ 1199 px). Responsive properties in `MainWindow.resx` (icon rail on tablets; hidden bar, menu button and no search box on phones) and in `ContactsView.resx`, `CompaniesView.resx`, `DealsView.resx`, `ActivitiesView.resx`, `TasksView.resx` (stacked headers and filters on phones). `DashboardView` and `ActivitiesView` reflow in `OnResponsiveProfileChanged`, because table cells and the split container panels are not properties a profile can hold. Guide: [Responsive Properties](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/responsive-properties) | The app is usable on a tablet and a phone. |
| Dialog buttons | `relay-primary` / `relay-secondary` CSS classes | Theme. |

Still used from step 1: [AllowHtml](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/allowhtml/)
for the sign-in user list and the task group headers, and [VirtualScroll](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/virtualscroll)
(`KeepSameRowHeight`) on the big grids. Not used: [Enhanced TabControl](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/enhanced-tabcontrol)
and [Label Wrapper](https://docs.iceteagroup.com/migration/winforms-to-wisej-1/optimizations-after-migration/label-wrapper).

The project file adds the packages `Wisej-4-NavigationBar` and `Wisej-4-BootstrapIcons` (4.1.*), the embedded theme
mixin, and the content items `ClientProfiles.json`, `Themes/relay.css`, `Assets/**/*.svg` and `Images/*.png`.
`Program.Main` sets `Icons.Prefix` and `Icons.Suffix`, so the icon names of the Core services ("person",
"briefcase"...) are the SVG files of the BootstrapIcons extension.

### 10.2 What stayed the same

- **`RelayCrm.Core`: 0 lines changed.** Its rows already had what the 4.2 controls bind to (`DealRow.Status`,
  `BoardOrder`, `CloseTone`, `ProbabilityText`, and the `Icon`/`Tone` members of the dashboard and detail items).
- **Code-behind logic.** Loading, filtering, paging, saving, the drill-downs, the navigation (`Navigator`), the
  session state and the start options are the step-1 code. The edits are where a control changed: an event
  (`SeriesPointEventArgs`, `KanbanCardMoveEventArgs`, `SchedulerAppointmentEventArgs`, `ActionCardListItemEventArgs`,
  `TimelineItemEventArgs`), a data source, or a radio button read that is now a `SelectedIndex`.
- **Dialogs.** Every edit dialog keeps its fields, validation and code-behind; only the button styles changed.
  The sign-in centring from `Application.Browser.Size` (`SignInDialog.SignIn`), the `FormAutoCloseModalDialog`
  switch in `Startup.Main` and `DialogHelper.KeepOpenOnAccept` are unchanged, and the new `AdvancedFilterDialog` uses
  `KeepOpenOnAccept` too. `ConfirmDialog` is still a message box.
- **Services kept as they were:** `QueryFilter`, `CsvExport`, `TemplateItem` (sign-in list, task headers),
  `UiHelper`, `WisejSessionBag`, `IRefreshable`, `App`, `StartOptions`.

### 10.3 Rough numbers

Measured with `git diff --no-index --stat` between the step-1 copy and step 2, without this file:

- **55 files**: 40 changed, 12 added, 3 deleted; about **+4,050 / −4,400 lines**.
- **Added:** `Themes/Relay.mixin.theme`, `Themes/relay.css`, `Assets/Icons/relay-logo.svg`, `ClientProfiles.json`,
  `MainWindow.resx` and five view `.resx` files (responsive properties), `Services/Avatars.cs`, `Services/ChartStyle.cs`.
- **Deleted:** `Controls/KpiTile.cs`, `Controls/KpiTile.Designer.cs`, `Services/TimelineEntry.cs`.
- **Designer code:** 11,456 → about 10,600 lines. **Code-behind and services:** 6,906 → about 6,600 lines.
- The biggest rewrites are `MainWindow` (shell), `DashboardView`, `DealsView` (board), `ActivitiesView` (calendar)
  and `AdvancedFilterDialog` (QueryBuilder). The dialogs other than `DealDetailDialog` and `AdvancedFilterDialog`
  changed by 2 or 3 designer lines each.

### 10.4 Gaps

Closed by step 2 (also marked in section 9):

- The drop position on the deal board: the KanbanBoard inserts the card where it is dropped.
- One-line activity descriptions: the Timeline wraps them.
- The status bar message that disappeared after 8 seconds is now a toast; the overdue link of the status bar is the
  badge of the Tasks item and the notifications button.
- The fixed desktop layout: phones and tablets have their own layout.

New in step 2:

- **Board context menu.** The KanbanBoard has no right-click event for a card, so the card menu acts on the card
  clicked last: left-click a card, then right-click it. The menu of the list acts on the row under the pointer, as before.
- **Calendar clicks.** In WPF a click on an activity of the month grid opened its record. Now a click lists its day in
  the Timeline next to the calendar, and a double-click (or a click in the Timeline) opens the record.
- **Board columns.** The WPF column header had the count and the total on two lines and a colour bar. The KanbanBoard
  shows the count in its own badge, the total in the heading text and the tone as the heading dot.
- **Users grid colours.** `DataGridViewAvatarColumn` has no member for a colour, so the avatars of the users grid use
  the theme palette (`AutoColor`), not the colour each user chose. The profile preview, the header avatar and the
  sign-in list still use the chosen colour.
- **Menu commands without a menu.** View › Refresh is F5 only, View › Back is the header Back button and Alt+Left,
  View › Search is the search box and Ctrl+K, and File › Exit and Help › About moved to the user menu.
- **Phone layout.** The deal filters wrap over three lines, the Tasks group grids clip their last columns, and the
  Activities page hides the day Timeline so that the calendar gets the width. Use a tablet or desktop width for those
  pages.
- **Lists filter on change, not per keystroke.** As in step 1, a list search applies when the box loses the focus or
  Enter is pressed.

### 10.5 How to run

```
dotnet build src/RelayCrm.WpfToWisej42/RelayCrm.WpfToWisej42.csproj
cd src/RelayCrm.WpfToWisej42
dotnet run --framework net10.0 --launch-profile RelayCrm
```

Open http://localhost:5200/Default.html. The database (`relay.db`) is created with the demo data on the first start.
`?user=1&page=DealsView` skips the sign-in and opens a page, as in step 1. Make the browser narrower than 1200 px for
the tablet layout and narrower than 768 px for the phone layout.
