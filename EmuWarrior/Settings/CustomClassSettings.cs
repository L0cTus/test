using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmuWarrior.Settings
{
    class EmuWarriorSettings
    {

        public volatile int RangedAttackRange = 25;
        public volatile int MeleeAttackRange = 4;
        public volatile string FoodName = "";
        public volatile string DrinkName = "";

        public volatile bool UseRangedToPull = false;
        public volatile string RangedPullSpell = "Shoot Bow";
        public volatile string RangedAmmo = "Rough arrow";

        public volatile bool CastRend = false;

        public volatile int PreferredStance = 1;




        private EmuWarriorSettings()
        {

        }

        internal static EmuWarriorSettings Values { get; set; } = new EmuWarriorSettings();

        internal void Load()
        {
            Values = ZzukBot.Settings.OptionManager.Get(Data.Statics.SettingsName).LoadFromJson<EmuWarriorSettings>() ??
                     this;
        }

        internal void Save()
        {
            ZzukBot.Settings.OptionManager.Get(Data.Statics.SettingsName).SaveToJson(this);
        }
    }
}
