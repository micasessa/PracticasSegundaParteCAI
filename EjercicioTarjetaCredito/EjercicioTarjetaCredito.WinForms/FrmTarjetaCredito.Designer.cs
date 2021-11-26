
namespace EjercicioTarjetaCredito.WinForms
{
    partial class FrmTarjetaCredito
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._btnCalcular = new System.Windows.Forms.Button();
            this._btnAlta = new System.Windows.Forms.Button();
            this._txtBxLimiteCompra = new System.Windows.Forms.TextBox();
            this._cmbTipoTarjeta = new System.Windows.Forms.ComboBox();
            this._cmbPeriodoCierre = new System.Windows.Forms.ComboBox();
            this._cmbCliente = new System.Windows.Forms.ComboBox();
            this._txtNumPlastico = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._lstTarjetas = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._txtCantPlasticoEmitidos = new System.Windows.Forms.TextBox();
            this._txtLimitePromedio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario Tarjeta de Credito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Tarjeta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Periodo de Cierre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero de plástico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Límite de compra";
            // 
            // _btnCalcular
            // 
            this._btnCalcular.Location = new System.Drawing.Point(17, 226);
            this._btnCalcular.Name = "_btnCalcular";
            this._btnCalcular.Size = new System.Drawing.Size(350, 36);
            this._btnCalcular.TabIndex = 6;
            this._btnCalcular.Text = "CALCULAR";
            this._btnCalcular.UseVisualStyleBackColor = true;
            this._btnCalcular.Click += new System.EventHandler(this._btnCalcular_Click);
            // 
            // _btnAlta
            // 
            this._btnAlta.Location = new System.Drawing.Point(17, 335);
            this._btnAlta.Name = "_btnAlta";
            this._btnAlta.Size = new System.Drawing.Size(350, 36);
            this._btnAlta.TabIndex = 7;
            this._btnAlta.Text = "ALTA";
            this._btnAlta.UseVisualStyleBackColor = true;
            this._btnAlta.Click += new System.EventHandler(this._btnAlta_Click);
            // 
            // _txtBxLimiteCompra
            // 
            this._txtBxLimiteCompra.Location = new System.Drawing.Point(194, 181);
            this._txtBxLimiteCompra.Name = "_txtBxLimiteCompra";
            this._txtBxLimiteCompra.Size = new System.Drawing.Size(173, 26);
            this._txtBxLimiteCompra.TabIndex = 8;
            // 
            // _cmbTipoTarjeta
            // 
            this._cmbTipoTarjeta.Enabled = false;
            this._cmbTipoTarjeta.FormattingEnabled = true;
            this._cmbTipoTarjeta.Location = new System.Drawing.Point(194, 47);
            this._cmbTipoTarjeta.Name = "_cmbTipoTarjeta";
            this._cmbTipoTarjeta.Size = new System.Drawing.Size(173, 28);
            this._cmbTipoTarjeta.TabIndex = 9;
            // 
            // _cmbPeriodoCierre
            // 
            this._cmbPeriodoCierre.FormattingEnabled = true;
            this._cmbPeriodoCierre.Location = new System.Drawing.Point(194, 98);
            this._cmbPeriodoCierre.Name = "_cmbPeriodoCierre";
            this._cmbPeriodoCierre.Size = new System.Drawing.Size(173, 28);
            this._cmbPeriodoCierre.TabIndex = 10;
            // 
            // _cmbCliente
            // 
            this._cmbCliente.FormattingEnabled = true;
            this._cmbCliente.Location = new System.Drawing.Point(194, 137);
            this._cmbCliente.Name = "_cmbCliente";
            this._cmbCliente.Size = new System.Drawing.Size(173, 28);
            this._cmbCliente.TabIndex = 11;
            // 
            // _txtNumPlastico
            // 
            this._txtNumPlastico.Location = new System.Drawing.Point(194, 291);
            this._txtNumPlastico.Name = "_txtNumPlastico";
            this._txtNumPlastico.Size = new System.Drawing.Size(173, 26);
            this._txtNumPlastico.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(407, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Reporte Tarjetas";
            // 
            // _lstTarjetas
            // 
            this._lstTarjetas.FormattingEnabled = true;
            this._lstTarjetas.ItemHeight = 20;
            this._lstTarjetas.Location = new System.Drawing.Point(411, 47);
            this._lstTarjetas.Name = "_lstTarjetas";
            this._lstTarjetas.Size = new System.Drawing.Size(314, 204);
            this._lstTarjetas.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cantidad de plástico emitidos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Limite promedio";
            // 
            // _txtCantPlasticoEmitidos
            // 
            this._txtCantPlasticoEmitidos.Location = new System.Drawing.Point(629, 294);
            this._txtCantPlasticoEmitidos.Name = "_txtCantPlasticoEmitidos";
            this._txtCantPlasticoEmitidos.Size = new System.Drawing.Size(96, 26);
            this._txtCantPlasticoEmitidos.TabIndex = 17;
            // 
            // _txtLimitePromedio
            // 
            this._txtLimitePromedio.Location = new System.Drawing.Point(629, 329);
            this._txtLimitePromedio.Name = "_txtLimitePromedio";
            this._txtLimitePromedio.Size = new System.Drawing.Size(96, 26);
            this._txtLimitePromedio.TabIndex = 18;
            // 
            // FrmTarjetaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 404);
            this.Controls.Add(this._txtLimitePromedio);
            this.Controls.Add(this._txtCantPlasticoEmitidos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._lstTarjetas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._txtNumPlastico);
            this.Controls.Add(this._cmbCliente);
            this.Controls.Add(this._cmbPeriodoCierre);
            this.Controls.Add(this._cmbTipoTarjeta);
            this.Controls.Add(this._txtBxLimiteCompra);
            this.Controls.Add(this._btnAlta);
            this.Controls.Add(this._btnCalcular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTarjetaCredito";
            this.Text = "Decaedro SRL";
            this.Load += new System.EventHandler(this.FrmTarjetaCredito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button _btnCalcular;
        private System.Windows.Forms.Button _btnAlta;
        private System.Windows.Forms.TextBox _txtBxLimiteCompra;
        private System.Windows.Forms.ComboBox _cmbTipoTarjeta;
        private System.Windows.Forms.ComboBox _cmbPeriodoCierre;
        private System.Windows.Forms.ComboBox _cmbCliente;
        private System.Windows.Forms.TextBox _txtNumPlastico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox _lstTarjetas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _txtCantPlasticoEmitidos;
        private System.Windows.Forms.TextBox _txtLimitePromedio;
    }
}

