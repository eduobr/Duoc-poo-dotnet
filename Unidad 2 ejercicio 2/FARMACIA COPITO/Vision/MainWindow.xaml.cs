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
using BIBLIOTECA_DE_CLASES;

namespace Vision
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cboCategoria.ItemsSource = Enum.GetValues(typeof(TipoCategoria));
            cboSalud.ItemsSource = Enum.GetValues(typeof(TipoCliente));
            lblFechaVenta.Content = "Fecha Venta:"+DateTime.Now.ToString("dd/MM/yyyy");
        }

        Cl_Producto prod;
        int PosProd = 0;
        private void btnGrabarProducto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                prod = new Cl_Producto();
                prod.Numero = PosProd;
                prod.FechaIngreso = (DateTime)dpFechaIngreso.SelectedDate;
                prod.Descripcion = txtDescripcion.Text;
                prod.Categoria = (TipoCategoria)cboCategoria.SelectedValue;
                prod.Valor = int.Parse(txtValor.Text);
                prod.Cantidad = int.Parse(txtCantidad.Text);
                lblImpuesto.Content = "Impuesto: " + prod.Impuesto;
                MessageBox.Show("Producto Grabado");
                PosProd++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
