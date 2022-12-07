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
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
        }

        private void btnGerar(object sender, MouseButtonEventArgs e)
        {
            string nomeArquivo = @"/avaliação.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            string dados = "";

            Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));

            paragrafo.Alignment = Element.ALIGN_LEFT;
            paragrafo.Add("Avaliação");

            doc.Open();
            doc.Add(paragrafo);
            doc.Close();
        }
    }
}
