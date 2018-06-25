using Controller;
using Model;
using System.Windows;
using System.Windows.Controls;


namespace ViewProjeto
{
    /// <summary>
    /// Interaction logic for ListarPaciente.xaml
    /// </summary>
    public partial class ListarPaciente : Window
    {
        public ListarPaciente()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PacientesController pacientesController = new PacientesController();
            dgPacientes.ItemsSource = pacientesController.ListarTodos();
        }

        private void dgPacientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

            Paciente p = (Paciente)dg.Items[dg.SelectedIndex];
        }
    }
}
