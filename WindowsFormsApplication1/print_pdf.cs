using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class print_pdf
    {


        public String current_datetime(String dateortime)
        {

            DateTime current = DateTime.Now;

            if (dateortime.Equals("date"))
            {
                return current.ToString("yyyy-MM-dd");
            }
            if (dateortime.Equals("time"))
            {
                return current.ToLongTimeString();
            }
            // Change String to time-----------   DateTime enteredDate = DateTime.Parse(enteredString);
            return null;
        }

        public void Create_pdf(String in_time,String out_time,double tot_toatal,String Name) {

            float tot = (float)(Math.Round((double)tot_toatal, 2));

            var exportFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var exportFile = System.IO.Path.Combine(exportFolder, "hasan/"+Name+".pdf");

             using (var write = new PdfWriter(exportFile))
              {
                 using (var pdf_doc = new PdfDocument(write))
                 {
                    pdf_doc.SetDefaultPageSize(iText.Kernel.Geom.PageSize.A6);

                    Document doc = new Document(pdf_doc);
                                    

                    Paragraph p1 = new Paragraph("CAR PARK").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                    p1.SetFontSize(25);
                    p1.SetFontColor(iText.Kernel.Colors.Color.BLUE);
                    doc.Add(p1);
                    Paragraph p2 = new Paragraph(DateTime.Now.ToString()).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                    p2.SetFontSize(12);
                    p2.SetFontColor(iText.Kernel.Colors.Color.BLACK);
                    doc.Add(p2);


                    Table table = new Table(2);
                    table.SetBorder(iText.Layout.Borders.Border.NO_BORDER);
                    table.AddCell("Arrival");
                    table.AddCell(": "+in_time);
                    table.AddCell("Departure");
                    table.AddCell(": " + out_time);
                    table.AddCell("Total Amount");
                    table.AddCell(": Rs."+tot);

                    doc.Add(table);

                    Paragraph p3 = new Paragraph("Thank You\n Come Again....").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                    p3.SetFontSize(11);
                    p3.SetFontColor(iText.Kernel.Colors.Color.DARK_GRAY);
                    doc.Add(p3);

                    doc.Close();

                    MessageBox.Show(Name + ".pdf has been created");


                           }
                 }

             }
    }
}
