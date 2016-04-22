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
using Microsoft.Win32;

namespace Proyecto_Clinic_Veterinaria
{
    /// <summary>
    /// Lógica de interacción para AddMascota.xaml
    /// </summary>
    public partial class AddMascota : UserControl
    {
        string PathImage;
        public AddMascota()
        {
            InitializeComponent();
        }
        private Mascota EnlazarDatos()
        {
            Mascota mascota = new Mascota();

            mascota.Nombre = NombretextBox1.Text;
            mascota.Especie = EspecietextBox2.Text;
            mascota.Raza = RazatextBox3.Text;
            if (FemradioButton.IsChecked==true)
            {
                mascota.Sexo = FemradioButton.Content.ToString();;
            }
            else if (MaleradioButton.IsChecked == true)
            {
                mascota.Sexo = MaleradioButton.Content.ToString(); ;
            }
            mascota.Pelaje = PelajetextBox3_Copy.Text;
            mascota.FechaNacimiento = FechaNacimientoDatePicker.SelectedDate.Value;

            var bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.UriSource = new Uri(PathImage);
            bmp.EndInit();

            image.Source = bmp;
            mascota.Foto = image;

            if (ActivocheckBox.IsChecked==true)
            {
                mascota.Activo = true;
            }
            else
            {
                mascota.Activo = false;
            }

            return mascota; 
        }

        private void LoadImgbutton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            openFileDialog.DefaultExt = ".png";

            if (openFileDialog.ShowDialog() == true)
                PathImage = openFileDialog.FileName;

        }
    }
}
