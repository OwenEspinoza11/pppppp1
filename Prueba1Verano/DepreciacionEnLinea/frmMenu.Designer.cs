namespace DepreciacionEnLinea
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularDepreciacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularDepreciacionToolStripMenuItem,
            this.calcularPagoToolStripMenuItem,
            this.solicitudPrestamoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 20);
            this.toolStripMenuItem1.Text = "Pestañas de cálculo";
            // 
            // calcularDepreciacionToolStripMenuItem
            // 
            this.calcularDepreciacionToolStripMenuItem.Name = "calcularDepreciacionToolStripMenuItem";
            this.calcularDepreciacionToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.calcularDepreciacionToolStripMenuItem.Text = "Calcular depreciacion";
            this.calcularDepreciacionToolStripMenuItem.Click += new System.EventHandler(this.calcularDepreciacionToolStripMenuItem_Click);
            // 
            // calcularPagoToolStripMenuItem
            // 
            this.calcularPagoToolStripMenuItem.Name = "calcularPagoToolStripMenuItem";
            this.calcularPagoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.calcularPagoToolStripMenuItem.Text = "Calcular pago";
            this.calcularPagoToolStripMenuItem.Click += new System.EventHandler(this.calcularPagoToolStripMenuItem_Click);
            // 
            // solicitudPrestamoToolStripMenuItem
            // 
            this.solicitudPrestamoToolStripMenuItem.Name = "solicitudPrestamoToolStripMenuItem";
            this.solicitudPrestamoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.solicitudPrestamoToolStripMenuItem.Text = "Solicitud prestamo";
            this.solicitudPrestamoToolStripMenuItem.Click += new System.EventHandler(this.solicitudPrestamoToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(812, 490);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu de inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem calcularDepreciacionToolStripMenuItem;
        private ToolStripMenuItem calcularPagoToolStripMenuItem;
        private ToolStripMenuItem solicitudPrestamoToolStripMenuItem;
    }
}