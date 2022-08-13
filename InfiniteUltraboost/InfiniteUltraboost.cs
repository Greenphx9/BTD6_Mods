using MelonLoader;
using BTD_Mod_Helper;
using InfiniteUltraboost;
using Assets.Scripts.Models;
using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using BTD_Mod_Helper.Extensions;

[assembly: MelonInfo(typeof(InfiniteUltraboost.InfiniteUltraboost), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace InfiniteUltraboost;

public class InfiniteUltraboost : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<InfiniteUltraboost>("Infinite Ultraboost loaded!");
    }
    public override void OnGameModelLoaded(GameModel model)
    {
        base.OnGameModelLoaded(model);
        for(int i = 0; i < model.towers.Length; i++)        {

            if (model.towers[i].baseId == TowerType.EngineerMonkey && model.towers[i].tiers[1] == 5)
            {
                var towerModel = model.towers[i];
                towerModel.GetDescendants<OverclockPermanentModel>().ForEach(model => model.maxStacks = 9999999);
            }
        }
    }
}