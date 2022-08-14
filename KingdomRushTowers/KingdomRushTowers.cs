using MelonLoader;
using BTD_Mod_Helper;
using KingdomRushTowers;

[assembly: MelonInfo(typeof(KingdomRushTowers.KingdomRushTowers), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace KingdomRushTowers;

public class KingdomRushTowers : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<KingdomRushTowers>("KingdomRushTowers loaded!");
    }
}