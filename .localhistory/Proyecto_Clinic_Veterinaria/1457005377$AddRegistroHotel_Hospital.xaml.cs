using System;
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
        int idJaula;
        int idMascota;

        public AddRegistroHotel_Hospital()
        {
            InitializeComponent();
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
            MascotacomboBox.SelectedValuePath = "TipoCitaID";

            JaulacomboBox.ItemsSource = uow.RepositorioJaula.Get()
                .Select(h => new
                {
                    h.JaulaId,
                    h.TipoJaula
                });
            JaulacomboBox.DisplayMemberPath = "TipoJaula";
            JaulacomboBox.SelectedValuePath = "JaulaId";

            UsuaruicomboBox.ItemsSource = uow.RepositorioUsuarios.Get()
                .Select(h => new
                {
                    h.UsuarioId,
                    h.TipoUsuario
                });
            JaulacomboBox.DisplayMemberPath = "TipoUsuario";
            JaulacomboBox.SelectedValuePath = "UsuarioId";

        }

        private void MascotacomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MascotacomboBox.SelectedItem != null)
            {
                ComboBoxItem tipo = (ComboBoxItem)MascotacomboBox.SelectedItem;
                idMascota = Convert.ToInt16(tipo.Content.ToString());
            }
        }

        private void JaulacomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (JaulacomboBox.SelectedItem != null)
            {
                ComboBoxItem tipo = (ComboBoxItem)JaulacomboBox.SelectedItem;
                idJaula = Convert.ToInt16(tipo.Content.ToString());
            }
        }
    }
}
