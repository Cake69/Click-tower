using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Behaviors.Emissions;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMod.Upgrades.Top
{
    public class TopTier5 : ModUpgrade<ClickTower>
    {
        public override int Path => TOP;
        public override int Tier => 5;
        public override int Cost => 500;

        public override string Description => "More speedier...";

        public override void ApplyUpgrade(TowerModel tower)
        {
            foreach (var weaponModel in tower.GetWeapons())
            {
                weaponModel.Rate *= .5f;
            }
        }
    }
}
