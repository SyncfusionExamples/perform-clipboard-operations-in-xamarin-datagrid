# perform-clipboard-operations-in-xamarin-datagrid

This sample shows how to implement Copy, Cut, and Paste for Syncfusion SfDataGrid in Xamarin.Forms using Xamarin.Essentials Clipboard. It focuses on MVVM-friendly commands, safe parsing (CSV/TSV), and basic selection handling.

## Quick start
1) Install NuGet: Syncfusion.Xamarin.SfDataGrid, Xamarin.Essentials.
2) Initialize Syncfusion in platform projects and register your license if required.
3) Build and deploy to Android/iOS.

## What it does
- Copy: Gather selected cells/rows, serialize to TSV/CSV, place on Clipboard.
- Cut: Copy, then clear the bound values of selected cells.
- Paste: Read text from Clipboard, parse into a matrix, and write into grid cells starting at the active cell.

## Minimal wiring
- Toolbar buttons bind to CopyCommand, CutCommand, PasteCommand.
- A selection service abstracts reading selected cells and the paste start cell.
- A clipboard service wraps Xamarin.Essentials Clipboard API.

## Tips
- Prefer TSV for fewer escaping issues (tabs/newlines).
- Keep column order in sync with visible columns when copying rows.
- Validate and coerce types on paste (numeric/date columns).
- Ensure models implement INotifyPropertyChanged so grid refreshes after Cut/Paste.


