using System.Windows;

namespace ViewProjeto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MenuPaciente(object sender, RoutedEventArgs e)
        {
            MenuPaciente mp = new MenuPaciente();
            mp.ShowDialog();
        }

        private void Button_MenuMedico(object sender, RoutedEventArgs e)
        {
            MenuMedico mm = new MenuMedico();
            mm.ShowDialog();
        }
    }
}
