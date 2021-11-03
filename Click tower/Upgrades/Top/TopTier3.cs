using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMod.Upgrades.Top
{
    public class TopTier3 : ModUpgrade<ClickTower>
    {
        public override int Path => TOP;
        public override int Tier => 3;
        public override int Cost => 300;

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
