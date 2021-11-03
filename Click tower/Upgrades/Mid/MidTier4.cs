using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Behaviors.Emissions;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMod.Upgrades.Mid
{
    public class MidTier4 : ModUpgrade<ClickTower>
    {
        public override int Path => MIDDLE;
        public override int Tier => 4;
        public override int Cost => 400;

        public override string Description => "Why do you even need this many projectiles?";

        public override void ApplyUpgrade(TowerModel tower)
        {
            tower.GetWeapon().emission = new ArcEmissionModel("ArcEmissionModel_", 10, 20, 10, null, false);
        }
    }
}
