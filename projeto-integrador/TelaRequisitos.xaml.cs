using System;
using System.Collections.Generic;
using System.IO;
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

namespace projeto_integrador
{
    /// <summary>
    /// Lógica interna para TelaRequisitos.xaml
    /// </summary>
    public partial class TelaRequisitos : Window
    {
        public TelaRequisitos()
        {
            InitializeComponent();
            cbQntd.Items.Add("1");
            cbQntd.Items.Add("2");
            cbQntd.Items.Add("3");
            cbQntd.Items.Add("4");
            cbQntd.Items.Add("5");
            cbQntd.Items.Add("6");
            cbQntd.Items.Add("7");
            cbQntd.Items.Add("8");
            cbQntd.Items.Add("9");
            cbQntd.Items.Add("10");
        }

        private void btnGerar(object sender, MouseButtonEventArgs e)
        {
            avaliacao avaliacao = new avaliacao();
            avaliacao.Show();
            Close();
        }

        private void voltaTela(object sender, MouseButtonEventArgs e)
        {
            TelaCurso telaCurso = new TelaCurso();
            telaCurso.Show();
            Close();
        }
    }
}
