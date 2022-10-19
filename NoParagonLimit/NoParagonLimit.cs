using MelonLoader;
using BTD_Mod_Helper;
using NoParagonLimit;
using HarmonyLib;
using Assets.Scripts.Simulation.Towers;
using Assets.Scripts.Unity.Bridge;

[assembly: MelonInfo(typeof(NoParagonLimit.NoParagonLimit), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace NoParagonLimit;

public class NoParagonLimit : BloonsTD6Mod
{
    [HarmonyPatch(typeof(Tower), nameof(Tower.HasParagonLimitBeenReached))]
    public class HasParagonLimitBeenReachedPatch1
    {
        [HarmonyPrefix]
        private static bool Prefix(bool __result)
        {
            __result = false;
            return false;
        }
    }
    [HarmonyPatch(typeof(TowerToSimulation), nameof(TowerToSimulation.HasParagonLimitBeenReached))]
    public class HasParagonLimitBeenReachedPatch2
    {
        [HarmonyPrefix]
        private static bool Prefix(bool __result)
        {
            __result = false;
            return false;
        }
    }
}