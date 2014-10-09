using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            String texto=" ";
            if (chkingles.Checked==true)
            {
                texto = texto + " Inglés";
            }
            if (chkfrances.Checked == true)
            {
                texto = texto + " Francés";
            }
            if (chkaleman.Checked == true)
            {
                texto = texto + " Alemán";
            }
            Text = texto;
        }
    }
}
