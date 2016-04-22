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
        Usuario usu;
        string tipoUsu;

        public AddClient()
        {
            InitializeComponent();
            usu = new Usuario();
            DataContext = usu;
            ListPets();

        }

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
            MascotasdataGrid.ItemsSource = uow.RepositorioMascota.Get().Select(
                h => new {
                    h.MascotaId,
                    h.Nombre,
                    h.Especie,
                    h.Raza,
                    h.Sexo,
                    h.Edad,
                    h.Activo });
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
            if (validador.errrores(usu) != "")
            {
                MessageBox.Show(validador.errrores(usu));
            }
            else
            {

                uow.RepositorioCliente.Insert(GetCliente());
                uow.Save();
                ClearTextBox();
                MessageBox.Show("El usuario se ha añadido correctamente");
            }
        }
    }
}
