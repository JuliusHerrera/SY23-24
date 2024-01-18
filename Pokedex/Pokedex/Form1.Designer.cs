namespace Pokedex
{
    partial class Form1
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
            this.LevelTB = new System.Windows.Forms.TextBox();
            this.AttackcomboBox = new System.Windows.Forms.ComboBox();
            this.GenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LegendaryCheckBox = new System.Windows.Forms.CheckBox();
            this.ShinyCheckBox = new System.Windows.Forms.CheckBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.TypeTB = new System.Windows.Forms.TextBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Typelabel = new System.Windows.Forms.Label();
            this.HpNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ExpNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GenLabel = new System.Windows.Forms.Label();
            this.HPlabel = new System.Windows.Forms.Label();
            this.EXPlabel = new System.Windows.Forms.Label();
            this.AttackTypelabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DebugTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GenNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HpNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // LevelTB
            // 
            this.LevelTB.Location = new System.Drawing.Point(145, 207);
            this.LevelTB.Name = "LevelTB";
            this.LevelTB.Size = new System.Drawing.Size(120, 22);
            this.LevelTB.TabIndex = 1;
            // 
            // AttackcomboBox
            // 
            this.AttackcomboBox.FormattingEnabled = true;
            this.AttackcomboBox.Items.AddRange(new object[] {
            "Special Attack",
            "Special Defense ",
            "Attack ",
            "Defense"});
            this.AttackcomboBox.Location = new System.Drawing.Point(145, 355);
            this.AttackcomboBox.Name = "AttackcomboBox";
            this.AttackcomboBox.Size = new System.Drawing.Size(141, 24);
            this.AttackcomboBox.TabIndex = 2;
            // 
            // GenNumericUpDown
            // 
            this.GenNumericUpDown.Location = new System.Drawing.Point(145, 263);
            this.GenNumericUpDown.Name = "GenNumericUpDown";
            this.GenNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.GenNumericUpDown.TabIndex = 3;
            // 
            // LegendaryCheckBox
            // 
            this.LegendaryCheckBox.AutoSize = true;
            this.LegendaryCheckBox.Location = new System.Drawing.Point(145, 113);
            this.LegendaryCheckBox.Name = "LegendaryCheckBox";
            this.LegendaryCheckBox.Size = new System.Drawing.Size(94, 20);
            this.LegendaryCheckBox.TabIndex = 4;
            this.LegendaryCheckBox.Text = "Legendary";
            this.LegendaryCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShinyCheckBox
            // 
            this.ShinyCheckBox.AutoSize = true;
            this.ShinyCheckBox.Location = new System.Drawing.Point(145, 139);
            this.ShinyCheckBox.Name = "ShinyCheckBox";
            this.ShinyCheckBox.Size = new System.Drawing.Size(62, 20);
            this.ShinyCheckBox.TabIndex = 5;
            this.ShinyCheckBox.Text = "Shiny";
            this.ShinyCheckBox.UseVisualStyleBackColor = true;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(313, 207);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(120, 22);
            this.NameTB.TabIndex = 6;
            // 
            // TypeTB
            // 
            this.TypeTB.Location = new System.Drawing.Point(462, 207);
            this.TypeTB.Name = "TypeTB";
            this.TypeTB.Size = new System.Drawing.Size(120, 22);
            this.TypeTB.TabIndex = 7;
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(142, 183);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(40, 16);
            this.LevelLabel.TabIndex = 8;
            this.LevelLabel.Text = "Level";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(310, 183);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 16);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Name";
            // 
            // Typelabel
            // 
            this.Typelabel.AutoSize = true;
            this.Typelabel.Location = new System.Drawing.Point(459, 183);
            this.Typelabel.Name = "Typelabel";
            this.Typelabel.Size = new System.Drawing.Size(39, 16);
            this.Typelabel.TabIndex = 10;
            this.Typelabel.Text = "Type";
            // 
            // HpNumericUpDown
            // 
            this.HpNumericUpDown.Location = new System.Drawing.Point(313, 263);
            this.HpNumericUpDown.Name = "HpNumericUpDown";
            this.HpNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.HpNumericUpDown.TabIndex = 11;
            // 
            // ExpNumericUpDown
            // 
            this.ExpNumericUpDown.Location = new System.Drawing.Point(462, 263);
            this.ExpNumericUpDown.Name = "ExpNumericUpDown";
            this.ExpNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.ExpNumericUpDown.TabIndex = 12;
            // 
            // GenLabel
            // 
            this.GenLabel.AutoSize = true;
            this.GenLabel.Location = new System.Drawing.Point(142, 244);
            this.GenLabel.Name = "GenLabel";
            this.GenLabel.Size = new System.Drawing.Size(73, 16);
            this.GenLabel.TabIndex = 13;
            this.GenLabel.Text = "Generation";
            // 
            // HPlabel
            // 
            this.HPlabel.AutoSize = true;
            this.HPlabel.Location = new System.Drawing.Point(310, 244);
            this.HPlabel.Name = "HPlabel";
            this.HPlabel.Size = new System.Drawing.Size(26, 16);
            this.HPlabel.TabIndex = 14;
            this.HPlabel.Text = "HP";
            // 
            // EXPlabel
            // 
            this.EXPlabel.AutoSize = true;
            this.EXPlabel.Location = new System.Drawing.Point(459, 244);
            this.EXPlabel.Name = "EXPlabel";
            this.EXPlabel.Size = new System.Drawing.Size(33, 16);
            this.EXPlabel.TabIndex = 15;
            this.EXPlabel.Text = "EXP";
            // 
            // AttackTypelabel
            // 
            this.AttackTypelabel.AutoSize = true;
            this.AttackTypelabel.Location = new System.Drawing.Point(142, 336);
            this.AttackTypelabel.Name = "AttackTypelabel";
            this.AttackTypelabel.Size = new System.Drawing.Size(76, 16);
            this.AttackTypelabel.TabIndex = 16;
            this.AttackTypelabel.Text = "AttackType";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(520, 68);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DebugTB
            // 
            this.DebugTB.Location = new System.Drawing.Point(520, 97);
            this.DebugTB.Multiline = true;
            this.DebugTB.Name = "DebugTB";
            this.DebugTB.ReadOnly = true;
            this.DebugTB.Size = new System.Drawing.Size(516, 102);
            this.DebugTB.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Debug";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DebugTB);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AttackTypelabel);
            this.Controls.Add(this.EXPlabel);
            this.Controls.Add(this.HPlabel);
            this.Controls.Add(this.GenLabel);
            this.Controls.Add(this.ExpNumericUpDown);
            this.Controls.Add(this.HpNumericUpDown);
            this.Controls.Add(this.Typelabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.TypeTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.ShinyCheckBox);
            this.Controls.Add(this.LegendaryCheckBox);
            this.Controls.Add(this.GenNumericUpDown);
            this.Controls.Add(this.AttackcomboBox);
            this.Controls.Add(this.LevelTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GenNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HpNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox LevelTB;
        private System.Windows.Forms.ComboBox AttackcomboBox;
        private System.Windows.Forms.NumericUpDown GenNumericUpDown;
        private System.Windows.Forms.CheckBox LegendaryCheckBox;
        private System.Windows.Forms.CheckBox ShinyCheckBox;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox TypeTB;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label Typelabel;
        private System.Windows.Forms.NumericUpDown HpNumericUpDown;
        private System.Windows.Forms.NumericUpDown ExpNumericUpDown;
        private System.Windows.Forms.Label GenLabel;
        private System.Windows.Forms.Label HPlabel;
        private System.Windows.Forms.Label EXPlabel;
        private System.Windows.Forms.Label AttackTypelabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox DebugTB;
        private System.Windows.Forms.Label label1;
    }
}

