<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595485/16.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T491302)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Program.cs](./CS/ExportInteractiveForms/Program.cs) (VB: [Program.vb](./VB/ExportInteractiveForms/Program.vb))
<!-- default file list end -->
# PDF Document API - Export Interactive Form Data to an XML File


This example shows how to export AcroForm data (interactive form data) from a PDF document to XML format.<br><br>You can also export the AcroForm data to FDF, XFDF, and TXT formats using the approach described below.


<h3>Description</h3>

To export&nbsp;interactive form&nbsp;data&nbsp;to XML format:<br><br>- load a document containing interactive forms (e.g., from a file path)&nbsp;using the&nbsp;<a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_LoadDocumenttopic">PdfDocumentProcessor.LoadDocument</a> method; <br>- call one of the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_Exporttopic">PdfDocumentProcessor.Export </a>overloaded methods, for example, with a specified XML file name including a file path, where the exported document will be located, and&nbsp;XML data format.

<br/>


