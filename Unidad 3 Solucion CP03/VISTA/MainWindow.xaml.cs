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
        List<CL_PELICULA> lista = new List<CL_PELICULA>();
        public MainWindow()
        {
            InitializeComponent();
            cboTipoP.Items.Add("Seleccione");
            cboTipoP.Items.Add("DVD");
            cboTipoP.Items.Add("BlueRay");
            cboTipoP.SelectedIndex = 0;
        }

        private void cboTipoP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int indice = cboTipoP.SelectedIndex;
            switch (indice)
            {
                case 1:
                    gbDvd.IsEnabled = true;
                    gbBlue.IsEnabled = false;
                    break;
                default:
                    gbDvd.IsEnabled = false;
                    gbBlue.IsEnabled = true;
                    break;
            }
        }

        private void btnGrabar_Click(object sender, RoutedEventArgs e)
        {
            if (cboTipoP.SelectedIndex==0)
            {
                MessageBox.Show("Seleccione un tipo de pelicula");
                return;
            }
            CL_PELICULA pel = null;

            if (cboTipoP.SelectedIndex == 1)
            {
                pel = new CL_DVD();
            }
            else
            {
                pel = new CL_BLUERAY();
            }

            pel.Titulo = txtTitulo.Text;
            int ano = 0;
            if (int.TryParse(txtAnno.Text, out ano))
            {
                pel.Anno = ano;
            }
            else
            {
                MessageBox.Show("Ingrese un numero en año");
                return;
            }
            int cens = 0;
            if (int.TryParse(txtCensura.Text, out cens))
            {
                pel.Censura = cens;
            }
            else
            {
                MessageBox.Show("Ingrese un numero en censura");
                return;
            }

            if (cboTipoP.SelectedIndex == 1)
            {
                CL_DVD dvd = (CL_DVD)pel;
                int cantidadM = 0;
                if (int.TryParse(txtCantidadM.Text, out cantidadM))
                {
                    dvd.CantidadM = cantidadM;
                }
                else
                {
                    MessageBox.Show("Ingrese un numero en cantidad de minutos");
                    return;
                }
                lista.Add(dvd);
                MessageBox.Show("Grabado");
            }
            else
            {
                CL_BLUERAY blue = (CL_BLUERAY)pel;
                int cantidadC = 0;
                if (int.TryParse(txtCantidadC.Text, out cantidadC))
                {
                    blue.CantidadC = cantidadC;
                }
                else
                {
                    MessageBox.Show("Ingrese un numero en la cantidad de Camaras");
                    return;
                }
                lista.Add(blue);
                MessageBox.Show("Grabado");
            }
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            lstListado.Items.Clear();
            foreach (CL_PELICULA item in lista)
            {
                lstListado.Items.Add(item.Imprimir());
                if (item.GetType() == typeof(CL_DVD))
                {
                    lstListado.Items.Add("Cantidad de Minutos: " + ((CL_DVD)item).CantidadM);
                    lstListado.Items.Add("Actualizacion: " + ((CL_DVD)item).Actualizacion);
                    lstListado.Items.Add("Duplicado: " + ((CL_DVD)item).Duplicado());
                }
                if (item.GetType() == typeof(CL_BLUERAY))
                {
                    lstListado.Items.Add("Cantidad de camaras: "+((CL_BLUERAY)item).CantidadC);
                    lstListado.Items.Add("Actualizacion: " + ((CL_BLUERAY)item).Actualizacion);
                    lstListado.Items.Add("Duplicado: " + ((CL_BLUERAY)item).Duplicado());
                }
            }
        }


    }
}
