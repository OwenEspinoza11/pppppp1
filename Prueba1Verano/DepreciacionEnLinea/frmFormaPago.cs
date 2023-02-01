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
    public partial class frmFormaPago : Form
    {
        double total;
        public frmFormaPago()
        {
            InitializeComponent();
        }

        private void frmFormaPago_Load(object sender, EventArgs e)
        {
            txtIva.Enabled = false;
            txtTotal.Enabled = false;
            txtVuelto.Enabled = false;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double subtotal, iva;


            if (mtxtSubtotal.Text == "")
            {
                MessageBox.Show("No puede estar en blanco", "Warning");
            }
            else
            {
                subtotal = double.Parse(mtxtSubtotal.Text);

                if (subtotal >= 1 || subtotal <= 1000)
                {
                    iva = subtotal * 0.15;
                    total = subtotal + iva;
                    txtTotal.Text = total.ToString();
                }
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            double montoPago, vuelto, descuento;

            if (mtxtMonto.Text == "")
            {
                MessageBox.Show("No puede estar en blanco", "Warning");
            }
            else
            {
                montoPago = double.Parse(mtxtMonto.Text);

                
                    if (rbtnEfectivo.Checked == true && rbtnTarjeta.Checked == false)
                    {
                        if (montoPago >= 1 || montoPago <= 25)
                        {
                            descuento = total * 0.02;
                            vuelto = montoPago - (total - descuento);
                            txtVuelto.Text = vuelto.ToString();
                        }
                        else if (montoPago >= 26 || montoPago <= 60)
                        {
                            descuento = total * 0.04;
                            vuelto = montoPago - (total - descuento);
                            txtVuelto.Text = vuelto.ToString();
                        }
                        else if (montoPago > 60)
                        {
                            descuento = total * 0.07;
                            vuelto = montoPago - (total - descuento);
                            txtVuelto.Text = vuelto.ToString();
                        }
                    else if (montoPago < total)
                    {
                        MessageBox.Show("El monto de pago no puede ser menor al total", "Warning");
                    }
                }
                    else if (rbtnEfectivo.Checked == false && rbtnTarjeta.Checked == true)
                    {
                    if (montoPago >= 1 || montoPago <= 1000)
                    {
                        descuento = total * 0.05;
                        vuelto = montoPago - (total - descuento);
                        txtVuelto.Text = vuelto.ToString();
                    }
                    else if (montoPago < total)
                    {
                        MessageBox.Show("El monto de pago no puede ser menor al total", "Warning");
                    }

                }
                    else if (rbtnEfectivo.Checked == false && rbtnTarjeta.Checked == false)
                    {
                        MessageBox.Show("Seleccione una opcion");
                    }
                    else if (rbtnEfectivo.Checked == true && rbtnTarjeta.Checked == true)
                    {
                        MessageBox.Show("Solo se puede seleccionar una opcion");
                    }


            }




        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mtxtMonto.Clear();
            mtxtSubtotal.Clear();
            txtIva.Clear();
            txtTotal.Clear();
            txtVuelto.Clear();
            mtxtSubtotal.Focus();
        }
    }
}
