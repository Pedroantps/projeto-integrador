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

namespace projeto_integrador
{
    /// <summary>
    /// Lógica interna para TelaModulo.xaml
    /// </summary>
    public partial class TelaModulo : Window
    {
        public TelaModulo()
        {
            InitializeComponent();
        }

        private void btnPA(object sender, MouseButtonEventArgs e)
        {
            string modulo = "Programação de aplicativos";
            TelaRequisitos telaRequisitos = new TelaRequisitos(modulo);
            TelaRequisitos.Show();
            Close();
        }

        private void btnCSE(object sender, MouseButtonEventArgs e)
        {
            string modulo = "Comissionamento de sistmas embarcados";
            TelaRequisitos telaRequisitos = new TelaRequisitos(modulo);
            TelaRequisitos.Show();
            Close();
        }

        private void btnRDS(object sender, MouseButtonEventArgs e)
        {
            string modulo = "Rede de dados em sistema de manufatura";
            TelaRequisitos telaRequisitos = new TelaRequisitos(modulo);
            TelaRequisitos.Show();
            Close();
        }

        private void btnDS(object sender, MouseButtonEventArgs e)
        {
            string modulo = "Desenvolvimento de sistemas";
            TelaRequisitos telaRequisitos = new TelaRequisitos(modulo);
            TelaRequisitos.Show();
            Close();
        }
    }
}
