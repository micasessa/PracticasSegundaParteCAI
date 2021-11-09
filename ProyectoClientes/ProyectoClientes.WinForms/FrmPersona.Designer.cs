
namespace ProyectoClientes.WinForms
{
    partial class FrmPersona
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
            this._lblNombre = new System.Windows.Forms.Label();
            this._lblApellido = new System.Windows.Forms.Label();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._txtApellido = new System.Windows.Forms.TextBox();
            this._btnResultado = new System.Windows.Forms.Button();
            this._btnLimpiar = new System.Windows.Forms.Button();
            this._txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _lblNombre
            // 
            this._lblNombre.AutoSize = true;
            this._lblNombre.Location = new System.Drawing.Point(100, 58);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(123, 20);
            this._lblNombre.TabIndex = 0;
            this._lblNombre.Text = "Ingrese Nombre";
            // 
            // _lblApellido
            // 
            this._lblApellido.AutoSize = true;
            this._lblApellido.Location = new System.Drawing.Point(100, 100);
            this._lblApellido.Name = "_lblApellido";
            this._lblApellido.Size = new System.Drawing.Size(123, 20);
            this._lblApellido.TabIndex = 1;
            this._lblApellido.Text = "Ingrese Apellido";
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(279, 52);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(188, 26);
            this._txtNombre.TabIndex = 2;
            // 
            // _txtApellido
            // 
            this._txtApellido.Location = new System.Drawing.Point(279, 94);
            this._txtApellido.Name = "_txtApellido";
            this._txtApellido.Size = new System.Drawing.Size(188, 26);
            this._txtApellido.TabIndex = 3;
            // 
            // _btnResultado
            // 
            this._btnResultado.Location = new System.Drawing.Point(103, 273);
            this._btnResultado.Name = "_btnResultado";
            this._btnResultado.Size = new System.Drawing.Size(217, 32);
            this._btnResultado.TabIndex = 4;
            this._btnResultado.Text = "Resultado";
            this._btnResultado.UseVisualStyleBackColor = true;
            this._btnResultado.Click += new System.EventHandler(this._btnResultado_Click);
            // 
            // _btnLimpiar
            // 
            this._btnLimpiar.Location = new System.Drawing.Point(342, 275);
            this._btnLimpiar.Name = "_btnLimpiar";
            this._btnLimpiar.Size = new System.Drawing.Size(124, 29);
            this._btnLimpiar.TabIndex = 5;
            this._btnLimpiar.Text = "Limpiar";
            this._btnLimpiar.UseVisualStyleBackColor = true;
            this._btnLimpiar.Click += new System.EventHandler(this._btnLimpiar_Click);
            // 
            // _txtResultado
            // 
            this._txtResultado.Location = new System.Drawing.Point(102, 219);
            this._txtResultado.Name = "_txtResultado";
            this._txtResultado.ReadOnly = true;
            this._txtResultado.Size = new System.Drawing.Size(364, 26);
            this._txtResultado.TabIndex = 6;
            // 
            // FrmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._txtResultado);
            this.Controls.Add(this._btnLimpiar);
            this.Controls.Add(this._btnResultado);
            this.Controls.Add(this._txtApellido);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this._lblApellido);
            this.Controls.Add(this._lblNombre);
            this.Name = "FrmPersona";
            this.Text = "FrmPersona";
            this.Load += new System.EventHandler(this.FrmPersona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.Label _lblApellido;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.TextBox _txtApellido;
        private System.Windows.Forms.Button _btnResultado;
        private System.Windows.Forms.Button _btnLimpiar;
        private System.Windows.Forms.TextBox _txtResultado;
    }
}