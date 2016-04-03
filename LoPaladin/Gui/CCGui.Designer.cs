namespace LoPaladin.Gui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CCGui));
            this.drinklb = new System.Windows.Forms.Label();
            this.drinkTb = new System.Windows.Forms.TextBox();
            this.meleelb = new System.Windows.Forms.Label();
            this.meleeNud = new System.Windows.Forms.NumericUpDown();
            this.saveBtn = new System.Windows.Forms.Button();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.useRighteousFury = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dropaura = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.autojudgement = new System.Windows.Forms.CheckBox();
            this.dropseal = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.foodlb = new System.Windows.Forms.Label();
            this.foodTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.meleeNud)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // drinklb
            // 
            this.drinklb.AutoSize = true;
            this.drinklb.Location = new System.Drawing.Point(3, 16);
            this.drinklb.Name = "drinklb";
            this.drinklb.Size = new System.Drawing.Size(69, 13);
            this.drinklb.TabIndex = 0;
            this.drinklb.Text = "Drink Name: ";
            // 
            // drinkTb
            // 
            this.drinkTb.Location = new System.Drawing.Point(6, 32);
            this.drinkTb.Name = "drinkTb";
            this.drinkTb.Size = new System.Drawing.Size(159, 20);
            this.drinkTb.TabIndex = 1;
            // 
            // meleelb
            // 
            this.meleelb.AutoSize = true;
            this.meleelb.Location = new System.Drawing.Point(3, 149);
            this.meleelb.Name = "meleelb";
            this.meleelb.Size = new System.Drawing.Size(87, 13);
            this.meleelb.TabIndex = 2;
            this.meleelb.Text = "Melee Distance: ";
            // 
            // meleeNud
            // 
            this.meleeNud.Location = new System.Drawing.Point(123, 147);
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
            this.meleeNud.Size = new System.Drawing.Size(42, 20);
            this.meleeNud.TabIndex = 3;
            this.meleeNud.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(456, 276);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(85, 34);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.Location = new System.Drawing.Point(547, 276);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(85, 34);
            this.reloadBtn.TabIndex = 2;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.UseVisualStyleBackColor = true;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LoPaladin Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please note that this Rotation CC is in development and may cause bugs. \r\nReport " +
    "bugs to get them fixed, with level and a detailed description.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.foodTb);
            this.groupBox4.Controls.Add(this.foodlb);
            this.groupBox4.Controls.Add(this.useRighteousFury);
            this.groupBox4.Controls.Add(this.meleelb);
            this.groupBox4.Controls.Add(this.meleeNud);
            this.groupBox4.Controls.Add(this.drinklb);
            this.groupBox4.Controls.Add(this.drinkTb);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox4.Location = new System.Drawing.Point(534, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 175);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Misc";
            // 
            // useRighteousFury
            // 
            this.useRighteousFury.AutoSize = true;
            this.useRighteousFury.Location = new System.Drawing.Point(6, 124);
            this.useRighteousFury.Name = "useRighteousFury";
            this.useRighteousFury.Size = new System.Drawing.Size(119, 17);
            this.useRighteousFury.TabIndex = 3;
            this.useRighteousFury.Text = "Use Righteous Fury";
            this.useRighteousFury.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dropaura);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox3.Location = new System.Drawing.Point(6, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 50);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aura\'s";
            // 
            // dropaura
            // 
            this.dropaura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropaura.FormattingEnabled = true;
            this.dropaura.Items.AddRange(new object[] {
            "Best DPS",
            "Disable Autocast",
            "",
            "Devotion Aura",
            "Retribution Aura",
            "Concentration Aura",
            "Shadow Resistance Aura",
            "Frost Resistance Aura",
            "Fire Resistance Aura"});
            this.dropaura.Location = new System.Drawing.Point(6, 19);
            this.dropaura.MaxDropDownItems = 6;
            this.dropaura.Name = "dropaura";
            this.dropaura.Size = new System.Drawing.Size(159, 21);
            this.dropaura.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.autojudgement);
            this.groupBox2.Controls.Add(this.dropseal);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 70);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seal\'s";
            // 
            // autojudgement
            // 
            this.autojudgement.AutoSize = true;
            this.autojudgement.Checked = true;
            this.autojudgement.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autojudgement.Location = new System.Drawing.Point(6, 46);
            this.autojudgement.Name = "autojudgement";
            this.autojudgement.Size = new System.Drawing.Size(123, 17);
            this.autojudgement.TabIndex = 2;
            this.autojudgement.Text = "Autocast Judgement";
            this.autojudgement.UseVisualStyleBackColor = true;
            // 
            // dropseal
            // 
            this.dropseal.Cursor = System.Windows.Forms.Cursors.Default;
            this.dropseal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropseal.FormattingEnabled = true;
            this.dropseal.ItemHeight = 13;
            this.dropseal.Items.AddRange(new object[] {
            "Best DPS",
            "Disable Autocast",
            "",
            "Seal of Righteousness",
            "Seal of the Crusader",
            "Seal of Command",
            "Seal of Justice",
            "Seal of Light",
            "Seal of Wisdom"});
            this.dropseal.Location = new System.Drawing.Point(6, 19);
            this.dropseal.Name = "dropseal";
            this.dropseal.Size = new System.Drawing.Size(159, 21);
            this.dropseal.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(735, 73);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // foodlb
            // 
            this.foodlb.AutoSize = true;
            this.foodlb.Location = new System.Drawing.Point(3, 55);
            this.foodlb.Name = "foodlb";
            this.foodlb.Size = new System.Drawing.Size(68, 13);
            this.foodlb.TabIndex = 4;
            this.foodlb.Text = "Food Name: ";
            // 
            // foodTb
            // 
            this.foodTb.Location = new System.Drawing.Point(6, 71);
            this.foodTb.Name = "foodTb";
            this.foodTb.Size = new System.Drawing.Size(159, 20);
            this.foodTb.TabIndex = 5;
            // 
            // CCGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(735, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CCGui";
            this.Text = "1";
            this.Load += new System.EventHandler(this.CCGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meleeNud)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label drinklb;
        private System.Windows.Forms.TextBox drinkTb;
        private System.Windows.Forms.Label meleelb;
        private System.Windows.Forms.NumericUpDown meleeNud;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox dropaura;
        private System.Windows.Forms.ComboBox dropseal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox autojudgement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox useRighteousFury;
        private System.Windows.Forms.TextBox foodTb;
        private System.Windows.Forms.Label foodlb;
    }
}