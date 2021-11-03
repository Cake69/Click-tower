using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMod.Upgrades.Bot
{
    public class BotTier4 : ModUpgrade<ClickTower>
    {
        public override int Path => BOTTOM;
        public override int Tier => 4;
        public override int Cost => 400;

        public override string Description => "Adds a lot of damage.";

        public override void ApplyUpgrade(TowerModel tower)
        {
            foreach (var weaponModel in tower.GetWeapons())
            {
                weaponModel.projectile.GetDamageModel().damage += 16;
            }
        }
    }
}
