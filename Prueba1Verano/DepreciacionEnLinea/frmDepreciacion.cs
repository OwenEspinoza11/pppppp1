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
    public partial class frmDepreciacion : Form
    {
        public frmDepreciacion()
        {
            InitializeComponent();
        }

        private void frmDepreciacion_Load(object sender, EventArgs e)
        {
            txtDepreciacion.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor, depVeh, depEdif, depEqOf, vida, valorDesecho;

            if (mtxtValor.Text == "")
            {
                MessageBox.Show("No puede estar en blanco", "Warning");
            }
            else if (cboTipoBien.Text == "")
            {
                MessageBox.Show("No puede estar en blanco", "Warning");
            }
            else if (mtxtVidaUtil.Text == "")
            {
                MessageBox.Show("No puede estar en blanco", "Warning");
            }
            else if (mtxtValorDesecho.Text == "")
            {
                MessageBox.Show("No puede estar en blanco", "Warning");
            }
            else
            {
                do
                {
                    valor = double.Parse(mtxtValor.Text);
                    valorDesecho = double.Parse(mtxtValorDesecho.Text);
                    vida = double.Parse(mtxtVidaUtil.Text);

                    if (valor >= 2000 && valor <= 20000)
                    {
                        if (cboTipoBien.Text.Equals("Vehiculo"))
                        {
                            depVeh = valor - valorDesecho / vida;
                            txtDepreciacion.Text = depVeh.ToString();
                        }

                    }

                    if (valor >= 20000 && valor <= 100000)
                    {
                        if (cboTipoBien.Text.Equals("Edificios"))
                        {
                            depEdif = valor - valorDesecho / vida;
                            txtDepreciacion.Text = depEdif.ToString();
                        }

                    }


                    if (valor >= 5000 && valor <= 30000)
                    {
                        if (cboTipoBien.Text.Equals("Equipo de oficina"))
                        {
                            depEqOf = valor - valorDesecho / vida;
                            txtDepreciacion.Text = depEqOf.ToString();
                        }

                    }
                } while (valorDesecho < valor);

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mtxtValor.Clear();
            mtxtValorDesecho.Clear();
            mtxtVidaUtil.Clear();
            txtDepreciacion.Clear();
            cboTipoBien.Focus();
        }
    }
}
