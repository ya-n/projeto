using Model;
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
            try
            {
                Paciente p = new Paciente();

                //p.Nome = txtNome.Text;

                PacientesController pacientesController = new PacientesController();
                pacientesController.Adicionar(p);

                MessageBox.Show("Usuário salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o usuário (" + ex.Message + ")");
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }

 }
