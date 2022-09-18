# ML.Templates

ML.Templates is nuget package containing templates for projects intended for development using [MelonLoader](https://github.com/LavaGang/MelonLoader).

## Manual Installation

1. Download nuget package from releases.
2. Open terminal in directory you downloaded package to.
3. Run the following command `dotnet new -i .\yamiM0NSTER.ML.Templates.1.0.0.nupkg` (version can differ depending on release file name)
4. Hopefully it installs without issues!

## Usage

### Visual Studio

Simply start up Visual Studio and you should be able to choose either MelonLoader Mod or MelonLoader Plugin project.
![vs projects](https://i.imgur.com/yisGEEN.png)
And further the line you should be able to set project options
![mod fields](https://i.imgur.com/hJ85JD0.png)

### Rider

TBD

### dotnet CLI

Run `dotnet new ml-mod -h` or `dotnet new ml-plugin -h` and proceed from there.

## Development

Simply clone the repo and whenever you do any changes run `install.bat` file(on Windows). Some changes require changing package version (eg. Icon image or package tags)

# End notes

**Disclaimer:** Express Permission to use MelonLoader logo granted by [@HerpDerpinstine](https://github.com/HerpDerpinstine)
