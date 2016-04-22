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
                ClearTextBox();
                MessageBox.Show("El usuario se ha añadido correctamente");
            }
        }
    }
}
