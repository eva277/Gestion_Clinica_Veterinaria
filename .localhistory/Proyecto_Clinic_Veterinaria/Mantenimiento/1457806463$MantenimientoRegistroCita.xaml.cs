using System;
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

namespace Proyecto_Clinic_Veterinaria.Mantenimiento
{
    /// <summary>
    /// Lógica de interacción para AddRegistroCita.xaml
    /// </summary>
    public partial class MantenimientoRegistroCita : UserControl
    {
        PropertyValidateModel validador = new PropertyValidateModel();
        private UnitOfWork uow = new UnitOfWork();
        RegistroCita registroCita = new RegistroCita();
        int idTipoCita;
        int idUsusario;


        public MantenimientoRegistroCita()
        {
            InitializeComponent();
            TipoCitacomboBox.ItemsSource = uow.RepositorioTipoCitas.Get().Select(h=> new { h.Motivo,h.TipoCitaID});
            TipoCitacomboBox.DisplayMemberPath = "Motivo";
            TipoCitacomboBox.SelectedValuePath = "TipoCitaID";
            CultureInfo ci = new CultureInfo(Thread.CurrentThread.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            ci.DateTimeFormat.DateSeparator = "/";
            Thread.CurrentThread.CurrentCulture = ci;
            FechaCita.SelectedDate = DateTime.Today;

            UsuariocomboBox.ItemsSource = uow.RepositorioUsuarios.Get()
            .Select(h => new
            {
                h.UsuarioId,
                h.NombreCompleto,
            });
            UsuariocomboBox.DisplayMemberPath = "NombreCompleto";
            UsuariocomboBox.SelectedValuePath = "UsuarioId";

            ListRegistros();
        }

        private void TipoCitacomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TipoCitacomboBox.SelectedItem != null)
            {
                idTipoCita = Convert.ToInt16(TipoCitacomboBox.SelectedValue);
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

        private void UsuariocomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UsuariocomboBox.SelectedItem != null)
            {
                idUsusario = Convert.ToInt16(UsuariocomboBox.SelectedValue);
            }
        }
        private void ListRegistros()
        {
            RegistroDatagrid.ItemsSource = uow.RepositorioRegistroCita.Get().Select(
                h => new
                {
                    h.RegistroCitaId,
                    h.Resumen,
                    h.Fecha,
                    h.Observaciones,
                });
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            GetCita();

            if (validador.errrores(registroCita) != "")
            {
                MessageBox.Show(validador.errrores(registroCita));
            }
            else
            {
                uow.RepositorioRegistroCita.Insert(registroCita);
                uow.Save();
                ListRegistros();
                MessageBox.Show("Los datos se han añadido correctamente");
            }
        }
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBlock.Text.ToString()))
            {
                MessageBox.Show("Debe seleccionar un usario para modificarlo");
            }
            else
            {
                GetCita();
                if (validador.errrores(registroCita) != "")
                {
                    MessageBox.Show(validador.errrores(registroCita));
                }
                else
                {
                    uow.RepositorioRegistroCita.Update(Convert.ToInt16(textBlock.Text), registroCita);
                    uow.Save();
                    MessageBox.Show("El usuario se ha modificado conrrectamente");
                    ListRegistros();
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBlock.Text.ToString()))
            {
                MessageBox.Show("Debe seleccionar un usario para borrarlo");
            }
            else
            {
                GetCita();
                if (validador.errrores(registroCita) != "")
                {
                    MessageBox.Show(validador.errrores(registroCita));
                }
                else
                {
                    uow.RepositorioRegistroCita.Delete(Convert.ToInt16(textBlock.Text));
                    uow.Save();
                    MessageBox.Show("El usuario se ha eliminado conrrectamente");
                    ListRegistros();
                }
            }
        }
    }
}
