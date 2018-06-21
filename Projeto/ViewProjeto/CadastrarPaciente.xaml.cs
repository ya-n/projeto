using Controller;
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
    /// Interaction logic for CadastrarPaciente.xaml
    /// </summary>
    public partial class CadastrarPaciente : Window
    {
        public CadastrarPaciente()
        {
            InitializeComponent();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBox.Items.Add("PR");
            comboBox.Items.Add("SC");
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Paciente paciente = new Paciente();

                paciente.Nome = txtNome.Text;
                paciente.CPF = txtCPF.Text;
                paciente.Nasc = txtNasc.Text;

                PacientesController pacientesController = new PacientesController();
                pacientesController.Cadastrar(paciente);

                MessageBox.Show("Paciente salvo com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar Paciente (" + ex.Message + ")");
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
