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
            ListPets();

        }
        List<Mascota> a = new List<Mascota>();
        private Cliente GetCliente()
        {
            Cliente cliente = new Cliente();

            cliente.Nombre = NombretextBox.Text;
            cliente.Apellidos = ApellidostextBox.Text;
            cliente.Direccion = DirecciontextBox_Copy5.Text;
            cliente.CodigoPostal = CodigoPostalTextbox.Text;
            cliente.Telefono = TelefonoTextbox.Text;
            cliente.Email = EmailtextBox.Text;

            return cliente;
        }
        private void ListPets()
        {
            MascotasdataGrid.ItemsSource = uow.RepositorioCliente.Get().Select(
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

                uow.RepositorioCliente.Insert(GetCliente());
                uow.Save();
                ClearTextBox();
                MessageBox.Show("El usuario se ha añadido correctamente");
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ListPets();
        }
    }
}
