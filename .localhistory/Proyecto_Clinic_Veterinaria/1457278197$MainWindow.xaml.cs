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

namespace Proyecto_Clinic_Veterinaria
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }


            //dibuja en un canvas un determinado control de usuario
            /*canvas.Children.Clear();
            Login login = new Login();
            canvas.Children.Add(login);*/

            //Crear nueva ventana con un control de usuario especifico
            /*Window w2 = new Window
            {
                Title="Añadir nuevo Usuario",
                SizeToContent= SizeToContent.WidthAndHeight,

                Content = new AddUser()
            };
            w2.ShowDialog();*/


        private void MenuItemClientes_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            canvas.Children.Add(new AddClient());
        }

        private void MenuItemPacientes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemJaulas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemHotel_Hospi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemCitas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemRegistros_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemUsers_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
