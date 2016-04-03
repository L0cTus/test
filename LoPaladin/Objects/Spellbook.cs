using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ZzukBot.ExtensionFramework.Classes;
using ZzukBot.Game.Statics;
using ZzukBot.Objects;
using LoPaladin.Data;
using LoPaladin.Settings;

namespace LoPaladin.Objects
{
    internal class Spellbook
    {
        private static Spell lastSpell = new Spell(string.Empty, -1, false, false);

        private List<Spell> spells;

        //=========================================================================================================================
        // Survival Spells - Not buff but doesn't do damage

        //Divine Protection - Not 100% sure if works
        public static readonly Spell DivineProtection = new Spell("Divine Protection", 1500, false, false, true,
            isWanted:
                () =>
                    Helpers.ShouldBuffSelf("Divine Protection") && Me.HealthPercent <= 30 && Target.HealthPercent >= 10
                    && !Me.GotDebuff("Forbearance") && Me.IsInCombat);

        //Divine Shield - Not 100% sure if works
        public static readonly Spell DivineShield = new Spell("Divine Shield", 1500, false, false, true,
            isWanted:
                () =>
                    Helpers.ShouldBuffSelf("Divine Shield") && Me.HealthPercent <= 20 && Target.HealthPercent >= 10
                    && !Me.GotDebuff("Forbearance") && Me.IsInCombat);

        //Hammer of justice
        public static readonly Spell HammerofJustice = new Spell("Hammer of Justice", 1500, false, false, true,
            isWanted:
                () =>
                    Helpers.CanCast("Hammer of Justice") && Me.HealthPercent <= 40 && Target.HealthPercent >= 20);

        //=========================================================================================================================
        //Seals: with autocast enabled and one for auto levleing with most DPS

        //Seal of Righteousness
        public static readonly Spell SealofRighteousness = new Spell("Seal of Righteousness", 1300, false, false, true,
            isWanted:
                () => Target.Position.GetDistanceTo(Me.Position) <= 12
                    && Helpers.ShouldBuffSelf("Seal of Righteousness") && (LoPaladinSettings.Values.Seal == "Seal of Righteousness"
                    || (LoPaladinSettings.Values.Seal == "Best DPS" && (!Helpers.CanCast("Seal of the Crusader")
                    || Target.GotDebuff("Judgement of the Crusader") && !Me.GotAura("Seal of the Crusader")))));

        //Seal of the Crusader
        public static readonly Spell SealoftheCrusader = new Spell("Seal of the Crusader", 1300, false, false, true,
            isWanted:
                () => Target.Position.GetDistanceTo(Me.Position) <= 12
                    && Helpers.ShouldBuffSelf("Seal of the Crusader") && (LoPaladinSettings.Values.Seal == "Seal of the Crusader"
                    || (LoPaladinSettings.Values.Seal == "Best DPS" && !Target.GotDebuff("Judgement of the Crusader")
                    && (Target.HealthPercent >= 25 || !Me.GotAura("Seal of Righteousness")))));

        //Seal of Command
        public static readonly Spell SealofCommand = new Spell("Seal of Command", 1300, false, false, true,
            isWanted:
                () => Target.Position.GetDistanceTo(Me.Position) <= 12
                    && Helpers.ShouldBuffSelf("Seal of Command") && LoPaladinSettings.Values.Seal == "Seal of Command");

        //Seal of Justice
        public static readonly Spell SealofJustice = new Spell("Seal of Justice", 1300, false, false, true,
            isWanted:
                () => Target.Position.GetDistanceTo(Me.Position) <= 12
                    && Helpers.ShouldBuffSelf("Seal of Justice") && LoPaladinSettings.Values.Seal == "Seal of Justice");

        //Seal of Light
        public static readonly Spell SealofLight = new Spell("Seal of Light", 1300, false, false, true,
            isWanted:
                () => Target.Position.GetDistanceTo(Me.Position) <= 12
                    && Helpers.ShouldBuffSelf("Seal of Light") && LoPaladinSettings.Values.Seal == "Seal of Light");

        //Seal of Wisdom
        public static readonly Spell SealofWisdom = new Spell("Seal of Wisdom", 1300, false, false, true,
            isWanted:
                () => Target.Position.GetDistanceTo(Me.Position) <= 12
                    && Helpers.ShouldBuffSelf("Seal of Wisdom") && LoPaladinSettings.Values.Seal == "Seal of Wisdom");

        //=========================================================================================================================
        //Heals
        // Holy light Out of combat.
        public static readonly Spell HolyLightOOC = new Spell("Holy Light", 100, true, false,
            isWanted:
                () => Me.ManaPercent >= 15
                    && Helpers.CanCast("Holy Light") && Me.HealthPercent <= 60, customAction:
                () =>
                {
                    //Make sure it's cast on us!
                    Data.Helpers.TryBuff("Holy Light");
                });

        // Holy light in combat before flash heal
        public static readonly Spell HolyLight = new Spell("Holy Light", 1400, false, false,
            isWanted:
                () => Me.ManaPercent >= 15
                    && Helpers.CanCast("Holy Light") && Me.HealthPercent <= 40 && !Helpers.CanCast("Flash of Light"), customAction:
                () =>
                {
                    //Make sure it's cast on us!
                    Data.Helpers.TryBuff("Holy Light");
                });

