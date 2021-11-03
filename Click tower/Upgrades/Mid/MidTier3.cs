using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Behaviors.Emissions;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMod.Upgrades.Mid
{
    public class MidTier3 : ModUpgrade<ClickTower>
    {
        public override int Path => MIDDLE;
        public override int Tier => 3;
        public override int Cost => 300;

        public override string Description => "Double projectiles, for even more damage.";

        public override void ApplyUpgrade(TowerModel tower)
        {
            tower.GetWeapon().emission = new ArcEmissionModel("ArcEmissionModel_", 2, 10, 10, null, false);
        }
    }
}
