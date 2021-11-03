using System;
using BTD_Mod_Helper;
using MelonLoader;


[assembly: MelonInfo(typeof(Click_tower.Main), "My first mod", "1.0.0", "Cake")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace Click_tower
{
    public class Main : BloonsTD6Mod
    {
        public override void OnMainMenu()
        {
            base.OnMainMenu();
        }

        public override void OnApplicationStart()
        {
            MelonLogger.Msg("Click tower loaded!");
        }
    }
}
