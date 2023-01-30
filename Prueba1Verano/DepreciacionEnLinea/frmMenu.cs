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
    }
}