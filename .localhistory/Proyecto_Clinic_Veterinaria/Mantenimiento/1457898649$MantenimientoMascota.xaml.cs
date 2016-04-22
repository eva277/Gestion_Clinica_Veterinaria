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
using System.Globalization;
using System.Threading;
using System.IO;
using Proyecto_Clinic_Veterinaria.DAL;

namespace Proyecto_Clinic_Veterinaria.Mantenimiento
{
    /// <summary>
    /// Lógica de interacción para AddMascota.xaml
    /// </summary>
    public partial class MantenimientoMascota : UserControl
    {
        PropertyValidateModel validador = new PropertyValidateModel();
        private UnitOfWork uow = new UnitOfWork();
        Mascota mascota;
        int idUsuario;
        int idOwner;
        string PathImage;
        DateTime fecha;
        string opcion;


        public MantenimientoMascota()
        {
            InitializeComponent();
            mascota = new Mascota();
            DataContext = mascota;
            CultureInfo ci = new CultureInfo(Thread.CurrentThread.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            ci.DateTimeFormat.DateSeparator = "/";
            Thread.CurrentThread.CurrentCulture = ci;
            FechaNacimientoDatePicker.SelectedDate = DateTime.Today;

            UsercomboBox.ItemsSource = uow.RepositorioUsuarios.Get()
                .Select(h => new
                {
                    h.UsuarioId,
                    h.NombreCompleto,
                });
            UsercomboBox.DisplayMemberPath = "NombreCompleto";
            UsercomboBox.SelectedValuePath = "UsuarioId";

            OwnercomboBox.ItemsSource = uow.RepositorioCliente.Get()
                .Select(h => new
                {
                    h.ClienteId,
                    h.NombreCompleto,
                });
            OwnercomboBox.DisplayMemberPath = "NombreCompleto";
            OwnercomboBox.SelectedValuePath = "ClienteId";

            ListPets();
        }
        private void EnlazarDatos()
        {
            mascota.MascotaId =Convert.ToInt16(IdtextBox.Text);
            mascota.Nombre = NombretextBox1.Text;
            mascota.Raza = RazatextBox.Text;
            if (FemradioButton.IsChecked==true)
            {
                mascota.Sexo = FemradioButton.Content.ToString();;
            }
            else if (MaleradioButton.IsChecked == true)
            {
                mascota.Sexo = MaleradioButton.Content.ToString(); ;
            }
            mascota.Pelaje = PelajetextBox3_Copy.Text;
            mascota.FechaNacimiento = fecha;

            if (ActivocheckBox.IsChecked==true)
            {
                mascota.Activo = true;
            }
            else
            {
                mascota.Activo = false;
            }
            mascota.ClienteId = idOwner;
            mascota.UsuarioId = idUsuario;
        }

        private void LoadImgbutton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == true)
                PathImage = openFileDialog.FileName;
            if (PathImage != null)
            {
                mascota.Foto = ImagetoByte(PathImage);
            }
        }

        private void FechaNacimientoDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            fecha = FechaNacimientoDatePicker.SelectedDate.Value.Date;
        }

        private void OwnercomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OwnercomboBox.SelectedItem != null)
            {
                idUsuario = Convert.ToInt16(OwnercomboBox.SelectedValue);
            }
        }

        private void UsercomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UsercomboBox.SelectedItem != null)
            {
                idOwner = Convert.ToInt16(UsercomboBox.SelectedValue);
            }
        }

        public ImageSource ByteToImage(byte[] imageData)
        {
            BitmapImage biImg = new BitmapImage();
            MemoryStream ms = new MemoryStream(imageData);
            biImg.BeginInit();
            biImg.StreamSource = ms;
            biImg.EndInit();

            ImageSource imgSrc = biImg as ImageSource;

            return imgSrc;
        }
        public byte[] ImagetoByte(string pathImage)
        {
            var bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.UriSource = new Uri(pathImage);
            bmp.EndInit();

            image.Source = bmp;

            byte[] data;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bmp));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            }
            return data;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ListPets();
        }

        private void EspeciecomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EspeciecomboBox.SelectedItem != null)
            {
                ComboBoxItem tipo = (ComboBoxItem)EspeciecomboBox.SelectedItem;
                mascota.Especie= tipo.Content.ToString();
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

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(SearchTextbox.Text) && (SearchcomboBox.SelectedItem != null))
            {
                PetsDataGrid.ItemsSource = uow.RepositorioMascota.Buscar(opcion, SearchTextbox.Text);
            }
            else
            {
                MessageBox.Show("Debe ingresar un campo para realizar la busqueda");
            }
        }
        private void ListPets()
        {
            PetsDataGrid.ItemsSource = uow.RepositorioMascota.Get().Select(h => new { h.MascotaId, h.Nombre, h.Especie, h.Raza, h.Sexo, h.Foto, h.Cliente.NombreCompleto });
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            EnlazarDatos();
            if (String.IsNullOrWhiteSpace(IdtextBox.Text))
            {
                MessageBox.Show("Debe seleccionar un usuario para modificarlo");
            }
            else
            {
                mascota.MascotaId = Convert.ToInt16(mascota.MascotaId);
                uow.RepositorioMascota.Update(Convert.ToInt16(mascota.MascotaId), mascota);
                uow.Save();
                MessageBox.Show("El usuario se ha modificado conrrectamente");
                ListPets();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(IdtextBox.Text))
            {
                MessageBox.Show("Debe seleccionar un usuario para eliminarlo");
            }
            else
            {
                mascota.MascotaId = Convert.ToInt16(mascota.MascotaId);
                uow.RepositorioMascota.Delete(Convert.ToInt16(mascota.MascotaId));
                uow.Save();
                MessageBox.Show("El usuario se ha eliminado conrrectamente");
                ListPets();
            }
        }
    }
}
