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

namespace Proyecto_Clinic_Veterinaria
{
    /// <summary>
    /// Lógica de interacción para AddRegistroCita.xaml
    /// </summary>
    public partial class AddRegistroCita : UserControl
    {
        PropertyValidateModel validador = new PropertyValidateModel();
        private UnitOfWork uow = new UnitOfWork();
        RegistroCita registroCita;
        int idTipoCita;
        int idUsusario;
        int idCliente;
        int idMascota;

        public AddRegistroCita()
        {
            InitializeComponent();
            registroCita = new RegistroCita();
            DataContext = registroCita;
            CultureInfo ci = new CultureInfo(Thread.CurrentThread.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            ci.DateTimeFormat.DateSeparator = "/";
            Thread.CurrentThread.CurrentCulture = ci;
            FechaCita.SelectedDate = DateTime.Today;

            ClienteCombobox.ItemsSource = uow.RepositorioCliente.Get()
                            .Select(h => new
                            {
                                h.ClienteId,
                                h.NombreCompleto,
                            });
            ClienteCombobox.DisplayMemberPath = "NombreCompleto";
            ClienteCombobox.SelectedValuePath = "ClienteId";

            MascotaCombobox.ItemsSource = uow.RepositorioMascota.Get()
                .Select(h => new
                {
                    h.MascotaId,
                    h.Nombre,
                    h.Raza,
                });
            //MascotaCombobox.DisplayMemberPath = "Nombre";
            MascotaCombobox.SelectedValuePath = "MascotaId";

            UsuariocomboBox.ItemsSource = uow.RepositorioUsuarios.Get()
                .Select(h => new
                {
                    h.UsuarioId,
                    h.NombreCompleto,
                });
            UsuariocomboBox.DisplayMemberPath = "NombreCompleto";
            UsuariocomboBox.SelectedValuePath = "UsuarioId";

            TipoCitacomboBox.ItemsSource = uow.RepositorioTipoCitas.Get()
                .Select(h => new
                {
                    h.Motivo,
                    h.TipoAtencionId
                });
            TipoCitacomboBox.DisplayMemberPath = "Motivo";
            TipoCitacomboBox.SelectedValuePath = "TipoAtencionId";

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
            registroCita.UsuarioId = idUsusario;
            registroCita.TipoAtencionId = idTipoCita;
            registroCita.PacienteId = idMascota;
            registroCita.DueñoId = idCliente;
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

        private void MascotaCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MascotaCombobox.SelectedItem != null)
            {
                idMascota = Convert.ToInt16(MascotaCombobox.SelectedValue);
            }
        }

        private void ClienteCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ClienteCombobox.SelectedItem != null)
            {
                idCliente = Convert.ToInt16(ClienteCombobox.SelectedValue);
            }
        }

        private void Acceptbutton_Click(object sender, RoutedEventArgs e)
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
                MessageBox.Show("Los datos se han añadido correctamente");
            }
        }
    }
}
