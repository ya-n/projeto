using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Controller;
using Model;
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
    /// Interaction logic for EditarPaciente.xaml
    /// </summary>
    public partial class EditarPaciente : Window
    {
        Paciente paciente = new Paciente();
        PacientesController pacientesController = new PacientesController();
        public EditarPaciente()
        {
            InitializeComponent();
            MessageBox.Show("Favor preencher o ID do Paciente");
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                paciente = pacientesController.BuscarPorID(Convert.ToInt32(txtID.Text));
                paciente.Nome = txtNome.Text;
                paciente.CPF = txtCPF.Text;
                paciente.Nasc = txtNasc.Text;
                paciente.UF = cbUF.Text;
                paciente.Cidade = txtCidade.Text;
                paciente.End = txtEnd.Text;
                paciente.FichaMedica = txtObs.Text;

                pacientesController.Atualizar(paciente);

                MessageBox.Show("Cadastro do Paciente alterado. ");


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao alterar cadastro do Paciente (" + ex.Message + ")");
            }
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                paciente = pacientesController.BuscarPorID(Convert.ToInt32(txtID.Text));

                if (paciente != null)
                    pacientesController.Excluir((Convert.ToInt32(txtID.Text)));
                MessageBox.Show("O Paciente foi excluido.");


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao excluir o Paciente (" + ex.Message + ")");
            }
        }

        private void txtID_LostFocus(object sender, RoutedEventArgs e)
        {
            paciente = pacientesController.BuscarPorID(Convert.ToInt32(txtID.Text));
            if (paciente != null)
            {
                txtNome.Text = paciente.Nome;
                txtCPF.Text = paciente.CPF;
                txtNasc.Text = paciente.Nasc;
                cbUF.Text = paciente.UF;
                txtCidade.Text = paciente.Cidade;
                txtEnd.Text = paciente.End;
                txtObs.Text = paciente.FichaMedica;
            }
        }
    }
}
