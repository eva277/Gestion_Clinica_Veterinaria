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
            tipoCita.Nombre = NombretextBox.Text;
            tipoCita.Motivo = MotivotextBox2.Text;
            tipoCita.Importancia = Convert.ToInt16(ImportanciatextBox1.Text);
            tipoCita.UsuarioId = idUsuario;

        }

        private void UsuariocomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UsuariocomboBox.SelectedItem != null)
            {
                ComboBoxItem tipo = (ComboBoxItem)UsuariocomboBox.SelectedItem;
                idUsuario = Convert.ToInt16(tipo.Content.ToString());
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
            if (String.IsNullOrWhiteSpace(textBlock.Text.ToString()))
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
                    uow.RepositorioTipoCitas.Update(Convert.ToInt16(textBlock.Text),tipoCita);
                    uow.Save();
                    MessageBox.Show("El registro se ha modificado conrrectamente");
                    ListarTipoCita();
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBlock.Text.ToString()))
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
                    uow.RepositorioTipoCitas.Delete(Convert.ToInt16(textBlock.Text));
                    uow.Save();
                    MessageBox.Show("El registro se ha eliminado conrrectamente");
                    ListarTipoCita();
                }
            }
        }
    }
}
