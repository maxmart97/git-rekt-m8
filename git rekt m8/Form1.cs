using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace git_rekt_m8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int index = 0;

            int x, y;
            int r1, g1, b1;
            int r2, g2, b2;

            while (index < 1)
            {
                x = rand.Next(1000);
                y = rand.Next(1000);
                r1 = rand.Next(256);
                g1 = rand.Next(256);
                b1 = rand.Next(256);
                r2 = rand.Next(256);
                g2 = rand.Next(256);
                b2 = rand.Next(256);

                SecondForm newForm = new SecondForm();
                newForm.Location = new Point(x, y);
                newForm.trollLabel.ForeColor = Color.FromArgb(r1, g1, b1);
                newForm.BackColor = Color.FromArgb(r2, g2, b2);
                newForm.Show();
                newForm.Refresh();

                //Thread.Sleep(100);
            }
        }
    }
}
