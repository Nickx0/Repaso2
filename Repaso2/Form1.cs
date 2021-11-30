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

        private void btnMayor_Click(object sender, EventArgs e)
        {
            if(listDesarrollo.Items.Count==0)
            {
                btnMayor.Enabled = false;
                return;
            }
            if(listDesarrollo.SelectedIndex==-1)
            {
                MessageBox.Show("Seleccione un Estudiante");
                listDesarrollo.Focus();
            }
            else
            {
                listSoporte.Items.Add(listDesarrollo.Text);
                listDesarrollo.Items.RemoveAt(listDesarrollo.SelectedIndex);
                txtSoporte.Text = listSoporte.Items.Count.ToString("n0");
                txtDesarrollo.Text = listDesarrollo.Items.Count.ToString("n0");
                btnMenor.Enabled = true;

            }
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            if (listSoporte.Items.Count == 0)
            {
                btnMenor.Enabled = false;
                return;
            }
            if (listSoporte.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Estudiante");
                listSoporte.Focus();
            }
            else
            {
                listDesarrollo.Items.Add(listSoporte.Text);
                listSoporte.Items.RemoveAt(listSoporte.SelectedIndex);
                txtDesarrollo.Text = listDesarrollo.Items.Count.ToString("n0");
                txtSoporte.Text = listSoporte.Items.Count.ToString("n0");
                btnMayor.Enabled = true;

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listDesarrollo.Items.Clear();
            listSoporte.Items.Clear();
            cboCarrera.SelectedIndex = -1;
            txtnombre.Clear();
            txtnombre.Focus();
            txtDesarrollo.Text = "0";
            txtSoporte.Text = "0";
        }
    }
}
