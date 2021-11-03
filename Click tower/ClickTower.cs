using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Filters;
using Assets.Scripts.Models.Towers.Projectiles;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMod
{
    public class ClickTower : ModTower
    {
        public override string Portrait => "Portrait";
        public override string Icon => "Icon";
        public override string TowerSet => PRIMARY;

        public override string BaseTower => TowerType.DartMonkey;

        public override int Cost => 300;

        public override int TopPathUpgrades => 5;

        public override int MiddlePathUpgrades => 5;

        public override int BottomPathUpgrades => 5;

        public override string Description => "Allowes you to click on bloons, in order to pop them.";

        public override ParagonMode ParagonMode => ParagonMode.Base555;

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.range += 10;
            var attackModel = towerModel.GetAttackModel();

            attackModel.range += 10;

            // throw new NotImplementedException();

        }
        
        public override IEnumerable<int[]> TowerTiers()
        {
            if (MelonHandler.Mods.OfType<BloonsTD6Mod>().Any(m => m.GetModName() == "UltimateCrosspathing"))
            {
                for (var top = 0; top <= TopPathUpgrades; top++)
                {
                    for (var mid = 0; mid <= MiddlePathUpgrades; mid++)
                    {
                        for (var bot = 0; bot <= BottomPathUpgrades; bot++)
                        {
                            yield return new[] { top, mid, bot };
                        }
                    }
                }
            }
            else
            {
                foreach (var towerTier in base.TowerTiers())
                {
                    yield return towerTier;
                }
            }
        }
        
    }
}
