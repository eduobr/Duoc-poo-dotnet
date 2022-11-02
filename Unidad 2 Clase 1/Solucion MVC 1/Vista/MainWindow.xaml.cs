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
using Biblioteca_Modelo;
using Biblioteca_Controlador;

namespace Vista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DaoPersona dao;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCrearArreglo_Click(object sender, RoutedEventArgs e)
        {
            string tamaño=txtTamano.Text;
            int dimension = 0;
            if (int.TryParse(tamaño, out dimension))
            {
                dao = new DaoPersona(dimension);
                MessageBox.Show("Arreglo Creado");
            }
            else {
                MessageBox.Show("Ingrese solo Numeros");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, RoutedEventArgs e)
        {
            Cl_Persona persona = new Cl_Persona();
            try
            {
                persona.Rut = txtRut.Text;
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                persona.Edad = int.Parse(txtEdad.Text);
                persona.Sexo = char.Parse(cboSexo.Text.Substring(0, 1));
                bool resp = dao.Agregar(persona);
                if (resp)
                {
                    MessageBox.Show("Grabo");
                }
                else
                {
                    MessageBox.Show("Arreglo Lleno");
                }
            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
