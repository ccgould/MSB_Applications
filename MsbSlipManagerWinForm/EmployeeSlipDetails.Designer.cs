namespace MsbSlipManagerWinForm;

partial class EmployeeSlipDetails
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
        components = new System.ComponentModel.Container();
        groupBox1 = new GroupBox();
        resultsDataGridView = new DataGridView();
        Airline = new DataGridViewTextBoxColumn();
        Count = new DataGridViewTextBoxColumn();
        dataGridView1 = new DataGridView();
        slipIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        employeeIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        flightNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        airlineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        customerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        agentNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        guardNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        dateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        startTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        endTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        slipBindingSource = new BindingSource(components);
        searchBtn = new Button();
        toDateTimePicker = new DateTimePicker();
        fromDateTimePicker = new DateTimePicker();
        employeeCmb = new ComboBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        slipBindingSource1 = new BindingSource(components);
        slipBindingSource2 = new BindingSource(components);
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)slipBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)slipBindingSource1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)slipBindingSource2).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        groupBox1.Controls.Add(resultsDataGridView);
        groupBox1.Location = new Point(12, 27);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(250, 689);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Information";
        // 
        // resultsDataGridView
        // 
        resultsDataGridView.AllowUserToAddRows = false;
        resultsDataGridView.AllowUserToDeleteRows = false;
        resultsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        resultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Airline, Count });
        resultsDataGridView.Location = new Point(6, 40);
        resultsDataGridView.Name = "resultsDataGridView";
        resultsDataGridView.RowHeadersWidth = 51;
        resultsDataGridView.Size = new Size(238, 643);
        resultsDataGridView.TabIndex = 0;
        // 
        // Airline
        // 
        Airline.DataPropertyName = "Key";
        Airline.HeaderText = "Airline";
        Airline.MinimumWidth = 6;
        Airline.Name = "Airline";
        Airline.ReadOnly = true;
        Airline.Width = 125;
        // 
        // Count
        // 
        Count.DataPropertyName = "Value";
        Count.HeaderText = "Count";
        Count.MinimumWidth = 6;
        Count.Name = "Count";
        Count.ReadOnly = true;
        Count.Width = 125;
        // 
        // dataGridView1
        // 
        dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView1.AutoGenerateColumns = false;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { slipIdDataGridViewTextBoxColumn, employeeIDDataGridViewTextBoxColumn, flightNumberDataGridViewTextBoxColumn, airlineDataGridViewTextBoxColumn, customerNameDataGridViewTextBoxColumn, agentNameDataGridViewTextBoxColumn, guardNameDataGridViewTextBoxColumn, dateTimeDataGridViewTextBoxColumn, startTimeDataGridViewTextBoxColumn, endTimeDataGridViewTextBoxColumn });
        dataGridView1.DataSource = slipBindingSource;
        dataGridView1.Location = new Point(268, 73);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(790, 643);
        dataGridView1.TabIndex = 1;
        // 
        // slipIdDataGridViewTextBoxColumn
        // 
        slipIdDataGridViewTextBoxColumn.DataPropertyName = "SlipId";
        slipIdDataGridViewTextBoxColumn.HeaderText = "SlipId";
        slipIdDataGridViewTextBoxColumn.MinimumWidth = 6;
        slipIdDataGridViewTextBoxColumn.Name = "slipIdDataGridViewTextBoxColumn";
        slipIdDataGridViewTextBoxColumn.Width = 125;
        // 
        // employeeIDDataGridViewTextBoxColumn
        // 
        employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
        employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
        employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
        employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
        employeeIDDataGridViewTextBoxColumn.Width = 125;
        // 
        // flightNumberDataGridViewTextBoxColumn
        // 
        flightNumberDataGridViewTextBoxColumn.DataPropertyName = "FlightNumber";
        flightNumberDataGridViewTextBoxColumn.HeaderText = "FlightNumber";
        flightNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
        flightNumberDataGridViewTextBoxColumn.Name = "flightNumberDataGridViewTextBoxColumn";
        flightNumberDataGridViewTextBoxColumn.Width = 125;
        // 
        // airlineDataGridViewTextBoxColumn
        // 
        airlineDataGridViewTextBoxColumn.DataPropertyName = "Airline";
        airlineDataGridViewTextBoxColumn.HeaderText = "Airline";
        airlineDataGridViewTextBoxColumn.MinimumWidth = 6;
        airlineDataGridViewTextBoxColumn.Name = "airlineDataGridViewTextBoxColumn";
        airlineDataGridViewTextBoxColumn.Width = 125;
        // 
        // customerNameDataGridViewTextBoxColumn
        // 
        customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
        customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
        customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
        customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
        customerNameDataGridViewTextBoxColumn.Width = 125;
        // 
        // agentNameDataGridViewTextBoxColumn
        // 
        agentNameDataGridViewTextBoxColumn.DataPropertyName = "AgentName";
        agentNameDataGridViewTextBoxColumn.HeaderText = "AgentName";
        agentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
        agentNameDataGridViewTextBoxColumn.Name = "agentNameDataGridViewTextBoxColumn";
        agentNameDataGridViewTextBoxColumn.Width = 125;
        // 
        // guardNameDataGridViewTextBoxColumn
        // 
        guardNameDataGridViewTextBoxColumn.DataPropertyName = "GuardName";
        guardNameDataGridViewTextBoxColumn.HeaderText = "GuardName";
        guardNameDataGridViewTextBoxColumn.MinimumWidth = 6;
        guardNameDataGridViewTextBoxColumn.Name = "guardNameDataGridViewTextBoxColumn";
        guardNameDataGridViewTextBoxColumn.Width = 125;
        // 
        // dateTimeDataGridViewTextBoxColumn
        // 
        dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
        dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
        dateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
        dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
        dateTimeDataGridViewTextBoxColumn.Width = 125;
        // 
        // startTimeDataGridViewTextBoxColumn
        // 
        startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
        startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
        startTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
        startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
        startTimeDataGridViewTextBoxColumn.Width = 125;
        // 
        // endTimeDataGridViewTextBoxColumn
        // 
        endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
        endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
        endTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
        endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
        endTimeDataGridViewTextBoxColumn.Width = 125;
        // 
        // slipBindingSource
        // 
        slipBindingSource.DataSource = typeof(Models.Slip);
        // 
        // searchBtn
        // 
        searchBtn.Location = new Point(916, 42);
        searchBtn.Name = "searchBtn";
        searchBtn.Size = new Size(94, 29);
        searchBtn.TabIndex = 2;
        searchBtn.Text = "Search";
        searchBtn.UseVisualStyleBackColor = true;
        searchBtn.Click += searchBtn_Click;
        // 
        // toDateTimePicker
        // 
        toDateTimePicker.Location = new Point(707, 42);
        toDateTimePicker.Name = "toDateTimePicker";
        toDateTimePicker.Size = new Size(183, 27);
        toDateTimePicker.TabIndex = 3;
        // 
        // fromDateTimePicker
        // 
        fromDateTimePicker.Location = new Point(520, 40);
        fromDateTimePicker.Name = "fromDateTimePicker";
        fromDateTimePicker.Size = new Size(160, 27);
        fromDateTimePicker.TabIndex = 4;
        // 
        // employeeCmb
        // 
        employeeCmb.FormattingEnabled = true;
        employeeCmb.Location = new Point(268, 39);
        employeeCmb.Name = "employeeCmb";
        employeeCmb.Size = new Size(227, 28);
        employeeCmb.TabIndex = 5;
        employeeCmb.SelectedIndexChanged += employeeCmb_SelectedIndexChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(268, 12);
        label1.Name = "label1";
        label1.Size = new Size(75, 20);
        label1.TabIndex = 6;
        label1.Text = "Employee";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(520, 12);
        label2.Name = "label2";
        label2.Size = new Size(43, 20);
        label2.TabIndex = 7;
        label2.Text = "From";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(686, 47);
        label3.Name = "label3";
        label3.Size = new Size(15, 20);
        label3.TabIndex = 8;
        label3.Text = "-";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(707, 12);
        label4.Name = "label4";
        label4.Size = new Size(25, 20);
        label4.TabIndex = 9;
        label4.Text = "To";
        // 
        // slipBindingSource1
        // 
        slipBindingSource1.DataSource = typeof(Models.Slip);
        // 
        // slipBindingSource2
        // 
        slipBindingSource2.DataSource = typeof(Models.Slip);
        // 
        // EmployeeSlipDetails
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1060, 728);
        Controls.Add(dataGridView1);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(employeeCmb);
        Controls.Add(fromDateTimePicker);
        Controls.Add(toDateTimePicker);
        Controls.Add(searchBtn);
        Controls.Add(groupBox1);
        Name = "EmployeeSlipDetails";
        Text = "Employee Data Viewer";
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)slipBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)slipBindingSource1).EndInit();
        ((System.ComponentModel.ISupportInitialize)slipBindingSource2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox groupBox1;
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn slipIdDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn flightNumberDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn airlineDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn agentNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn guardNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
    private BindingSource slipBindingSource;
    private Button searchBtn;
    private DateTimePicker toDateTimePicker;
    private DateTimePicker fromDateTimePicker;
    private ComboBox employeeCmb;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private DataGridView resultsDataGridView;
    private DataGridViewTextBoxColumn Airline;
    private DataGridViewTextBoxColumn Count;
    private BindingSource slipBindingSource1;
    private BindingSource slipBindingSource2;
}