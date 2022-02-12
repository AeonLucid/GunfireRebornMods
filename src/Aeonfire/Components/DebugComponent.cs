using UnityEngine;

namespace AeonFire.Components;

internal class DebugComponent : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            foreach (var p in NewPlayerManager.PlayerTeamerDict)
            {
                var playerId = p.key;
                var player = p.value;
                
                // Player name.
                Plugin.Log.LogInfo($"Name {player.playerProp.Name}");
                
                // Stats.
                Plugin.Log.LogInfo($"- Health {player.playerProp.HP} / {player.playerProp.HPMax}");
                Plugin.Log.LogInfo($"- Shield {player.playerProp.Shield} / {player.playerProp.ShieldMax}");
                Plugin.Log.LogInfo($"- Armor  {player.playerProp.Armor} / {player.playerProp.ArmorMax}");
            }

            Plugin.Log.LogInfo($"PickUpRelicList");
            foreach (var i in DropManager.PickUpRelicList)
            {
                Plugin.Log.LogInfo($"- {i}");
            }

            Plugin.Log.LogInfo($"AutoPickDict");
            foreach (var i in DropManager.AutoPickDict)
            {
                Plugin.Log.LogInfo($"- {i.key} - {i.value.DropType} {i.value.AutoPickRange} Shape: {i.value.Shape} DropType: {i.value.DropType}");
                i.value.AutoPickRange = 5000f;
            }

            Plugin.Log.LogInfo($"IsFullItem");
            foreach (var i in DropManager.IsFullItem)
            {
                Plugin.Log.LogInfo($"- {i.key} - {i.value}");
            }
        }
    }
}