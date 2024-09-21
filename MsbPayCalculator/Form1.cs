using System.ComponentModel.DataAnnotations;

namespace MsbPayCalculator;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        Calculate();
    }

    private void Calculate()
    {
        if (ValidateTimeFormat(textBox1.Text, out var result))
        {
            if (decimal.TryParse(textBox2.Text, out decimal nib))
            {
                if (decimal.TryParse(textBox4.Text, out decimal payPerHour))
                {
                    var minInHour = (decimal)1.0 / 60;

                    var mins = minInHour * result.Item2;

                    var totaltime = mins + result.Item1;

                    var pay = totaltime * payPerHour;

                    var payWNib = pay * (nib / 100);

                    textBox5.Text = $"${payWNib.ToString("0.##")}";

                    var payResult = pay - payWNib;

                    textBox3.Text = $"${payResult.ToString("0.##")}";
                }
            }
        }
    }

    private bool ValidateTimeFormat(string text, out Tuple<int, int> result)
    {

        if (!string.IsNullOrEmpty(text))
        {
            var split = text.Split(':');

            if (split.Length == 2)
            {
                if (int.TryParse(split[0], out int rs1))
                {
                    if (int.TryParse(split[1], out int rs2))
                    {
                        result = new Tuple<int, int>(rs1, rs2);
                        return true;
                    }
                }
            }
        }

        result = null;
        return false;
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        Calculate();
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {
        Calculate();
    }
}
