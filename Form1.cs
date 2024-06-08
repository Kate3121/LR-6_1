using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_6_1
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbX1.Text) || (String.IsNullOrEmpty(tbX2.Text)))
            {
                tbY.Text = "Не введено даних!";
                tbArithetic_mean.Text = "Не введено даних!"; return;
            }
            double x1 = double.Parse(tbX1.Text); double x2 = double.Parse(tbX2.Text);
            double y = x1 * x2;
            tbY.Text = y.ToString(" 0.0000");
            double z = (x1 * x2) / 2;
            tbArithetic_mean.Text = z.ToString("0.0000");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbX1.Text = string.Empty; tbX2.Text = string.Empty;
            tbY.Text = string.Empty;
            tbArithetic_mean.Text= string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
