using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Biblioteca_Semestre_3;
namespace Vista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Pasajes_Aereos> PASAJES = new List<Pasajes_Aereos>();
        public MainWindow()
        {
            InitializeComponent();
            cboNaciDestino.ItemsSource = Enum.GetValues(typeof(TipoDestino));
            cboInterPais.ItemsSource = Enum.GetValues(typeof(TipoPais));
        }

        private void rbtNacional_Checked(object sender, RoutedEventArgs e)
        {
            gpNacional.IsEnabled = true;
            gpInternacional.IsEnabled = false;

        }

        private void rbtInternacional_Checked(object sender, RoutedEventArgs e)
        {
            gpInternacional.IsEnabled = true;
            gpNacional.IsEnabled = false;
        }

        private void txtCodigoP_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Pasajes_Aereos pasaje = null;
                if (cboInterPais.SelectedIndex == 1)
                {
                    pasaje = new Internacional();
                }
                else
                {
                    pasaje = new Nacional();
                }

                if (rbtInternacional.IsChecked == true)
                {
                    Internacional d1 = (Internacional)pasaje;
                    d1.NombrePasajero = txtNombrePa.Text;
                    d1.HoraPasaje = int.Parse(txtHoraPa.Text);
                    d1.Precio = int.Parse(txtPrecioPa.Text);
                    d1.CodigoPasaje = txtCodigoP.Text;
                    d1.ElPais = (TipoPais)cboInterPais.SelectedValue;
                    PASAJES.Add(d1);
                    MessageBox.Show("Agrego un Pasaje Internacional");
                }

                if (rbtNacional.IsChecked == true)
                {
                    Nacional n1 = (Nacional)pasaje;
                    n1.NombrePasajero = txtNombrePa.Text;
                    n1.HoraPasaje = int.Parse(txtHoraPa.Text);
                    n1.Precio = int.Parse(txtPrecioPa.Text);
                    n1.CodigoPasaje = txtCodigoP.Text;
                    n1.ElDestino = (TipoDestino)cboNaciDestino.SelectedValue;
                    PASAJES.Add(n1);
                    MessageBox.Show("Agrego un Pasaje Nacional");
                    return;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            dtgListado.Items.Clear();
            foreach (Pasajes_Aereos item in PASAJES)
            {
                if (item.GetType()==typeof(Internacional))
                {
                    dtgListado.Items.Add(((Internacional)item).imprimir());
                }
            }
        }

        private void btnLinQ_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                int max = PASAJES.Max(x => x.Precio);
                int min = PASAJES.Min(x => x.Precio);


                MessageBox.Show("Precio Maximo : " + max);
                MessageBox.Show("Precio Minimo : " + min);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        //string categoria = "";
        private void cboNaciDestino_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //categoria = cboNaciDestino.SelectedValue.ToString();
        }
        //string categoria1 = "";
        private void cboInterPais_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //categoria1 = cboInterPais.SelectedValue.ToString();
        }
    }
}
