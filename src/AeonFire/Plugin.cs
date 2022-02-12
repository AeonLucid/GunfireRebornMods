using AeonFire.Components;
using BepInEx;
using BepInEx.IL2CPP;
using BepInEx.Logging;

namespace AeonFire;

[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
    internal new static ManualLogSource Log;
    
    public override void Load()
    {
        Log = base.Log;
        Log.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        
        AddComponent<PickupComponent>();

#if DEBUG
        AddComponent<DebugComponent>();
#endif
    }
}