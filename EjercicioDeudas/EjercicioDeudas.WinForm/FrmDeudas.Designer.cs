
namespace EjercicioDeudas.WinForm
{
    partial class FrmDeudas
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this._cmbServicio = new System.Windows.Forms.ComboBox();
            this._txtPunitorio = new System.Windows.Forms.TextBox();
            this._txtImporteAdeudado = new System.Windows.Forms.TextBox();
            this._txtFechaVencimiento = new System.Windows.Forms.TextBox();
            this._txtFechaPago = new System.Windows.Forms.TextBox();
            this._txtInteresPunitorio = new System.Windows.Forms.TextBox();
            this._txtImporteTotal = new System.Windows.Forms.TextBox();
            this._btnCalcular = new System.Windows.Forms.Button();
            this._btnPagar = new System.Windows.Forms.Button();
            this._txtDiasAtraso = new System.Windows.Forms.TextBox();
            this._txtInteresPromedio = new System.Windows.Forms.TextBox();
            this._lstPagos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario de Pago Tardio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reporte de Moras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Servicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Punitorio por dia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Importe Adeudado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de Vencimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Importe Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dias de atraso promedio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Interés punitorio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Fecha de Pago";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(454, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Interes promedio";
            // 
            // _cmbServicio
            // 
            this._cmbServicio.FormattingEnabled = true;
            this._cmbServicio.Location = new System.Drawing.Point(219, 62);
            this._cmbServicio.Name = "_cmbServicio";
            this._cmbServicio.Size = new System.Drawing.Size(141, 28);
            this._cmbServicio.TabIndex = 11;
            // 
            // _txtPunitorio
            // 
            this._txtPunitorio.Location = new System.Drawing.Point(219, 100);
            this._txtPunitorio.Name = "_txtPunitorio";
            this._txtPunitorio.Size = new System.Drawing.Size(139, 26);
            this._txtPunitorio.TabIndex = 12;
            // 
            // _txtImporteAdeudado
            // 
            this._txtImporteAdeudado.Location = new System.Drawing.Point(219, 138);
            this._txtImporteAdeudado.Name = "_txtImporteAdeudado";
            this._txtImporteAdeudado.Size = new System.Drawing.Size(139, 26);
            this._txtImporteAdeudado.TabIndex = 13;
            // 
            // _txtFechaVencimiento
            // 
            this._txtFechaVencimiento.Location = new System.Drawing.Point(219, 176);
            this._txtFechaVencimiento.Name = "_txtFechaVencimiento";
            this._txtFechaVencimiento.Size = new System.Drawing.Size(139, 26);
            this._txtFechaVencimiento.TabIndex = 14;
            // 
            // _txtFechaPago
            // 
            this._txtFechaPago.Location = new System.Drawing.Point(219, 217);
            this._txtFechaPago.Name = "_txtFechaPago";
            this._txtFechaPago.Size = new System.Drawing.Size(139, 26);
            this._txtFechaPago.TabIndex = 15;
            // 
            // _txtInteresPunitorio
            // 
            this._txtInteresPunitorio.Location = new System.Drawing.Point(219, 332);
            this._txtInteresPunitorio.Name = "_txtInteresPunitorio";
            this._txtInteresPunitorio.Size = new System.Drawing.Size(139, 26);
            this._txtInteresPunitorio.TabIndex = 16;
            // 
            // _txtImporteTotal
            // 
            this._txtImporteTotal.Location = new System.Drawing.Point(219, 371);
            this._txtImporteTotal.Name = "_txtImporteTotal";
            this._txtImporteTotal.Size = new System.Drawing.Size(139, 26);
            this._txtImporteTotal.TabIndex = 17;
            // 
            // _btnCalcular
            // 
            this._btnCalcular.Location = new System.Drawing.Point(31, 264);
            this._btnCalcular.Name = "_btnCalcular";
            this._btnCalcular.Size = new System.Drawing.Size(328, 31);
            this._btnCalcular.TabIndex = 18;
            this._btnCalcular.Text = "CALCULAR";
            this._btnCalcular.UseVisualStyleBackColor = true;
            // 
            // _btnPagar
            // 
            this._btnPagar.Location = new System.Drawing.Point(27, 418);
            this._btnPagar.Name = "_btnPagar";
            this._btnPagar.Size = new System.Drawing.Size(328, 31);
            this._btnPagar.TabIndex = 19;
            this._btnPagar.Text = "PAGAR";
            this._btnPagar.UseVisualStyleBackColor = true;
            // 
            // _txtDiasAtraso
            // 
            this._txtDiasAtraso.Location = new System.Drawing.Point(672, 377);
            this._txtDiasAtraso.Name = "_txtDiasAtraso";
            this._txtDiasAtraso.Size = new System.Drawing.Size(94, 26);
            this._txtDiasAtraso.TabIndex = 20;
            // 
            // _txtInteresPromedio
            // 
            this._txtInteresPromedio.Location = new System.Drawing.Point(672, 415);
            this._txtInteresPromedio.Name = "_txtInteresPromedio";
            this._txtInteresPromedio.Size = new System.Drawing.Size(94, 26);
            this._txtInteresPromedio.TabIndex = 21;
            // 
            // _lstPagos
            // 
            this._lstPagos.FormattingEnabled = true;
            this._lstPagos.ItemHeight = 20;
            this._lstPagos.Location = new System.Drawing.Point(437, 59);
            this._lstPagos.Name = "_lstPagos";
            this._lstPagos.Size = new System.Drawing.Size(328, 284);
            this._lstPagos.TabIndex = 22;
            // 
            // FrmDeudas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this._lstPagos);
            this.Controls.Add(this._txtInteresPromedio);
            this.Controls.Add(this._txtDiasAtraso);
            this.Controls.Add(this._btnPagar);
            this.Controls.Add(this._btnCalcular);
            this.Controls.Add(this._txtImporteTotal);
            this.Controls.Add(this._txtInteresPunitorio);
            this.Controls.Add(this._txtFechaPago);
            this.Controls.Add(this._txtFechaVencimiento);
            this.Controls.Add(this._txtImporteAdeudado);
            this.Controls.Add(this._txtPunitorio);
            this.Controls.Add(this._cmbServicio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDeudas";
            this.Text = "RAPI COBRANZAS S.A.";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox _cmbServicio;
        private System.Windows.Forms.TextBox _txtPunitorio;
        private System.Windows.Forms.TextBox _txtImporteAdeudado;
        private System.Windows.Forms.TextBox _txtFechaVencimiento;
        private System.Windows.Forms.TextBox _txtFechaPago;
        private System.Windows.Forms.TextBox _txtInteresPunitorio;
        private System.Windows.Forms.TextBox _txtImporteTotal;
        private System.Windows.Forms.Button _btnCalcular;
        private System.Windows.Forms.Button _btnPagar;
        private System.Windows.Forms.TextBox _txtDiasAtraso;
        private System.Windows.Forms.TextBox _txtInteresPromedio;
        private System.Windows.Forms.ListBox _lstPagos;
    }
}

