using Controller;
using System.Windows;
using System.Windows.Controls;
using Model;

namespace ViewProjeto
{
    /// <summary>
    /// Interaction logic for ListarMedico.xaml
    /// </summary>
    public partial class ListarMedico : Window
    {
        public ListarMedico()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MedicosController medicosController = new MedicosController();
            dgMedicos.ItemsSource = medicosController.ListarTodos();
        }

        private void dgMedicos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

            CadastrarMedico m = (Medico)dg.Items[dg.SelectedIndex];


        }
    }
}
