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
using CONTROLADOR;
namespace VISTA
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DaoPersona dao_Persona = new DaoPersona();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGrabarGerente_Click(object sender, RoutedEventArgs e)
        {
            Cl_Gerente gerente = new Cl_Gerente();
            gerente.Nombre = txtNombre.Text;
            gerente.Apellido = txtApellido.Text;
            gerente.Edad = int.Parse(txtEdad.Text);
            gerente.Sucursal = txtSucursal.Text;
            gerente.Region = txtRegion.Text;
            gerente.Ciudad = txtCiudad.Text;

            bool resp = dao_Persona.Agregar(gerente);
            MessageBox.Show("Grabo Correctamente");
            lstListado.Items.Clear();
            foreach (Cl_Persona item in dao_Persona.Listar())
            {
                if (item.GetType() == typeof(Cl_Gerente))
                {
                    lstListado.Items.Add(((Cl_Gerente)item).Imprimir());
                }

                if (item.GetType() == typeof(Cl_Empleado))
                {
                    lstListado.Items.Add(((Cl_Empleado)item).Imprimir());
                }

            }
        }

        private void btnGrabarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            Cl_Empleado empleado = new Cl_Empleado();
            empleado.Nombre = txtNombre.Text;
            empleado.Apellido = txtApellido.Text;
            empleado.Edad = int.Parse(txtEdad.Text);
            empleado.FechaIngreso = (DateTime)dpFechaIngreso.SelectedDate;
            empleado.Cargo = txtCargo.Text;
            empleado.Salario = int.Parse(txtSalario.Text);
            dao_Persona.Agregar(empleado);

            lstListado.Items.Clear();
            foreach (Cl_Persona item in dao_Persona.Listar())
            {
                if (item.GetType() == typeof(Cl_Gerente))
                {
                    lstListado.Items.Add(((Cl_Gerente)item).Imprimir());
                }

                if (item.GetType() == typeof(Cl_Empleado))
                {
                    lstListado.Items.Add(((Cl_Empleado)item).Imprimir());
                }

            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            bool resp = dao_Persona.Eliminar(txtElimnaNomb.Text);
            if (resp == true)
            {
                MessageBox.Show("Elimino Correctamente");
                lstListado.Items.Clear();
                foreach (Cl_Persona item in dao_Persona.Listar())
                {
                    if (item.GetType() == typeof(Cl_Gerente))
                    {
                        lstListado.Items.Add(((Cl_Gerente)item).Imprimir());
                    }
                    if (item.GetType() == typeof(Cl_Empleado))
                    {
                        lstListado.Items.Add(((Cl_Empleado)item).Imprimir());
                    }

                }
            }
            else
            {
                MessageBox.Show("No Elimino");
            }
        }

        
    }
}
