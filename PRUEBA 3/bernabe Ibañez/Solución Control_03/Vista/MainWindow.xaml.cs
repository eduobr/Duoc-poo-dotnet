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
using Biblioteca;

namespace Vista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        DaoBus flota = new DaoBus();
        public MainWindow()
        {

            InitializeComponent();
            cboTipodeBus.ItemsSource = Enum.GetValues(typeof(TipoBus));
            cboDestinoPais.ItemsSource = Enum.GetValues(typeof(TipoPais));
            dpkFecha.SelectedDate = DateTime.Today;
            cboTipodeBus.SelectedIndex = 0;

            if (cboTipodeBus.SelectedIndex==0)
            {
                txtCiudadD.IsEnabled = false;
                
                txtDireccion.IsEnabled = false;
                txtTerminal.IsEnabled = false;
            }

        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            int ho = 0;
            if (!int.TryParse(txtHora.Text.Trim(),out ho) && ho>=0 && ho<=59)
            {
                MessageBox.Show("Porfavor Ingrese una Hora Valida");
                return;
            }
            int mi = 0;
            if (!int.TryParse(txtMin.Text.Trim(), out mi) && mi >= 0 && mi <= 59)
            {
                MessageBox.Show("Porfavor Ingrese un Minuto Valida");
                return;
            }
            int pr = 0;
            if (!int.TryParse(txtPrecio.Text.Trim(),out pr))
            {
                MessageBox.Show("Porfavor Ingrese un precio Valido");
                return;
            }
            try
            {
                if (cboTipodeBus.SelectedIndex==1 || cboTipodeBus.SelectedIndex==2)
                {
                    if (cboTipodeBus.SelectedIndex==1)
                    {
                        DateTime dp=((DateTime)dpkFecha.SelectedDate);
                        DateTime x=new DateTime(
                            dp.Year,dp.Month,dp.Day,ho,mi,0);

                        InterNacional i = new InterNacional(txtPatente.Text,pr, txtNchofer.Text,x, (TipoBus)cboTipodeBus.SelectedItem, (TipoPais)cboDestinoPais.SelectedItem, txtCiudadD.Text);
                        flota.Agregar(i);
                    }
                    else
                    {
                        DateTime dp1 = ((DateTime)dpkFecha.SelectedDate);
                        DateTime x1 = new DateTime(
                            dp1.Year, dp1.Month, dp1.Day, ho, mi, 0);
                        Urbano ur = new Urbano(txtPatente.Text, pr, txtNchofer.Text, x1, (TipoBus)cboTipodeBus.SelectedItem, txtDireccion.Text, txtTerminal.Text);

                    }
                }
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }

        }
    }
}
