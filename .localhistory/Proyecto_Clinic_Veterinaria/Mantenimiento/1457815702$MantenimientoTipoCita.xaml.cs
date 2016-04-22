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
    /// Lógica de interacción para AddTipoCita.xaml
    /// </summary>
    public partial class MantenimientoTipoCita : UserControl
    {
        PropertyValidateModel validador = new PropertyValidateModel();
        private UnitOfWork uow = new UnitOfWork();
        TipoCita tipoCita;
        int idUsuario;
        string opcion;

        public MantenimientoTipoCita()
        {

            InitializeComponent();
            tipoCita = new TipoCita();
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
            tipoCita.TipoCitaID = Convert.ToInt16(idtextbox.Text);
            tipoCita.Nombre = NombretextBox.Text;
            tipoCita.Motivo = MotivotextBox2.Text;
            tipoCita.Importancia = Convert.ToInt16(ImportanciatextBox1.Text);
            tipoCita.UsuarioId = idUsuario;
        }

        private void UsuariocomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UsuariocomboBox.SelectedItem != null)
            {
                idUsuario =  Convert.ToInt16(UsuariocomboBox.SelectedValue);
            }
        }

        private void addbutton_Click(object sender, RoutedEventArgs e)
        {
            getTipoCita();
            if (validador.errrores(tipoCita) != "")
            {
                MessageBox.Show(validador.errrores(tipoCita));
            }
            else
            {
                uow.RepositorioTipoCitas.Insert(tipoCita);
                uow.Save();
                ListarTipoCita();
                MessageBox.Show("El registro se ha añadido correctamente");
            }
        }
        private void ListarTipoCita()
        {
            TipoCitaDatagrid.ItemsSource = uow.RepositorioTipoCitas.Get().Select(
                h => new {
                    h.TipoCitaID,
                    h.Nombre,
                    h.Motivo,
                    h.Importancia,
                }
            );
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(idtextbox.Text))
            {
                MessageBox.Show("Debe seleccionar un registro para modificar");
            }
            else
            {
                getTipoCita();
                if (validador.errrores(tipoCita) != "")
                {
                    MessageBox.Show(validador.errrores(tipoCita));
                }
                else
                {
                    uow.RepositorioTipoCitas.Update(Convert.ToInt16(idtextbox.Text),tipoCita);
                    uow.Save();
                    MessageBox.Show("El registro se ha modificado conrrectamente");
                    ListarTipoCita();
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(idtextbox.Text))
            {
                MessageBox.Show("Debe seleccionar un registro para eliminar");
            }
            else
            {
                getTipoCita();
                if (validador.errrores(tipoCita) != "")
                {
                    MessageBox.Show(validador.errrores(tipoCita));
                }
                else
                {
                    uow.RepositorioTipoCitas.Delete(Convert.ToInt16(idtextbox.Text));
                    uow.Save();
                    MessageBox.Show("El registro se ha eliminado conrrectamente");
                    ListarTipoCita();
                }
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
                TipoCitaDatagrid.ItemsSource = uow.RepositorioTipoCitas.Buscar(opcion, SearchTextbox.Text);
            }
            else
            {
                MessageBox.Show("Debe ingresar un campo para realizar la busqueda");
            }
        }

        private void Listbutton_Click(object sender, RoutedEventArgs e)
        {
            ListarTipoCita();
        }
    }
}
