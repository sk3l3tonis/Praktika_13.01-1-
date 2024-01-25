using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.IO;
using System.Windows.Forms;

namespace PDF
{
    public partial class Form1 : Form
    {
        private string path;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Stream outStream = new FileStream("C:\\Users\\kosti\\Desktop\\PDF Documents\\PDFTest1.pdf", FileMode.OpenOrCreate))
            {
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, outStream);

                document.Open();
                try
                {
                    PdfContentByte to = writer.DirectContent;

                    to.BeginText();
                    try
                    {
                        to.SetFontAndSize(BaseFont.CreateFont(), 12);
                        to.SetTextMatrix(50,800);
                        to.ShowText(textBox1.Text);
                        MessageBox.Show("PDF-файл был успешно создан!");
                    }
                    finally
                    {
                        to.EndText();
                    }
                }
                finally
                {
                    document.Close();
                }
            }


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
