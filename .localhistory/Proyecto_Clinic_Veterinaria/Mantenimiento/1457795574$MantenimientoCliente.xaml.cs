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

namespace Proyecto_Clinic_Veterinaria.Mantenimiento
{
    /// <summary>
    /// Lógica de interacción para AddClient.xaml
    /// </summary>
    public partial class MantenimientoCliente : UserControl
    {
        PropertyValidateModel validador = new PropertyValidateModel();
        private UnitOfWork uow = new UnitOfWork();
        Cliente cliente;
        List<Mascota> list;
        string opcionBusqueda;

        public MantenimientoCliente()
        {
            InitializeComponent();
            cliente = new Cliente();
            DataContext = cliente;
            ListClients();

        }
        List<Mascota> a = new List<Mascota>();
        private void GetCliente()
        {
            cliente = new Cliente();
            cliente.ClienteId = Convert.ToInt16(IdtextBox.Text);
            cliente.Nombre = NombretextBox.Text;
            cliente.Apellidos = ApellidostextBox.Text;
            cliente.Direccion = DirecciontextBox_Copy5.Text;
            cliente.CodigoPostal = CodigoPostalTextbox.Text;
            cliente.Telefono = TelefonoTextbox.Text;
            cliente.Email = EmailtextBox.Text;
            cliente.ListaMascota = uow.RepositorioCliente.getPets(cliente.ClienteId);
        }
        private void ListClients()
        {
            ClientesdataGrid.ItemsSource = uow.RepositorioCliente.Get().Select(
                h => new
                {
                    h.ClienteId,
                    h.Nombre,
                    h.Apellidos,
                    h.Direccion,
                    h.Telefono,
                    h.Email,
                    h.ListaMascota,
                });

        }
        private void ClearTextBox()
        {
            IdtextBox.Clear();
            NombretextBox.Clear();
            ApellidostextBox.Clear();
            DirecciontextBox_Copy5.Clear();
            CodigoPostalTextbox.Clear();
            TelefonoTextbox.Clear();
            EmailtextBox.Clear();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            GetCliente();

            if (String.IsNullOrWhiteSpace(IdtextBox.Text))
            {
                MessageBox.Show("Debe seleccionar un usario para modificarlo");
            }
            else
            {
                if (validador.errrores(cliente) != "")
                {
                    MessageBox.Show(validador.errrores(cliente));
                }
                else
                {
                    uow.RepositorioCliente.Update(cliente.ClienteId, cliente);
                    uow.Save();
                    MessageBox.Show("El usuario se ha modificado conrrectamente");
                    ListClients();
                    ClearTextBox();
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            GetCliente();

            if (String.IsNullOrWhiteSpace(IdtextBox.Text))
            {
                MessageBox.Show("Debe seleccionar un usuario para eliminarlo");
            }
            else
            {
                uow.RepositorioCliente.Delete(cliente.ClienteId);
                uow.Save();
                MessageBox.Show("El usuario se ha eliminado conrrectamente");
                ListClients();
                ClearTextBox();
            }
        }

        private void SearchcomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SearchcomboBox.SelectedItem != null)
            {
                ComboBoxItem tipo = (ComboBoxItem)SearchcomboBox.SelectedItem;
                opcionBusqueda = tipo.Content.ToString();
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(SearchTextbox.Text) && (SearchcomboBox.SelectedItem != null))
            {
                ClientesdataGrid.ItemsSource = uow.RepositorioCliente.BuscarCliente(opcionBusqueda, SearchTextbox.Text);
            }
            else
            {
                MessageBox.Show("Debe ingresar un campo para la busqueda");
            }
        }


    }
}
