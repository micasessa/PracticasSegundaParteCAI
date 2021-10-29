
namespace Prueba1.WinForms
{
    partial class _frm1
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
            this._txtBxNombre = new System.Windows.Forms.TextBox();
            this._lblNombre = new System.Windows.Forms.Label();
            this._lblApellido = new System.Windows.Forms.Label();
            this._txtBxApellido = new System.Windows.Forms.TextBox();
            this._txtBxResultado = new System.Windows.Forms.TextBox();
            this._bttnEnter = new System.Windows.Forms.Button();
            this._lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _txtBxNombre
            // 
            this._txtBxNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._txtBxNombre.Location = new System.Drawing.Point(225, 96);
            this._txtBxNombre.Name = "_txtBxNombre";
            this._txtBxNombre.Size = new System.Drawing.Size(161, 26);
            this._txtBxNombre.TabIndex = 0;
            // 
            // _lblNombre
            // 
            this._lblNombre.AutoSize = true;
            this._lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblNombre.Location = new System.Drawing.Point(139, 99);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(71, 20);
            this._lblNombre.TabIndex = 1;
            this._lblNombre.Text = "Nombre";
            // 
            // _lblApellido
            // 
            this._lblApellido.AutoSize = true;
            this._lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblApellido.Location = new System.Drawing.Point(139, 143);
            this._lblApellido.Name = "_lblApellido";
            this._lblApellido.Size = new System.Drawing.Size(73, 20);
            this._lblApellido.TabIndex = 2;
            this._lblApellido.Text = "Apellido";
            // 
            // _txtBxApellido
            // 
            this._txtBxApellido.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this._txtBxApellido.Location = new System.Drawing.Point(226, 143);
            this._txtBxApellido.Name = "_txtBxApellido";
            this._txtBxApellido.Size = new System.Drawing.Size(160, 26);
            this._txtBxApellido.TabIndex = 3;
            // 
            // _txtBxResultado
            // 
            this._txtBxResultado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._txtBxResultado.Location = new System.Drawing.Point(143, 195);
            this._txtBxResultado.Name = "_txtBxResultado";
            this._txtBxResultado.Size = new System.Drawing.Size(243, 26);
            this._txtBxResultado.TabIndex = 4;
            // 
            // _bttnEnter
            // 
            this._bttnEnter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._bttnEnter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._bttnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bttnEnter.Location = new System.Drawing.Point(143, 241);
            this._bttnEnter.Name = "_bttnEnter";
            this._bttnEnter.Size = new System.Drawing.Size(243, 31);
            this._bttnEnter.TabIndex = 5;
            this._bttnEnter.Text = "Enter";
            this._bttnEnter.UseVisualStyleBackColor = false;
            this._bttnEnter.Click += new System.EventHandler(this._bttnEnter_Click);
            // 
            // _lblHeader
            // 
            this._lblHeader.AutoSize = true;
            this._lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblHeader.Location = new System.Drawing.Point(139, 59);
            this._lblHeader.Name = "_lblHeader";
            this._lblHeader.Size = new System.Drawing.Size(240, 20);
            this._lblHeader.TabIndex = 6;
            this._lblHeader.Text = "Ingrese los siguientes datos:";
            this._lblHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // _frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 368);
            this.Controls.Add(this._lblHeader);
            this.Controls.Add(this._bttnEnter);
            this.Controls.Add(this._txtBxResultado);
            this.Controls.Add(this._txtBxApellido);
            this.Controls.Add(this._lblApellido);
            this.Controls.Add(this._lblNombre);
            this.Controls.Add(this._txtBxNombre);
            this.Name = "_frm1";
            this.Text = "Formulario Prueba";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtBxNombre;
        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.Label _lblApellido;
        private System.Windows.Forms.TextBox _txtBxApellido;
        private System.Windows.Forms.TextBox _txtBxResultado;
        private System.Windows.Forms.Button _bttnEnter;
        private System.Windows.Forms.Label _lblHeader;
    }
}

