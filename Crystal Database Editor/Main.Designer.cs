namespace Crystal_Database_Editor
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ExpEditor = new System.Windows.Forms.TabPage();
            this.Startexp_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Create_Button = new System.Windows.Forms.Button();
            this.Maxlevel_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Endexp_textbox = new System.Windows.Forms.TextBox();
            this.Startlevel_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MonEditor = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemEditor = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.Custom = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Patcher = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.ExpEditor.SuspendLayout();
            this.MonEditor.SuspendLayout();
            this.ItemEditor.SuspendLayout();
            this.Custom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ExpEditor);
            this.tabControl1.Controls.Add(this.MonEditor);
            this.tabControl1.Controls.Add(this.ItemEditor);
            this.tabControl1.Controls.Add(this.Custom);
            this.tabControl1.Controls.Add(this.Patcher);
            this.tabControl1.Controls.Add(this.Settings);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(430, 264);
            this.tabControl1.TabIndex = 0;
            // 
            // ExpEditor
            // 
            this.ExpEditor.BackColor = System.Drawing.Color.Transparent;
            this.ExpEditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExpEditor.Controls.Add(this.Startexp_textbox);
            this.ExpEditor.Controls.Add(this.label7);
            this.ExpEditor.Controls.Add(this.Create_Button);
            this.ExpEditor.Controls.Add(this.Maxlevel_textbox);
            this.ExpEditor.Controls.Add(this.label6);
            this.ExpEditor.Controls.Add(this.Endexp_textbox);
            this.ExpEditor.Controls.Add(this.Startlevel_textbox);
            this.ExpEditor.Controls.Add(this.label5);
            this.ExpEditor.Controls.Add(this.label4);
            this.ExpEditor.Location = new System.Drawing.Point(4, 22);
            this.ExpEditor.Name = "ExpEditor";
            this.ExpEditor.Padding = new System.Windows.Forms.Padding(3);
            this.ExpEditor.Size = new System.Drawing.Size(422, 238);
            this.ExpEditor.TabIndex = 0;
            this.ExpEditor.Text = "Exp Editor";
            // 
            // Startexp_textbox
            // 
            this.Startexp_textbox.Location = new System.Drawing.Point(95, 51);
            this.Startexp_textbox.MaxLength = 10;
            this.Startexp_textbox.Name = "Startexp_textbox";
            this.Startexp_textbox.Size = new System.Drawing.Size(100, 20);
            this.Startexp_textbox.TabIndex = 8;
            this.Startexp_textbox.TextChanged += new System.EventHandler(this.Startexp_textbox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Start Exp : ";
            // 
            // Create_Button
            // 
            this.Create_Button.Location = new System.Drawing.Point(120, 129);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(75, 23);
            this.Create_Button.TabIndex = 6;
            this.Create_Button.Text = "Create";
            this.Create_Button.UseVisualStyleBackColor = true;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // Maxlevel_textbox
            // 
            this.Maxlevel_textbox.Location = new System.Drawing.Point(95, 103);
            this.Maxlevel_textbox.MaxLength = 5;
            this.Maxlevel_textbox.Name = "Maxlevel_textbox";
            this.Maxlevel_textbox.Size = new System.Drawing.Size(100, 20);
            this.Maxlevel_textbox.TabIndex = 5;
            this.Maxlevel_textbox.TextChanged += new System.EventHandler(this.Maxlevel_textbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Max Level : ";
            // 
            // Endexp_textbox
            // 
            this.Endexp_textbox.Location = new System.Drawing.Point(95, 77);
            this.Endexp_textbox.MaxLength = 10;
            this.Endexp_textbox.Name = "Endexp_textbox";
            this.Endexp_textbox.Size = new System.Drawing.Size(100, 20);
            this.Endexp_textbox.TabIndex = 3;
            this.Endexp_textbox.TextChanged += new System.EventHandler(this.Endexp_textbox_TextChanged);
            // 
            // Startlevel_textbox
            // 
            this.Startlevel_textbox.Location = new System.Drawing.Point(95, 25);
            this.Startlevel_textbox.MaxLength = 5;
            this.Startlevel_textbox.Name = "Startlevel_textbox";
            this.Startlevel_textbox.Size = new System.Drawing.Size(100, 20);
            this.Startlevel_textbox.TabIndex = 2;
            this.Startlevel_textbox.TextChanged += new System.EventHandler(this.Startlevel_textbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "End Exp : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Start Level : ";
            // 
            // MonEditor
            // 
            this.MonEditor.Controls.Add(this.label2);
            this.MonEditor.Location = new System.Drawing.Point(4, 22);
            this.MonEditor.Name = "MonEditor";
            this.MonEditor.Padding = new System.Windows.Forms.Padding(3);
            this.MonEditor.Size = new System.Drawing.Size(422, 238);
            this.MonEditor.TabIndex = 1;
            this.MonEditor.Text = "Mon Editor";
            this.MonEditor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Made u look";
            // 
            // ItemEditor
            // 
            this.ItemEditor.Controls.Add(this.label3);
            this.ItemEditor.Location = new System.Drawing.Point(4, 22);
            this.ItemEditor.Name = "ItemEditor";
            this.ItemEditor.Size = new System.Drawing.Size(422, 238);
            this.ItemEditor.TabIndex = 2;
            this.ItemEditor.Text = "Item Editor";
            this.ItemEditor.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Made u look";
            // 
            // Custom
            // 
            this.Custom.Controls.Add(this.button1);
            this.Custom.Controls.Add(this.label16);
            this.Custom.Controls.Add(this.label15);
            this.Custom.Controls.Add(this.label14);
            this.Custom.Controls.Add(this.label13);
            this.Custom.Controls.Add(this.label12);
            this.Custom.Controls.Add(this.label11);
            this.Custom.Controls.Add(this.label10);
            this.Custom.Controls.Add(this.label9);
            this.Custom.Controls.Add(this.label8);
            this.Custom.Location = new System.Drawing.Point(4, 22);
            this.Custom.Name = "Custom";
            this.Custom.Padding = new System.Windows.Forms.Padding(3);
            this.Custom.Size = new System.Drawing.Size(422, 238);
            this.Custom.TabIndex = 3;
            this.Custom.Text = "Custom";
            this.Custom.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(141, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "New";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(141, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Old";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label14.Location = new System.Drawing.Point(140, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "Quest System";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Archer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Assassin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Taoist";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Wizard";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Warrior";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(6, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Classes";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Patcher
            // 
            this.Patcher.Location = new System.Drawing.Point(4, 22);
            this.Patcher.Name = "Patcher";
            this.Patcher.Padding = new System.Windows.Forms.Padding(3);
            this.Patcher.Size = new System.Drawing.Size(422, 238);
            this.Patcher.TabIndex = 4;
            this.Patcher.Text = "Patcher";
            this.Patcher.UseVisualStyleBackColor = true;
            this.Patcher.Click += new System.EventHandler(this.Patcher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Created by Valhalla && Jev";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(422, 238);
            this.Settings.TabIndex = 5;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(455, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Crystal Database Editor";
            this.tabControl1.ResumeLayout(false);
            this.ExpEditor.ResumeLayout(false);
            this.ExpEditor.PerformLayout();
            this.MonEditor.ResumeLayout(false);
            this.MonEditor.PerformLayout();
            this.ItemEditor.ResumeLayout(false);
            this.ItemEditor.PerformLayout();
            this.Custom.ResumeLayout(false);
            this.Custom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ExpEditor;
        private System.Windows.Forms.Button Create_Button;
        private System.Windows.Forms.TextBox Maxlevel_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Endexp_textbox;
        private System.Windows.Forms.TextBox Startlevel_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage MonEditor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage ItemEditor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Startexp_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage Custom;
        private System.Windows.Forms.TabPage Patcher;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage Settings;
    }
}

