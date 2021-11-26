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
                ValidacionesGenerales();
                //declaro a los atrib del "DropDown"
                TipoTarjetaEnum tipoTarj = (TipoTarjetaEnum)_cmbTipoTarjeta.SelectedItem;
                PeriodoEnum periodoEnum = (PeriodoEnum)_cmbPeriodoCierre.SelectedItem;
                Cliente cliente = (Cliente)_cmbCliente.SelectedItem;

                if (cliente != null) //Si el cliente está seleccionado
                {   //asigno al numero de tarjeta los atributos seleccionados por el usuario
                    //1.declaro el string
                    string nroTarj = _servicioTarjeta.CalculoPlastico(cliente, tipoTarj, periodoEnum);

                    //2.matcheo string con el texto del form
                    _txtNumPlastico.Text = nroTarj;
                }

            } catch(ClientesSinCuentaException ex)
            {
                MessageBox.Show("Cliente sin cuenta");
            }
            catch (ClientesSinLimiteException ex)
            {
                MessageBox.Show("Cliente sin limite disponible");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                ValidacionesGenerales();
                Validador.ValidacionInt(_txtNumPlastico); // dígitos del plástico depende del tipo tarjeta
                TipoTarjetaEnum tipoTarj = (TipoTarjetaEnum)_cmbTipoTarjeta.SelectedItem;
                PeriodoEnum periodoEnum = (PeriodoEnum)_cmbPeriodoCierre.SelectedItem;
                Cliente cliente = (Cliente)_cmbCliente.SelectedItem;
                string tarjeta = _txtNumPlastico.Text;
                double limite = Convert.ToDouble(_txtBxLimiteCompra.Text);
                _servicioTarjeta.Alta(tipoTarj, periodoEnum, cliente, tarjeta, limite);

                Carga();
                Limpiar();
                Recargar();

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


        private void ValidacionesGenerales()
        {            
            //declaro a los atrib para validar "DropDown"
            TipoTarjetaEnum tipoTarj = (TipoTarjetaEnum)_cmbTipoTarjeta.SelectedItem;
            PeriodoEnum periodoEnum = (PeriodoEnum)_cmbPeriodoCierre.SelectedItem;
            Cliente cliente = (Cliente)_cmbCliente.SelectedItem;

            //1ero valido que el usuario haya seleccionado alguna de las opciones mostradas
            if ((int)tipoTarj == 0)
            {
                throw new Exception("Seleccione una opcion");
            }
            if ((int)periodoEnum == 0)
            {
                throw new Exception("Seleccione una opcion");
            }
            if (cliente == null || cliente.id == 0)
            {
                throw new Exception("Seleccione una opcion");
            }

            Validador.ValidacionInt(_txtBxLimiteCompra);
            int limiteElegido = Convert.ToInt32(_txtBxLimiteCompra.Text);
            int limiteMax = 50000;
            if(limiteElegido > limiteMax)
                throw new Exception("El limite maximo es 50000");
        

        }

        
    }
}
