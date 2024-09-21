namespace MsbSlipManagerWinForm;

partial class ExportExcel
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
        dataGridView1 = new DataGridView();
        groupBox1 = new GroupBox();
        filterBTN = new Button();
        label15 = new Label();
        employeeCmb2 = new ComboBox();
        label14 = new Label();
        label13 = new Label();
        label12 = new Label();
        dateTimePicker2 = new DateTimePicker();
        dateTimePicker = new DateTimePicker();
        label9 = new Label();
        label8 = new Label();
        airlineFilterCmbBox = new ComboBox();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(12, 97);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(1010, 414);
        dataGridView1.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        groupBox1.Controls.Add(filterBTN);
        groupBox1.Controls.Add(label15);
        groupBox1.Controls.Add(employeeCmb2);
        groupBox1.Controls.Add(label14);
        groupBox1.Controls.Add(label13);
        groupBox1.Controls.Add(label12);
        groupBox1.Controls.Add(dateTimePicker2);
        groupBox1.Controls.Add(dateTimePicker);
        groupBox1.Controls.Add(label9);
        groupBox1.Controls.Add(label8);
        groupBox1.Controls.Add(airlineFilterCmbBox);
        groupBox1.Location = new Point(12, 20);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(1010, 71);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "groupBox1";
        // 
        // filterBTN
        // 
        filterBTN.Location = new Point(918, 35);
        filterBTN.Margin = new Padding(3, 2, 3, 2);
        filterBTN.Name = "filterBTN";
        filterBTN.Size = new Size(82, 22);
        filterBTN.TabIndex = 36;
        filterBTN.TabStop = false;
        filterBTN.Text = "Search";
        filterBTN.UseVisualStyleBackColor = true;
        filterBTN.Click += exportBTN_Click;
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Location = new Point(3, 35);
        label15.Name = "label15";
        label15.Size = new Size(62, 15);
        label15.TabIndex = 35;
        label15.Text = "Employee:";
        // 
        // employeeCmb2
        // 
        employeeCmb2.AutoCompleteMode = AutoCompleteMode.Suggest;
        employeeCmb2.AutoCompleteSource = AutoCompleteSource.ListItems;
        employeeCmb2.FormattingEnabled = true;
        employeeCmb2.Items.AddRange(new object[] { "American Airlines", "Bahamasair", "British Airways", "Caribbean Airlines", "Copa Airlines", "SouthWest", "Inter Caribbean", "United Airlines" });
        employeeCmb2.Location = new Point(76, 33);
        employeeCmb2.Margin = new Padding(3, 2, 3, 2);
        employeeCmb2.Name = "employeeCmb2";
        employeeCmb2.Size = new Size(174, 23);
        employeeCmb2.TabIndex = 34;
        employeeCmb2.TabStop = false;
        employeeCmb2.Text = "All";
        employeeCmb2.SelectedIndexChanged += employeeCmb2_SelectedIndexChanged;
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(724, 17);
        label14.Name = "label14";
        label14.Size = new Size(12, 15);
        label14.TabIndex = 33;
        label14.Text = "-";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(818, 17);
        label13.Name = "label13";
        label13.Size = new Size(19, 15);
        label13.TabIndex = 32;
        label13.Text = "To";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(610, 17);
        label12.Name = "label12";
        label12.Size = new Size(35, 15);
        label12.TabIndex = 31;
        label12.Text = "From";
        // 
        // dateTimePicker2
        // 
        dateTimePicker2.Location = new Point(744, 36);
        dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
        dateTimePicker2.Name = "dateTimePicker2";
        dateTimePicker2.Size = new Size(156, 23);
        dateTimePicker2.TabIndex = 30;
        dateTimePicker2.TabStop = false;
        // 
        // dateTimePicker
        // 
        dateTimePicker.Location = new Point(560, 36);
        dateTimePicker.Margin = new Padding(3, 2, 3, 2);
        dateTimePicker.Name = "dateTimePicker";
        dateTimePicker.Size = new Size(156, 23);
        dateTimePicker.TabIndex = 27;
        dateTimePicker.TabStop = false;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(522, 37);
        label9.Name = "label9";
        label9.Size = new Size(34, 15);
        label9.TabIndex = 29;
        label9.Text = "Date:";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(276, 37);
        label8.Name = "label8";
        label8.Size = new Size(44, 15);
        label8.TabIndex = 28;
        label8.Text = "Airline:";
        // 
        // airlineFilterCmbBox
        // 
        airlineFilterCmbBox.AutoCompleteMode = AutoCompleteMode.Suggest;
        airlineFilterCmbBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        airlineFilterCmbBox.FormattingEnabled = true;
        airlineFilterCmbBox.Items.AddRange(new object[] { "All", "American Airlines", "Bahamasair", "British Airways", "Caribbean Airlines", "Copa Airlines", "SouthWest", "Inter Caribbean", "United Airlines" });
        airlineFilterCmbBox.Location = new Point(337, 35);
        airlineFilterCmbBox.Margin = new Padding(3, 2, 3, 2);
        airlineFilterCmbBox.Name = "airlineFilterCmbBox";
        airlineFilterCmbBox.Size = new Size(174, 23);
        airlineFilterCmbBox.TabIndex = 26;
        airlineFilterCmbBox.TabStop = false;
        airlineFilterCmbBox.Text = "All";
        // 
        // ExportExcel
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1034, 523);
        Controls.Add(groupBox1);
        Controls.Add(dataGridView1);
        Name = "ExportExcel";
        Text = "ExportExcel";
        Load += ExportExcel_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView1;
    private GroupBox groupBox1;
    private Button filterBTN;
    private Label label15;
    private ComboBox employeeCmb2;
    private Label label14;
    private Label label13;
    private Label label12;
    private DateTimePicker dateTimePicker2;
    private DateTimePicker dateTimePicker;
    private Label label9;
    private Label label8;
    private ComboBox airlineFilterCmbBox;
}