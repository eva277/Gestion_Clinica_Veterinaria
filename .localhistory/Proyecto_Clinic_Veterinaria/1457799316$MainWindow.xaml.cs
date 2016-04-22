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
using Proyecto_Clinic_Veterinaria.Mantenimiento;

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


        }

        private void MenuItemPacientes_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            AddMascota c = new AddMascota();
            Titulo.Content = "Mantenimiento Pacientes";
            canvas.Children.Add(new AddMascota());
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemJaulas_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Titulo.Content = "Mantenimiento Jaulas";
            AddJaula c = new AddJaula();
            canvas.Children.Add(new AddJaula());
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemHotel_Hospi_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Titulo.Content = "Mantenimiento Hotel - Hosital";
            AddRegistroHotel_Hospital c = new AddRegistroHotel_Hospital();
            canvas.Children.Add(new AddRegistroHotel_Hospital());
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemCitas_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Titulo.Content = "Mantenimiento Citas";
            AddTipoCita c = new AddTipoCita();
            canvas.Children.Add(new AddTipoCita());
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemRegistros_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Titulo.Content = "Mantenimiento Registros";
            AddRegistroCita c = new AddRegistroCita();
            canvas.Children.Add(new AddRegistroCita());
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemUsers_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Titulo.Content = "Mantenimiento Usuarios";
            MantenimientoUser c = new MantenimientoUser();
            canvas.Children.Add(new MantenimientoUser());
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemAddCli_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Titulo.Content = "Mantenimiento Clientes. Añadir";
            AddClient c = new AddClient();
            canvas.Children.Add(c);
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemMantCli_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Titulo.Content = "Mantenimiento Clientes. Mantenimiento";
            MantenimientoCliente c = new MantenimientoCliente();
            canvas.Children.Add(c);
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemAddMascota_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemMantMascota_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemAddJaula_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemMantJaulas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemAddHH_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemMantHH_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemAddCita_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemMantCitas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemAddReg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemMantReg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemAddUsu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemMantUsu_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
