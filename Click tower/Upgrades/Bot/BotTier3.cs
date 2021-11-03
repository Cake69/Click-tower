using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMod.Upgrades.Bot
{
    public class BotTier3 : ModUpgrade<ClickTower>
    {
        public override int Path => BOTTOM;
        public override int Tier => 3;
        public override int Cost => 300;

        public override string Description => "Did someone say pierce?";

        public override void ApplyUpgrade(TowerModel tower)
        {
            foreach (var weaponModel in tower.GetWeapons())
            {
                weaponModel.projectile.pierce += 99;
            }
        }
    }
}
