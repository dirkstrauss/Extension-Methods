# .NET 8.0 Upgrade Plan

## Execution Steps

1. Validate that an .NET 8.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 8.0 upgrade.
3. Upgrade Helper\Helper.csproj
4. Upgrade consoleApp\consoleApp.csproj

## Settings

This section contains settings and data used by execution steps.

### Excluded projects

| Project name | Description |
|:-----------------------------------------------|:---------------------------:|

### Project upgrade details

#### Helper\Helper.csproj modifications

Project properties changes:
  - Convert project file to SDK-style format
  - Target framework should be changed from `.NETFramework,Version=v4.8` to `net8.0`

#### consoleApp\consoleApp.csproj modifications

Project properties changes:
  - Convert project file to SDK-style format
  - Target framework should be changed from `.NETFramework,Version=v4.8` to `net8.0`
