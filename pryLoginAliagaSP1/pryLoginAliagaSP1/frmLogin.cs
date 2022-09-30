using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLoginAliagaSP1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtContra.Text = "";
            txtContra.Enabled = false;
            txtUsuario.Text = "";
            btnAceptar.Enabled = false;
            cmbModulo.Items.Clear();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if(txtUsuario.Text != "" )
            {
                txtContra.Enabled = true;
            }
            else
            {
                txtContra.Enabled = false;
            }
            if (txtUsuario.Text == "Adm")
            {
                cmbModulo.Items.Add("ADM");
                cmbModulo.Items.Add("COM");
                cmbModulo.Items.Add("VTA");
            }
            else if (txtUsuario.Text == "Jonh")
            {
                cmbModulo.Items.Add("SIST");
            }
            else if (txtUsuario.Text == "Ceci")
            {
                cmbModulo.Items.Add("ADM");
                cmbModulo.Items.Add("VTA");
            }

            else if (txtUsuario.Text == "God")
            {  
                cmbModulo.Items.Add("ADM");
                cmbModulo.Items.Add("COM");
                cmbModulo.Items.Add("VTA");
                cmbModulo.Items.Add("SIST");
            }
            else 
            {
                cmbModulo.Items.Clear();
                


            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int intentos = 0;
            if ((txtUsuario.Text == "Adm" && txtContra.Text == "adm123") ||
                (txtUsuario.Text == "John" && txtContra.Text == "jonh123") ||
                (txtUsuario.Text == "Ceci" && txtContra.Text == "ceci123") ||
                (txtUsuario.Text == "God" && txtContra.Text == "god123"))
            {
                this.Hide(); // oculta este formualrio
                MessageBox.Show("BIENVENIDO " + txtUsuario.Text + " AL SISTEMA");
                frmPrincipal Acceso = new frmPrincipal(); // crea el frmInicio
                Acceso.Text = txtUsuario.Text; // asigna el texto de título
                Acceso.ShowDialog(); // visualiza y ejecuta el frmInicio
                this.Show(); // visualiza nuevamente este formulario
                Close();
            }
            else
            {
                MessageBox.Show("Datos incorrectamente ingresados, acceso totalmente DENEGADO");
                intentos++; // incrementa el contador de intentos fallidos
                if (intentos == 3) // si es 3 se cierra el formulario
                {
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        
        }

        private void cmbModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbModulo.SelectedIndex != -1 && txtContra.Text != "")
            {
                btnAceptar.Enabled = true;

            }
            else
            { 
                btnAceptar.Enabled = false;
            }
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            if (cmbModulo.SelectedIndex != -1 && txtContra.Text != "")
            {
                btnAceptar.Enabled = true;

            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }
    }
}
