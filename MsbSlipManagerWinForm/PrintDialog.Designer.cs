﻿using Syncfusion.Windows.Forms.PdfViewer;

namespace MsbSlipManagerWinForm;

partial class PrintDialog
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        MessageBoxSettings messageBoxSettings1 = new MessageBoxSettings();
        Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings1 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintDialog));
        TextSearchSettings textSearchSettings1 = new TextSearchSettings();
        pdfViewerControl1 = new PdfViewerControl();
        SuspendLayout();
        // 
        // pdfViewerControl1
        // 
        pdfViewerControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pdfViewerControl1.CursorMode = PdfViewerCursorMode.SelectTool;
        pdfViewerControl1.EnableContextMenu = true;
        pdfViewerControl1.EnableNotificationBar = true;
        pdfViewerControl1.HorizontalScrollOffset = 0;
        pdfViewerControl1.IsBookmarkEnabled = true;
        pdfViewerControl1.IsTextSearchEnabled = true;
        pdfViewerControl1.IsTextSelectionEnabled = true;
        pdfViewerControl1.Location = new Point(12, 12);
        messageBoxSettings1.EnableNotification = true;
        pdfViewerControl1.MessageBoxSettings = messageBoxSettings1;
        pdfViewerControl1.MinimumZoomPercentage = 50;
        pdfViewerControl1.Name = "pdfViewerControl1";
        pdfViewerControl1.PageBorderThickness = 1;
        pdfViewerPrinterSettings1.Copies = 1;
        pdfViewerPrinterSettings1.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto;
        pdfViewerPrinterSettings1.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize;
        pdfViewerPrinterSettings1.PrintLocation = (PointF)resources.GetObject("pdfViewerPrinterSettings1.PrintLocation");
        pdfViewerPrinterSettings1.ShowPrintStatusDialog = true;
        pdfViewerControl1.PrinterSettings = pdfViewerPrinterSettings1;
        pdfViewerControl1.ReferencePath = null;
        pdfViewerControl1.ScrollDisplacementValue = 0;
        pdfViewerControl1.ShowHorizontalScrollBar = true;
        pdfViewerControl1.ShowToolBar = true;
        pdfViewerControl1.ShowVerticalScrollBar = true;
        pdfViewerControl1.Size = new Size(776, 426);
        pdfViewerControl1.SpaceBetweenPages = 8;
        pdfViewerControl1.TabIndex = 1;
        pdfViewerControl1.Text = "pdfViewerControl1";
        textSearchSettings1.CurrentInstanceColor = Color.FromArgb(127, 255, 171, 64);
        textSearchSettings1.HighlightAllInstance = true;
        textSearchSettings1.OtherInstanceColor = Color.FromArgb(127, 254, 255, 0);
        pdfViewerControl1.TextSearchSettings = textSearchSettings1;
        pdfViewerControl1.ThemeName = "Default";
        pdfViewerControl1.VerticalScrollOffset = 0;
        pdfViewerControl1.VisualStyle = VisualStyle.Default;
        pdfViewerControl1.ZoomMode = ZoomMode.Default;
        // 
        // PrintDialog
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(pdfViewerControl1);
        Name = "PrintDialog";
        Text = "PrintDialog";
        ResumeLayout(false);
    }

    #endregion
    private PdfViewerControl pdfViewerControl1;
}