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

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Paciente paciente = new Paciente();

                paciente.Nome = txtNome.Text;
                paciente.CPF = txtCPF.Text;
                paciente.Nasc = txtNasc.Text;
                paciente.UF = cbUF.SelectedValue.ToString();
                paciente.Cidade = txtCidade.Text;
                paciente.End = txtEnd.Text;
                paciente.FichaMedica = txtObs.Text;
                

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
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbUF.Items.Add("AC");
            cbUF.Items.Add("AL");
            cbUF.Items.Add("AP");
            cbUF.Items.Add("AM");
            cbUF.Items.Add("BA");
            cbUF.Items.Add("CE");
            cbUF.Items.Add("DF");
            cbUF.Items.Add("ES");
            cbUF.Items.Add("GO");
            cbUF.Items.Add("MA");
            cbUF.Items.Add("MT");
            cbUF.Items.Add("MS");
            cbUF.Items.Add("MG");
            cbUF.Items.Add("PA");
            cbUF.Items.Add("PB");
            cbUF.Items.Add("PR");
            cbUF.Items.Add("PE");
            cbUF.Items.Add("PI");
            cbUF.Items.Add("RR");
            cbUF.Items.Add("RO");
            cbUF.Items.Add("RJ");
            cbUF.Items.Add("RN");
            cbUF.Items.Add("RS");
            cbUF.Items.Add("SC");
            cbUF.Items.Add("SP");
            cbUF.Items.Add("SE");
            cbUF.Items.Add("TO");
        }
    }
}
