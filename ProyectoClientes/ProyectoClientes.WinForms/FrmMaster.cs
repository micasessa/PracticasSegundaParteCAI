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
    public partial class FrmMaster : Form
    {
        private FrmListarCliente _formListaCliente;


        //atrib serializ.

        public FrmMaster()
        {
            //Instancio el atributo de listarCliente
            _formListaCliente = new FrmListarCliente(this);
            

            InitializeComponent();
        }

        private void btnListarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                _formListaCliente.Show();
                this.Hide();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // boton serializar/descer
        private void _btnSerialDescer(object sender, EventArgs e)
        {
            try
            {
                _frmSerializar.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

    }
}
