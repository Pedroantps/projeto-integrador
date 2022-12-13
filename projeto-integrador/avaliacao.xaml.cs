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
    /// Lógica interna para avaliacao.xaml
    /// </summary>
    public partial class avaliacao : Window
    {
        
        public avaliacao()
        {
            InitializeComponent();
        }

        public void questoes()
        {
            string enunciado = txtQuestao1.Text;
            string alternativaA = txtAlternativaA1.Text;
            string alternativaB = txtAlternativaB1.Text;
            string alternativaC = txtAlternativaC1.Text;
            string alternativaD = txtAlternativaD1.Text;
            string modulo = "";
            Questao questao = consultaQuestao.ObterQuestao(enunciado, alternativaA, alternativaB, alternativaC, alternativaD, modulo);
            if (questao != null)
            {
                enunciado = questao.enunciado;
                alternativaA = questao.alternativaA;
                alternativaB = questao.alternativaB;
                alternativaC = questao.alternativaC;
                alternativaD = questao.alternativaD;
            }
        }
    }
}
