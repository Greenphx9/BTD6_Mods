using BTD_Mod_Helper.Api.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingdomRushTowers.Towers
{
    public class KingdomRushTowerSet : ModTowerSet
    {
        public override string DisplayName => "Kingdom Rush";
        public override int GetTowerSetIndex(List<string> towerSets)
        {
            return towerSets.IndexOf("Support") + 1;
        }
    }
}
