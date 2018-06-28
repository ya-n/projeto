using System;
using System.Windows;
using Controller;
using Model;

namespace ViewProjeto
{
    /// <summary>
    /// Interaction logic for EditarMedico.xaml
    /// </summary>
    public partial class EditarMedico : Window
    {
        Medico medico;
        MedicosController medicosController = new MedicosController();

        public EditarMedico()
        {
            InitializeComponent();
            MessageBox.Show("Favor preencher o CRM");
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                medico = medicosController.BuscarPorID(Convert.ToString(txtCRM.Text));
                medico.Nome = txtNome.Text;
                medico.CPF = txtCPF.Text;
                medico.Nasc = txtNasc.Text;
                medico.UF = txtUF.Text;
                medico.Cidade = txtCidade.Text;
                medico.End = txtEnd.Text;
                medico.CRM = txtCRM.Text;

                medicosController.Atualizar(medico);

                MessageBox.Show("Cadastro do Médico alterado. ");


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao alterar cadastro do Médico (" + ex.Message + ")");
            }
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                medico = medicosController.BuscarPorID(Convert.ToString(txtCRM.Text));

                if (medico != null)
                    medicosController.Excluir((Convert.ToString(txtCRM.Text)));
                MessageBox.Show("O Médico foi excluido.");


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao excluir o Médico (" + ex.Message + ")");
            }
        }




        private void txtCRM_LostFocus(object sender, RoutedEventArgs e)
        {
            medico = medicosController.BuscarPorID(txtCRM.Text);
            if (medico != null)
            {
                txtNome.Text = medico.Nome;
                txtCPF.Text = medico.CPF;
                txtNasc.Text = medico.Nasc;
                txtUF.Text = medico.UF;
                txtCidade.Text = medico.Cidade;
                txtEnd.Text = medico.End;
            }
        }
    }
}
