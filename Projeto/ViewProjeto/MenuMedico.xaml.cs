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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
