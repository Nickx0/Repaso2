using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso2
{
    public partial class frmRepaso2 : Form
    {
        public frmRepaso2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtnombre.Text=="")
            {
                errorprove.SetError(txtnombre, "Debe Ingresar un nombre");
                txtnombre.Focus();
                return;
            }
            errorprove.SetError(txtnombre, "");
            if (cboCarrera.SelectedIndex==-1)
            {
                errorprove.SetError(cboCarrera, "Debe Ingresar una carrera");
                cboCarrera.Focus();
                return;
            }
            errorprove.SetError(txtnombre, "");
            if (cboCarrera.SelectedIndex == 0)
            {
                listDesarrollo.Items.Add(txtnombre.Text);
                txtDesarrollo.Text = listDesarrollo.Items.Count.ToString("n0");
                btnMayor.Enabled = true;
            }
            else
            {
                listSoporte.Items.Add(txtnombre.Text);
                txtSoporte.Text = listSoporte.Items.Count.ToString("n0");
                btnMenor.Enabled = true;
            }
            txtnombre.Clear();
            cboCarrera.SelectedIndex = -1;
            txtnombre.Focus();

        }
    }
}
