using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMod.Upgrades.Bot
{
    public class BotTier1 : ModUpgrade<ClickTower>
    {
        public override int Path => BOTTOM;
        public override int Tier => 1;
        public override int Cost => 100;

        public override string Description => "Double damage!";

        public override void ApplyUpgrade(TowerModel tower)
        {
            foreach (var weaponModel in tower.GetWeapons())
            {
                weaponModel.projectile.GetDamageModel().damage *= 2;
            }
        }
    }
}
