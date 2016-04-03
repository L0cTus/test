using System;
using System.Windows.Forms;
using LoPaladin.Settings;

namespace LoPaladin.Gui
{


    public partial class CCGui : Form
    {
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        public CCGui()
        {
            InitializeComponent();
            load();
        }


        private void save()
        {
            //Misc
            LoPaladinSettings.Values.DrinkName = drinkTb.Text;
            LoPaladinSettings.Values.MeleeAttackRange = (int)meleeNud.Value;
            LoPaladinSettings.Values.FoodName = foodTb.Text;
            LoPaladinSettings.Values.Aura = dropaura.Text;
            LoPaladinSettings.Values.Seal = dropseal.Text;
            LoPaladinSettings.Values.AutoJudgement = autojudgement.Checked;
            LoPaladinSettings.Values.RighteousFury = useRighteousFury.Checked;

            LoPaladinSettings.Values.Save();
        }

        private void load()
        {
            LoPaladinSettings.Values.Load();
            drinkTb.Text = LoPaladinSettings.Values.DrinkName;
            foodTb.Text = LoPaladinSettings.Values.FoodName;
            meleeNud.Value = LoPaladinSettings.Values.MeleeAttackRange;
            dropaura.Text = LoPaladinSettings.Values.Aura;
            dropseal.Text = LoPaladinSettings.Values.Seal;
            autojudgement.Checked = LoPaladinSettings.Values.AutoJudgement;
            useRighteousFury.Checked = LoPaladinSettings.Values.RighteousFury;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
