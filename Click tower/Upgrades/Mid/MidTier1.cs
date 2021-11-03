using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Filters;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMod.Upgrades.Mid
{
    public class MidTier1 : ModUpgrade<ClickTower>
    {
        public override int Path => MIDDLE;
        public override int Tier => 1;
        public override int Cost => 100;

        public override string Description => "Camo detection, nice!";

        public override void ApplyUpgrade(TowerModel tower)
        {
            tower.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
        }
    }
}
