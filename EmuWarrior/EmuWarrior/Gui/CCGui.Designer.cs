namespace EmuWarrior.Gui
{
    partial class CCGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.foodlb = new System.Windows.Forms.Label();
            this.drinklb = new System.Windows.Forms.Label();
            this.foodTb = new System.Windows.Forms.TextBox();
            this.drinkTb = new System.Windows.Forms.TextBox();
            this.meleelb = new System.Windows.Forms.Label();
            this.castlb = new System.Windows.Forms.Label();
            this.meleeNud = new System.Windows.Forms.NumericUpDown();
            this.castNud = new System.Windows.Forms.NumericUpDown();
            this.saveBtn = new System.Windows.Forms.Button();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rangedAmmoTb = new System.Windows.Forms.TextBox();
            this.rangedSpellTb = new System.Windows.Forms.TextBox();
            this.useRangedCb = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.castRendCb = new System.Windows.Forms.CheckBox();
            this.stanceCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.meleeNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.castNud)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodlb
            // 
            this.foodlb.AutoSize = true;
            this.foodlb.Location = new System.Drawing.Point(6, 16);
            this.foodlb.Name = "foodlb";
            this.foodlb.Size = new System.Drawing.Size(68, 13);
            this.foodlb.TabIndex = 0;
            this.foodlb.Text = "Food Name: ";
            // 
            // drinklb
            // 
            this.drinklb.AutoSize = true;
            this.drinklb.Location = new System.Drawing.Point(5, 44);
            this.drinklb.Name = "drinklb";
            this.drinklb.Size = new System.Drawing.Size(69, 13);
            this.drinklb.TabIndex = 1;
            this.drinklb.Text = "Drink Name: ";
            // 
            // foodTb
            // 
            this.foodTb.Location = new System.Drawing.Point(80, 13);
            this.foodTb.Name = "foodTb";
            this.foodTb.Size = new System.Drawing.Size(100, 20);
            this.foodTb.TabIndex = 2;
            // 
            // drinkTb
            // 
            this.drinkTb.Location = new System.Drawing.Point(80, 41);
            this.drinkTb.Name = "drinkTb";
            this.drinkTb.Size = new System.Drawing.Size(100, 20);
            this.drinkTb.TabIndex = 3;
            // 
            // meleelb
            // 
            this.meleelb.AutoSize = true;
            this.meleelb.Location = new System.Drawing.Point(5, 69);
            this.meleelb.Name = "meleelb";
            this.meleelb.Size = new System.Drawing.Size(87, 13);
            this.meleelb.TabIndex = 4;
            this.meleelb.Text = "Melee Distance: ";
            // 
            // castlb
            // 
            this.castlb.AutoSize = true;
            this.castlb.Location = new System.Drawing.Point(6, 95);
            this.castlb.Name = "castlb";
            this.castlb.Size = new System.Drawing.Size(79, 13);
            this.castlb.TabIndex = 5;
            this.castlb.Text = "Cast Distance: ";
            // 
            // meleeNud
            // 
            this.meleeNud.Location = new System.Drawing.Point(115, 67);
            this.meleeNud.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.meleeNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.meleeNud.Name = "meleeNud";
            this.meleeNud.Size = new System.Drawing.Size(66, 20);
            this.meleeNud.TabIndex = 6;
            this.meleeNud.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // castNud
            // 
            this.castNud.Location = new System.Drawing.Point(115, 93);
            this.castNud.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.castNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.castNud.Name = "castNud";
            this.castNud.Size = new System.Drawing.Size(66, 20);
            this.castNud.TabIndex = 7;
            this.castNud.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(209, 160);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(85, 34);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.Location = new System.Drawing.Point(300, 160);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(85, 34);
            this.reloadBtn.TabIndex = 9;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.UseVisualStyleBackColor = true;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.foodlb);
            this.groupBox1.Controls.Add(this.drinklb);
            this.groupBox1.Controls.Add(this.foodTb);
            this.groupBox1.Controls.Add(this.castNud);
            this.groupBox1.Controls.Add(this.drinkTb);
            this.groupBox1.Controls.Add(this.meleeNud);
            this.groupBox1.Controls.Add(this.meleelb);
            this.groupBox1.Controls.Add(this.castlb);
            this.groupBox1.Location = new System.Drawing.Point(200, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 122);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Misc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rangedAmmoTb);
            this.groupBox2.Controls.Add(this.rangedSpellTb);
            this.groupBox2.Controls.Add(this.useRangedCb);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 97);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pulling";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ranged Ammo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ranged Spell";
            // 
            // rangedAmmoTb
            // 
            this.rangedAmmoTb.Location = new System.Drawing.Point(80, 68);
            this.rangedAmmoTb.Name = "rangedAmmoTb";
            this.rangedAmmoTb.Size = new System.Drawing.Size(100, 20);
            this.rangedAmmoTb.TabIndex = 7;
            // 
            // rangedSpellTb
            // 
            this.rangedSpellTb.Location = new System.Drawing.Point(80, 42);
            this.rangedSpellTb.Name = "rangedSpellTb";
            this.rangedSpellTb.Size = new System.Drawing.Size(100, 20);
            this.rangedSpellTb.TabIndex = 6;
            // 
            // useRangedCb
            // 
            this.useRangedCb.AutoSize = true;
            this.useRangedCb.Location = new System.Drawing.Point(6, 19);
            this.useRangedCb.Name = "useRangedCb";
            this.useRangedCb.Size = new System.Drawing.Size(109, 17);
            this.useRangedCb.TabIndex = 5;
            this.useRangedCb.Text = "Pull With Ranged";
            this.useRangedCb.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.stanceCb);
            this.groupBox3.Controls.Add(this.castRendCb);
            this.groupBox3.Location = new System.Drawing.Point(12, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 97);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Combat";
            // 
            // castRendCb
            // 
            this.castRendCb.AutoSize = true;
            this.castRendCb.Location = new System.Drawing.Point(6, 73);
            this.castRendCb.Name = "castRendCb";
            this.castRendCb.Size = new System.Drawing.Size(76, 17);
            this.castRendCb.TabIndex = 0;
            this.castRendCb.Text = "Cast Rend";
            this.castRendCb.UseVisualStyleBackColor = true;
            // 
            // stanceCb
            // 
            this.stanceCb.FormattingEnabled = true;
            this.stanceCb.Items.AddRange(new object[] {
            "Battle Stance",
            "Defensive Stance",
            "Berserker Stance"});
            this.stanceCb.Location = new System.Drawing.Point(6, 36);
            this.stanceCb.Name = "stanceCb";
            this.stanceCb.Size = new System.Drawing.Size(121, 21);
            this.stanceCb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preferred Stance";
            // 
            // CCGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 221);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CCGui";
            this.Text = "EmuWarrior - Thanks z0mg";
            this.Load += new System.EventHandler(this.CCGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meleeNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.castNud)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label foodlb;
        private System.Windows.Forms.Label drinklb;
        private System.Windows.Forms.TextBox foodTb;
        private System.Windows.Forms.TextBox drinkTb;
        private System.Windows.Forms.Label meleelb;
        private System.Windows.Forms.Label castlb;
        private System.Windows.Forms.NumericUpDown meleeNud;
        private System.Windows.Forms.NumericUpDown castNud;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rangedAmmoTb;
        private System.Windows.Forms.TextBox rangedSpellTb;
        private System.Windows.Forms.CheckBox useRangedCb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox stanceCb;
        private System.Windows.Forms.CheckBox castRendCb;
    }
}