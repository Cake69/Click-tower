using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMod.Upgrades.Mid
{
    public class MidTier2 : ModUpgrade<ClickTower>
    {
        public override int Path => MIDDLE;
        public override int Tier => 2;
        public override int Cost => 200;

        public override string Description => "Pops everything now.";

        public override void ApplyUpgrade(TowerModel tower)
        {
            foreach (var some in tower.GetWeapons())
            {
                some.projectile.GetDamageModel().immuneBloonProperties = BloonProperties.None;
            }
        }
    }
}
