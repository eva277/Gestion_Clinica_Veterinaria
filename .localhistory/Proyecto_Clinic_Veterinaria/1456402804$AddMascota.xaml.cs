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

namespace Proyecto_Clinic_Veterinaria
{
    /// <summary>
    /// Lógica de interacción para AddMascota.xaml
    /// </summary>
    public partial class AddMascota : UserControl
    {
        string PathImage;
        DateTime fecha;
        public AddMascota()
        {
            InitializeComponent();
            CultureInfo ci = new CultureInfo(Thread.CurrentThread.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            ci.DateTimeFormat.DateSeparator = "/";
            Thread.CurrentThread.CurrentCulture = ci;
            FechaNacimientoDatePicker.SelectedDate = DateTime.Today;
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
            mascota.FechaNacimiento = fecha;

            var bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.UriSource = new Uri(PathImage);
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

            mascota.Foto = data;

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
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == true)
                PathImage = openFileDialog.FileName;
            Mascota mascota = new Mascota();
            var bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.UriSource = new Uri(PathImage);
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

            mascota.Foto = data;

        }

        private void FechaNacimientoDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            fecha = FechaNacimientoDatePicker.SelectedDate.Value.Date;
        }
    }
}