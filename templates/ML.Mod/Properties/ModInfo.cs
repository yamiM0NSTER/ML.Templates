using MelonLoader;

#if (UseCustomRootNamespace)
[assembly: MelonInfo(typeof(DefaultNamespace.ModMain), ModInfo.Name, ModInfo.Version, ModInfo.Author, ModInfo.Download)]
#else
[assembly: MelonInfo(typeof(ML.Mod.ModMain), ModInfo.Name, ModInfo.Version, ModInfo.Author, ModInfo.Download)]
#endif
#if (UseAuthorConsoleColor)
[assembly: MelonAuthorColor(System.ConsoleColor.{AuthorConsoleColor})]
#endif
#if (UseModConsoleColor)
[assembly: MelonColor(System.ConsoleColor.{ModConsoleColor})]
#endif
internal static class ModInfo {
  public const string Name = "{ModName}";
  public const string Author = "{ModAuthor}";
  public const string Version = "{ModVersion}";
  public const string Download = "{ModDownloadURL}";
}