﻿using System;
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
using Proyecto_Clinic_Veterinaria.Model;
using Proyecto_Clinic_Veterinaria.DAL;

namespace Proyecto_Clinic_Veterinaria
{
    /// <summary>
    /// Lógica de interacción para AddJaula.xaml
    /// </summary>
    public partial class AddJaula : UserControl
    {
        PropertyValidateModel validador = new PropertyValidateModel();
        private UnitOfWork uow = new UnitOfWork();
        Jaula jaula;

        public AddJaula()
        {
            InitializeComponent();
            jaula = new Jaula();
            DataContext = jaula;
            ListPets();
        }
        private Jaula EnlazarDatos()
        {
            jaula.TipoJaula = TipoJaulacomboBox.SelectedItem.ToString();
            jaula.Alto = Convert.ToInt16(AltotextBox.Text);
            jaula.Ancho = Convert.ToInt16(AnchotextBox_Copy.Text);
            jaula.Fondo = Convert.ToInt16(FondotextBox_Copy1.Text);
            if (OcupadacheckBox.IsChecked == true)
            {
                jaula.Ocupada = true;
            }
            else
            {
                jaula.Ocupada = false;
            }

            return jaula;
        }
        private void ListJails()
        {
            JaulasdataGrid.ItemsSource = uow.RepositorioJaula.Get().Select(
                h => new
                {
                    h.JaulaId,
                    h.TipoJaula,
                    h.Ocupada,
                });
        }
        private void ListPets()
        {
            uow.RepositorioMascota.Get().Select(
                h => new
                {
                    h.MascotaId,
                    h.Nombre,
                    h.Especie,
                    h.Raza,
                    h.Sexo,
                    h.Edad,
                    h.Activo
                });
        }

        private void Acceptbutton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (validador.errrores(jaula) != "")
                {
                    MessageBox.Show(validador.errrores(jaula));
                }
                else
                {

                    uow.RepositorioJaula.Insert(EnlazarDatos());
                    uow.Save();
                    ClearTextBox();
                    MessageBox.Show("El usuario se ha añadido correctamente");
                }
            }
        }
        private void ClearTextBox()
        {

        }
    }
}