﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Lógica de interacción para AddRegistroHotel_Hospital.xaml
    /// </summary>
    public partial class AddRegistroHotel_Hospital : UserControl
    {
        PropertyValidateModel validador = new PropertyValidateModel();
        private UnitOfWork uow = new UnitOfWork();
        RegistroHotel_Hospital registro;
        int idMascota;
        int idJaula;
        int idUsuario;

        public AddRegistroHotel_Hospital()
        {
            InitializeComponent();
            registro = new RegistroHotel_Hospital();
            CultureInfo ci = new CultureInfo(Thread.CurrentThread.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            ci.DateTimeFormat.DateSeparator = "/";
            Thread.CurrentThread.CurrentCulture = ci;
            RegresoDatePicker.SelectedDate = DateTime.Today;
            IngresoDatePicker.SelectedDate = DateTime.Today;

            MascotacomboBox.ItemsSource = uow.RepositorioMascota.Get()
                .Select(h => new
                {
                    h.MascotaId,
                    h.Nombre,
                });
            MascotacomboBox.DisplayMemberPath = "Nombre";
            MascotacomboBox.SelectedValuePath = "MascotaId";

            JaulacomboBox.ItemsSource = uow.RepositorioJaula.Get()
                .Select(h => new
                {
                    h.JaulaId,
                    h.TipoJaula
                });
            JaulacomboBox.DisplayMemberPath = "Fondo";
            JaulacomboBox.SelectedValuePath = "JaulaId";

            UsuaruicomboBox.ItemsSource = uow.RepositorioUsuarios.Get()
                .Select(h => new
                {
                    h.UsuarioId,
                    h.TipoUsuario
                });
            JaulacomboBox.DisplayMemberPath = "NombreCompleto";
            JaulacomboBox.SelectedValuePath = "UsuarioId";

        }

        private void MascotacomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MascotacomboBox.SelectedItem != null)
            {
                idMascota = Convert.ToInt16(MascotacomboBox.SelectedValue);
            }
        }

        private void JaulacomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (JaulacomboBox.SelectedItem != null)
            {
                idJaula = Convert.ToInt16(JaulacomboBox.SelectedValue);
            }
        }
        private void UsuaruicomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UsuaruicomboBox.SelectedItem != null)
            {
                idUsuario = Convert.ToInt16(UsuaruicomboBox.SelectedValue);
            }
        }
        private void IngresoDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            registro.Ingreso = IngresoDatePicker.SelectedDate.Value.Date;

        }

        private void RegresoDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            registro.Regreso = RegresoDatePicker.SelectedDate.Value.Date;

        }
        private RegistroHotel_Hospital getRegistro()
        {
            registro.Ingreso = IngresoDatePicker.SelectedDate.Value.Date;
            registro.Regreso = RegresoDatePicker.SelectedDate.Value.Date;
            if (DisponiblecheckBox.IsChecked == true)
            {
                registro.Disponible = true;

            }
            else
            {
                registro.Disponible = false;
            }
            registro.MascotaId = idMascota;
            registro.JaulaId = idJaula;
            return null;
        }
    }
}
