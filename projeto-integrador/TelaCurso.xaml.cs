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
    /// Lógica interna para TelaCurso.xaml
    /// </summary>
    public partial class TelaCurso : Window
    {
        public TelaCurso()
        {
            InitializeComponent();
        }

        private void btnDS(object sender, MouseButtonEventArgs e)
        {
            TelaModulo TelaModulo = new TelaModulo();
            TelaModulo.Show();
            Close();
        }
    }
}
