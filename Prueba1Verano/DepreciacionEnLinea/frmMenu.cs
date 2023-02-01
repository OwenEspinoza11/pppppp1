namespace DepreciacionEnLinea
{
    public partial class frmMenu : Form
    {
        frmDepreciacion x = new frmDepreciacion();
        frmFormaPago y = new frmFormaPago();
        frmPrestamo z = new frmPrestamo();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void calcularDepreciacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MdiParent = this;
            x.Show();
        }

        private void calcularPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            y.MdiParent = this;
            y.Show();
        }

        private void solicitudPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            z.MdiParent = this;
            z.Show();
        }
    }
}