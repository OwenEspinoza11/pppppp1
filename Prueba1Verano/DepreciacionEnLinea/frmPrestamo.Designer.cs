namespace DepreciacionEnLinea
{
    partial class frmPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipoIngreso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtIngresoP = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtEgresoP = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtMontoRequerido = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboPlazo = new System.Windows.Forms.ComboBox();
            this.txtCuotaP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo ingreso";
            // 
            // cboTipoIngreso
            // 
            this.cboTipoIngreso.FormattingEnabled = true;
            this.cboTipoIngreso.Items.AddRange(new object[] {
            "Asalariado",
            "Jubilado",
            "Ingreso propio"});
            this.cboTipoIngreso.Location = new System.Drawing.Point(134, 117);
            this.cboTipoIngreso.Name = "cboTipoIngreso";
            this.cboTipoIngreso.Size = new System.Drawing.Size(121, 23);
            this.cboTipoIngreso.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingresos";
            // 
            // mtxtIngresoP
            // 
            this.mtxtIngresoP.Location = new System.Drawing.Point(134, 171);
            this.mtxtIngresoP.Mask = "00000000000000";
            this.mtxtIngresoP.Name = "mtxtIngresoP";
            this.mtxtIngresoP.Size = new System.Drawing.Size(100, 23);
            this.mtxtIngresoP.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Egresos";
            // 
            // mtxtEgresoP
            // 
            this.mtxtEgresoP.Location = new System.Drawing.Point(134, 227);
            this.mtxtEgresoP.Mask = "0000000000000";
            this.mtxtEgresoP.Name = "mtxtEgresoP";
            this.mtxtEgresoP.Size = new System.Drawing.Size(100, 23);
            this.mtxtEgresoP.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Monto requerido";
            // 
            // mtxtMontoRequerido
            // 
            this.mtxtMontoRequerido.Location = new System.Drawing.Point(134, 284);
            this.mtxtMontoRequerido.Mask = "0000000000000000";
            this.mtxtMontoRequerido.Name = "mtxtMontoRequerido";
            this.mtxtMontoRequerido.Size = new System.Drawing.Size(100, 23);
            this.mtxtMontoRequerido.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Plazo (meses)";
            // 
            // cboPlazo
            // 
            this.cboPlazo.FormattingEnabled = true;
            this.cboPlazo.Items.AddRange(new object[] {
            "6",
            "9",
            "12",
            "18",
            "24",
            "36"});
            this.cboPlazo.Location = new System.Drawing.Point(134, 342);
            this.cboPlazo.Name = "cboPlazo";
            this.cboPlazo.Size = new System.Drawing.Size(121, 23);
            this.cboPlazo.TabIndex = 11;
            // 
            // txtCuotaP
            // 
            this.txtCuotaP.Location = new System.Drawing.Point(134, 398);
            this.txtCuotaP.Name = "txtCuotaP";
            this.txtCuotaP.Size = new System.Drawing.Size(100, 23);
            this.txtCuotaP.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cuota";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(51, 466);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(209, 468);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(82, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "SOLICITUD DE PRESTAMO";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 17;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(251, 398);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(134, 23);
            this.txtEstado.TabIndex = 18;
            // 
            // frmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 513);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCuotaP);
            this.Controls.Add(this.cboPlazo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtxtMontoRequerido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtxtEgresoP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtIngresoP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTipoIngreso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPrestamo";
            this.Text = "Solicitd de prestamo";
            this.Load += new System.EventHandler(this.frmPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboTipoIngreso;
        private Label label3;
        private MaskedTextBox mtxtIngresoP;
        private Label label4;
        private MaskedTextBox mtxtEgresoP;
        private Label label5;
        private MaskedTextBox mtxtMontoRequerido;
        private Label label6;
        private ComboBox cboPlazo;
        private TextBox txtCuotaP;
        private Label label7;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Label label8;
        private TextBox txtNombre;
        private TextBox txtEstado;
    }
}