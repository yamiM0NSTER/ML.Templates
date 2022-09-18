using MelonLoader;

#if (UseCustomRootNamespace)
namespace DefaultNamespace;
#else
namespace ML.Mod;
#endif

public sealed class ModMain : MelonMod {
  public override void OnApplicationStart() {
    LoggerInstance.Msg("Hello world!");
    // Your code here
  }
}
