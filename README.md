# Relay CRM showcase: Windows Forms → Wisej.NET 4.2

A small but complete sales CRM (dashboard, contacts, companies, deals board, activities calendar, tasks, reports,
settings) built twice from the same code:

| App | Project | What it is |
|---|---|---|
| **Relay CRM for Windows** | `src/RelayCrm.WinForms` | A classic Windows Forms app: MenuStrip, ToolStrip, TreeView, DataGridView, ListView, DataVisualization charts. |
| **Relay CRM on the web** | `src/RelayCrm.Wisej` | The same WinForms code migrated to [Wisej.NET 4.2](https://wisej.com): step 1 lifts it to the browser with 92% of the lines unchanged, step 2 modernizes it with the new 4.2 controls. |
| Shared | `src/RelayCrm.Core` | Data (EF Core + SQLite) and business logic, used by both apps without changes. |

How the migration was done, step by step, with the numbers: **[docs/MIGRATION.md](docs/MIGRATION.md)**.
Screenshots of the WinForms app: [`docs/winforms-*.png`](docs/) (for example
[the dashboard](docs/winforms-dashboard.png) and [the deals board](docs/winforms-deals-board.png)).

## Run

Requires the .NET 10 SDK. Both apps create `relay.db` with demo data on the first start.

**Windows Forms** (Windows only):

```
dotnet run --project src/RelayCrm.WinForms
```

**Wisej.NET 4.2** (put the pre-release package `wisej-4.4.2.0-test.1.nupkg` in `packages/`, see `nuget.config`):

```
dotnet run --project src/RelayCrm.Wisej -f net10.0 --launch-profile RelayCrm.Wisej
```

and open http://localhost:5100/Default.html. Add `?user=1` to sign in as the demo admin directly, and
`&page=DealsView` (or `&contact=5`, `&company=5`, `&deal=5`) to open a page or a record.

The solution `RelayCrm.Showcase.slnx` opens all projects in Visual Studio.
