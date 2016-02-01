# CoreConfig #
## An example how to use configuration in .NET Core ##

- **Build1.ps1** installs .NET Version Manager *(DNVM)* with latest .NET runtime *(DNX)* and restore the application *(dnu restore)*
- **RunWithJsonFile.cmd** => appsettings.json is the default configuration source
- **RunWithConsolArguments.cmd** => Console Arguments override appsettings.json
- **RunWithEnvironmentVariables.cmd** => Environment Variables override all configurations