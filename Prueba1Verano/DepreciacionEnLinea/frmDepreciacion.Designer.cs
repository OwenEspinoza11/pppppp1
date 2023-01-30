namespace DepreciacionEnLinea
{
    partial class frmDepreciacion
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
            this.cboTipoBien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtValor = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepreciacion = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.mtxtValorDesecho = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtVidaUtil = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo bien";
            // 
            // cboTipoBien
            // 
            this.cboTipoBien.FormattingEnabled = true;
            this.cboTipoBien.Items.AddRange(new object[] {
            "Vehiculo",
            "Edificios",
            "Equipo de oficina"});
            this.cboTipoBien.Location = new System.Drawing.Point(149, 34);
            this.cboTipoBien.Name = "cboTipoBien";
            this.cboTipoBien.Size = new System.Drawing.Size(121, 23);
            this.cboTipoBien.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // mtxtValor
            // 
            this.mtxtValor.Location = new System.Drawing.Point(149, 96);
            this.mtxtValor.Mask = "00000000000";
            this.mtxtValor.Name = "mtxtValor";
            this.mtxtValor.Size = new System.Drawing.Size(100, 23);
            this.mtxtValor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Depreciación";
            // 
            // txtDepreciacion
            // 
            this.txtDepreciacion.Location = new System.Drawing.Point(149, 267);
            this.txtDepreciacion.Name = "txtDepreciacion";
            this.txtDepreciacion.Size = new System.Drawing.Size(100, 23);
            this.txtDepreciacion.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(53, 336);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(166, 336);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(1, 0);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(33, 32);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "<-";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // mtxtValorDesecho
            // 
            this.mtxtValorDesecho.Location = new System.Drawing.Point(149, 158);
            this.mtxtValorDesecho.Mask = "00000000000";
            this.mtxtValorDesecho.Name = "mtxtValorDesecho";
            this.mtxtValorDesecho.Size = new System.Drawing.Size(100, 23);
            this.mtxtValorDesecho.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor desecho";
            // 
            // mtxtVidaUtil
            // 
            this.mtxtVidaUtil.Location = new System.Drawing.Point(149, 212);
            this.mtxtVidaUtil.Mask = "00";
            this.mtxtVidaUtil.Name = "mtxtVidaUtil";
            this.mtxtVidaUtil.Size = new System.Drawing.Size(100, 23);
            this.mtxtVidaUtil.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Años vida util";
            // 
            // frmDepreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 391);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtxtVidaUtil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtValorDesecho);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDepreciacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtxtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTipoBien);
            this.Controls.Add(this.label1);
            this.Name = "frmDepreciacion";
            this.Text = "frmDepreciacion";
            this.Load += new System.EventHandler(this.frmDepreciacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cboTipoBien;
        private Label label2;
        private MaskedTextBox mtxtValor;
        private Label label3;
        private TextBox txtDepreciacion;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnRegresar;
        private MaskedTextBox mtxtValorDesecho;
        private Label label4;
        private MaskedTextBox mtxtVidaUtil;
        private Label label5;
    }
}