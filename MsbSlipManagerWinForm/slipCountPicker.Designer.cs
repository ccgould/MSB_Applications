namespace MsbSlipManagerWinForm;

partial class slipCountPicker
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
        label1 = new Label();
        numericUpDown1 = new NumericUpDown();
        printBtn = new Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(20, 27);
        label1.Name = "label1";
        label1.Size = new Size(100, 20);
        label1.TabIndex = 0;
        label1.Text = "Enter Amount";
        // 
        // numericUpDown1
        // 
        numericUpDown1.Increment = new decimal(new int[] { 2, 0, 0, 0 });
        numericUpDown1.Location = new Point(20, 50);
        numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(456, 27);
        numericUpDown1.TabIndex = 1;
        numericUpDown1.Value = new decimal(new int[] { 2, 0, 0, 0 });
        // 
        // printBtn
        // 
        printBtn.Location = new Point(187, 124);
        printBtn.Name = "printBtn";
        printBtn.Size = new Size(94, 29);
        printBtn.TabIndex = 2;
        printBtn.Text = "PRINT";
        printBtn.UseVisualStyleBackColor = true;
        printBtn.Click += printBtn_Click;
        // 
        // slipCountPicker
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(510, 169);
        Controls.Add(printBtn);
        Controls.Add(numericUpDown1);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "slipCountPicker";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Generate and Print";
        Load += slipCountPicker_Load;
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private NumericUpDown numericUpDown1;
    private Button printBtn;
}