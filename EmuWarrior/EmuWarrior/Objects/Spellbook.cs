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
using EmuWarrior.Data;
using EmuWarrior.Settings;

namespace EmuWarrior.Objects
{
    internal class Spellbook
    {
        private static Spell lastSpell = new Spell(string.Empty, -1, false, false);

        private List<Spell> spells;


        // Damage Spells
        public static readonly Spell Charge = new Spell("Charge", 1000, false, true,
            isWanted:
                () =>
                    Helpers.CanCast("Charge") 
                    && !Me.IsInCombat && Target.Position.GetDistanceTo(Me.Position) > 9
                    && Helpers.GetStance() == Enums.WarriorStance.Battle);

        public static readonly Spell Execute = new Spell("Execute", 950, false, true,
            isWanted:
                () =>
                    Helpers.CanCast("Execute") && Me.Rage >= 10 && Target.HealthPercent < 20
                    && Helpers.GetStance() != Enums.WarriorStance.Defensive);

        public static readonly Spell MortalStrike = new Spell("Mortal Strike", 900, false, true,
            isWanted:
                () =>
                    Helpers.CanCast("Mortal Strike") && Me.Rage >= 20 && Helpers.GetStance() != Enums.WarriorStance.Defensive);

        public static readonly Spell Bloodthirst = new Spell("Bloodthirst", 900, false, true,
            isWanted:
                () =>
                    Helpers.CanCast("Bloodthirst") && Me.Rage >= 20 && Helpers.GetStance() != Enums.WarriorStance.Defensive);

        public static readonly Spell ShieldSlam = new Spell("Shield Slam", 900, false, true,
            isWanted:
                () =>
                    Helpers.CanCast("Shield Slam") && Me.Rage >= 20 && Helpers.GetStance() != Enums.WarriorStance.Berserker
                    && Helpers.HasSheild());

        public static readonly Spell Whirlwind = new Spell("Whirlwind", 850, false, true,
            isWanted:
                () =>
                    Helpers.CanCast("Whirlwind") && Me.Rage >= 25 && Helpers.GetStance() == Enums.WarriorStance.Berserker);

        public static readonly Spell Overpower = new Spell("Overpower", 875, false, true,
            isWanted:
                () =>
                    Helpers.CanCast("Overpower") && Me.Rage >= 5 
                    && ObjectManager.Instance.Player.CanOverpower 
                    && Helpers.GetStance() == Enums.WarriorStance.Battle);

        public static readonly Spell Rend = new Spell("Rend", 300, false, true,
            isWanted:
                () =>
                    Helpers.CanCast("Rend") && Me.Rage >= 10 && Helpers.GetStance() != Enums.WarriorStance.Berserker
                    && EmuWarriorSettings.Values.CastRend);

        //Only cast if we can't do anything else - or as a rage dump
        
        public static readonly Spell Cleave = new Spell("Cleave", 450, false, true,
             isWanted:
                 () =>
                     Helpers.CanCast("Cleave") && UnitInfo.Instance.NpcAttackers.Count > 2 
                     && ((Me.Rage >= 20 && !Helpers.CanCast("Mortal Strike")
                     && !Helpers.CanCast("Bloodthirst") && !Helpers.CanCast("Shield Slam")) || Me.Rage >= 45));
        
        public static readonly Spell HerioicStrike = new Spell("Heroic Strike", 400, false, true,
            isWanted:
                () =>
                    Helpers.CanCast("Heroic Strike") && UnitInfo.Instance.NpcAttackers.Count == 1
                    && ((Me.Rage >= 15 && !Helpers.CanCast("Mortal Strike")
                    && !Helpers.CanCast("Bloodthirst") && !Helpers.CanCast("Shield Slam")) || Me.Rage >= 45));

        // Buff spells.
        public static readonly Spell BattleShout = new Spell("Battle Shout", 1050, true, true,
            isWanted:
                () =>
                    Helpers.ShouldBuffSelf("Battle Shout") && Me.Rage >= 10);

        public static readonly Spell Bloodrage = new Spell("Bloodrage ", 750, false, true,
            isWanted:
                () =>
                    Helpers.CanCast("Bloodrage") && Me.HealthPercent >= 75 
                    && Target.HealthPercent >= 25);

        //Big Cooldowns
        public static readonly Spell LastStand = new Spell("Last Stand", 1100, false, true,
            isWanted:
                () =>
                    Helpers.CanCast("Last Stand") && Me.HealthPercent <= 20);

        public static readonly Spell Retaliation = new Spell("Retaliation", 1100, false, true,
            isWanted:
                () =>
                    Helpers.CanCast("Retaliation") && (Me.HealthPercent <= 80 && UnitInfo.Instance.NpcAttackers.Count >= 2
                    || Me.HealthPercent <= 40 && Target.HealthPercent >= 50));

        public static readonly Spell Attack = new Spell("Attack", Int32.MaxValue, false, true, true, false,
            () => Helpers.CanCast("Attack"), customAction:
                () =>
                {
                    ZzukBot.Game.Statics.Spell.Instance.Attack();
                });

        public Spellbook()
        {
            this.spells = new List<Spell>();
            this.InitializeSpellbook();
        }

        //Do not use this as a template - this has been changed for warriors
        public IEnumerable<Spell> GetDamageSpells()
        {
            return Cache.Instance.GetOrStore("damageSpells", () => this.spells.Where(s => s.DoesDamage));
        }

        //Do not use this as a template - this has been changed for warriors
        public IEnumerable<Spell> GetBuffSpells()
        {
            return Cache.Instance.GetOrStore("buffSpells", () => this.spells.Where(s => s.IsBuff || !s.DoesDamage));
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

            spells = spells.OrderBy(s => s.Priority).ToList();
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
