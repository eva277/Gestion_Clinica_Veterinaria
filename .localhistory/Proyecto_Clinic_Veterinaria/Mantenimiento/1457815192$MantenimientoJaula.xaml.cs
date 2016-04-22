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

namespace Proyecto_Clinic_Veterinaria.Mantenimiento
{
    /// <summary>
    /// Lógica de interacción para AddJaula.xaml
    /// </summary>
    public partial class MantenimientoJaula : UserControl
    {
        PropertyValidateModel validador = new PropertyValidateModel();
        private UnitOfWork uow = new UnitOfWork();
        Jaula jaula;
        string opcion;
        int idOwner;

        public MantenimientoJaula()
        {
            InitializeComponent();
            jaula = new Jaula();
            DataContext = jaula;
            ListJails();
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
            jaula.JaulaId = Convert.ToInt16(idtextBox.Text);
            jaula.TipoJaula = TipoJaulacomboBox.SelectedItem.ToString();
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

        }
        private void ListJails()
        {
            JaulasdataGrid.ItemsSource = uow.RepositorioJaula.Get().Select(
                h => new
                {
                    h.JaulaId,
                    h.TipoJaula,
                    h.Ocupada,
                    h.Medida
                });
        }
        private void ClearTextBox()
        {
            idtextBox.Clear();
            AltotextBox.Clear();
            AnchotextBox_Copy.Clear();
            FondotextBox_Copy1.Clear();
        }
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(idtextBox.Text))
            {
                MessageBox.Show("Debe Ingresar el id para Modificar los datos");

            }
            else
            {
                jaula.JaulaId = Convert.ToInt16(idtextBox.Text);
                if (validador.errrores(jaula) != "")
                {
                    MessageBox.Show(validador.errrores(jaula));
                }
                else
                {
                    EnlazarDatos();
                    uow.RepositorioJaula.Update(jaula.JaulaId, jaula);
                    uow.Save();
                    MessageBox.Show("Los datos se han modificado conrrectamente");
                    ListJails();
                    ClearTextBox();
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(idtextBox.Text))
            {
                MessageBox.Show("Debe ingresar el id para borrar los datos");
            }
            else
            {
                EnlazarDatos();
                uow.RepositorioJaula.Delete(jaula.JaulaId);
                uow.Save();
                MessageBox.Show("Los datos se han eliminado correctamente");
                ListJails();
                ClearTextBox();
            }
        }

        private void TipoJaulacomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TipoJaulacomboBox.SelectedItem != null)
            {
                ComboBoxItem tipo = (ComboBoxItem)TipoJaulacomboBox.SelectedItem;
                jaula.TipoJaula = tipo.Content.ToString();
            }
        }

        private void Listbutton_Click(object sender, RoutedEventArgs e)
        {
            ListJails();
        }

        private void SearchcomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SearchcomboBox.SelectedItem != null)
            {
                ComboBoxItem tipo = (ComboBoxItem)SearchcomboBox.SelectedItem;
                opcion = tipo.Content.ToString();
                if (opcion.Equals("Disponibilidad"))
                {
                    SearchTextbox.Text = "Libre / Ocupada"; 
                }
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(SearchTextbox.Text) && (SearchcomboBox.SelectedItem != null))
            {
                JaulasdataGrid.ItemsSource = uow.RepositorioJaula.Buscar(opcion, SearchTextbox.Text);
            }
            else
            {
                MessageBox.Show("Debe ingresar un campo para realizar la busqueda");
            }
        }

        private void UserComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UserComboBox.SelectedItem != null)
            {
                idOwner = Convert.ToInt16(UserComboBox.SelectedValue);
            }
        }


    }
}
