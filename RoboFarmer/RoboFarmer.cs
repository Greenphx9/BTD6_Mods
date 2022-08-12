using MelonLoader;
using BTD_Mod_Helper;
using RoboFarmer;
using Assets.Scripts.Models;
using BTD_Mod_Helper.Extensions;
using Assets.Scripts.Models.Towers.Behaviors;

[assembly: MelonInfo(typeof(RoboFarmer.RoboFarmer), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace RoboFarmer;

public class RoboFarmer : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<RoboFarmer>("RoboFarmer loaded!");
    }
    public override void OnGameModelLoaded(GameModel model)
    {
        base.OnGameModelLoaded(model);
        for(int i = 0; i < model.powers.Length; i++)
        {
            var power = model.powers[i];
            if(power.name == "BananaFarmer")
            {
                var towerModel = power.tower;
                towerModel.range = 1000f;
                towerModel.GetBehavior<CollectCashZoneModel>().attractRange = 1000f;
                towerModel.GetBehavior<CollectCashZoneModel>().collectRange = 1000f;
            }
        }
    }
}