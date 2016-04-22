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
using System.Data;

namespace Proyecto_Clinic_Veterinaria
{
    /// <summary>
    /// Lógica de interacción para MantenimientoUsuario.xaml
    /// </summary>
    public partial class Profile : UserControl
    {
        PropertyValidateModel validador = new PropertyValidateModel();
        private UnitOfWork uow = new UnitOfWork();
        Usuario usu;
        string tipoUsu;

        public Profile(Usuario current)
        {
            InitializeComponent();
            usu = current;
            DataContext = usu;
        }

        private void TipoUsucomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TipoUsucomboBox.SelectedItem != null)
            {
                ComboBoxItem tipo = (ComboBoxItem)TipoUsucomboBox.SelectedItem;
                tipoUsu = tipo.Content.ToString();
            }
        }

        private void ClearTextbox()
        {
            NombretextBox.Clear();
            ApellidostextBox.Clear();
            EmailtextBox_Copy5.Clear();
            NickNametextBox_Copy6.Clear();
            PasswordtextBox_Copy7.Clear();
            DirecciontextBox.Clear();
            TipoUsucomboBox.SelectedItem = null;
            CodPosttextBox_Copy3.Clear();
            TelefonotextBox_Copy4.Clear();
            PreguntaSecrretatextBox_Copy8.Clear();
            RespuestaSecrettextBox_Copy9.Clear();
        }

        private void GetUser()
        {
            usu.Nombre = NombretextBox.Text;
            usu.Apellidos = ApellidostextBox.Text;
            usu.Email = EmailtextBox_Copy5.Text;
            usu.NickName = NickNametextBox_Copy6.Text;
            usu.Password = PasswordtextBox_Copy7.Text;
            usu.Direccion = DirecciontextBox.Text;
            usu.CodigoPostal = CodPosttextBox_Copy3.Text;
            usu.Telefono = TelefonotextBox_Copy4.Text;
            usu.TipoUsuario = tipoUsu;
            usu.PreguntaSecreta = PreguntaSecrretatextBox_Copy8.Text;
            usu.RespuestaSecreta = RespuestaSecrettextBox_Copy9.Text;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (validador.errrores(usu) != "")
            {
                MessageBox.Show(validador.errrores(usu));
            }
            else
            {
                GetUser();
                uow.RepositorioUsuarios.Update(usu.UsuarioId,usu);
                uow.Save();
                ClearTextbox();
                MessageBox.Show("El usuario se ha modificado conrrectamente");
            }
        }
    }
}
