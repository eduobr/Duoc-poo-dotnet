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

namespace Vista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DaoPaciente dao;
        public MainWindow()
        {
            InitializeComponent();

            cboSaludPaciente.ItemsSource= Enum.GetValues(typeof(TipoSalud));

            cboTipoPaciente.Items.Add("Seleccione");
            cboTipoPaciente.Items.Add("Adulto");
            cboTipoPaciente.Items.Add("Niño");

            dpFechaPaciente.SelectedDate = DateTime.Now;
            cboSaludPaciente.SelectedValue = TipoSalud.Fonasa;
            cboTipoPaciente.SelectedIndex = 0;
        }

        private void cboTipoPaciente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int indice = cboTipoPaciente.SelectedIndex;
           // MessageBox.Show("indice:"+ indice);
            switch (indice)
            {
                case 1:
                    gbAdulto.IsEnabled = true;
                    gbNiño.IsEnabled = false;
                    break;
                case 2:
                    gbAdulto.IsEnabled = false;
                    gbNiño.IsEnabled = true;
                    break;
                default:
                    gbAdulto.IsEnabled = false;
                    gbNiño.IsEnabled = false;
                    break;
            }
        }

        private void btnGrabar_Click(object sender, RoutedEventArgs e)
        {
            dao = new DaoPaciente();
            CL_PACIENTE paciente= null;
            if (cboTipoPaciente.SelectedIndex==1)
            {
                paciente = new CL_ADULTO();
            }
            if (cboTipoPaciente.SelectedIndex==2)
            {
                paciente = new CL_NINO();
            }
            if (cboTipoPaciente.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione Paciente");
                return;
            }
            int numero_ficha = 0;
            if (int.TryParse(txtNumeroFicha.Text,out numero_ficha))
            {
                paciente.NumeroFicha = numero_ficha;
            }
            else
            {
                MessageBox.Show("Ingrese un numeroi en numero FIcha");
                return;
            }
            paciente.Nombre = txtNombrePaciente.Text;
            paciente.Fecha = (DateTime)dpFechaPaciente.SelectedDate;
            paciente.Salud = (TipoSalud)cboSaludPaciente.SelectedValue;
            int edad = 0;
            if (int.TryParse(txtEdadPaciente.Text,out edad))
            {
                paciente.Edad = edad;
            }
        }
    }
}
