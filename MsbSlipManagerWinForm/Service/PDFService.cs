using MsbSlipManagerWinForm.Models;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Barcode;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Interactive;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;

namespace MsbSlipManagerWinForm.Service;
internal static class PDFService
{

    //Create PdfTrueTypeFont from stream with different size. 
    private static PdfTrueTypeFont headerFont = new PdfTrueTypeFont(new Font("Helvetica", 18));
    private static PdfTrueTypeFont subHeaderFont = new PdfTrueTypeFont(new Font("Helvetica", 10));
    private static PdfTrueTypeFont arialRegularFont = new PdfTrueTypeFont(new Font("Regular", 18));
    private static PdfTrueTypeFont arialBoldFont = new PdfTrueTypeFont(new Font("Bold", 9));


    //Create brush with black color. 
    private static PdfBrush blackBrush = new PdfSolidBrush(Color.FromArgb(0, 0, 0, 255));

    public static MemoryStream CreatePDF(List<Tuple<string,string>> Item,bool isNewSlip = false)
    {
        RectangleF TotalPriceCellBounds = RectangleF.Empty;
        RectangleF QuantityCellBounds = RectangleF.Empty;

        //Create a new PDF document.
        using (PdfDocument document = new PdfDocument())
        {
            document.PageSettings.Orientation = PdfPageOrientation.Portrait;

            document.PageSettings.Margins.All = 20;


            for (int i = 0; i < Item.Count; i++)
            {
                var s1 = new Slip { SlipId = Item[i].Item1 };
                var s2 = new Slip { SlipId = Item[i].Item2 };

                PrinterSettings printerSettings = new PrinterSettings();



                //Add a page to the document.
                PdfPage page = document.Pages.Add();

                //Create PDF graphics for the page.
                PdfGraphics graphics = page.Graphics;

                //Get the page width and height
                float pageWidth = page.GetClientSize().Width;
                float pageHeight = page.GetClientSize().Height;

                //Set the header height
                float headerHeight = 100;

                //Create string format.
                PdfStringFormat format = new PdfStringFormat();
                format.Alignment = PdfTextAlignment.Center;
                format.LineAlignment = PdfVerticalAlignment.Middle;

                CreateSlip(s1, page, document, 0, graphics, format, pageWidth, headerHeight,isNewSlip);

                graphics.DrawLine(new PdfPen(Color.Black), new PointF(0, pageHeight / 2), new PointF(pageWidth, pageHeight / 2));

                CreateSlip(s2, page, document, (pageHeight / 2) + 20, graphics, format, pageWidth, headerHeight,isNewSlip);
            }


            document.Save("output.pdf");
            var ms = new MemoryStream();
            document.Save(ms);
            ms.Position = 0;
            return ms;
        }
    }

