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
        DaoPaciente dao;

        public MainWindow()
        {
            InitializeComponent();
            cboSalud.ItemsSource = Enum.GetValues(typeof(TipoSalud));
            cboTipoPaciente.Items.Add("Seleccione");
            cboTipoPaciente.Items.Add("Adulto");
            cboTipoPaciente.Items.Add("Niño");
            dpFecha.SelectedDate = DateTime.Now;
            cboSalud.SelectedValue = TipoSalud.Fonasa;
            cboTipoPaciente.SelectedIndex = 0;

        }

        private void cboTipoPaciente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int indice = cboTipoPaciente.SelectedIndex;
            //MessageBox.Show("indice:" + indice);
            switch (indice)
            {
                case 1:
                    gbAdulto.IsEnabled = true;
                    gbNino.IsEnabled = false;
                    break;
                case 2:
                    gbAdulto.IsEnabled = false;
                    gbNino.IsEnabled = true;
                    break;
                default:
                    gbAdulto.IsEnabled = false;
                    gbNino.IsEnabled = false;
                    break;
            }
        }

        private void btnGrabar_Click(object sender, RoutedEventArgs e)
        {
            dao = new DaoPaciente();

            CL_PACIENTE paciente = null;
            if (cboTipoPaciente.SelectedIndex == 1)
            {
                paciente = new CL_ADULTO();
            }
            else
            {
                paciente = new CL_NINO();
            }

            if (cboTipoPaciente.SelectedIndex == 0)
            {
                MessageBox.Show("seleccione un paciente");
                return;
            }
            int numero_ficha = 0;
            if (int.TryParse(txtFicha.Text, out numero_ficha))
            {
                paciente.NumeroFicha = numero_ficha;
            }
            else
            {
                MessageBox.Show("ingrese un numero en Numero Ficha");
                return;
            }
            paciente.Nombre = txtNombre.Text;
            paciente.Fecha = (DateTime)dpFecha.SelectedDate;
            paciente.Salud = (TipoSalud)cboSalud.SelectedValue;
            int edad = 0;
            if (int.TryParse(txtEdad.Text, out edad))
            {
                paciente.Edad = edad;
            }
            else
            {
                MessageBox.Show("ingrese numero en edad");
                return;
            }
            int hora = 0;
            if (int.TryParse(txtHora.Text, out hora))
            {
                paciente.Hora = hora;
            }
            else
            {
                MessageBox.Show("ingrese un numero en hora");
                return;
            }

            //DETERMINAR EL TIPO DE PACIENTE
            bool resp = false;
            if (cboTipoPaciente.SelectedIndex == 1)
            {
                CL_ADULTO ADULTO = (CL_ADULTO)paciente;
                ADULTO.Trabajo = txtTrabajo.Text;
                resp = dao.Agregar(ADULTO);
            }
            else
            {
                CL_NINO NINO = (CL_NINO)paciente;
                NINO.Colegio = txtColegio.Text;
                resp = dao.Agregar(NINO);
            }

            if (resp)
            {
                MessageBox.Show("GRABO PACIENTE"); Listar(); Limpiar();
            }
            else
            {
                MessageBox.Show("EL PACIENTE YA EXISTE");
            }

        }

        private void Limpiar()
        {
            txtColegio.Clear(); txtEdad.Clear(); txtFicha.Clear(); txtHora.Clear(); txtNombre.Clear(); txtTrabajo.Clear();
            cboSalud.SelectedIndex = 0; cboTipoPaciente.SelectedIndex = 0; dpFecha.SelectedDate = DateTime.Now;
            gbAdulto.IsEnabled = false; gbNino.IsEnabled = false;
        }

        private void Listar()
        {
            lstListado.Items.Clear();
            foreach (CL_PACIENTE item in dao.Listar())
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("\n Numero Ficha"+item.NumeroFicha);
                sb.Append("\n Nombre:"+item.Nombre);
                sb.Append("\n Edad:" + item.Edad);
                sb.Append("\n Doctor:" + item.NombreDoctor());
                sb.Append("\n Costo Aten:"+item.ValorAtencion());
                sb.Append("\n "+new string('-',25));
                lstListado.Items.Add(sb.ToString());
            }
        }

        private void btnEstadisticas_Click(object sender, RoutedEventArgs e)
        {
            lblLinQ1.Content = "" + dao.MayorFechaAtencion();
            lblLinQ2.Content = "" + dao.MenorFechaAtencion();
            lblLinQ3.Content = "" + dao.MayoresIsapre();
            lblLinQ4.Content = "" + dao.AdultosMenores13();
        }
    }
}
