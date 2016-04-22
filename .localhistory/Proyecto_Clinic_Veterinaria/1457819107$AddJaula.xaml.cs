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
using Proyecto_Clinic_Veterinaria.DAL;

namespace Proyecto_Clinic_Veterinaria
{
    /// <summary>
    /// Lógica de interacción para AddJaula.xaml
    /// </summary>
    public partial class AddJaula : UserControl
    {
        PropertyValidateModel validador = new PropertyValidateModel();
        private UnitOfWork uow = new UnitOfWork();
        Jaula jaula;
        int idUser;

        public AddJaula()
        {
            InitializeComponent();
            jaula = new Jaula();
            DataContext = jaula;
            UserComboBox.ItemsSource = uow.RepositorioUsuarios.Get()
                .Select(h => new
                {
                    h.UsuarioId,
                    h.NombreCompleto,
                });
            UserComboBox.DisplayMemberPath = "NombreCompleto";
            UserComboBox.SelectedValuePath = "UsuarioId";
        }
        private void EnlazarDatos()
        {
            jaula.Alto = Convert.ToInt16(AltotextBox.Text);
            jaula.Ancho = Convert.ToInt16(AnchotextBox_Copy.Text);
            jaula.Fondo = Convert.ToInt16(FondotextBox_Copy1.Text);
            if (OcupadacheckBox.IsChecked == true)
            {
                jaula.Ocupada = true;
            }
            else
            {
                jaula.Ocupada = false;
            }
            jaula.UsuarioId = idUser;
       }

        private void Acceptbutton_Click(object sender, RoutedEventArgs e)
        {

            if (validador.errrores(jaula) != "")
            {
                MessageBox.Show(validador.errrores(jaula));
            }
            else
            {
                EnlazarDatos();
                uow.RepositorioJaula.Insert(jaula);
                uow.Save();
                ClearTextBox();
                MessageBox.Show("Los datos se han añadido correctamente");
            }
        }
        private void ClearTextBox()
        {
            AltotextBox.Clear();
            AnchotextBox_Copy.Clear();
            FondotextBox_Copy1.Clear();
        }

        private void TipoJaulacomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TipoJaulacomboBox.SelectedItem != null)
            {
                ComboBoxItem tipo = (ComboBoxItem)TipoJaulacomboBox.SelectedItem;
                jaula.TipoJaula = tipo.Content.ToString();
            }
        }

        private void UserComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UserComboBox.SelectedItem != null)
            {
                idUser = Convert.ToInt16(UserComboBox.SelectedValue);
            }
        }
    }
}
