namespace DepreciacionEnLinea
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void calcularDepreciacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepreciacion depreciacion = new frmDepreciacion();
            depreciacion.Show();
            this.Hide();
        }

        private void calcularPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormaPago formaPago = new frmFormaPago();
            formaPago.Show();
            this.Hide();
        }

        private void solicitudPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrestamo prestamo = new frmPrestamo();
            prestamo.Show();
            this.Hide();
        }
    }
}