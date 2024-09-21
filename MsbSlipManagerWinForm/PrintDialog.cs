using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Windows.PdfViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsbSlipManagerWinForm;
public partial class PrintDialog : Form
{
    public PrintDialog()
    {
        InitializeComponent();
    }

    public void LoadDocument(Stream pdf)
    {
        pdfViewerControl1.PrinterSettings.PageSize = PdfViewerPrintSize.Fit;
        pdfViewerControl1.Load(pdf);

    }
}