    private static float CreateSlip(Slip Item, PdfPage page, PdfDocument document, float yPos, PdfGraphics graphics, PdfStringFormat format, float pageWidth, float headerHeight,bool isNewSlip)
    {
        float y = yPos;
        float x = 0;

        //Set the margins of address.
        float margin = 25;

        //Set the line space.
        float lineSpace = 20;

        #region Header         

        string title = "MORE SECURITY BAHAMAS";
        string subTitle = "PHONE: 325-5886/636-1068 P.O.BOX N1687 NASSAU BAHAMAS";
        string subTitle1 = "info@moresecuritybahamas.com";
        string subTitle2 = "WHEELCHAIR SLIPS";
        string slipId = string.IsNullOrWhiteSpace(Item.SlipId) ? "N/A" : Item.SlipId;

        DrawImage("company_logo", new PointF(10, y + -10), new SizeF(108, 98.5f), graphics);

        //Measure the string size using font. 
        SizeF textSize = headerFont.MeasureString(title);
        graphics.DrawString(title, headerFont, blackBrush, new PointF(pageWidth - textSize.Width, y + 10), format);
        graphics.DrawString(subTitle, subHeaderFont, blackBrush, new PointF(pageWidth - textSize.Width, y + 35), format);
        graphics.DrawString(subTitle1, subHeaderFont, blackBrush, new PointF(pageWidth - textSize.Width, y + 50), format);
        graphics.DrawString(slipId, subHeaderFont, blackBrush, new PointF(pageWidth - textSize.Width, y + 65), format);
        graphics.DrawString(subTitle2, headerFont, blackBrush, new PointF(pageWidth - textSize.Width, y + 85), format);

        //Create font from font stream. 
        arialRegularFont = new PdfTrueTypeFont(new Font("Regular", 14,FontStyle.Regular));

        #endregion

        #region QRBarcode
        //Drawing QR barcode 
        PdfQRBarcode qrBarcode = new PdfQRBarcode();
        qrBarcode.Size  = new SizeF(80,80);
        //Set Error Correction Level
        qrBarcode.ErrorCorrectionLevel = PdfErrorCorrectionLevel.High;
        //Set XDimension
        qrBarcode.XDimension = 3;
        qrBarcode.Text = slipId;
        //Draw string
        //page.Graphics.DrawString(qrBarcode.Text, new PdfStandardFont(PdfFontFamily.Helvetica, 10, PdfFontStyle.Bold), PdfBrushes.Black, new PointF(pageWidth - 50, y + -30));
        //Printing barcode on to the PDF
        qrBarcode.Draw(page, new PointF(pageWidth - 200, y + 270));
        #endregion

        y = y + headerHeight + margin;
        x = margin;

        int column2Spacing = 300;

        //Draw text to PDF page with provided font and location. 

        graphics.DrawString("Date:_______________________", arialRegularFont, PdfBrushes.Black, new PointF(x, y));
        graphics.DrawString("Flight Number:_______________________", arialRegularFont, PdfBrushes.Black, new PointF(x + column2Spacing, y));

        if(!isNewSlip)
        {
            graphics.DrawString(Item.DateTime.Date.ToString("D"), arialRegularFont, PdfBrushes.Black, new PointF(x + 80, y - 5));
        }

        graphics.DrawString($"{Item.Airline} {Item.FlightNumber}", arialRegularFont, PdfBrushes.Black, new PointF(x + (column2Spacing + 80), y - 5));

        y += arialRegularFont.Height + lineSpace;
        graphics.DrawString("Passenger Name:____________________", arialRegularFont, PdfBrushes.Black, new PointF(x, y));
        graphics.DrawString("Passenger Signature:__________________________", arialRegularFont, PdfBrushes.Black, new PointF(x + column2Spacing, y));
        graphics.DrawString(Item.CustomerName, arialRegularFont, PdfBrushes.Black, new PointF(x + 80, y - 5));
        //DrawImage(new MemoryStream(Item.PassengerSignatureStream), new PointF(x + 560, y - 40), new SizeF(54, 49.25f), graphics, assembly);

         
        y += arialRegularFont.Height + lineSpace;
        graphics.DrawString("Airline Agent:_______________________", arialRegularFont, PdfBrushes.Black, new PointF(x, y));
        graphics.DrawString("Airline Signature:___________________", arialRegularFont, PdfBrushes.Black, new PointF(x + column2Spacing, y));
        graphics.DrawString(Item.AgentName, arialRegularFont, PdfBrushes.Black, new PointF(x + 80, y - 5));
        //DrawImage(new MemoryStream(Item.AgentSignatureStream), new PointF(x + 560, y - 40), new SizeF(54, 49.25f), graphics, assembly);

        y += arialRegularFont.Height + lineSpace;
        graphics.DrawString("Start Time:__________________________", arialRegularFont, PdfBrushes.Black, new PointF(x, y));
        graphics.DrawString("End Time:____________________________", arialRegularFont, PdfBrushes.Black, new PointF(x + column2Spacing, y));

        if(!isNewSlip)
        {
            graphics.DrawString(Item.StartTime.ToLongTimeString(), arialRegularFont, PdfBrushes.Black, new PointF(x + 80, y - 5));
            graphics.DrawString(Item.EndTime.ToLongTimeString(), arialRegularFont, PdfBrushes.Black, new PointF(x + (column2Spacing + 80), y - 5));
        }

        y += arialRegularFont.Height + lineSpace;
        
        graphics.DrawString("Employee Name:_______________________", arialRegularFont, PdfBrushes.Black, new PointF(x, y));
        
        //graphics.DrawString("Employee Signature:_______________________", arialRegularFont, PdfBrushes.Black, new PointF(x + 400, y));
       
        if (!isNewSlip)
        {
            graphics.DrawString(Item.EmployeeID.ToString(), arialRegularFont, PdfBrushes.Black, new PointF(x + 80, y - 5));
        }

        //DrawImage("company_logo_embeded", new PointF(x + 560, y - 40), new SizeF(54, 49.25f), graphics, assembly);

        y += arialRegularFont.Height + (lineSpace - 10);

        y += arialRegularFont.Height + 5;
        graphics.DrawString("I Will Walk", arialBoldFont, PdfBrushes.Black, new PointF(x, y));
        //'Create a check box
        var checkBox = new PdfCheckBoxField(page, "C#.NET");
        checkBox.Bounds = new RectangleF(x + 10, y, 20, 20);
        checkBox.HighlightMode = PdfHighlightMode.Push;
        checkBox.BorderStyle = PdfBorderStyle.Beveled;
        //'Set the value for the check box
        checkBox.Checked = true;
        document.Form.Fields.Add(checkBox);

        y += arialRegularFont.Height + 5;
        graphics.DrawString("Service No Longer Needed", arialBoldFont, PdfBrushes.Black, new PointF(x, y));

        //if (Item.IWillWalk || Item.ServiceNoLongerNeeded)
        //{
        //    graphics.DrawString("Additional Options:", arialRegularFont, PdfBrushes.Black, new PointF(x, y));


        //    if (Item.IWillWalk)
        //    {
        //        y += arialRegularFont.Height + 5;
        //        graphics.DrawString("I Will Walk", arialRegularFont, PdfBrushes.Black, new PointF(x, y));
        //    }


        //    if (Item.ServiceNoLongerNeeded)
        //    {
        //        y += arialRegularFont.Height + 5;
        //        graphics.DrawString("Service No Longer Needed", arialRegularFont, PdfBrushes.Black, new PointF(x, y));
        //    }
        //}

        return y;
    }

    private static void DrawImage(string imageName, PointF position, SizeF dimensions, PdfGraphics graphics)
    {
        Bitmap image = GetImageByName(imageName);

        //Create PDF bitmap image from stream.
        PdfBitmap bitmap = new PdfBitmap(image);

        //Draw the image to PDF page. 
        graphics.DrawImage(bitmap, position, dimensions);
    }

    public static Bitmap GetImageByName(string imageName)
    {
        var rm = Resource1.ResourceManager;
        return (Bitmap)rm.GetObject(imageName);
    }

    private static void DrawImage(Stream stream, PointF position, SizeF dimensions, PdfGraphics graphics, Assembly assembly)
    {
        //Create PDF bitmap image from stream.
        PdfBitmap bitmap = new PdfBitmap(stream);

        //Draw the image to PDF page. 
        graphics.DrawImage(bitmap, position, dimensions);
    }
}
