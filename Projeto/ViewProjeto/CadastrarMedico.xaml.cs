using System;
using Model;
using Controller;
using System.Windows;
using System.Windows.Controls;

namespace ViewProjeto
{
    /// <summary>
    /// Interaction logic for CadastrarMedico.xaml
    /// </summary>
    public partial class CadastrarMedico : Window
    {
        public CadastrarMedico()
        {
            InitializeComponent();
        }


        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Medico medico = new Medico();

                medico.Nome = txtNome.Text;
                medico.CPF = txtCPF.Text;
                medico.Nasc = txtNasc.Text;
                medico.UF = cbUF.SelectedValue.ToString();
                medico.Cidade = txtCidade.Text;
                medico.End = txtEnd.Text;
                medico.CRM = txtCRM.Text;

                MedicosController medicosController = new MedicosController();
                medicosController.Cadastrar(medico);

                MessageBox.Show("Mé7dico salvo com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar Médico (" + ex.Message + ")");
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
       

        private void Window_Loaded_Loaded(object sender, RoutedEventArgs e)
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
