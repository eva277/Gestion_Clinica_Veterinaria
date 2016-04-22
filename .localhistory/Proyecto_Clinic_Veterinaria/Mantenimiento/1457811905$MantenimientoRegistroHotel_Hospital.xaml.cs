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


namespace Proyecto_Clinic_Veterinaria.Mantenimiento
{
    /// <summary>
    /// Lógica de interacción para AddRegistroHotel_Hospital.xaml
    /// </summary>
    public partial class MantenimientoRegistroHotel_Hospital : UserControl
    {
        PropertyValidateModel validador = new PropertyValidateModel();
        private UnitOfWork uow = new UnitOfWork();
        RegistroHotel_Hospital registro;
        int idMascota;
        int idJaula;
        int idUsuario;

        public MantenimientoRegistroHotel_Hospital()
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
                    h.TipoJaula,
                    h.Medida,
                    h.Fondo,
                });
            JaulacomboBox.SelectedValuePath = "JaulaId";
            //JaulacomboBox.DisplayMemberPath = "TipoJaula";

            UsuaruicomboBox.ItemsSource = uow.RepositorioUsuarios.Get()
            .Select(h => new
            {
                h.UsuarioId,
                h.NombreCompleto,
            });
            UsuaruicomboBox.DisplayMemberPath = "NombreCompleto";
            UsuaruicomboBox.SelectedValuePath = "UsuarioId";

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
        private void getRegistro()
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
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBlock.Text.ToString()))
            {
                MessageBox.Show("Debe seleccionar un registro para modificarlo");
            }
            else
            {
                getRegistro();
                if (validador.errrores(registro) != "")
                {
                    MessageBox.Show(validador.errrores(registro));
                }
                else
                {
                    uow.RepositorioRegistroHotel_Hospital.Update(Convert.ToInt16(textBlock.Text), registro);
                    uow.Save();
                    MessageBox.Show("El registro se ha modificado conrrectamente");
                    ListRegistros();
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBlock.Text.ToString()))
            {
                MessageBox.Show("Debe seleccionar un registro para eliminar");
            }
            else
            {
                getRegistro();
                if (validador.errrores(registro) != "")
                {
                    MessageBox.Show(validador.errrores(registro));
                }
                else
                {
                    uow.RepositorioRegistroHotel_Hospital.Delete(Convert.ToInt16(textBlock.Text));
                    uow.Save();
                    MessageBox.Show("El registro se ha eliminado conrrectamente");
                    ListRegistros();
                }
            }
        }
        private void ListRegistros()
        {
            HHDatagrid.ItemsSource = uow.RepositorioRegistroHotel_Hospital.Get().Select(
                h => new {
                h.RegistroHotel_HospitalId,
                h.Ingreso,
                h.Regreso,
                h.Disponible,}
            );
        }

        private void addbutton_Click(object sender, RoutedEventArgs e)
        {
            getRegistro();
            if (validador.errrores(registro) != "")
            {
                MessageBox.Show(validador.errrores(registro));
            }
            else
            {
                uow.RepositorioRegistroHotel_Hospital.Insert(registro);
                uow.Save();
                ListRegistros();
                MessageBox.Show("El registro se ha añadido correctamente");
            }
        }
    }
}
