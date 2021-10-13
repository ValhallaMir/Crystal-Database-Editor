using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Crystal_Database_Editor
{
    public partial class Main : Form
    {

        ushort maxLevel, startLevel;
        public long startExp, endExp;
        public Main()
        {
            InitializeComponent();

            startLevel = 1;
            startExp = 100;
            endExp = 500000;
            maxLevel = 50;

            Startlevel_textbox.Text = "1";
            Startexp_textbox.Text = "100";
            Endexp_textbox.Text = "500000";
            Maxlevel_textbox.Text = "50";
        }

        private void Startlevel_textbox_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            if (!ushort.TryParse(ActiveControl.Text, out _) || ushort.Parse(ActiveControl.Text) >= ushort.Parse(Maxlevel_textbox.Text))
            {
                ActiveControl.BackColor = Color.Red;
                return;
            }
            ActiveControl.BackColor = SystemColors.Window;
            startLevel = ushort.Parse(ActiveControl.Text);
        }

        private void Startexp_textbox_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            if (!long.TryParse(ActiveControl.Text, out _))
            {
                ActiveControl.BackColor = Color.Red;
                return;
            }
            ActiveControl.BackColor = SystemColors.Window;

            startExp = long.Parse(ActiveControl.Text);
        }

        private void Endexp_textbox_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            if (!long.TryParse(ActiveControl.Text, out _))
            {
                ActiveControl.BackColor = Color.Red;
                return;
            }
            ActiveControl.BackColor = SystemColors.Window;

            endExp = long.Parse(ActiveControl.Text);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Patcher_Click(object sender, EventArgs e)
        {
            //Val I need you to sort this out. Ive added all the code for the patcher.
        }

        private void Maxlevel_textbox_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            if (!ushort.TryParse(ActiveControl.Text, out _) || ushort.Parse(ActiveControl.Text) <= ushort.Parse(Startlevel_textbox.Text))
            {
                ActiveControl.BackColor = Color.Red;
                return;
            }
            ActiveControl.BackColor = SystemColors.Window;
            maxLevel = ushort.Parse(ActiveControl.Text);
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            int levels = maxLevel - startLevel;

            double B = Math.Log((double)endExp / startExp) / (levels - 1);
            double A = (double)startExp / (Math.Exp(B) - 1);

            var list = new List<string>();

            for (int i = startLevel; i <= maxLevel; i++)
            {
                long old_xp = (long)Math.Round(A * Math.Exp(B * (i - 1)));
                long new_xp = (long)Math.Round(A * Math.Exp(B * i));
                list.Add("Level" + i + "=" + (new_xp - old_xp));
                File.WriteAllLines("ExpList.txt", list);
            }
            MessageBox.Show(list.Count + " Levels have been generated.");
        }
    }
}
