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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //canvas.Children.Clear();
            //Login login = new Login();
            //canvas.Children.Add(login);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window w2 = new Window
            {
                Title="Añadir nuevo Usuario",
                SizeToContent= SizeToContent.WidthAndHeight,

                Content = new AddUser()
            };
            w2.ShowDialog();
        }
    }
}
