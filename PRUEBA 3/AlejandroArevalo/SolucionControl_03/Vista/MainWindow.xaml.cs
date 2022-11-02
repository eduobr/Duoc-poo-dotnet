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
using BibClases;
namespace Vista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Bus> viajes = new List<Bus>();
        public MainWindow()
        {
            InitializeComponent();
            cboPaisDestino.ItemsSource = Enum.GetValues(typeof(TipoPais));
            cboPaisDestino.SelectedIndex = 0;
            cboRegion.ItemsSource = Enum.GetValues(typeof(TipoRegion));
            cboRegion.SelectedIndex = 0;
            cboTipoViaje.ItemsSource = Enum.GetValues(typeof(TipoViaje));
            cboTipoViaje.SelectedIndex = 0;
            for (int i = 0; i < 24; i++)
            {
                cboHora.Items.Add((i < 10) ? "0" + i.ToString() : i.ToString());
            }
            cboHora.SelectedIndex = 0;
            for (int i = 0; i < 60; i += 5)
            {
                cboMin.Items.Add((i < 10) ? "0" + i.ToString() : i.ToString());
            }
            cboMin.SelectedIndex = 0;
            dpFecha.SelectedDate = DateTime.Today;
        }

        private void cboTipoViaje_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch ((TipoViaje)cboTipoViaje.SelectedItem)
            {
                case TipoViaje.Seleccione:
                    gbInternacional.IsEnabled = false;
                    gbUrbano.IsEnabled = false;
                    break;
                case TipoViaje.Internacional:
                    gbInternacional.IsEnabled = true;
                    gbUrbano.IsEnabled = false;
                    break;
                case TipoViaje.Urbano:
                    gbInternacional.IsEnabled = false;
                    gbUrbano.IsEnabled = true;
                    break;
            }
        }

        private void btnGrabar_Click(object sender, RoutedEventArgs e)
        {
            int precio = 0;
            if (!int.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("El precio debe ser numérico.");
                return;
            }
            int anio = ((DateTime)dpFecha.SelectedDate).Year;
            int mes = ((DateTime)dpFecha.SelectedDate).Month;
            int dia = ((DateTime)dpFecha.SelectedDate).Day;
            switch ((TipoViaje)cboTipoViaje.SelectedItem)
            {
                case TipoViaje.Seleccione:
                    MessageBox.Show("Debe Seleccionar un Tipo de Viaje.");
                    return;
                case TipoViaje.Internacional:
                    Internacional viajeInt = new Internacional();
                    switch ((TipoPais)cboPaisDestino.SelectedItem)
                    {
                        case TipoPais.Seleccione:
                            MessageBox.Show("Debe Seleccionar un País de Destino.");
                            return;
                        default:
                            viajeInt.CiudadDestino = txtCiudadDestino.Text;
                            viajeInt.FechaHora = new DateTime(anio, mes, dia, cboHora.SelectedIndex, cboMin.SelectedIndex, 0);
                            viajeInt.NombreChofer = txtNombreChofer.Text;
                            viajeInt.PaisDestino = (TipoPais)cboPaisDestino.SelectedItem;
                            viajeInt.Patente = txtPatente.Text;
                            viajeInt.Precio = precio;
                            viajeInt.Tipo = (TipoViaje)cboTipoViaje.SelectedItem;
                            ActDatos(viajeInt);
                            LimpiarDatos();
                            break;
                    }
                    break;
                case TipoViaje.Urbano:
                    Urbano viajeUrb = new Urbano();
                    switch ((TipoRegion)cboRegion.SelectedItem)
                    {
                        case TipoRegion.Seleccione:
                            MessageBox.Show("Debe Seleccionar una Región.");
                            return;
                        default:
                            viajeUrb.FechaHora = new DateTime(anio, mes, dia, cboHora.SelectedIndex, cboMin.SelectedIndex, 0);
                            viajeUrb.NombreChofer = txtNombreChofer.Text;
                            viajeUrb.Patente = txtPatente.Text;
                            viajeUrb.Precio = precio;
                            viajeUrb.RegionDestino = (TipoRegion)cboRegion.SelectedItem;
                            viajeUrb.Terminal = txtTerminal.Text;
                            viajeUrb.Tipo = (TipoViaje)cboTipoViaje.SelectedItem;
                            ActDatos(viajeUrb);
                            LimpiarDatos();
                            break;
                    }
                    break;
            }
        }

        private void LimpiarDatos()
        {
            txtCiudadDestino.Clear();
            txtNombreChofer.Clear();
            txtPatente.Clear();
            txtPrecio.Clear();
            txtTerminal.Clear();
            cboPaisDestino.SelectedIndex = 0;
            cboRegion.SelectedIndex = 0;
            cboTipoViaje.SelectedIndex = 0;
            cboHora.SelectedIndex = 0;
            cboMin.SelectedIndex = 0;
            dpFecha.SelectedDate = DateTime.Today;
        }

        private void ActDatos(Bus viaje)
        {
            viajes.Add(viaje);
            dgViajes.ItemsSource = viajes;
            dgViajes.Items.Refresh();
            lblMayorPrecio.Content = viajes.Max(v => v.Precio).ToString();
            lblMenorPrecio.Content = viajes.Min(v => v.Precio).ToString();
            lblTotalInt.Content = viajes.Where(v => v.GetType() == typeof(Internacional)).Count().ToString();
            lblUrbanosSur.Content = viajes.Where(v => v.GetType() == typeof(Urbano) && ((Urbano)v).RegionDestino == TipoRegion.Sur).Count().ToString();
        }

        private void dgViajes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgViajes.SelectedIndex > -1)
            {
                if (dgViajes.SelectedItem.GetType() == typeof(Internacional))
                {
                    lblPrecioTotal.Content = ((Internacional)dgViajes.SelectedItem).PrecioTotal.ToString();
                    lblTiempoDemora.Content = ((Internacional)dgViajes.SelectedItem).TiempoDemora.ToString();
                }
                if (dgViajes.SelectedItem.GetType() == typeof(Urbano))
                {
                    lblPrecioTotal.Content = ((Urbano)dgViajes.SelectedItem).PrecioTotal.ToString();
                    lblTiempoDemora.Content = ((Urbano)dgViajes.SelectedItem).TiempoDemora.ToString();
                }
            }
        }

        private void dpFecha_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dpFecha.SelectedDate<DateTime.Today)
            {
                MessageBox.Show("La Fecha no puede ser inferior a la fecha actual.");
                dpFecha.SelectedDate = DateTime.Today;
            }
        }
    }
}
