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
    /// Lógica de interacción para AddTipoCita.xaml
    /// </summary>
    public partial class AddTipoAtencion : UserControl
    {
        PropertyValidateModel validador = new PropertyValidateModel();
        private UnitOfWork uow = new UnitOfWork();
        TipoAtencion tipoCita;
        int idUsuario;
        string nombre;
        string motivo;

        public AddTipoAtencion()
        {

            InitializeComponent();
            tipoCita = new TipoAtencion();
            DataContext = tipoCita;
            UsuariocomboBox.ItemsSource = uow.RepositorioUsuarios.Get()
                .Select(h => new
                {
                    h.UsuarioId,
                    h.NombreCompleto,
                });
            UsuariocomboBox.DisplayMemberPath = "NombreCompleto";
            UsuariocomboBox.SelectedValuePath = "UsuarioId";
        }
        private void getTipoCita()
        {
            tipoCita.Nombre = nombre;
            tipoCita.Motivo = motivo;
            tipoCita.Importancia = Convert.ToInt16(ImportanciatextBox1.Text);
        }

        private void UsuariocomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UsuariocomboBox.SelectedItem != null)
            {
                idUsuario = Convert.ToInt16(UsuariocomboBox.SelectedValue);
            }
        }

        private void Acceptbutton_Click(object sender, RoutedEventArgs e)
        {
            if (validador.errrores(tipoCita) != "")
            {
                MessageBox.Show(validador.errrores(tipoCita));
            }
            else
            {
                getTipoCita();
                uow.RepositorioTipoCitas.Insert(tipoCita);
                uow.Save();
                MessageBox.Show("Los datos se han añadido correctamente");
            }
        }

        private void NombrecomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MotivocomboBox_Copy.Items.Clear();
            if (NombrecomboBox.SelectedItem != null)
            {
                ComboBoxItem tipo = (ComboBoxItem)NombrecomboBox.SelectedItem;
                nombre = tipo.Content.ToString();
                if (nombre.Equals("Control"))
                {
                    
                    MotivocomboBox_Copy.IsEnabled = true;
                    MotivocomboBox_Copy.Items.Add("Control");
                    MotivocomboBox_Copy.Items.Add("Post Operatorio");
                    MotivocomboBox_Copy.Items.Add("Post Parto");
                }
                else if (nombre.Equals("Vacunacion"))
                {
                    MotivocomboBox_Copy.IsEnabled = true;
                    MotivocomboBox_Copy.Items.Add("Anti Rabia");
                    MotivocomboBox_Copy.Items.Add("Anti Parasitaria");
                    MotivocomboBox_Copy.Items.Add("Quadruple");
                }
                else if (nombre.Equals("Corte Pelo"))
                {
                    MotivocomboBox_Copy.IsEnabled = true;
                    MotivocomboBox_Copy.Items.Add("Corte");
                }
            }
        }

        private void MotivocomboBox_Copy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MotivocomboBox_Copy.SelectedItem != null)
            {
                ComboBoxItem tipo = (ComboBoxItem)MotivocomboBox_Copy.SelectedItem;
                motivo = tipo.Content.ToString();
            }
        }
    }
}
