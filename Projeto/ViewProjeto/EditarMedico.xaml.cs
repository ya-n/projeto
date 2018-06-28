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

                cliente = controllerCliente.BuscarClientePorID(Convert.ToInt32(txtID.Text));
                cliente.Nome = txtNome.Text;
                cliente.CPF = txtCPF.Text;
                cliente.Email = txtEmail.Text;
                cliente.Telefone = txtTelefone.Text;
                controllerCliente.AlterCliente(cliente);

                MessageBox.Show("Cliente alterado com sucesso!! ");
                


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao alterar Cliente (" + ex.Message + ")");
            }
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cliente = controllerCliente.BuscarClientePorID(Convert.ToInt32(txtID.Text));
                if (cliente != null)
                    controllerCliente.Excluir((Convert.ToInt32(txtID.Text)));
                MessageBox.Show("Cliente excluido com sucesso!");
                dgDadosCliente.Items.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao excluir Cliente (" + ex.Message + ")");
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
