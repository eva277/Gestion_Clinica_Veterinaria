﻿using System;
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
using Proyecto_Clinic_Veterinaria.Model;

namespace Proyecto_Clinic_Veterinaria
{
    public partial class MainWindow : Window
    {
        public Usuario CurrentUser = new Usuario();

        public MainWindow()
        {
            InitializeComponent();
            ProfileNick.Text += CurrentUser.NickName;
        }
        public MainWindow(Usuario usu)
        {
            InitializeComponent();
            CurrentUser = usu;
            ProfileNick.Text += CurrentUser.NickName;
            if (CurrentUser.TipoUsuario.Equals("Administrador"))
            {
                MenuItemUsers.IsEnabled = true;
            }
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

        private void MenuItemAddCli_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Titulo.Content = "Zona Clientes. Añadir";
            AddClient c = new AddClient();
            canvas.Children.Add(c);
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemMantCli_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Titulo.Content = "Zona Clientes. Mantenimiento";
            MantenimientoCliente c = new MantenimientoCliente();
            canvas.Children.Add(c);
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemAddMascota_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            AddMascota c = new AddMascota();
            Titulo.Content = "Zona Mascotas. Añadir";
            canvas.Children.Add(c);
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemMantMascota_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            MantenimientoMascota c = new MantenimientoMascota();
            Titulo.Content = "Zona Mascotas. Mantenimiento";
            canvas.Children.Add(c);
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemAddJaula_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Titulo.Content = "Zona Jaulas. Añadir";
            AddJaula c = new AddJaula();
            canvas.Children.Add(c);
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemMantJaulas_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Titulo.Content = "Zona Jaulas.Mantenimiento";
            MantenimientoJaula c = new MantenimientoJaula();
            canvas.Children.Add(c);
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemAddHH_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Titulo.Content = "Zona Hotel - Hosital. Añadir Registro";
            AddRegistroHotel_Hospital c = new AddRegistroHotel_Hospital();
            canvas.Children.Add(c);
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemMantHH_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Titulo.Content = "Zona Hotel - Hosital. Mantenimiento";
            MantenimientoRegistroHotel_Hospital c = new MantenimientoRegistroHotel_Hospital();
            canvas.Children.Add(c);
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemAddCita_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Titulo.Content = "Zona Citas. Añadir";
            AddRegistroCita c = new AddRegistroCita();
            canvas.Children.Add(c);
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemMantCitas_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Titulo.Content = "Zona Citas. Mantenimiento";
            MantenimientoRegistroCita c = new MantenimientoRegistroCita();
            canvas.Children.Add(c);
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemAddUsu_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Titulo.Content = "Zona Usuarios. Añadir";
            AddUser c = new AddUser();
            canvas.Children.Add(c);
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemMantUsu_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Titulo.Content = "Zona Usuarios. Mantenimiento";
            MantenimientoUser c = new MantenimientoUser();
            canvas.Children.Add(c);
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemAddTipoAten_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Titulo.Content = "Zona Tipo Atencion. Añadir";
            AddTipoAtencion c = new AddTipoAtencion();
            canvas.Children.Add(c);
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void MenuItemMantTipoAten_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Titulo.Content = "Zona Tipo Atencion. Mantenimiento";
            MantenimientoTipoAtencion c = new MantenimientoTipoAtencion();
            canvas.Children.Add(c);
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void ViewPerfil_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Titulo.Content = "Zona Perfil Usuario";
            Profile c = new Profile(CurrentUser);
            canvas.Children.Add(c);
            canvas.Height = c.Height;
            canvas.Width = c.Width;
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que quiere salir", "Aviso", MessageBoxButton.YesNo,MessageBoxImage.Question)==MessageBoxResult.Yes)
            {
                Login c = new Login();
                c.Show();
                this.Close();
            }
        }
    }
}
