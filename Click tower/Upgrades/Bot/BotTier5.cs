using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMod.Upgrades.Bot
{
    public class BotTier5 : ModUpgrade<ClickTower>
    {
        public override int Path => BOTTOM;
        public override int Tier => 5;
        public override int Cost => 500;

        public override string Description => "Ceramic and MOAB shredder.";

        public override void ApplyUpgrade(TowerModel tower)
        {
            int number = 2000;
            foreach (var projectile in tower.GetWeapons().Select(WeaponModel => WeaponModel.projectile))
            {
                projectile.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Ceramic", "Ceramic", number, number, false, true));
                projectile.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Fortified", "Fortified", number, number, false, true));
                projectile.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Moab", "Moab", number, number, false, true));
                projectile.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Bfb", "Bfb", number, number, false, true));
                projectile.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Zomg", "Zomg", number, number, false, true));
                projectile.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Ddt", "Ddt", number, number, false, true));
                projectile.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Bad", "Bad", number, number, false, true));
            }
        }
    }
}
