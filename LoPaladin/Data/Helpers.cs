using ZzukBot.Game.Statics;
using ZzukBot.Objects;

namespace LoPaladin.Data
{
    internal static class Helpers
    {
        public static void PrintToChat(string parMessage)
        {
            Lua.Instance.Execute("DEFAULT_CHAT_FRAME:AddMessage('ProtPalla: " + parMessage + "')");
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
            return Spell.Instance.IsSpellReady(parSpell) && Spell.Instance.GetSpellRank(parSpell) != 0;
        }

        public static bool CanWand()
        {
            return ObjectManager.Instance.Player.IsWandEquipped();
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
