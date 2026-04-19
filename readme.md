# Plugin Template
This is a template for creating plugins for Launchbox. It's designed to be as "out of the box" as possible, but there are a few things you need to do before compilation.

## Build debug version to your Launchbox plugins folder

It's recommended that you run a 'development' installation of Launchbox for testing your plugin. To mirror you plugin's debug build to your dev Launchbox install:

For each project you want building to the plugin folder (if your plugin is multi-project), open the project properties and place this in the post build events:

```cmd
REM call "$(SolutionDir)build\scripts\moveDebugBuild.bat" "$(ConfigurationName)" "$(SolutionDir)" "{pluginPath}" "{buildPath}"
```

Replace `{pluginPath}` with your path to your (development?) launchbox plugin directory e.g. "C:\LaunchBox\Plugins\MyPlugin"

Replace `{buildPath}` with the relative path from the solution folder to your debug build files e.g. "src\LaunchboxPlugin.Core\bin\Debug\net9.0"

You should then be able to run the template plugin and see it appear in your launchbox tools menu. If it's there, it's all set up.

## Set up Visual Studio to debug your plugin

- Open your main project's (the one with PluginHost.cs) Properties.
- Go to Debug > Launch Profiles.
- Add a new profile for an "Executable"
- Set the executable path to your Launchbox.exe **in your Core folder** (e.g. "C:\LaunchBox\Core\LaunchBox.exe")
- Name it to something memorable (eg. "PluginDebug")

Make sure you select the right debug profile in the drop-down at the top of the VS UI. Then run in debug mode. 
