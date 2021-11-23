
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
            this._lblDni = new System.Windows.Forms.Label();
            this._lblNombreCliente = new System.Windows.Forms.Label();
            this._lblApellidoCliente = new System.Windows.Forms.Label();
            this._txtDni = new System.Windows.Forms.TextBox();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._txtApellido = new System.Windows.Forms.TextBox();
            this._btnGuardar = new System.Windows.Forms.Button();
            this._btnLimpiar = new System.Windows.Forms.Button();
            this._btnVolver = new System.Windows.Forms.Button();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this._txtDireccion = new System.Windows.Forms.TextBox();
            this._txtTelefono = new System.Windows.Forms.TextBox();
            this._txtEmail = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this._txtCodigo = new System.Windows.Forms.TextBox();
            this.lblClientes = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this._lblActivo = new System.Windows.Forms.Label();
            this._chckActivo = new System.Windows.Forms.CheckBox();
            this._lstClientes = new System.Windows.Forms.ListBox();
            this._btnRecargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblDni
            // 
            this._lblDni.AutoSize = true;
            this._lblDni.Location = new System.Drawing.Point(47, 119);
            this._lblDni.Name = "_lblDni";
            this._lblDni.Size = new System.Drawing.Size(33, 20);
            this._lblDni.TabIndex = 0;
            this._lblDni.Text = "Dni";
            // 
            // _lblNombreCliente
            // 
            this._lblNombreCliente.AutoSize = true;
            this._lblNombreCliente.Location = new System.Drawing.Point(47, 170);
            this._lblNombreCliente.Name = "_lblNombreCliente";
            this._lblNombreCliente.Size = new System.Drawing.Size(65, 20);
            this._lblNombreCliente.TabIndex = 1;
            this._lblNombreCliente.Text = "Nombre";
            // 
            // _lblApellidoCliente
            // 
            this._lblApellidoCliente.AutoSize = true;
            this._lblApellidoCliente.Location = new System.Drawing.Point(47, 223);
            this._lblApellidoCliente.Name = "_lblApellidoCliente";
            this._lblApellidoCliente.Size = new System.Drawing.Size(65, 20);
            this._lblApellidoCliente.TabIndex = 2;
            this._lblApellidoCliente.Text = "Apellido";
            // 
            // _txtDni
            // 
            this._txtDni.Location = new System.Drawing.Point(192, 113);
            this._txtDni.Name = "_txtDni";
            this._txtDni.Size = new System.Drawing.Size(122, 26);
            this._txtDni.TabIndex = 3;
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(192, 164);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(121, 26);
            this._txtNombre.TabIndex = 4;
            // 
            // _txtApellido
            // 
            this._txtApellido.Location = new System.Drawing.Point(191, 217);
            this._txtApellido.Name = "_txtApellido";
            this._txtApellido.Size = new System.Drawing.Size(122, 26);
            this._txtApellido.TabIndex = 5;
            // 
            // _btnGuardar
            // 
            this._btnGuardar.Location = new System.Drawing.Point(149, 515);
            this._btnGuardar.Name = "_btnGuardar";
            this._btnGuardar.Size = new System.Drawing.Size(85, 29);
            this._btnGuardar.TabIndex = 6;
            this._btnGuardar.Text = "Guardar";
            this._btnGuardar.UseVisualStyleBackColor = true;
            this._btnGuardar.Click += new System.EventHandler(this._btnGuardar_Click);
            // 
            // _btnLimpiar
            // 
            this._btnLimpiar.Location = new System.Drawing.Point(258, 516);
            this._btnLimpiar.Name = "_btnLimpiar";
            this._btnLimpiar.Size = new System.Drawing.Size(85, 28);
            this._btnLimpiar.TabIndex = 7;
            this._btnLimpiar.Text = "Limpiar";
            this._btnLimpiar.UseVisualStyleBackColor = true;
            this._btnLimpiar.Click += new System.EventHandler(this._btnLimpiar_Click);
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(27, 516);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(85, 28);
            this._btnVolver.TabIndex = 8;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(45, 403);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(133, 20);
            this.lblFechaNac.TabIndex = 9;
            this.lblFechaNac.Text = "FechaNacimiento";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(45, 358);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 20);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(47, 267);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(45, 314);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "Direccion";
            // 
            // _txtDireccion
            // 
            this._txtDireccion.Location = new System.Drawing.Point(192, 309);
            this._txtDireccion.Name = "_txtDireccion";
            this._txtDireccion.Size = new System.Drawing.Size(122, 26);
            this._txtDireccion.TabIndex = 14;
            // 
            // _txtTelefono
            // 
            this._txtTelefono.Location = new System.Drawing.Point(192, 353);
            this._txtTelefono.Name = "_txtTelefono";
            this._txtTelefono.Size = new System.Drawing.Size(122, 26);
            this._txtTelefono.TabIndex = 15;
            // 
            // _txtEmail
            // 
            this._txtEmail.Location = new System.Drawing.Point(193, 262);
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new System.Drawing.Size(122, 26);
            this._txtEmail.TabIndex = 16;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(46, 77);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 17;
            this.lblCodigo.Text = "Codigo";
            // 
            // _txtCodigo
            // 
            this._txtCodigo.Location = new System.Drawing.Point(193, 71);
            this._txtCodigo.Name = "_txtCodigo";
            this._txtCodigo.Size = new System.Drawing.Size(122, 26);
            this._txtCodigo.TabIndex = 18;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(28, 20);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(160, 32);
            this.lblClientes.TabIndex = 19;
            this.lblClientes.Text = "CLIENTES";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 403);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(296, 26);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // _lblActivo
            // 
            this._lblActivo.AutoSize = true;
            this._lblActivo.Location = new System.Drawing.Point(47, 454);
            this._lblActivo.Name = "_lblActivo";
            this._lblActivo.Size = new System.Drawing.Size(52, 20);
            this._lblActivo.TabIndex = 21;
            this._lblActivo.Text = "Activo";
            // 
            // _chckActivo
            // 
            this._chckActivo.AutoSize = true;
            this._chckActivo.Location = new System.Drawing.Point(191, 453);
            this._chckActivo.Name = "_chckActivo";
            this._chckActivo.Size = new System.Drawing.Size(22, 21);
            this._chckActivo.TabIndex = 22;
            this._chckActivo.UseVisualStyleBackColor = true;
            // 
            // _lstClientes
            // 
            this._lstClientes.FormattingEnabled = true;
            this._lstClientes.ItemHeight = 20;
            this._lstClientes.Location = new System.Drawing.Point(532, 68);
            this._lstClientes.Name = "_lstClientes";
            this._lstClientes.Size = new System.Drawing.Size(417, 344);
            this._lstClientes.TabIndex = 23;
            // 
            // _btnRecargar
            // 
            this._btnRecargar.Location = new System.Drawing.Point(864, 515);
            this._btnRecargar.Name = "_btnRecargar";
            this._btnRecargar.Size = new System.Drawing.Size(85, 28);
            this._btnRecargar.TabIndex = 24;
            this._btnRecargar.Text = "Recargar";
            this._btnRecargar.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 582);
            this.Controls.Add(this._btnRecargar);
            this.Controls.Add(this._lstClientes);
            this.Controls.Add(this._chckActivo);
            this.Controls.Add(this._lblActivo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this._txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this._txtEmail);
            this.Controls.Add(this._txtTelefono);
            this.Controls.Add(this._txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnLimpiar);
            this.Controls.Add(this._btnGuardar);
            this.Controls.Add(this._txtApellido);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this._txtDni);
            this.Controls.Add(this._lblApellidoCliente);
            this.Controls.Add(this._lblNombreCliente);
            this.Controls.Add(this._lblDni);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblDni;
        private System.Windows.Forms.Label _lblNombreCliente;
        private System.Windows.Forms.Label _lblApellidoCliente;
        private System.Windows.Forms.TextBox _txtDni;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.TextBox _txtApellido;
        private System.Windows.Forms.Button _btnGuardar;
        private System.Windows.Forms.Button _btnLimpiar;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox _txtDireccion;
        private System.Windows.Forms.TextBox _txtTelefono;
        private System.Windows.Forms.TextBox _txtEmail;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox _txtCodigo;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label _lblActivo;
        private System.Windows.Forms.CheckBox _chckActivo;
        private System.Windows.Forms.ListBox _lstClientes;
        private System.Windows.Forms.Button _btnRecargar;
    }
}