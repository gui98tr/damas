using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3.Forms
{
    public partial class FinalForm : Form
    {
        public FinalForm(string gg)
        {
            InitializeComponent();
            lblVitoria.Text = gg;
        }


        private void lblVitoria_Click(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
