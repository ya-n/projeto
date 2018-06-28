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
        Paciente paciente= new Paciente();
        PacientesController pacientesController = new PacientesController();
        public EditarPaciente()
        {
            InitializeComponent();
        }
    }
}
