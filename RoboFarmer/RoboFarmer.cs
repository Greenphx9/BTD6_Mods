using MelonLoader;
using BTD_Mod_Helper;
using RoboFarmer;

[assembly: MelonInfo(typeof(RoboFarmer.RoboFarmer), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace RoboFarmer;

public class RoboFarmer : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<RoboFarmer>("RoboFarmer loaded!");
    }
}