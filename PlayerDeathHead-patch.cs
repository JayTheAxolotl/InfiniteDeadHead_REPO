using HarmonyLib;

namespace InfiniteDeadHead;

[HarmonyPatch(typeof(PlayerDeathHead))]

public class PlayerDeathHead_patch
{
    
    [HarmonyPostfix, HarmonyPatch(nameof(PlayerDeathHead.Update))]
    private static void Update_Postfix(PlayerDeathHead __instance)
    {
        SpectateCamera.instance.headEnergy = (float) 1.0;
    }
}