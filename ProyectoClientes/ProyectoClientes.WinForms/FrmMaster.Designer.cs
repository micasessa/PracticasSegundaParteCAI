
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
            this.btnListarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this._btnSerialDescer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarCliente
            // 
            this.btnListarCliente.Location = new System.Drawing.Point(130, 84);
            this.btnListarCliente.Name = "btnListarCliente";
            this.btnListarCliente.Size = new System.Drawing.Size(187, 37);
            this.btnListarCliente.TabIndex = 1;
            this.btnListarCliente.Text = "Listar Cliente";
            this.btnListarCliente.UseVisualStyleBackColor = true;
            this.btnListarCliente.Click += new System.EventHandler(this.btnListarCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(130, 146);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(187, 37);
            this.btnModificarCliente.TabIndex = 3;
            this.btnModificarCliente.Text = "Modificar Cliente";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // _btnSerialDescer
            // 
            this._btnSerialDescer.Location = new System.Drawing.Point(131, 210);
            this._btnSerialDescer.Name = "_btnSerialDescer";
            this._btnSerialDescer.Size = new System.Drawing.Size(185, 41);
            this._btnSerialDescer.TabIndex = 4;
            this._btnSerialDescer.Text = "Serializar/Descerializar";
            this._btnSerialDescer.UseVisualStyleBackColor = true;
            this._btnSerialDescer.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 387);
            this.Controls.Add(this._btnSerialDescer);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnListarCliente);
            this.Name = "FrmMaster";
            this.Text = "FrmMaster";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button _btnSerialDescer;
    }
}