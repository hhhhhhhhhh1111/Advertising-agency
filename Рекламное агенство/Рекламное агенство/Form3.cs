using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace Рекламное_агенство
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ночка f2 = new ночка();
            f2.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текст заказа", "Заказ 1");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текст заказа", "Заказ 2");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текст заказа", "Заказ 3");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текст заказа", "Заказ 4");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текст заказа", "Заказ 5");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текст заказа", "Заказ 6");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заказ успешно зарегистрирован!", "Регистрация заказа");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заказ успешно удален", "Удаление заказа");
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;
            if (startDate > endDate)
            {
                MessageBox.Show("Начальная дата не может быть больше конечной даты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxResult.Text = $"в период с {startDate.ToShortDateString()} по {endDate.ToShortDateString()}";
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            // Путь к существующему Word документу
            string existingDocPath = @"C:\Users\Mihai\Downloads\dogovor.docx";
            //Путь для сохранения копии Word документа
            string tempDocPath = @"C:\Users\Mihai\Downloads\temp_dogovor.docx";
            // Путь для сохранения PDF документа
            string pdfSavePath = @"C:\Users\Mihai\Downloads\dogovorfull.pdf";
            File.Copy(existingDocPath, tempDocPath, true);
            DateTime Dogovortime = DateTime.Now;
            string DogovortimeS = Dogovortime.ToShortDateString();
            // Собираем текст из TextBox'ов
            var replacements = new Dictionary<string, string>
            {
                { "ФИО", textBox1.Text},
                { "ПЕРИОД", textBoxResult.Text},
                { "ПАКЕТ_УСЛУГ", textBox3.Text},
                { "СТОИМОСТЬ", textBox2.Text},
                { "СЕГОДНЯ", DogovortimeS},
                { "ОПЛАТА", textBox2.Text}
                // Добавьте другие замены, если у вас есть дополнительные TextBox'ы
            };
            ReplaceTextInWordDocument(tempDocPath, replacements);
            SaveWordDocumentAsPdf(tempDocPath, pdfSavePath);
            MessageBox.Show("Документ сохранен в формате PDF.");
        }
        private void ReplaceTextInWordDocument(string documentPath, Dictionary<string, string> replacements)
        {
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(documentPath, true))
            {
                var body = wordDoc.MainDocumentPart.Document.Body;
                foreach (var text in body.Descendants<Text>())
                {
                    foreach (var placeholder in replacements.Keys)
                    {
                        if (text.Text.Contains(placeholder))
                        {
                            text.Text = text.Text.Replace(placeholder, replacements[placeholder]);
                        }
                    }
                }
                wordDoc.MainDocumentPart.Document.Save();
            }
        }
        private void SaveWordDocumentAsPdf(string wordFilePath, string pdfFilePath)
        {
            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = null;

            try
            {
                wordDoc = wordApp.Documents.Open(wordFilePath);
                wordDoc.ExportAsFixedFormat(pdfFilePath, Word.WdExportFormat.wdExportFormatPDF);
            }
            finally
            {
                if (wordDoc != null)
                {
                    wordDoc.Close(false);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDoc);
                }
                wordApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
            }
        }
    }
}
