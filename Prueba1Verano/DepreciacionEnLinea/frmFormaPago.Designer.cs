namespace DepreciacionEnLinea
{
    partial class frmFormaPago
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
            this.mtxtSubtotal = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVuelto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnEfectivo = new System.Windows.Forms.RadioButton();
            this.rbtnTarjeta = new System.Windows.Forms.RadioButton();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.mtxtMonto = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal";
            // 
            // mtxtSubtotal
            // 
            this.mtxtSubtotal.Location = new System.Drawing.Point(177, 43);
            this.mtxtSubtotal.Mask = "00000000000";
            this.mtxtSubtotal.Name = "mtxtSubtotal";
            this.mtxtSubtotal.Size = new System.Drawing.Size(100, 23);
            this.mtxtSubtotal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "IVA";
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(177, 105);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(100, 23);
            this.txtIva.TabIndex = 3;
            this.txtIva.Text = "15%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(177, 172);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monto a pagar";
            // 
            // txtVuelto
            // 
            this.txtVuelto.Location = new System.Drawing.Point(177, 355);
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.Size = new System.Drawing.Size(100, 23);
            this.txtVuelto.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vuelto";
            // 
            // rbtnEfectivo
            // 
            this.rbtnEfectivo.AutoSize = true;
            this.rbtnEfectivo.Location = new System.Drawing.Point(65, 235);
            this.rbtnEfectivo.Name = "rbtnEfectivo";
            this.rbtnEfectivo.Size = new System.Drawing.Size(67, 19);
            this.rbtnEfectivo.TabIndex = 10;
            this.rbtnEfectivo.TabStop = true;
            this.rbtnEfectivo.Text = "Efectivo";
            this.rbtnEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtnTarjeta
            // 
            this.rbtnTarjeta.AutoSize = true;
            this.rbtnTarjeta.Location = new System.Drawing.Point(218, 236);
            this.rbtnTarjeta.Name = "rbtnTarjeta";
            this.rbtnTarjeta.Size = new System.Drawing.Size(59, 19);
            this.rbtnTarjeta.TabIndex = 11;
            this.rbtnTarjeta.TabStop = true;
            this.rbtnTarjeta.Text = "Tarjeta";
            this.rbtnTarjeta.UseVisualStyleBackColor = true;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(319, 104);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 12;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(319, 286);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 13;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(319, 355);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // mtxtMonto
            // 
            this.mtxtMonto.Location = new System.Drawing.Point(177, 287);
            this.mtxtMonto.Mask = "00000000000000";
            this.mtxtMonto.Name = "mtxtMonto";
            this.mtxtMonto.Size = new System.Drawing.Size(100, 23);
            this.mtxtMonto.TabIndex = 15;
            // 
            // frmFormaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.mtxtMonto);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.rbtnTarjeta);
            this.Controls.Add(this.rbtnEfectivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVuelto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtSubtotal);
            this.Controls.Add(this.label1);
            this.Name = "frmFormaPago";
            this.Text = "Forma de pago";
            this.Load += new System.EventHandler(this.frmFormaPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MaskedTextBox mtxtSubtotal;
        private Label label2;
        private TextBox txtIva;
        private Label label3;
        private TextBox txtTotal;
        private Label label4;
        private TextBox txtVuelto;
        private Label label5;
        private RadioButton rbtnEfectivo;
        private RadioButton rbtnTarjeta;
        private Button btnTotal;
        private Button btnPagar;
        private Button btnLimpiar;
        private MaskedTextBox mtxtMonto;
    }
}