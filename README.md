# This fork

**Excel Export/Import**
- Translation Builder always use comma as a separator which is not convenient for Canadien French computers (where semicolon is used because comma is a decimal separator).
- This version use the ClosedXml open source libray to Export and Import Excel files. When exporting it creates a real table that is autosized by column content and can be sorted/filtered.

**Display Folder support**
- Fixed DisplayFolder bugs : import from CSV and directly in the UI grid.

**UI changes**
- Changed default shortcut keys to avoid Ctrl+C and Ctrl+S which are usually associated with Copy and Save.
- A wait cursor is shown when importing translations from Excel
- Always show descriptions for Tables, Columns, Measures and Hierarchies

# Translations Builder

Translations Builder is an external tool created for Power BI Desktop
specifically to assist report authors and dataset authors with tasks
associated with creating translations and building multi-language
reports. **As a user**, you can install Translations Builder and use it
together with Power BI Desktop to build and test datasets and reports
that support multiple languages. **As a developer**, you can clone the
GitHub repository with the Translations Builder source code and extend
this application to meet whatever translation and localization
requirements your organization faces.

## Quick Start Guide
Here are the primary links for learning how to build multi-language reports for Power BI using Translations Builder.
 - [**Guidance Document**: *Building Multi-language Reports for Power BI*](Docs/Building%20Multi-language%20Reports%20in%20Power%20BI.md)
 - [**Hands-on Lab**: *Building Multi-language Reports for Power BI*](Labs/Hands-on%20Lab%20-%20Building%20Multi-language%20Reports%20for%20Power%20BI.md)
 - [**Multi-language Report Live Demo**](https://multilanguagereportdemo.azurewebsites.net)
 - [**Installation Guide**](Docs/Installation%20Guide.md)
 - [**User Guide**](Docs/User%20Guide.md)
 - [**Developer Guide**](Docs/Developer%20Guide.md)
