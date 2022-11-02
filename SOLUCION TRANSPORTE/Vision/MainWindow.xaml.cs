using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BIBLIOTECA_CLASES;

namespace Vision
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Cl_Carga[] cargas = new Cl_Carga[5];
        int posicion = 0;

        Cl_Transporte transporte;
        Cl_Carga carga;
        public MainWindow()
        {
            InitializeComponent();
            cboCaja.ItemsSource = Enum.GetValues(typeof(TipoCaja));
            cboDestino.ItemsSource = Enum.GetValues(typeof(TipoDestino));
            cboMarca.ItemsSource = Enum.GetValues(typeof(MarcaCamion));
            cboTipo.ItemsSource = Enum.GetValues(typeof(TipoCarga));

            cboCaja.SelectedValue = TipoCaja.Manual;
            cboDestino.SelectedValue = TipoDestino.Centro;
            cboMarca.SelectedValue = MarcaCamion.Fiat;
            cboTipo.SelectedValue = TipoCarga.Nacional;


        }

        private void btnGrabarCamion_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                transporte = new Cl_Transporte();
                transporte.Patente = txtPatente.Text;
                transporte.Marca = (MarcaCamion)cboMarca.SelectedValue;
                transporte.CiudadOrigen = txtOrigen.Text;
                transporte.CiudadDestino = txtDestino.Text;
                transporte.Caja = (TipoCaja)cboCaja.SelectedValue;
                transporte.Acoplado = (rbtSi.IsChecked == true ? true : false);
                transporte.Chofer = txtChofer.Text;
                int tara = 0;
                if (int.TryParse(txtTara.Text, out tara))
                {
                    transporte.Tara = tara;
                }
                else
                {
                    MessageBox.Show("Ingrese un Numero en tara");
                    txtTara.Focus();
                }
                MessageBox.Show("Camion Ingresado");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnGrabarCarga_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                carga = new Cl_Carga();
                carga.Descripcion = txtDescripcion.Text;
                carga.Destino = (TipoDestino)cboDestino.SelectedValue;
                carga.Camion = transporte;
                carga.FechaEntrega = (DateTime)dpEntrega.SelectedDate;
                carga.FechaIngreso = (DateTime)dpIngreso.SelectedDate;
                carga.Tipo = (TipoCarga)cboTipo.SelectedValue;
                int peso = 0;
                if (int.TryParse(txtPeso.Text, out peso))
                {
                    carga.Peso = peso;
                }
                else
                {
                    MessageBox.Show("Ingrese un numero en peso");
                    txtPeso.Focus();
                }
                int valor = 0;
                if (int.TryParse(txtValor.Text, out valor))
                {
                    carga.Valor = valor;
                }
                else
                {
                    MessageBox.Show("ingrese un numero en valor");
                    txtValor.Focus();
                }
                if (posicion < 5)
                {
                    cargas[posicion] = carga;
                    MessageBox.Show("carga almacenada");
                    posicion++;
                }
                else {
                    MessageBox.Show("Arreglo Lleno");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
