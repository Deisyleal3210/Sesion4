using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNavegadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkchrome_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto="Resultado: ";
            if(chkchrome.Checked)
            {
                texto = texto + " google chrome";
            }
            if (chkexplore.Checked)
            {
                texto = texto + " Internet Explorer";
            }
            if (chkmozilla.Checked)
            {
                texto = texto + " Mozilla Firefox";
            }

            lblnavegador.Text = texto;
        }
    }
}
