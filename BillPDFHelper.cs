using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace BakeryShopManagementSystem
{
    class BillPDFHelper
    {
        public static void PrintBill(string customerName, string phone, decimal totalAmount)
        {
            string filePath = @"D:\Bill.pdf";

            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

            doc.Open();

            doc.Add(new Paragraph("                    --<-<-<  CAKE  AND  BAKE  >->->--       "));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("                             Customer Bill Receipt               "));
            doc.Add(new Paragraph("                ........................................................     "));
            doc.Add(new Paragraph("                           Customer Name: " + customerName));
            doc.Add(new Paragraph("                           Phone: " + phone));
            doc.Add(new Paragraph("                           Total Amount: " + totalAmount));
            doc.Add(new Paragraph("                           Date: " + System.DateTime.Now));
            doc.Add(new Paragraph("                   ............................................................   "));
            doc.Add(new Paragraph("                          Thank you for visiting our Shop          "));


            doc.Close();

            System.Diagnostics.Process.Start(filePath);
        }
    }
}
