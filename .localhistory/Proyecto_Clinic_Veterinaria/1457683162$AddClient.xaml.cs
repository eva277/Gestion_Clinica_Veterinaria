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

namespace Proyecto_Clinic_Veterinaria
{
    /// <summary>
    /// Lógica de interacción para AddClient.xaml
    /// </summary>
    public partial class AddClient : UserControl
    {
        PropertyValidateModel validador = new PropertyValidateModel();
        private UnitOfWork uow = new UnitOfWork();
        Cliente cliente;

        public AddClient()
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

            cliente.Nombre = NombretextBox.Text;
            cliente.Apellidos = ApellidostextBox.Text;
            cliente.Direccion = DirecciontextBox_Copy5.Text;
            cliente.CodigoPostal = CodigoPostalTextbox.Text;
            cliente.Telefono = TelefonoTextbox.Text;
            cliente.Email = EmailtextBox.Text;

        }
        private void ListClients()
        {
            ClientesdataGrid.ItemsSource = uow.RepositorioCliente.Get().Select(
                h => new
                {
                    h.ClienteId,
                    h.NombreCompleto,
                    h.Direccion,
                    h.Telefono,
                    h.Email,
                    h.ListaMascota,
                });
        }
        private void ClearTextBox()
        {
            NombretextBox.Clear();
            ApellidostextBox.Clear();
            DirecciontextBox_Copy5.Clear();
            CodigoPostalTextbox.Clear();
            TelefonoTextbox.Clear();
            EmailtextBox.Clear();
        }

        private void Acceptbutton_Click(object sender, RoutedEventArgs e)
        {
            if (validador.errrores(cliente) != "")
            {
                MessageBox.Show(validador.errrores(cliente));
            }
            else
            {
                GetCliente();
                uow.RepositorioCliente.Insert(cliente);
                uow.Save();
                ListClients();
                ClearTextBox();
                MessageBox.Show("El usuario se ha añadido correctamente");
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Idlabel.Content.ToString()))
            {
                MessageBox.Show("Debe seleccionar un usario para modificarlo");
            }
            else
            {
                GetCliente();
                if (validador.errrores(cliente) != "")
                {
                    MessageBox.Show(validador.errrores(cliente));
                }
                else
                {
                    uow.RepositorioCliente.Update(Convert.ToInt16(textBlock.Text), cliente);
                    uow.Save();
                    MessageBox.Show("El usuario se ha modificado conrrectamente");
                    ListClients();
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            uow.RepositorioCliente.Delete(Convert.ToInt16(Idlabel.Content) );
            uow.Save();
            MessageBox.Show("El usuario se ha eliminado conrrectamente");
            ListClients();
        }


    }
}
