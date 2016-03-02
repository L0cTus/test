using ZzukBot.Game.Statics;
using ZzukBot.Objects;

namespace EmuWarrior.Data
{
    internal static class Helpers
    {
        public static void PrintToChat(string parMessage)
        {
            Lua.Instance.Execute("DEFAULT_CHAT_FRAME:AddMessage('EmuWarrior: " + parMessage + "')");
        }

        public static void TryCast(string parSpell, int parWait = 10)
        { 
            if (CanCast(parSpell))
            {
                Spell.Instance.StopWand();
                Spell.Instance.CastWait(parSpell, parWait);
            }
        }

        public static void TryBuff(string parSpell)
        {
            if (ShouldBuffSelf(parSpell))
            {
                Lua.Instance.Execute("CastSpellByName('" + parSpell + "',1);");
            }
        }

        public static bool ShouldBuffSelf(string parSpell)
        {
            return (CanCast(parSpell) && !ObjectManager.Instance.Player.GotAura(parSpell));
        }


        public static bool CanCast(string parSpell)
        {
            return ZzukBot.Game.Statics.Spell.Instance.IsSpellReady(parSpell) && ZzukBot.Game.Statics.Spell.Instance.GetSpellRank(parSpell) != 0;
        }

        public static bool CanWand()
        {
            return ObjectManager.Instance.Player.IsWandEquipped();
        }

        public static Enums.WarriorStance GetStance()
        {
            if (Lua.Instance.GetText("icon, name, active = GetShapeshiftFormInfo(1);", "active") == "1")
                return Enums.WarriorStance.Battle;
            if (Lua.Instance.GetText("icon, name, active = GetShapeshiftFormInfo(2);", "active") == "1")
                return Enums.WarriorStance.Defensive;

            return Enums.WarriorStance.Berserker;
            //PrintToChat(text);
            /*
            for (int i = 1; i < 4; i++)
            {
                if (text.Equals(Statics.StanceName[i]))
                    return (Enums.WarriorStance) i;
            }
            return Enums.WarriorStance.Battle;*/
            //return (Enums.WarriorStance) (int.Parse(Lua.Instance.GetText("icon, name, active = GetShapeshiftFormInfo(true);", "active")));
        }

        public static bool HasSheild()
        {
            WoWItem Offhand = Inventory.Instance.GetEquippedItem(ZzukBot.Constants.Enums.EquipSlot.OffHand);
            if (Offhand == null) return false;
            if (Offhand.Info.Damage.DmgMin.Equals(0f)) return true;

            return false;
        }
    }
}
