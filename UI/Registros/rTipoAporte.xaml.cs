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
    /// Interaction logic for rTipoAporte.xaml
    /// </summary>
    public partial class rTipoAporte : Window
    {
       // private TipoAportes tipo = new TipoAportes();
        public rTipoAporte()
        {
            InitializeComponent();
            //this.DataContext = tipo;
        }
        /*private void Limpiar()
        {
            this.tipo = new TipoAportes();
            this.DataContext = tipo;
        }
        private bool Validar()
        {
            bool esValido = true;

            if (TextID.Text.Length == 0 || TextTipo.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Ingrese la descripcion", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return esValido;
        }
        private void BtnBuscar(object sender, RoutedEventArgs e)
        {
            var tipo = TipoAporteBLL.Buscar(Utilidades.ToInt(TextID.Text));

            if (tipo != null)
                this.tipo = tipo;
            else
                this.tipo = new TipoAportes();

            this.DataContext = this.tipo;
        }

        private void BtnNuevo(object sender, RoutedEventArgs e)
        {
            Limpiar(); 
        }

        private void BtnGuardar(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            var paso = TipoAporteBLL.Guardar(tipo);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccione exitosa!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Transaccion Fallida", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void BtnEliminar(object sender, RoutedEventArgs e)
        {
            if (TipoAporteBLL.Eliminar(Utilidades.ToInt(TextID.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro eliminado!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("No fue posible eliminar", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }
        */
    }
}
