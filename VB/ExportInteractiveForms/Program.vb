Imports DevExpress.Pdf

Namespace ExportInteractiveForms
    Friend Class Program
        Shared Sub Main(ByVal args() As String)

            Using processor As New PdfDocumentProcessor()

                ' Load a PDF document with AcroForm data. 
                processor.LoadDocument("..\..\InteractiveForm.pdf")

                ' Export AcroForm data to XML format.
                processor.Export("..\..\InteractiveForm.xml", PdfFormDataFormat.Xml)
            End Using
        End Sub
    End Class
End Namespace
