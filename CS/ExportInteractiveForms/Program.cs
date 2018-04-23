using DevExpress.Pdf;

namespace ExportInteractiveForms {
    class Program {
        static void Main(string[] args) {

            using (PdfDocumentProcessor processor = new PdfDocumentProcessor()) {

                // Load a PDF document with AcroForm data. 
                processor.LoadDocument("..\\..\\InteractiveForm.pdf");

                // Export AcroForm data to XML format.
                processor.Export("..\\..\\InteractiveForm.xml", PdfFormDataFormat.Xml);
            }
        }
    }
}
