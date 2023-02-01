using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DepreciacionEnLinea
{
    public partial class frmPrestamo : Form
    {
        public frmPrestamo()
        {
            InitializeComponent();
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            txtCuotaP.Enabled = false;
            txtEstado.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ingP, egrP, montoP, utiP, cuotaP, plazoP, utpP;
            string r, a;

            if (txtNombre.Text == "" || mtxtIngresoP.Text == ""
                || mtxtEgresoP.Text == "" || mtxtMontoRequerido.Text == ""
                || cboTipoIngreso.Text == "" || cboPlazo.Text == "")
            {
                MessageBox.Show("No se espacios en blanco");
                txtNombre.Focus();
            }
            else
            {

                ingP = double.Parse(mtxtIngresoP.Text);
                egrP = double.Parse(mtxtEgresoP.Text);
                montoP = double.Parse(mtxtMontoRequerido.Text);
                plazoP = double.Parse(cboPlazo.Text);

                if (ingP >= 500 && ingP <= 10000)
                {
                    if (egrP <= ingP)
                    {
                        utiP = ingP - egrP;
                       

                        utpP = utiP * 0.35;

                        cuotaP = montoP / plazoP;
                        txtCuotaP.Text = cuotaP.ToString();
                        if (cuotaP < utpP)
                        {
                            r = " Es Sujeto a Crédito";
                            txtEstado.Text = r.ToString();
                        }
                        else
                        {
                            a = " No es Sujeto a Crédito";
                            txtEstado.Text = a.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Egreso no puede ser mayor a Ingreso", "Error");
                        mtxtEgresoP.Clear(); ;
                        mtxtEgresoP.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(" EL rango de Ingreso debe de ser entre 500 y 10000",
                        "Ingrese un nuevo valor");
                    mtxtIngresoP.Clear();
                    mtxtIngresoP.Focus();
                }
                if (montoP < 100 || montoP > 5000)
                {
                    MessageBox.Show("rango entre 100 y 5000", "Error");
                    mtxtMontoRequerido.Clear();
                    mtxtMontoRequerido.Focus();
                }
            }
        }
    }
}
