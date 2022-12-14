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
    /// Lógica interna para gabarito.xaml
    /// </summary>
    public partial class gabarito : Window
    {
        public gabarito()
        {
            InitializeComponent();
        }

        private void voltarTela(object sender, MouseButtonEventArgs e)
        {
            TelaCurso telaCurso = new TelaCurso();
            telaCurso.Show();
            Close();
        }
    }
}
