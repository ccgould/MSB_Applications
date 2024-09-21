namespace MsbSlipManagerWinForm;

partial class AddNewEmployee
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
        nameTxtb = new TextBox();
        label2 = new Label();
        numericUpDown1 = new NumericUpDown();
        button1 = new Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 41);
        label1.Name = "label1";
        label1.Size = new Size(49, 20);
        label1.TabIndex = 0;
        label1.Text = "Name";
        // 
        // nameTxtb
        // 
        nameTxtb.Location = new Point(82, 38);
        nameTxtb.Name = "nameTxtb";
        nameTxtb.Size = new Size(342, 27);
        nameTxtb.TabIndex = 1;
        nameTxtb.TextChanged += nameTxtb_TextChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 74);
        label2.Name = "label2";
        label2.Size = new Size(94, 20);
        label2.TabIndex = 2;
        label2.Text = "Employee ID";
        // 
        // numericUpDown1
        // 
        numericUpDown1.Location = new Point(112, 72);
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(150, 27);
        numericUpDown1.TabIndex = 3;
        // 
        // button1
        // 
        button1.DialogResult = DialogResult.OK;
        button1.Location = new Point(168, 145);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 4;
        button1.Text = "Save";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // AddNewEmployee
        // 
        AcceptButton = button1;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(462, 186);
        Controls.Add(button1);
        Controls.Add(numericUpDown1);
        Controls.Add(label2);
        Controls.Add(nameTxtb);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "AddNewEmployee";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Add New Employee";
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox nameTxtb;
    private Label label2;
    private NumericUpDown numericUpDown1;
    private Button button1;
}