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
using Proyecto_Clinic_Veterinaria.DAL;
using Proyecto_Clinic_Veterinaria.Model;
namespace Proyecto_Clinic_Veterinaria
{
    /// <summary>
    /// Lógica de interacción para MantenimientoUsuario.xaml
    /// </summary>
    public partial class AddUser : UserControl
    {
        UnitOfWork uow = new UnitOfWork();
        public AddUser()
        {
            InitializeComponent();
        }

        private void Acceptbutton_Click(object sender, RoutedEventArgs e)
        {
            Usuario usu = new Usuario();
            usu.Nombre = NombretextBox.Text;
            usu.Apellidos = ApellidostextBox.Text;
            usu.Email = EmailtextBox_Copy5.Text;
            usu.NickName = NickNametextBox_Copy6.Text;
            usu.Password = PasswordtextBox_Copy7.Text;
            usu.Direccion = DirecciontextBox.Text;
            usu.CodigoPostal = Convert.ToInt16(CodPosttextBox_Copy3.Text);
            usu.Telefono = TelefonotextBox_Copy4.Text;
            usu.TipoUsuario = TipoUsucomboBox.SelectedItem.ToString();
            usu.PreguntaSecreta = PreguntaSecrretatextBox_Copy8.Text;
            usu.RespuestaSecreta = RespuestaSecrettextBox_Copy9.Text;
            uow.RepositorioUsuarios.Insert(usu);
        }
    }
}
