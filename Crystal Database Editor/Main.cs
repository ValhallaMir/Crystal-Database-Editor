using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crystal_Database_Editor
{
    public partial class Main : Form
    {

        public ushort maxLevel, startLevel;
        public long startExp;
        public byte percent;
        public Main()
        {
            InitializeComponent();

            Startlevel_textbox.Text = "1";
            Startexp_textbox.Text = "100";
            Percent_textbox.Text = "5";
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

        private void Percent_textbox_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            if (!byte.TryParse(ActiveControl.Text, out _))
            {
                ActiveControl.BackColor = Color.Red;
                return;
            }
            ActiveControl.BackColor = SystemColors.Window;

            percent = byte.Parse(ActiveControl.Text);
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
            //ushort levels = maxLevel - startLevel;

            //for (ushort i = startLevel; i <= levels; i++)
            //{
            //
            //}
        }
    }
}
