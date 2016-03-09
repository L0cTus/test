using System;
using System.Windows.Forms;
using EmuWarrior.Settings;

namespace EmuWarrior.Gui
{
    public partial class CCGui : Form
    {
        public CCGui()
        {
            InitializeComponent();
            load();
        }


        private void save()
        {
            //Misc
            EmuWarriorSettings.Values.DrinkName = drinkTb.Text;
            EmuWarriorSettings.Values.FoodName = foodTb.Text;
            EmuWarriorSettings.Values.MeleeAttackRange = (int)meleeNud.Value;
            EmuWarriorSettings.Values.RangedAttackRange = (int)castNud.Value;

            //Ranged
            EmuWarriorSettings.Values.UseRangedToPull = useRangedCb.Checked;
            EmuWarriorSettings.Values.RangedPullSpell = rangedSpellTb.Text;
            EmuWarriorSettings.Values.RangedAmmo = rangedAmmoTb.Text;

            //Combat
            EmuWarriorSettings.Values.PreferredStance = stanceCb.SelectedIndex + 1;
            EmuWarriorSettings.Values.CastRend = castRendCb.Checked;

            EmuWarriorSettings.Values.Save();
        }

        private void load()
        {
            EmuWarriorSettings.Values.Load();
            drinkTb.Text = EmuWarriorSettings.Values.DrinkName;
            foodTb.Text = EmuWarriorSettings.Values.FoodName;
            meleeNud.Value = EmuWarriorSettings.Values.MeleeAttackRange;
            castNud.Value = EmuWarriorSettings.Values.RangedAttackRange;

            //Ranged
            useRangedCb.Checked = EmuWarriorSettings.Values.UseRangedToPull;
            rangedSpellTb.Text = EmuWarriorSettings.Values.RangedPullSpell;
            rangedAmmoTb.Text = EmuWarriorSettings.Values.RangedAmmo;

            //Combat
            stanceCb.SelectedIndex = EmuWarriorSettings.Values.PreferredStance - 1;
            castRendCb.Checked = EmuWarriorSettings.Values.CastRend;

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            save();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            load();
        }

        private void CCGui_Load(object sender, EventArgs e)
        {
            this.Text = Data.Statics.SettingsName;
        }
    }
}
