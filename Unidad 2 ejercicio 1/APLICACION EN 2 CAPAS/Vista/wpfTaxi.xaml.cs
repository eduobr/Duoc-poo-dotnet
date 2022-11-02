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
using System.Windows.Shapes;
using BIBLIOTECA_EJERCICIO;

namespace Vista
{
    /// <summary>
    /// Lógica de interacción para wpfTaxi.xaml
    /// </summary>
    public partial class wpfTaxi : Window
    {
        Cl_Taxi[] taxi = new Cl_Taxi[5];
        int Pos = 0;
        public wpfTaxi()
        {
            InitializeComponent();
            cboMarca.ItemsSource = Enum.GetValues(typeof(TipoMarca));
            cboModelo.ItemsSource = Enum.GetValues(typeof(TipoModelo));
            cboCiudad.ItemsSource = Enum.GetValues(typeof(TipoCiudad));

            cboMarca.SelectedValue = TipoMarca.Chevrolet;
            cboModelo.SelectedValue = TipoModelo.Sedan;
            cboCiudad.SelectedValue = TipoCiudad.Santiago;


        }

        private void btnGrabar_Click(object sender, RoutedEventArgs e)
        {
            if (Pos<5)
            {
                try
                {
                    Cl_Taxi t = new Cl_Taxi();
                    t.Patente = txtPatente.Text;
                    t.Marca = (TipoMarca)cboMarca.SelectedValue;
                    t.Modelo = (TipoModelo)cboModelo.SelectedValue;
                    t.Ciudad = (TipoCiudad)cboCiudad.SelectedValue;
                    int ValorKM;
                    if (int.TryParse(txtValoKM.Text, out ValorKM))
                    {
                        t.ValorKM = int.Parse(txtValoKM.Text);
                    }
                    else {
                        MessageBox.Show("Ingrese un numero");
                        return;
                    }
                        
                    t.Puertas = rbt4.IsChecked == true ? 4 : 5;

                    taxi[Pos] = t;
                    MessageBox.Show("Taxi Grabado "+t.Patente);
                    Pos++;
                    Limpiar();
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                }
            }
        }
        private void Limpiar() {
            txtPatente.Clear(); txtValoKM.Clear();
            cboCiudad.SelectedValue = TipoCiudad.Santiago;
            cboMarca.SelectedValue = TipoMarca.Chevrolet;
            cboModelo.SelectedValue = TipoModelo.Sedan;
            rbt4.IsChecked = true;
        
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            lstTaxi.Items.Clear();
            foreach (Cl_Taxi item in taxi)
            {
                if (item != null)
                {
                    lstTaxi.Items.Add(item.Imprimir());
                }
            }
        }
    }
}
