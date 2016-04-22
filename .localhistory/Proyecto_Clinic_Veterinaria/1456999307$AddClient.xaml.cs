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
using Proyecto_Clinic_Veterinaria.DAL;

namespace Proyecto_Clinic_Veterinaria
{
    /// <summary>
    /// Lógica de interacción para AddClient.xaml
    /// </summary>
    public partial class AddClient : UserControl
    {
        PropertyValidateModel validador = new PropertyValidateModel();
        private UnitOfWork uow = new UnitOfWork();
        Usuario usu;
        string tipoUsu;

        public AddClient()
        {
            InitializeComponent();
            usu = new Usuario();
            DataContext = usu;
        }

        private Cliente EnlazarDatos()
        {
            Cliente cliente = new Cliente();

            cliente.Nombre = NombretextBox.Text;
            cliente.Apellidos = ApellidostextBox.Text;
            cliente.Direccion = DirecciontextBox_Copy5.Text;
            cliente.CodigoPostal = CodigoPostalTextbox.Text;
            cliente.Telefono = TelefonoTextbox.Text;
            cliente.Email = EmailtextBox.Text;

            return cliente;
        }
    }
}
