using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMod.Upgrades
{
    public class ParagonTier : ModParagonUpgrade<ClickTower>
    {
        public override int Cost => 500000;
        public override string Description => "When manual clicking is no longer good enough...";
        public override string DisplayName => "Auto-clicker";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            // throw new NotImplementedException();;
        }
    }
}
