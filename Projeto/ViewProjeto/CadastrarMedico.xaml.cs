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
            comboBox.Items.Add("AC");
            comboBox.Items.Add("AL");
            comboBox.Items.Add("AP");
            comboBox.Items.Add("AM");
            comboBox.Items.Add("BA");
            comboBox.Items.Add("CE");
            comboBox.Items.Add("DF");
            comboBox.Items.Add("ES");
            comboBox.Items.Add("GO");
            comboBox.Items.Add("MA");
            comboBox.Items.Add("MT");
            comboBox.Items.Add("MS");
            comboBox.Items.Add("MG");
            comboBox.Items.Add("PA");
            comboBox.Items.Add("PB");
            comboBox.Items.Add("PR");
            comboBox.Items.Add("PE");
            comboBox.Items.Add("PI");
            comboBox.Items.Add("RR");
            comboBox.Items.Add("RO");
            comboBox.Items.Add("RJ");
            comboBox.Items.Add("RN");
            comboBox.Items.Add("RS");
            comboBox.Items.Add("SC");
            comboBox.Items.Add("SP");
            comboBox.Items.Add("SE");
            comboBox.Items.Add("TO");
        }
    }
}
