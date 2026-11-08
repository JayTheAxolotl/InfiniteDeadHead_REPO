using HarmonyLib;

namespace InfiniteDeadHead;

[HarmonyPatch(typeof(PlayerDeathHead))]

public class PlayerDeathHead_patch
{
    
    [HarmonyPostfix, HarmonyPatch(nameof(PlayerDeathHead.Update))]
    private static void Update_Postfix(PlayerDeathHead __instance)
    {
        if (SpectateCamera.instance != null)
        {
            SpectateCamera.instance.headEnergy = 1f;
            SpectateCamera.instance.headEnergyEnough = true;
        }
    }
}