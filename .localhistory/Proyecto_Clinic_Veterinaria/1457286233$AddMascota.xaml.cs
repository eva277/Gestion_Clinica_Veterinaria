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
using Proyecto_Clinic_Veterinaria.Model;
using Microsoft.Win32;
using System.Globalization;
using System.Threading;
using System.IO;
using Proyecto_Clinic_Veterinaria.DAL;

namespace Proyecto_Clinic_Veterinaria
{
    /// <summary>
    /// Lógica de interacción para AddMascota.xaml
    /// </summary>
    public partial class AddMascota : UserControl
    {
        PropertyValidateModel validador = new PropertyValidateModel();
        private UnitOfWork uow = new UnitOfWork();
        Mascota mascota;
        int idUsuario;
        int idOwner;
        string PathImage;
        DateTime fecha;


        public AddMascota()
        {
            InitializeComponent();
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
        }
        private Mascota EnlazarDatos()
        {
            Mascota mascota = new Mascota();

            mascota.Nombre = NombretextBox1.Text;
           // mascota.Especie = EspecietextBox2.Text;
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

            mascota.Foto = ImagetoByte(PathImage);

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

            return mascota; 
        }


        private void LoadImgbutton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == true)
                PathImage = openFileDialog.FileName;

        }

        private void FechaNacimientoDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            fecha = FechaNacimientoDatePicker.SelectedDate.Value.Date;
        }

        private void OwnercomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OwnercomboBox.SelectedItem != null)
            {
                ComboBoxItem tipo = (ComboBoxItem)OwnercomboBox.SelectedItem;
                idUsuario = Convert.ToInt16(tipo.Content.ToString());
            }
        }

        private void UsercomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UsercomboBox.SelectedItem != null)
            {
                ComboBoxItem tipo = (ComboBoxItem)UsercomboBox.SelectedItem;
                idOwner = Convert.ToInt16(tipo.Content.ToString());
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
            PetsDataGrid.ItemsSource = uow.RepositorioMascota.Get().Select(h => new {h.MascotaId,h.Nombre,h.Especie,h.Raza,h.Sexo,h.Foto,h.Cliente.NombreCompleto });
        }

        private void Acceptbutton_Click(object sender, RoutedEventArgs e)
        {
            uow.RepositorioMascota.Insert(EnlazarDatos());
            uow.Save();
        }
    }
}
