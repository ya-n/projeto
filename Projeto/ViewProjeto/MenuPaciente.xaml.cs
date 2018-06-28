using System.Windows;

namespace ViewProjeto
{
    /// <summary>
    /// Interaction logic for MenuPaciente.xaml
    /// </summary>
    public partial class MenuPaciente : Window
    {
        public MenuPaciente()
        {
            InitializeComponent();
        }

        private void btnCadastrarPaciente_click(object sender, RoutedEventArgs e)
        {
            CadastrarPaciente mp = new CadastrarPaciente();
            mp.ShowDialog();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnListar (object sender, RoutedEventArgs e)
        {
            ListarPaciente telaListarPaciente = new ListarPaciente();
            telaListarPaciente.ShowDialog();
        }

        private void btnEditar(object sender, RoutedEventArgs e)
        {
            EditarPaciente editarPaciente = new EditarPaciente();
            editarPaciente.ShowDialog();
        }
    }

 }
