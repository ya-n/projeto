using System.Windows;

namespace ViewProjeto
{
    /// <summary>
    /// Interaction logic for MenuMedico.xaml
    /// </summary>
    public partial class MenuMedico : Window
    {
        public MenuMedico()
        {
            InitializeComponent();
        }

        private void btnCadastrarMedico_click(object sender, RoutedEventArgs e)
        {
            CadastrarMedico mm = new CadastrarMedico();
            mm.ShowDialog();
        }

        private void btnListar (object sender, RoutedEventArgs e)
        {
            ListarMedico telaListarMedico = new ListarMedico();
            telaListarMedico.ShowDialog();
        }

        private void btnEditar(object sender, RoutedEventArgs e)
        {
            EditarMedico editarMedico = new EditarMedico();
            editarMedico.ShowDialog();
        }
    }
}
