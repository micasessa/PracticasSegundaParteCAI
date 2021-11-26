using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioTarjetaCredito.Entidades.Enum;
using EjercicioTarjetaCredito.Entidades.Excepciones;
using EjercicioTarjetaCredito.Entidades;
using EjercicioTarjetaCredito.Negocio;


namespace EjercicioTarjetaCredito.WinForms
{
    public partial class FrmTarjetaCredito : Form
    {
        private ClienteNegocio _servicioCliente;
        private TarjetaCreditoNegocio _servicioTarjeta;
        private List<TarjetaCredito> _listaTarjetas;
        public FrmTarjetaCredito()
        {
            _servicioCliente = new ClienteNegocio();
            _servicioTarjeta = new TarjetaCreditoNegocio();
            _listaTarjetas = new List<TarjetaCredito>();

            InitializeComponent();
        }

        private void FrmTarjetaCredito_Load(object sender, EventArgs e)
        {
            Carga();
            Limpiar();
            Recargar();
        }

        private void _btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _btnAlta_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void Carga()
        {   //Como traer con clases ENUM:
            _cmbTipoTarjeta.DataSource = Enum.GetValues(typeof(TipoTarjetaEnum));
            _cmbPeriodoCierre.DataSource = Enum.GetValues(typeof(PeriodoEnum));

            //Como traer clientes
            _cmbCliente.DataSource = null;
            _cmbCliente.DataSource = _servicioCliente.GetClientes();
            _cmbCliente.DisplayMember = "Display Cliente";
            _cmbCliente.ValueMember = "Id";
        }

        private void Limpiar()
        {
            _cmbTipoTarjeta.SelectedIndex = 0;
            _cmbPeriodoCierre.SelectedIndex = 0;
            _txtBxLimiteCompra.Clear();
            _txtNumPlastico.Clear();
            _txtCantPlasticoEmitidos.Clear();
            _txtLimitePromedio.Clear();

        }

        private void Recargar()
        {
            RecargarLista();
            RecargarCalculo();
        }

        private void RecargarCalculo()
        {
            OperadorFormulario operador = new OperadorFormulario(_listaTarjetas);
            _txtCantPlasticoEmitidos.Text = operador.Cantidad.ToString();
            _txtLimitePromedio.Text = operador.LimitePromedio.ToString();
        }

        private void RecargarLista()
        {
            _listaTarjetas = _servicioTarjeta.TraerTodas();
            _lstTarjetas.DataSource = null;
            _lstTarjetas.DataSource = _listaTarjetas;
        }

        private void ValidacionesCalculos()
        {

        }
    }
}
