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
        TimeSpan f;
        int year;
        int month;
        int days;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            canvas.Children.Add(login);
        }

        private void Nacimiento_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

            label.Content=GetAge(Nacimiento.SelectedDate.Value, DateTime.Today);
        }

        

    }
}
