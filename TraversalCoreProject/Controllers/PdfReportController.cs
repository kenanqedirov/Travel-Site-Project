using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReport/" + "Doc1.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            Paragraph paragraph = new Paragraph("Traversal Reservation PDF Report");
            document.Add(paragraph);
            document.Close();
            return File("/PdfReport/Doc1.pdf","application/pdf","Doc1.pdf");
        }
        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReport/" + "Doc2.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            PdfPTable pdfPTable = new PdfPTable(3);
            pdfPTable.AddCell("Customer name");
            pdfPTable.AddCell("Customer Surname");
            pdfPTable.AddCell("ID");

            pdfPTable.AddCell("Kenan");
            pdfPTable.AddCell("Qedirov");
            pdfPTable.AddCell("5149849466");

            pdfPTable.AddCell("Senan");
            pdfPTable.AddCell("Qasimov");
            pdfPTable.AddCell("5649848494");

            pdfPTable.AddCell("Murat");
            pdfPTable.AddCell("Yucedag");
            pdfPTable.AddCell("65158198419");

            document.Add(pdfPTable);
            document.Close();
            return File("/PdfReport/Doc2.pdf", "application/pdf", "Doc2.pdf");
        }
    }
     
}
