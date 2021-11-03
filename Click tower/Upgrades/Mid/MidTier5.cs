using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Filters;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using Assets.Scripts.Unity;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMod.Upgrades.Mid
{
    public class MidTier5 : ModUpgrade<ClickTower>
    {
        public override int Path => MIDDLE;
        public override int Tier => 5;
        public override int Cost => 500;

        public override string Description => "Global range.";

        public override void ApplyUpgrade(TowerModel tower)
        {
            tower.isGlobalRange = true;
            tower.range += 50000;
            var attackModel = tower.GetAttackModel();
            attackModel.range += 50000;
        }
    }
}
