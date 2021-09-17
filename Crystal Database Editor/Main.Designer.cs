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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Startlevel_textbox = new System.Windows.Forms.TextBox();
            this.Percent_textbox = new System.Windows.Forms.TextBox();
            this.Maxlevel_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Create_Button = new System.Windows.Forms.Button();
            this.Startexp_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(325, 264);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Startexp_textbox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.Create_Button);
            this.tabPage1.Controls.Add(this.Maxlevel_textbox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Percent_textbox);
            this.tabPage1.Controls.Add(this.Startlevel_textbox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(317, 238);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Exp Editor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(317, 238);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mon Editor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Created by Valhalla + Jev";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(317, 238);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Item Editor";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Made u look";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Start Level : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "% to Increase : ";
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
            // Percent_textbox
            // 
            this.Percent_textbox.Location = new System.Drawing.Point(95, 77);
            this.Percent_textbox.MaxLength = 2;
            this.Percent_textbox.Name = "Percent_textbox";
            this.Percent_textbox.Size = new System.Drawing.Size(100, 20);
            this.Percent_textbox.TabIndex = 3;
            this.Percent_textbox.TextChanged += new System.EventHandler(this.Percent_textbox_TextChanged);
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
            // Startexp_textbox
            // 
            this.Startexp_textbox.Location = new System.Drawing.Point(95, 51);
            this.Startexp_textbox.MaxLength = 5;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Crystal Database Editor";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Create_Button;
        private System.Windows.Forms.TextBox Maxlevel_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Percent_textbox;
        private System.Windows.Forms.TextBox Startlevel_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Startexp_textbox;
        private System.Windows.Forms.Label label7;
    }
}

