using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClientes.Entidades;
using ProyectoClientes.Negocio;
using Newtonsoft.Json;

namespace ProyectoClientes.WinForms
{
    public partial class FrmPersona : Form
    {
        public FrmPersona()
        {
            InitializeComponent();
        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {

        }

        private void _btnResultado_Click(object sender, EventArgs e)
        {
            if (this._txtNombre.Text != string.Empty || this._txtApellido.Text != string.Empty)
            {
                Persona p = new Persona(this._txtNombre.Text, this._txtApellido.Text);

                _txtResultado.Text = p.ToString();
            }
            else
            {
                MessageBox.Show("Nombre o Apellido no pueden ser vacío");
            }
        }

        private void _btnLimpiar_Click(object sender, EventArgs e)
        {
            this._txtResultado.Text = string.Empty;
            this._txtNombre.Text = string.Empty;
            this._txtApellido.Text = string.Empty;
        }
    }
}
