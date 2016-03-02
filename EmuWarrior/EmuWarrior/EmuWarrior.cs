using System;
using System.ComponentModel.Composition;
using System.Linq;
using System.Windows.Forms;
using EmuWarrior.Data;
using EmuWarrior.Gui;
using EmuWarrior.Objects;
using EmuWarrior.Settings;
using ZzukBot.ExtensionFramework;
using ZzukBot.ExtensionFramework.Classes;
using ZzukBot.Game.Statics;
using ZzukBot.Objects;
using Enums = ZzukBot.Constants.Enums;

// EmuWarrior - 99% Credits to z0mg
// Would like to give a huge thanks to z0mg (Rob)
// I used his doctorDeath CC as a template
// very easy to follow and adapt - Thanks Heaps!

namespace EmuWarrior
{
    [Export(typeof(CustomClass))]
    public class EmuWarrior : CustomClass
    {
        private Form CCGui = new CCGui();
        private Spellbook spellbook;
        /// <summary>
        /// The WoW class the CustomClass is designed for
        /// </summary>
        public override Enums.ClassId Class => Enums.ClassId.Warrior;

        /// <summary>
        /// Should be called when the CC is loaded
        /// </summary>
        /// <returns></returns>
        public override bool Load()
        {
            this.spellbook = new Spellbook();
            EmuWarriorSettings.Values.Load();
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

                //Hack on RangedAttack :(
                if (EmuWarriorSettings.Values.UseRangedToPull &&
                    (Inventory.Instance.GetEquippedItem(Enums.EquipSlot.Ranged).Name ==
                     EmuWarriorSettings.Values.RangedAmmo ||
                     Inventory.Instance.GetEquippedItem(0).Name == EmuWarriorSettings.Values.RangedAmmo))
                {
                    CustomClasses.Instance.Current.CombatDistance = EmuWarriorSettings.Values.RangedAttackRange;
                    Helpers.TryCast(EmuWarriorSettings.Values.RangedPullSpell, 3000);
                    return;
                }
                else
                {

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

                if (EmuWarriorSettings.Values.PreferredStance != (int) Helpers.GetStance())
                {
                    Helpers.TryCast(Statics.StanceName[EmuWarriorSettings.Values.PreferredStance]);
                }

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
                    ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == EmuWarriorSettings.Values.DrinkName).Use();
                    ZzukBot.Helpers.Wait.For("DrinkWarrior", 500);
                }
                if (!ObjectManager.Instance.Player.IsEating)
                {
                    ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == EmuWarriorSettings.Values.FoodName)
                        .Use();
                    ZzukBot.Helpers.Wait.For("EatWarrior", 500);
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
                //If we want to charge - go back to battle stance
                if(!EmuWarriorSettings.Values.UseRangedToPull 
                    && Helpers.GetStance() != Data.Enums.WarriorStance.Battle 
                    && Helpers.CanCast("Charge"))
                    Helpers.TryCast(Statics.StanceName[(int)Data.Enums.WarriorStance.Battle]);

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
        public override string Name => Data.Statics.SettingsName;

        /// <summary>
        /// The author of the CC
        /// </summary>
        public override string Author => "z0mg";

        /// <summary>
        /// The version of the CC
        /// </summary>
        public override int Version => 1;

        /// <summary>
        /// The current combat distance
        /// </summary>
        public override float CombatDistance => EmuWarriorSettings.Values.MeleeAttackRange;

    }
}
