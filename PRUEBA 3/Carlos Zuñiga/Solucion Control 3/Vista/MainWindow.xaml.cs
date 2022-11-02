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
    public partial class MainWindow : Window
    {
        Cl_Dao dao;
        Cl_Buses bus;
        Cl_Internacional internacional;
        Cl_Nacional nacional;

        public MainWindow()
        {
            InitializeComponent();
            cboDestino.Items.Add("Seleccione");
            cboDestino.Items.Add("Nacional");
            cboDestino.Items.Add("Internacional");
            cboDestino.SelectedIndex = 0;
            cboPais.ItemsSource = Enum.GetValues(typeof(TipoPais));
            cboPais.SelectedIndex = 0;
            cboRegion.ItemsSource = Enum.GetValues(typeof(TipoRegion));
            cboRegion.SelectedIndex = 0;

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {

            if (cboDestino.SelectedValue.Equals("Nacional"))
            {
                nacional = new Cl_Nacional();
                nacional.Patente = txtPatente.Text;
                nacional.NombreChofer = txtChofer.Text;
                nacional.Fecha = (DateTime)dpFecha.SelectedDate;
                nacional.Precio = int.Parse(txtPrecio.Text);
                nacional.Region = (TipoRegion)cboRegion.SelectedIndex;
                nacional.Terminal = txtTerminal.Text;
                dao.Agregar(nacional);
            }
          
            
        }
    }
}
