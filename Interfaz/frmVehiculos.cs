using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Interfaz
{
    public partial class frmVehiculos : Form
    {
        private VehiculoServicio _vehiculoServicio;
        public frmVehiculos()
        {
            this._vehiculoServicio = new VehiculoServicio();
            InitializeComponent();
        }
        #region "Métodos"
        private void CargarMarcas()
        {
            cmbMarca.DataSource = null;
            List<String> marcas = new List<String>();
            marcas.Add("Fiat");
            marcas.Add("Peugeot");
            marcas.Add("Audi");
            cmbMarca.DataSource = marcas;
        }
        private void CargarPuertas()
        {
            cmbPuertas.DataSource = null;
            List<String> puertas = new List<String>();
            puertas.Add("2");
            puertas.Add("3");
            puertas.Add("4");
            puertas.Add("5");
            cmbMarca.DataSource = puertas;
        }
        private void CargarTitulares(List<String> titulares)
        {
            cmbMarca.DataSource = null;
            cmbMarca.DataSource = titulares;
        }
        private void CargarListaVehiculos(List<Vehiculo> vehiculos)
        {
            lstVehiculos.DataSource = null;
            lstVehiculos.DataSource = vehiculos;
        }
        private void LimpiarCampos()
        {
            txtPatente.Text = string.Empty;
            cmbMarca.SelectedIndex = -1;
            txtModelo.Text = string.Empty;
            cmbPuertas.SelectedIndex = -1;
            txtTitular.Text = string.Empty;
            lstVehiculos.SelectedIndex = -1;
        }
        private void CompletarFormulario(Vehiculo seleccionado)
        {
            txtPatente.Text = seleccionado.Patente;
            cmbMarca.Text = seleccionado.Marca;
            txtModelo.Text = seleccionado.Modelo;
            cmbPuertas.Text = seleccionado.Puertas.ToString();
            txtTitular.Text = seleccionado.Titular;
        }
        #endregion
        private void Vehiculos_Load(object sender, EventArgs e)
        {
            //CargarListaVehiculos(_vehiculoServicio.TraerVehiculos());
            CargarMarcas();
            CargarPuertas();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                string patente = txtPatente.Text;
                string marca = cmbMarca.Text;
                string modelo = txtModelo.Text;
                int puertas = Convert.ToInt32(cmbPuertas.Text);
                string titular = txtTitular.Text;
                this._vehiculoServicio.AltaVehiculo(patente, marca, modelo, puertas, titular);
                MessageBox.Show("El vehículo se dio de alta exitosamente");
                LimpiarCampos();
                CargarListaVehiculos(_vehiculoServicio.TraerVehiculos());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message);
            }
        }

        private void frmVehiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo);
            if (pregunta.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void lstVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehiculo seleccionado = (Vehiculo)lstVehiculos.SelectedItem;
            if (seleccionado != null)
            {
                CompletarFormulario(seleccionado);
            }
        }
    }
}
