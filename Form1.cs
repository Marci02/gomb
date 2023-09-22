using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            SubForm sf = new SubForm("Jó a suli?");
            sf.ShowDialog();

            if (sf.DialogResult == DialogResult.OK) MessageBox.Show("Igen");
            else MessageBox.Show("Nem");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Button gomb = new Button();
            gomb.Text = "Exit";
            gomb.Top = 104;
            gomb.Left = 184;
            this.Controls.Add(gomb);
        }
    }
}
