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
        List<CL_LIBRO> lista = new List<CL_LIBRO>();

        public MainWindow()
        {
            InitializeComponent();
            cboTipoLibro.Items.Add("Seleccione");
            cboTipoLibro.Items.Add("Impreso");
            cboTipoLibro.Items.Add("Digital");
            cboTipoLibro.SelectedIndex = 0;//por defecto "Seleccione"
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void cboTipoLibro_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int indice = cboTipoLibro.SelectedIndex;
            switch (indice)
            {
                case 1:
                    gbImpreso.IsEnabled = true;gbDigital.IsEnabled=false;
                    break;
                case 2:
                    gbImpreso.IsEnabled = false;gbDigital.IsEnabled=true;
                    break;
                default:
                    gbImpreso.IsEnabled = false;gbDigital.IsEnabled=false;
                    break;
            }
        }

        private void btnGrabar_Click(object sender, RoutedEventArgs e)
        {
            //definir el tipo dependiendo de la seleccion del combo
            if (cboTipoLibro.SelectedIndex==0)
            {
                MessageBox.Show("Seleccione un tipo de libro");
                return;
            }

            CL_LIBRO lib = null;

            if (cboTipoLibro.SelectedIndex == 1)
            {
                lib = new CL_IMPRESO();
            }
            else
            {
                lib = new CL_DIGITAL();
            }
            //cargar los datos basicos
            lib.NombreAutor = txtAutor.Text;
            lib.Titulo = txtTitulo.Text;
            int ano = 0;
            if (int.TryParse(txtAño.Text, out ano))
            {
                lib.Anno = ano;
            }
            else
            {
                MessageBox.Show("ingrese un numero en año"); return;
            }
            //cargar datos dependiendo del tipo
            if (cboTipoLibro.SelectedIndex == 1)
            {
                CL_IMPRESO imp = (CL_IMPRESO)lib;
                int cantidad_paginas = 0;
                if (int.TryParse(txtCantidadPaginas.Text, out cantidad_paginas))
                {
                    imp.CantidadPaginas = cantidad_paginas;
                }
                else
                {
                    MessageBox.Show("ingrese un numero en cantidad de paginas"); return;
                }
                lista.Add(imp);
                MessageBox.Show("GRABADO");
            }
            else
            {
                CL_DIGITAL dig = (CL_DIGITAL)lib;
                int cantidadMB = 0;
                if (int.TryParse(txtTamanoMB.Text, out cantidadMB))
                {
                    dig.Tamano = cantidadMB;
                }
                else
                {
                    MessageBox.Show("ingrese un numero en cantidad MB"); return;
                }
                lista.Add(dig);
                MessageBox.Show("grabado");
            }
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            lstListado.Items.Clear();
            foreach (CL_LIBRO item in lista)
            {
                lstListado.Items.Add(item.Imprimir());
                if (item.GetType() == typeof(CL_IMPRESO))
                {
                    lstListado.Items.Add("Cantidad Paginas:" + ((CL_IMPRESO)item).CantidadPaginas);
                    lstListado.Items.Add("Renovacion:" + ((CL_IMPRESO)item).Renovacion);
                    lstListado.Items.Add("Reproduccion" + ((CL_IMPRESO)item).Reproduccion());
                }
                else
                {
                    lstListado.Items.Add("Tamaño MB:" + ((CL_DIGITAL)item).Tamano);
                    lstListado.Items.Add("Renovacion:" + ((CL_DIGITAL)item).Renovacion);
                    lstListado.Items.Add("Reproduccion" + ((CL_DIGITAL)item).Reproduccion());
                }
            }
        }
    }
}
