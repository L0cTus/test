using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoPaladin.Settings
{
    class LoPaladinSettings
    {
        
        public volatile int MeleeAttackRange = 5;
        public volatile string DrinkName = "";
        public volatile string FoodName = "";
        public volatile string Aura = "Best DPS";
        public volatile string Seal = "Best DPS";
        public volatile bool AutoJudgement = true;
        public volatile bool RighteousFury = false;


        private LoPaladinSettings()
        {

        }

        internal static LoPaladinSettings Values { get; set; } = new LoPaladinSettings();

        internal void Load()
        {
            Values = ZzukBot.Settings.OptionManager.Get(Data.Statics.SettingsName).LoadFromJson<LoPaladinSettings>() ??
                     this;
        }

        internal void Save()
        {
            ZzukBot.Settings.OptionManager.Get(Data.Statics.SettingsName).SaveToJson(this);
        }
    }
}
