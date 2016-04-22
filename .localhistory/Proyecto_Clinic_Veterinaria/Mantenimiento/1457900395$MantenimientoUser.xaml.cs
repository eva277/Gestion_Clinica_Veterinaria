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

namespace Proyecto_Clinic_Veterinaria.Mantenimiento
{
    /// <summary>
    /// Lógica de interacción para MantenimientoUsuario.xaml
    /// </summary>
    public partial class MantenimientoUser : UserControl
    {
        PropertyValidateModel validador = new PropertyValidateModel();
        private UnitOfWork uow = new UnitOfWork();
        Usuario usu;
        string tipoUsu;
        string opcion;
        
        public MantenimientoUser()
        {
            InitializeComponent();
            usu = new Usuario();
            DataContext = usu;
            ListUsers();
        }

        private void TipoUsucomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TipoUsucomboBox.SelectedItem!=null)
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
            TipoUsucomboBox.SelectedItem=null;
            CodPosttextBox_Copy3.Clear();
            TelefonotextBox_Copy4.Clear();
            PreguntaSecrretatextBox_Copy8.Clear();
            RespuestaSecrettextBox_Copy9.Clear();
        }

        private void ListUsers()
        {
            dataGrid.ItemsSource = uow.RepositorioUsuarios.Get().Select(
                h => new
                {
                    h.UsuarioId,
                    h.NombreCompleto,
                    h.Direccion,
                    h.Telefono,
                    h.Email,
                    h.TipoUsuario,
                    h.NickName
                });
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ListUsers();
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
            if (String.IsNullOrWhiteSpace(IdtextBox.Text))
            {
                MessageBox.Show("Debe Ingresar el id para Modificar el usuario");

            }
            else
            {
                GetUser();
                usu.UsuarioId = Convert.ToInt16(IdtextBox.Text);
                if (validador.errrores(usu) != "")
                {
                    MessageBox.Show(validador.errrores(usu));
                }
                else
                {
                    uow.RepositorioUsuarios.Update(usu.UsuarioId, usu);
                    uow.Save();
                    ClearTextbox();
                    MessageBox.Show("El usuario se ha modificado conrrectamente");
                    ListUsers();
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(IdtextBox.Text))
            {
                MessageBox.Show("Debe Ingresar el id para borrar el usuario");
            }
            else
            {
                usu.UsuarioId = Convert.ToInt16(IdtextBox.Text);
                uow.RepositorioUsuarios.Delete(usu.UsuarioId);
                uow.Save();
                ClearTextbox();
                MessageBox.Show("Los datos se han elimnado correctamente");
                ListUsers();
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(SearchTextbox.Text) && (SearchcomboBox.SelectedItem != null))
            {
                dataGrid.ItemsSource = uow.RepositorioUsuarios.Buscar(opcion, SearchTextbox.Text);
            }
            else
            {
                MessageBox.Show("Debe una campo para realizar la busqueda");
            }
        }

        private void SearchcomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SearchcomboBox.SelectedItem != null)
            {
                ComboBoxItem tipo = (ComboBoxItem)SearchcomboBox.SelectedItem;
                opcion = tipo.Content.ToString();
            }
        }
    }
}
