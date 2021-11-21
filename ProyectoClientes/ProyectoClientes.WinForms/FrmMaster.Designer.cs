
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
            this.btnSerialDescer = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarCliente
            // 
            this.btnListarCliente.Location = new System.Drawing.Point(122, 64);
            this.btnListarCliente.Name = "btnListarCliente";
            this.btnListarCliente.Size = new System.Drawing.Size(337, 50);
            this.btnListarCliente.TabIndex = 0;
            this.btnListarCliente.Text = "Listar Cliente";
            this.btnListarCliente.UseVisualStyleBackColor = true;
            this.btnListarCliente.Click += new System.EventHandler(this.btnListarCliente_Click_1);
            // 
            // btnSerialDescer
            // 
            this.btnSerialDescer.Location = new System.Drawing.Point(122, 230);
            this.btnSerialDescer.Name = "btnSerialDescer";
            this.btnSerialDescer.Size = new System.Drawing.Size(337, 50);
            this.btnSerialDescer.TabIndex = 1;
            this.btnSerialDescer.Text = "Serializar/Descerializar";
            this.btnSerialDescer.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(122, 144);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(337, 50);
            this.btnAgregarCliente.TabIndex = 3;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // FrmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 369);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnSerialDescer);
            this.Controls.Add(this.btnListarCliente);
            this.Name = "FrmMaster";
            this.Text = "Master";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarCliente;
        private System.Windows.Forms.Button btnSerialDescer;
        private System.Windows.Forms.Button btnAgregarCliente;
    }
}