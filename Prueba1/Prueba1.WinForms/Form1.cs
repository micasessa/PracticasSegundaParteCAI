using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1.WinForms
{
    public partial class _frm1 : Form
    {
        public _frm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void _bttnEnter_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this._txtBxNombre.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
