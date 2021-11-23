using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoClientes.WinForms
{
    public partial class FrmMaster : Form
    {

        //atrib serializ.

        public FrmMaster()
        {

            InitializeComponent();
        }
                

        private void _btnModuloCuentas_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCuentas cuen = new FrmCuentas(this);
                cuen.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCliente cli = new FrmCliente(this);
                cli.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
