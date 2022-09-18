using MelonLoader;

#if (UseCustomRootNamespace)
[assembly: MelonInfo(typeof(DefaultNamespace.PluginMain), PluginInfo.Name, PluginInfo.Version, PluginInfo.Author, PluginInfo.Download)]
#else
[assembly: MelonInfo(typeof(ML.Plugin.PluginMain), PluginInfo.Name, PluginInfo.Version, PluginInfo.Author, PluginInfo.Download)]
#endif
#if (UseAuthorConsoleColor)
[assembly: MelonAuthorColor(System.ConsoleColor.{AuthorConsoleColor})]
#endif
#if (UsePluginConsoleColor)
[assembly: MelonColor(System.ConsoleColor.{PluginConsoleColor})]
#endif
internal static class PluginInfo {
  public const string Name = "{PluginName}";
  public const string Author = "{PluginAuthor}";
  public const string Version = "{PluginVersion}";
  public const string Download = "{PluginDownloadURL}";
}