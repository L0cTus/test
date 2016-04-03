using System;
using System.ComponentModel.Composition;
using System.Linq;
using System.Windows.Forms;
using LoPaladin.Data;
using LoPaladin.Gui;
using LoPaladin.Objects;
using LoPaladin.Settings;
using ZzukBot.ExtensionFramework;
using ZzukBot.ExtensionFramework.Classes;
using ZzukBot.Game.Statics;
using ZzukBot.Objects;
using Enums = ZzukBot.Constants.Enums;

namespace LoPaladin
{
    [Export(typeof(CustomClass))]
    public class LoPaladin : CustomClass
    {
        private Form CCGui = new CCGui();
        private Spellbook spellbook;
        /// <summary>
        /// The WoW class the CustomClass is designed for
        /// </summary>
        public override Enums.ClassId Class => Enums.ClassId.Paladin;

        /// <summary>
        /// Should be called when the CC is loaded
        /// </summary>
        /// <returns></returns>
        public override bool Load()
        {
            this.spellbook = new Spellbook();
            LoPaladinSettings.Values.Load();
            return true;
        }

        /// <summary>
        /// Should be called when the CC is unloaded
        /// </summary>
        public override void Unload()
        {
        }

        /// <summary>
        /// Should be called when the botbase is pulling an unit
        /// </summary>
        public override void OnPull()
        {
            try
            {
                WoWUnit targetUnit = ObjectManager.Instance.Target;
                if (targetUnit == null) return;

                CustomClasses.Instance.Current.CombatDistance = LoPaladinSettings.Values.MeleeAttackRange;
                ZzukBot.Game.Statics.Spell.Instance.Attack();

                var damageSpells = this.spellbook.GetDamageSpells();

                foreach (var spell in damageSpells)
                {
                    if (spell.IsWanted)
                    {
                        spell.Cast();
                        spellbook.UpdateLastSpell(spell);
                        break;
                    }
                    
                }
            }
            catch (Exception e)
            {
                //Don't even want to know
            }
        }

        /// <summary>
        /// Should be called when the botbase is fighting an unit
        /// </summary>
        public override void OnFight()
        {
            try
            {
                WoWUnit targetUnit = ObjectManager.Instance.Target;
                if (targetUnit == null) return;

                
                ZzukBot.Game.Statics.Spell.Instance.Attack();


                var damageSpells = this.spellbook.GetDamageSpells();

                foreach (var spell in damageSpells)
                {
                    if (spell.IsWanted)
                    {
                        spell.Cast();
                        spellbook.UpdateLastSpell(spell);
                        break;
                    }
                }
            }
            catch(Exception e)
            {
                
            }
        }

        /// <summary>
        /// Should be called when the botbase is resting
        /// </summary>
        public override void OnRest()
        {
            //This needs to be tested & cleaned up
            try
            {
                if (!ObjectManager.Instance.Player.IsDrinking)
                {
                    ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == LoPaladinSettings.Values.DrinkName).Use();
                    ZzukBot.Helpers.Wait.For("DrinkPaladin", 500);
                }
                if (!ObjectManager.Instance.Player.IsEating)
                {
                    ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == LoPaladinSettings.Values.FoodName)
                        .Use();
                    ZzukBot.Helpers.Wait.For("EatPaladin", 500);
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// Should be called when the botbase is resting
        /// </summary>
        /// <returns>
        /// Returns true when the character is done buffing
        /// </returns>
        public override bool OnBuff()
        {
            
            try
            {
                if (!ObjectManager.Instance.Player.InGhostForm && !ObjectManager.Instance.Player.IsDead)
                {
                    var buffs = this.spellbook.GetBuffSpells();

                    foreach (var spell in buffs)
                    {
                        if (spell.IsWanted)
                        {
                            spell.Cast();
                            return false;
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }
            return true;
        
        }

        /// <summary>
        /// Should be called to show the settings form
        /// </summary>
        public override void ShowGui()
        {
            CCGui.Dispose();
            CCGui = new CCGui();
            CCGui.Show();

        }

        /// <summary>
        /// The name of the CC
        /// </summary>
        public override string Name => "LoPaladin";

        /// <summary>
        /// The author of the CC
        /// </summary>
        public override string Author => "Loctus";

        /// <summary>
        /// The version of the CC
        /// </summary>
        public override int Version => 1;

        /// <summary>
        /// The current combat distance
        /// </summary>
        public override float CombatDistance => LoPaladinSettings.Values.MeleeAttackRange;

    }
}
