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
using BIBLIOTECA;
namespace VISTA
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<CL_BUS> buses = new List<CL_BUS>();

        public MainWindow()
        {
            InitializeComponent();

            cboTipoBus.Items.Add("Seleccione");
            cboTipoBus.Items.Add("Internacional");
            cboTipoBus.Items.Add("Nacional");
            cboDestino.ItemsSource = Enum.GetValues(typeof(TipoDestino));
            cboPais.ItemsSource = Enum.GetValues(typeof(TipoPais));

            cboTipoBus.SelectedIndex = 0;
            cboPais.SelectedIndex = 0;
            cboDestino.SelectedIndex = 0;
        }

        private void cboTipoBus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int indice = cboTipoBus.SelectedIndex;
            switch (indice)
            {
                case 1:
                    gbInternacional.IsEnabled = true;gbNacional.IsEnabled=false;
                    break;
                case 2:
                    gbInternacional.IsEnabled = false;gbNacional.IsEnabled=true;
                    break;
                default:
                    gbInternacional.IsEnabled = false;gbNacional.IsEnabled=false;
                    break;
            }
        }

        private void btnGrabar_Click(object sender, RoutedEventArgs e)
        {
            CL_BUS bus = null;
            if (cboTipoBus.SelectedIndex==0)
            {
                MessageBox.Show("seleccione bus"); return;
            }

            if (cboTipoBus.SelectedIndex == 1)
            {
                bus = new CL_INTERNACIONAL();
            }
            else {
                bus = new CL_URBANO();
            }
            bus.Patente = txtPatente.Text;
            bus.Chofer = txtChofer.Text;
            int hora = 0;
            if (int.TryParse(txtHora.Text,out hora))
            {
                bus.Hora = hora;
            }
            else
            {
                MessageBox.Show("hora mala"); return;
            }
            int precio= 0;
            if (int.TryParse(txtPrecio.Text, out precio))
            {
                bus.Precio= precio;
            }
            else
            {
                MessageBox.Show("precio malo"); return;
            }
            bus.Fecha = (DateTime)dpFecha.SelectedDate;
            if (cboTipoBus.SelectedIndex==1)
            {
                CL_INTERNACIONAL inter = (CL_INTERNACIONAL)bus;
                inter.Pais = (TipoPais)cboPais.SelectedValue;
                inter.Ciudad = txtCiudad.Text;

                buses.Add(inter);
                MessageBox.Show("grabado internacional");
            }
            else
            {
                CL_URBANO urb = (CL_URBANO)bus;
                urb.Terminal = txtTerminal.Text;
                urb.Destino = (TipoDestino)cboDestino.SelectedValue;

                buses.Add(urb);
                MessageBox.Show("grabado urbano");
            }
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            lstListado.Items.Clear();
            foreach (CL_BUS item in buses)
            {
                if (item.GetType() == typeof(CL_INTERNACIONAL))
                {
                    lstListado.Items.Add(((CL_INTERNACIONAL)item).Imprimir());
                }
                else {
                    lstListado.Items.Add(((CL_URBANO)item).Imprimir());
                }
            }
        }

        private void btnEstadisticas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lstEstadisticas.Items.Clear();
                int mayor_precio = buses.Max(b => b.Precio);
                int menor_precio = buses.Min(b => b.Precio);
                int cant_inter = buses.
                    Where(b => b.GetType() == typeof(CL_INTERNACIONAL)).                    
                    Count();
                int cant_urb_sur = buses.
                    Where(b => b.GetType() == typeof(CL_URBANO) 
                        && ((CL_URBANO)b).Destino == TipoDestino.Sur).Count();
                lstEstadisticas.Items.Add("Mayor Precio Pasaje:" + mayor_precio);
                lstEstadisticas.Items.Add("Menor Precio Pasaje:" + menor_precio);
                lstEstadisticas.Items.Add("Cantidad Pasajes Inter:" + cant_inter);
                lstEstadisticas.Items.Add("Urbanos destino sur:" + cant_urb_sur);
            }
            catch (Exception)
            {
                
                
            }
        }
    }
}
