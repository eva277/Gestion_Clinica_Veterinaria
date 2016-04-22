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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        PropertyValidateModel validador = new PropertyValidateModel();
        UnitOfWork uow = new UnitOfWork();
        Usuario usu = new Usuario();

        public Login()
        {
            InitializeComponent();
            usu = new Usuario();
            DataContext = usu;
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            string login = uow.RepositorioUsuarios.CheckUser(textBoxNickName.Text, passwordBox.Password);
            if (login.Equals("Login Success"))
            {
                MainWindow m = new MainWindow();
                m.CurrentUser= uow.RepositorioUsuarios.Get().Where(h => h.NickName == textBoxNickName.Text).FirstOrDefault();
                m.Show();
                this.Close();
            }
            else if(login.Equals("El usuario no existe"))
            {
                MessageBox.Show(login, "Error Login", MessageBoxButton.OK, MessageBoxImage.Error);
                textBoxNickName.Clear();
                passwordBox.Clear();
            }
            else
            {
                passwordBox.Clear();
                MessageBox.Show(login, "Error Login", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void AcceptButton_DragEnter(object sender, DragEventArgs e)
        {
            string login = uow.RepositorioUsuarios.CheckUser(textBoxNickName.Text, passwordBox.Password);
            if (login.Equals("Login Success"))
            {
                MainWindow m = new MainWindow();
                m.CurrentUser = uow.RepositorioUsuarios.Get().Where(h => h.NickName == textBoxNickName.Text).FirstOrDefault();
                m.Show();
                this.Close();
            }
            else if (login.Equals("El usuario no existe"))
            {
                MessageBox.Show(login, "Error Login", MessageBoxButton.OK, MessageBoxImage.Error);
                textBoxNickName.Clear();
                passwordBox.Clear();
            }
            else
            {
                passwordBox.Clear();
                MessageBox.Show(login, "Error Login", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
    }
}
