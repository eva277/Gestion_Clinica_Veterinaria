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

namespace Proyecto_Clinic_Veterinaria
{
    /// <summary>
    /// Lógica de interacción para AddTipoCita.xaml
    /// </summary>
    public partial class AddTipoCita : UserControl
    {
        public AddTipoCita()
        {
            InitializeComponent();
        }
        private TipoCita EnlazarDatos()
        {
            TipoCita tipoCita = new TipoCita();

            tipoCita.Nombre = NombretextBox.Text;
            tipoCita.Motivo = MotivotextBox2.Text;
            tipoCita.Importancia = Convert.ToInt16(ImportanciatextBox1.Text);

            return tipoCita;
        }
    }
}
