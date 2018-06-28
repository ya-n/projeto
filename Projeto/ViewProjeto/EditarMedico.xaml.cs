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
        Medico medico = new Medico();
        MedicosController medicosController = new MedicosController();
        public EditarMedico()
        {
            InitializeComponent();
        }
       

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                medico = medicosController.BuscarPorID(Convert.ToString(txtCRM.Text));
                txtNome.Text = medico.Nome;
                txtCPF.Text = medico.CPF;
                txtNasc.Text = medico.Nasc;
                txtUF.Text = medico.UF;
                txtCidade.Text = medico.Cidade;
                txtEnd.Text = medico.End;
                txtCRM.Text = medico.CRM;

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

     
        private void txtCRM_DragEnter(object sender, DragEventArgs e)
        {
            medico = medicosController.BuscarPorID(Convert.ToString(txtCRM.Text));
            txtNome.Text = medico.Nome;
            txtCPF.Text = medico.CPF;
            txtNasc.Text = medico.Nasc;
            txtUF.Text = medico.UF;
            txtCidade.Text = medico.Cidade;
            txtEnd.Text = medico.End;
        }
    }
}
