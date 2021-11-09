
namespace ProyectoClientes.WinForms
{
    partial class FrmListarCliente
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
            this.btnVolver_Click = new System.Windows.Forms.Button();
            this.lblListaCliente = new System.Windows.Forms.Label();
            this._lstClientes = new System.Windows.Forms.ListBox();
            this._btnDetalle_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver_Click
            // 
            this.btnVolver_Click.Location = new System.Drawing.Point(612, 45);
            this.btnVolver_Click.Name = "btnVolver_Click";
            this.btnVolver_Click.Size = new System.Drawing.Size(124, 30);
            this.btnVolver_Click.TabIndex = 1;
            this.btnVolver_Click.Text = "Volver";
            this.btnVolver_Click.UseVisualStyleBackColor = true;
            this.btnVolver_Click.Click += new System.EventHandler(this.btnVolver_Click_Click);
            // 
            // lblListaCliente
            // 
            this.lblListaCliente.AutoSize = true;
            this.lblListaCliente.Location = new System.Drawing.Point(48, 43);
            this.lblListaCliente.Name = "lblListaCliente";
            this.lblListaCliente.Size = new System.Drawing.Size(122, 20);
            this.lblListaCliente.TabIndex = 2;
            this.lblListaCliente.Text = "Listado Clientes";
            // 
            // _lstClientes
            // 
            this._lstClientes.FormattingEnabled = true;
            this._lstClientes.ItemHeight = 20;
            this._lstClientes.Location = new System.Drawing.Point(48, 92);
            this._lstClientes.Name = "_lstClientes";
            this._lstClientes.Size = new System.Drawing.Size(687, 264);
            this._lstClientes.TabIndex = 3;
            // 
            // _btnDetalle_Click
            // 
            this._btnDetalle_Click.Location = new System.Drawing.Point(48, 382);
            this._btnDetalle_Click.Name = "_btnDetalle_Click";
            this._btnDetalle_Click.Size = new System.Drawing.Size(117, 28);
            this._btnDetalle_Click.TabIndex = 4;
            this._btnDetalle_Click.Text = "Ver Detalle";
            this._btnDetalle_Click.UseVisualStyleBackColor = true;
            this._btnDetalle_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnDetalle_Click);
            this.Controls.Add(this._lstClientes);
            this.Controls.Add(this.lblListaCliente);
            this.Controls.Add(this.btnVolver_Click);
            this.Name = "FrmListarCliente";
            this.Text = "FrmListarCliente";
            this.Load += new System.EventHandler(this.FrmListarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver_Click;
        private System.Windows.Forms.Label lblListaCliente;
        private System.Windows.Forms.ListBox _lstClientes;
        private System.Windows.Forms.Button _btnDetalle_Click;
    }
}