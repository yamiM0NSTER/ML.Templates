using MelonLoader;

#if (UseCustomRootNamespace)
namespace DefaultNamespace;
#else
namespace ML.Plugin;
#endif

public sealed class PluginMain : MelonPlugin {
  public override void OnApplicationStart() {
    LoggerInstance.Msg("Hello world!");
    // Your code here
  }
}
