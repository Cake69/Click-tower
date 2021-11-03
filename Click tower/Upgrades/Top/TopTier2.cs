﻿using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMod.Upgrades.Top
{
    public class TopTier2 : ModUpgrade<ClickTower>
    {
        public override int Path => TOP;
        public override int Tier => 2;
        public override int Cost => 200;

        public override string Description => "More speedier...";

        public override void ApplyUpgrade(TowerModel tower)
        {
            foreach (var weaponModel in tower.GetWeapons())
            {
                weaponModel.Rate *= .5f;
            }
        }
    }
}