        //Flash opf Light
        public static readonly Spell FlashofLight = new Spell("Flash of Light", 1400, false, false,
            isWanted:
                () => Me.ManaPercent >= 15
                    && Helpers.CanCast("Flash of Light") && Me.HealthPercent <= 40, customAction:
                () =>
                {
                    //Make sure it's cast on us!
                    Data.Helpers.TryBuff("Flash of Light");
                });

        //Lay on Hands
        public static readonly Spell LayonHands = new Spell("Lay on Hands", 1500, false, false,
            isWanted:
                () =>
                    Helpers.ShouldBuffSelf("Lay on Hands") && Me.HealthPercent <= 12 && Target.HealthPercent >= 5 && Me.IsInCombat);

        //=========================================================================================================================
        // Damage Spells

        // Consecration
        public static readonly Spell Consecration = new Spell("Consecration", 800, false, false, true,
            isWanted:
                () => Target.Position.GetDistanceTo(Me.Position) <= 8 && UnitInfo.Instance.NpcAttackers.Count >= 2
                    && Helpers.CanCast("Consecration"));

        //Hammer of Wrath
        public static readonly Spell HammerofWrath = new Spell("Hammer of Wrath", 1000, false, false, true,
            isWanted:
                () => Target.Position.GetDistanceTo(Me.Position) <= 30
                    && Helpers.CanCast("Hammer of Wrath") && Target.HealthPercent <= 20);

        //Judgement
        public static readonly Spell Judgement = new Spell("Judgement", 750, false, true, true,
            isWanted:
                () => Target.Position.GetDistanceTo(Me.Position) <= 10 && Target.HealthPercent >= 15 && LoPaladinSettings.Values.AutoJudgement == true
                    && Helpers.CanCast("Judgement") && (Me.GotAura("Seal of Righteousness") || Me.GotAura("Seal of the Crusader")
                    || Me.GotAura("Seal of Justice") || Me.GotAura("Seal of Light") || Me.GotAura("Seal of Wisdom")));

        //=========================================================================================================================
        // Buff spells.

        //Righteous Fury - If enabled
        public static readonly Spell RighteousFury = new Spell("Righteous Fury", 1500, true, false, true,
            isWanted:
                () =>
                    Helpers.ShouldBuffSelf("Righteous Fury") && LoPaladinSettings.Values.RighteousFury == true);

        //=========================================================================================================================
        // Auras:
        public static readonly Spell DevotionAura = new Spell("Devotion Aura", 1500, true, false, true,
            isWanted:
                () => Helpers.ShouldBuffSelf("Devotion Aura") && (LoPaladinSettings.Values.Aura == "Devotion Aura"
                    || (LoPaladinSettings.Values.Aura == "Best DPS" && !Helpers.CanCast("Retribution Aura"))));

        public static readonly Spell RetributionAura = new Spell("Retribution Aura", 1500, true, false, true,
            isWanted:
                () => Helpers.ShouldBuffSelf("Retribution Aura") && (LoPaladinSettings.Values.Aura == "Retribution Aura"
                || LoPaladinSettings.Values.Aura == "Best DPS") && !ObjectManager.Instance.Player.InGhostForm);

        public static readonly Spell ConcentrationAura = new Spell("Concentration Aura", 1500, true, false, true,
            isWanted:
                () => Helpers.ShouldBuffSelf("Concentration Aura") && LoPaladinSettings.Values.Aura == "Concentration Aura");

        public static readonly Spell ShadowResistanceAura = new Spell("Shadow Resistance Aura", 1500, true, false, true,
            isWanted:
                () => Helpers.ShouldBuffSelf("Shadow Resistance Aura") && LoPaladinSettings.Values.Aura == "Shadow Resistance Aura");

        public static readonly Spell FrostResistanceAura = new Spell("Frost Resistance Aura", 1500, true, false, true,
            isWanted:
                () => Helpers.ShouldBuffSelf("Frost Resistance Aura") && LoPaladinSettings.Values.Aura == "Frost Resistance Aura");

        public static readonly Spell FireResistanceAura = new Spell("Fire Resistance Aura", 1500, true, false, true,
            isWanted:
                () => Helpers.ShouldBuffSelf("Fire Resistance Aura") && LoPaladinSettings.Values.Aura == "Fire Resistance Aura");

        //=========================================================================================================================
        //Blessings:
        public static readonly Spell BlessingofMight = new Spell("Blessing of Might", 1400, true, false, true,
            isWanted:
                () =>
                    Helpers.ShouldBuffSelf("Blessing of Might"));

        //=========================================================================================================================

        public Spellbook()
        {
            this.spells = new List<Spell>();
            this.InitializeSpellbook();
        }

        public IEnumerable<Spell> GetDamageSpells()
        {
            return Cache.Instance.GetOrStore("damageSpells", () => this.spells.Where(s => !s.IsBuff));
        }

        public IEnumerable<Spell> GetBuffSpells()
        {
            return Cache.Instance.GetOrStore("buffSpells", () => this.spells.Where(s => s.IsBuff && !s.DoesDamage));
        }

        public void UpdateLastSpell(Spell spell)
        {
            lastSpell = spell;
        }

        private void InitializeSpellbook()
        {
            foreach (var property in this.GetType().GetFields())
            {
                spells.Add(property.GetValue(property) as Spell);
            }

            spells = spells.OrderByDescending(s => s.Priority).ToList();
        }

        private static WoWUnit Me
        {
            get { return ObjectManager.Instance.Player; }
        }

        private static WoWUnit Target
        {
            get { return ObjectManager.Instance.Target; }
        }

        private static WoWUnit Pet
        {
            get { return ObjectManager.Instance.Pet; }
        }
    }
}
