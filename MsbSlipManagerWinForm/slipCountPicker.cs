using MsbSlipManagerWinForm.Models;
using MsbSlipManagerWinForm.Service;
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
public partial class slipCountPicker : Form
{
    public slipCountPicker()
    {
        InitializeComponent();
    }

    private void slipCountPicker_Load(object sender, EventArgs e)
    {

    }

    private void printBtn_Click(object sender, EventArgs e)
    {
        SlipsDAO s = new SlipsDAO();
        var slipID = s.AddNewGeneratedSlip(Convert.ToInt32(numericUpDown1.Value));
        var slipsDoc = PDFService.CreatePDF(slipID,true);

        PrintDialog pd = new PrintDialog();
        pd.LoadDocument(slipsDoc);
        pd.Show();
        Close();
    }
}
