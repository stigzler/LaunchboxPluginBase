# LaunchBox Plugin Template

This is a .NET template for creating LaunchBox plugins.

## Installing the Template

From the root directory of this repository, run:

```powershell
dotnet new install .
```

## Using the Template

Create a new LaunchBox plugin project:

```powershell
dotnet new launchbox-plugin -n MyAwesomePlugin
```

With custom LaunchBox plugins path:

```powershell
dotnet new launchbox-plugin -n MyAwesomePlugin -LaunchBoxPluginsPath "D:/LaunchBox/Plugins"
```

Include dev documentation:

```powershell
dotnet new launchbox-plugin -n MyAwesomePlugin --IncludeDevDocs true
```

Exclude user documentation:

```powershell
dotnet new launchbox-plugin -n MyAwesomePlugin --IncludeUserDocs false
```

## Template Parameters

| Parameter | Default | Description |
|-----------|---------|-------------|
| `LaunchBoxPluginsPath` | `C:/Users/YourUser/LaunchBox/Plugins` | Path to your LaunchBox plugins directory |
| `IncludeDevDocs` | `false` | Include the dev folder with development documentation |
| `IncludeUserDocs` | `true` | Include the docs folder with user documentation |

## Uninstalling the Template

```powershell
dotnet new uninstall Launchbox.Plugin.Template.CSharp
```

## Testing the Template Locally

Before installing, you can test the template:

```powershell
dotnet new install .
cd ..
mkdir TestPlugin
cd TestPlugin
dotnet new launchbox-plugin -n TestPlugin
```

## What Gets Replaced

When you create a new project from this template:
- `LaunchboxPlugin` → Your project name
- `C:\Users\stigz\LaunchBoxDevelopmentInstall\Plugins` → Your `LaunchBoxPluginsPath` parameter
- Solution file renamed to match your project name
- All namespaces updated to match your project name
