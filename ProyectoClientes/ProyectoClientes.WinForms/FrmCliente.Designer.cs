
namespace ProyectoClientes.WinForms
{
    partial class FrmCliente
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
            this._lblCuit = new System.Windows.Forms.Label();
            this._lblNombreCliente = new System.Windows.Forms.Label();
            this._lblApellidoCliente = new System.Windows.Forms.Label();
            this._txtCuit = new System.Windows.Forms.TextBox();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._txtApellido = new System.Windows.Forms.TextBox();
            this._btnGuardar = new System.Windows.Forms.Button();
            this._btnLimpiar = new System.Windows.Forms.Button();
            this._btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblCuit
            // 
            this._lblCuit.AutoSize = true;
            this._lblCuit.Location = new System.Drawing.Point(105, 75);
            this._lblCuit.Name = "_lblCuit";
            this._lblCuit.Size = new System.Drawing.Size(46, 20);
            this._lblCuit.TabIndex = 0;
            this._lblCuit.Text = "CUIT";
            // 
            // _lblNombreCliente
            // 
            this._lblNombreCliente.AutoSize = true;
            this._lblNombreCliente.Location = new System.Drawing.Point(105, 119);
            this._lblNombreCliente.Name = "_lblNombreCliente";
            this._lblNombreCliente.Size = new System.Drawing.Size(65, 20);
            this._lblNombreCliente.TabIndex = 1;
            this._lblNombreCliente.Text = "Nombre";
            // 
            // _lblApellidoCliente
            // 
            this._lblApellidoCliente.AutoSize = true;
            this._lblApellidoCliente.Location = new System.Drawing.Point(105, 171);
            this._lblApellidoCliente.Name = "_lblApellidoCliente";
            this._lblApellidoCliente.Size = new System.Drawing.Size(65, 20);
            this._lblApellidoCliente.TabIndex = 2;
            this._lblApellidoCliente.Text = "Apellido";
            // 
            // _txtCuit
            // 
            this._txtCuit.Location = new System.Drawing.Point(211, 69);
            this._txtCuit.Name = "_txtCuit";
            this._txtCuit.Size = new System.Drawing.Size(122, 26);
            this._txtCuit.TabIndex = 3;
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(211, 116);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(121, 26);
            this._txtNombre.TabIndex = 4;
            // 
            // _txtApellido
            // 
            this._txtApellido.Location = new System.Drawing.Point(211, 165);
            this._txtApellido.Name = "_txtApellido";
            this._txtApellido.Size = new System.Drawing.Size(122, 26);
            this._txtApellido.TabIndex = 5;
            // 
            // _btnGuardar
            // 
            this._btnGuardar.Location = new System.Drawing.Point(84, 259);
            this._btnGuardar.Name = "_btnGuardar";
            this._btnGuardar.Size = new System.Drawing.Size(85, 29);
            this._btnGuardar.TabIndex = 6;
            this._btnGuardar.Text = "Guardar";
            this._btnGuardar.UseVisualStyleBackColor = true;
            // 
            // _btnLimpiar
            // 
            this._btnLimpiar.Location = new System.Drawing.Point(181, 260);
            this._btnLimpiar.Name = "_btnLimpiar";
            this._btnLimpiar.Size = new System.Drawing.Size(85, 28);
            this._btnLimpiar.TabIndex = 7;
            this._btnLimpiar.Text = "Limpiar";
            this._btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(281, 260);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(85, 28);
            this._btnVolver.TabIndex = 8;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 376);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnLimpiar);
            this.Controls.Add(this._btnGuardar);
            this.Controls.Add(this._txtApellido);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this._txtCuit);
            this.Controls.Add(this._lblApellidoCliente);
            this.Controls.Add(this._lblNombreCliente);
            this.Controls.Add(this._lblCuit);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblCuit;
        private System.Windows.Forms.Label _lblNombreCliente;
        private System.Windows.Forms.Label _lblApellidoCliente;
        private System.Windows.Forms.TextBox _txtCuit;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.TextBox _txtApellido;
        private System.Windows.Forms.Button _btnGuardar;
        private System.Windows.Forms.Button _btnLimpiar;
        private System.Windows.Forms.Button _btnVolver;
    }
}