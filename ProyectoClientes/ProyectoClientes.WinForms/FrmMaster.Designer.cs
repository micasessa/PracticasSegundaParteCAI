
namespace ProyectoClientes.WinForms
{
    partial class FrmMaster
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
            this.btnSerialDescer = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this._btnModuloCuentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSerialDescer
            // 
            this.btnSerialDescer.Location = new System.Drawing.Point(122, 245);
            this.btnSerialDescer.Name = "btnSerialDescer";
            this.btnSerialDescer.Size = new System.Drawing.Size(337, 50);
            this.btnSerialDescer.TabIndex = 1;
            this.btnSerialDescer.Text = "Serializar/Descerializar";
            this.btnSerialDescer.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(122, 65);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(337, 50);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "Modulo Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // _btnModuloCuentas
            // 
            this._btnModuloCuentas.Location = new System.Drawing.Point(122, 149);
            this._btnModuloCuentas.Name = "_btnModuloCuentas";
            this._btnModuloCuentas.Size = new System.Drawing.Size(333, 49);
            this._btnModuloCuentas.TabIndex = 4;
            this._btnModuloCuentas.Text = "Modulo Cuentas";
            this._btnModuloCuentas.UseVisualStyleBackColor = true;
            this._btnModuloCuentas.Click += new System.EventHandler(this._btnModuloCuentas_Click);
            // 
            // FrmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 395);
            this.Controls.Add(this._btnModuloCuentas);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnSerialDescer);
            this.Name = "FrmMaster";
            this.Text = "Master";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSerialDescer;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button _btnModuloCuentas;
    }
}