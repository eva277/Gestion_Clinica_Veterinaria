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
using System.Globalization;
using System.Threading;

namespace Proyecto_Clinic_Veterinaria
{
    /// <summary>
    /// Lógica de interacción para AddRegistroCita.xaml
    /// </summary>
    public partial class AddRegistroCita : UserControl
    {
        PropertyValidateModel validador = new PropertyValidateModel();
        private UnitOfWork uow = new UnitOfWork();
        RegistroCita registroCita = new RegistroCita();
        int idTipoCita;

        public AddRegistroCita()
        {
            InitializeComponent();
            TipoCitacomboBox.ItemsSource = uow.RepositorioTipoCitas.Get().Select(h=> new { h.TipoCitaID,h.Nombre});
            TipoCitacomboBox.DisplayMemberPath = "Nombre";
            TipoCitacomboBox.SelectedValuePath = "TipoCitaID";
            CultureInfo ci = new CultureInfo(Thread.CurrentThread.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            ci.DateTimeFormat.DateSeparator = "/";
            Thread.CurrentThread.CurrentCulture = ci;
            FechaCita.SelectedDate = DateTime.Today;
        }

        private void TipoCitacomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TipoCitacomboBox.SelectedItem != null)
            {
                ComboBoxItem tipo = (ComboBoxItem)TipoCitacomboBox.SelectedItem;
                idTipoCita = Convert.ToInt16(tipo.Content.ToString());
            }
        }
        public void GetCita()
        {
            registroCita.Resumen = ResumentextBox.Text;
            registroCita.Observaciones = ObservacionestextBox.Text;
        }

        private void FechaCita_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            registroCita.Fecha = FechaCita.SelectedDate.Value.Date;

        }
    }
}
