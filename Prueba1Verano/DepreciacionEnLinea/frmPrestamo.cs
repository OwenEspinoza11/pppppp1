using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            txtCuota.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre;
            double ingreso, egreso, montoReq, plazo, cuota, utilidad;


            if (mtxtIngreso.Text == "")
            {
                MessageBox.Show("No puede estar en blanco", "Warning");
            }
            else if (cboTipoIngreso.Text == "")
            {
                MessageBox.Show("No puede estar en blanco", "Warning");
            }
            else if (mtxtEgreso.Text == "")
            {
                MessageBox.Show("No puede estar en blanco", "Warning");
            }
            else if (mtxtMontoRequerido.Text == "")
            {
                MessageBox.Show("No puede estar en blanco", "Warning");
            }
            else if (cboPlazo.Text == "")
            {
                MessageBox.Show("No puede estar en blanco", "Warning");
            }
            else
            {
                ingreso = double.Parse(mtxtIngreso.Text);
                egreso = double.Parse(mtxtEgreso.Text);
                nombre = Convert.ToString(txtNombre.Text);


                if (ingreso >= 2000 && ingreso <= 20000)
                {
                    if (cboTipoIngreso.Text.Equals("Vehiculo"))
                    {
                        depVeh = valor - valorDesecho / vida;
                        txtDepreciacion.Text = depVeh.ToString();
                    }

                }





            }
        }
    }
}
