using GestionPersonas.BLL;
using GestionPersonas.Entidades;
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
using System.Windows.Shapes;

namespace GestionPersonas.UI.Registros
{
    /// <summary>
    /// Interaction logic for rAportes.xaml
    /// </summary>
    public partial class rAportes : Window
    {
        private Aportes aportes = new Aportes();
        public rAportes()
        {
            InitializeComponent();

            this.DataContext = aportes;

            PersonaComboBox.ItemsSource = PersonasBLL.GetPersonas();
            PersonaComboBox.SelectedValuePath = "PersonaId";
            PersonaComboBox.DisplayMemberPath = "Nombres";

           
        }
        private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = aportes;
        }
        private void Limpiar()
        {
            this.aportes = new Aportes();
            this.DataContext = aportes;
        }
        private void BtnBuscar(object sender, RoutedEventArgs e)
        {
            Aportes encontrado = AporteBLL.Buscar(aportes.AporteId);

            if (encontrado != null)
            {
                aportes = encontrado;
                Cargar();
            }
            else
            {
                Limpiar();
                MessageBox.Show("Grupo no existe en la base de datos", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnNuevo(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Aportes esValido = AporteBLL.Buscar(aportes.AporteId);

            return (esValido != null);
        }
        private void BtnGuardar(object sender, RoutedEventArgs e)
        {
            bool paso = false;

            
            
                
            
           paso = AporteBLL.Guardar(aportes);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Fallo al guardar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void BtnEliminar(object sender, RoutedEventArgs e)
        {
            Aportes existe = AporteBLL.Buscar(aportes.AporteId);

            if (existe == null)
            {
                MessageBox.Show("No existe el grupo en la base de datos", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                AporteBLL.Eliminar(aportes.AporteId);
                MessageBox.Show("Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                Limpiar();
            }
        }

        private void BtnAgregar(object sender, RoutedEventArgs e)
        {
            aportes.Detalle.Add(new TipoAportes
            {
                AporteId = aportes.AporteId,
                Persona = (Personas)PersonaComboBox.SelectedItem,
                Valor = float.Parse(TextValor.Text),
                TipoAporte = TextTipo.Text,
               

            }) ;
            aportes.Monto += float.Parse(TextValor.Text);
            
            Cargar();

            TextTipo.Focus();
            TextTipo.Clear();
        }

        private void BtnEliminarFila(object sender, RoutedEventArgs e)
        {
            if (DetalleDataGrid.Items.Count >= 1 && DetalleDataGrid.SelectedIndex <= DetalleDataGrid.Items.Count - 1)
            {
                aportes.Detalle.RemoveAt(DetalleDataGrid.SelectedIndex);
                Cargar();
            }
        }
    }
}
