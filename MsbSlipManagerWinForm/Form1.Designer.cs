namespace MsbSlipManagerWinForm;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
        label1 = new Label();
        label2 = new Label();
        passengerNameTxtBox = new TextBox();
        label3 = new Label();
        agentNameTxtBox = new TextBox();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        submitBTN = new Button();
        groupBox1 = new GroupBox();
        groupBox2 = new GroupBox();
        slipCntLBL = new Label();
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
        historyListDataGrid = new DataGridView();
        slipIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        Airline = new DataGridViewTextBoxColumn();
        flightNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        customerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        agentNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        guardNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        dateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        startTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        endTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        slipBindingSource1 = new BindingSource(components);
        slipBindingSource2 = new BindingSource(components);
        slipBindingSource = new BindingSource(components);
        guardNameCmbBox = new ComboBox();
        startTime = new DateTimePicker();
        endTime = new DateTimePicker();
        airlineCmbBox = new ComboBox();
        fltNumTxtBox = new TextBox();
        dateTimePicker1 = new DateTimePicker();
        label10 = new Label();
        menuStrip1 = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        toolStripMenuItem3 = new ToolStripMenuItem();
        excelToolStripMenuItem = new ToolStripMenuItem();
        toolStripMenuItem1 = new ToolStripSeparator();
        exitToolStripMenuItem = new ToolStripMenuItem();
        toolsToolStripMenuItem = new ToolStripMenuItem();
        addNewEmployeeToolStripMenuItem = new ToolStripMenuItem();
        employeeDataViewerToolStripMenuItem = new ToolStripMenuItem();
        toolStripMenuItem2 = new ToolStripSeparator();
        printSlipsToolStripMenuItem = new ToolStripMenuItem();
        slipIdTxtB = new TextBox();
        label11 = new Label();
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        iWillWalkChkB = new CheckBox();
        serviceNoLongerNeededChkB = new CheckBox();
        holidayChkB = new CheckBox();
        overTimeChbK = new CheckBox();
        tabPage2 = new TabPage();
        groupBox3 = new GroupBox();
        radioButton3 = new RadioButton();
        radioButton2 = new RadioButton();
        radioButton1 = new RadioButton();
        dataGridView2 = new DataGridView();
        id = new DataGridViewTextBoxColumn();
        EmployeeName = new DataGridViewTextBoxColumn();
        dateCreated = new DataGridViewTextBoxColumn();
        received = new DataGridViewCheckBoxColumn();
        receivedDate = new DataGridViewTextBoxColumn();
        tabPage3 = new TabPage();
        importBTN = new Button();
        logsTxtB = new TextBox();
        validateChkB = new CheckBox();
        csvPathTxtb = new TextBox();
        csvBtn = new Button();
        label16 = new Label();
        contextMenuStrip1 = new ContextMenuStrip(components);
        editToolStripMenuItem = new ToolStripMenuItem();
        deleteToolStripMenuItem = new ToolStripMenuItem();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)historyListDataGrid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)slipBindingSource1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)slipBindingSource2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)slipBindingSource).BeginInit();
        menuStrip1.SuspendLayout();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        tabPage2.SuspendLayout();
        groupBox3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
        tabPage3.SuspendLayout();
        contextMenuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(3, 36);
        label1.Name = "label1";
        label1.Size = new Size(44, 15);
        label1.TabIndex = 0;
        label1.Text = "Airline:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(3, 67);
        label2.Name = "label2";
        label2.Size = new Size(87, 15);
        label2.TabIndex = 2;
        label2.Text = "Flight Number:";
        // 
        // passengerNameTxtBox
        // 
        passengerNameTxtBox.Location = new Point(114, 100);
        passengerNameTxtBox.Margin = new Padding(3, 2, 3, 2);
        passengerNameTxtBox.Name = "passengerNameTxtBox";
        passengerNameTxtBox.Size = new Size(214, 23);
        passengerNameTxtBox.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(3, 100);
        label3.Name = "label3";
        label3.Size = new Size(98, 15);
        label3.TabIndex = 4;
        label3.Text = "Passenger Name:";
        // 
        // agentNameTxtBox
        // 
        agentNameTxtBox.AutoCompleteMode = AutoCompleteMode.Suggest;
        agentNameTxtBox.Location = new Point(114, 141);
        agentNameTxtBox.Margin = new Padding(3, 2, 3, 2);
        agentNameTxtBox.Name = "agentNameTxtBox";
        agentNameTxtBox.Size = new Size(214, 23);
        agentNameTxtBox.TabIndex = 4;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(3, 141);
        label4.Name = "label4";
        label4.Size = new Size(77, 15);
        label4.TabIndex = 6;
        label4.Text = "Agent Name:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(3, 274);
        label5.Name = "label5";
        label5.Size = new Size(77, 15);
        label5.TabIndex = 8;
        label5.Text = "Guard Name:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(3, 175);
        label6.Name = "label6";
        label6.Size = new Size(63, 15);
        label6.TabIndex = 10;
        label6.Text = "Start Time:";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(3, 209);
        label7.Name = "label7";
        label7.Size = new Size(59, 15);
        label7.TabIndex = 12;
        label7.Text = "End Time:";
        // 
        // submitBTN
        // 
        submitBTN.Location = new Point(109, 369);
        submitBTN.Margin = new Padding(3, 2, 3, 2);
        submitBTN.Name = "submitBTN";
        submitBTN.Size = new Size(82, 22);
        submitBTN.TabIndex = 9;
        submitBTN.Text = "SUBMIT";
        submitBTN.UseVisualStyleBackColor = true;
        submitBTN.Click += submitBTN_Click;
        // 
        // groupBox1
        // 
        groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        groupBox1.Controls.Add(groupBox2);
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
        groupBox1.Controls.Add(historyListDataGrid);
        groupBox1.Location = new Point(350, 4);
        groupBox1.Margin = new Padding(3, 2, 3, 2);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(3, 2, 3, 2);
        groupBox1.Size = new Size(1022, 449);
        groupBox1.TabIndex = 15;
        groupBox1.TabStop = false;
        groupBox1.Text = "Logs";
        // 
        // groupBox2
        // 
        groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        groupBox2.Controls.Add(slipCntLBL);
        groupBox2.Location = new Point(11, 393);
        groupBox2.Margin = new Padding(3, 2, 3, 2);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(3, 2, 3, 2);
        groupBox2.Size = new Size(1005, 52);
        groupBox2.TabIndex = 26;
        groupBox2.TabStop = false;
        groupBox2.Text = "Information:";
        // 
        // slipCntLBL
        // 
        slipCntLBL.AutoSize = true;
        slipCntLBL.Location = new Point(5, 17);
        slipCntLBL.Name = "slipCntLBL";
        slipCntLBL.Size = new Size(74, 15);
        slipCntLBL.TabIndex = 0;
        slipCntLBL.Text = "Slip Count: 0";
        // 
        // filterBTN
        // 
        filterBTN.Location = new Point(926, 44);
        filterBTN.Margin = new Padding(3, 2, 3, 2);
        filterBTN.Name = "filterBTN";
        filterBTN.Size = new Size(82, 22);
        filterBTN.TabIndex = 25;
        filterBTN.TabStop = false;
        filterBTN.Text = "Search";
        filterBTN.UseVisualStyleBackColor = true;
        filterBTN.Click += filterBTN_Click;
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Location = new Point(11, 44);
        label15.Name = "label15";
        label15.Size = new Size(62, 15);
        label15.TabIndex = 24;
        label15.Text = "Employee:";
        // 
        // employeeCmb2
        // 
        employeeCmb2.AutoCompleteMode = AutoCompleteMode.Suggest;
        employeeCmb2.AutoCompleteSource = AutoCompleteSource.ListItems;
        employeeCmb2.FormattingEnabled = true;
        employeeCmb2.Items.AddRange(new object[] { "American Airlines", "Bahamasair", "British Airways", "Caribbean Airlines", "Copa Airlines", "SouthWest", "Inter Caribbean", "United Airlines" });
        employeeCmb2.Location = new Point(84, 42);
        employeeCmb2.Margin = new Padding(3, 2, 3, 2);
        employeeCmb2.Name = "employeeCmb2";
        employeeCmb2.Size = new Size(174, 23);
        employeeCmb2.TabIndex = 23;
        employeeCmb2.TabStop = false;
        employeeCmb2.Text = "All";
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(732, 26);
        label14.Name = "label14";
        label14.Size = new Size(12, 15);
        label14.TabIndex = 22;
        label14.Text = "-";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(826, 26);
        label13.Name = "label13";
        label13.Size = new Size(19, 15);
        label13.TabIndex = 21;
        label13.Text = "To";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(618, 26);
        label12.Name = "label12";
        label12.Size = new Size(35, 15);
        label12.TabIndex = 20;
        label12.Text = "From";
        // 
        // dateTimePicker2
        // 
        dateTimePicker2.Location = new Point(752, 45);
        dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
        dateTimePicker2.Name = "dateTimePicker2";
        dateTimePicker2.Size = new Size(156, 23);
        dateTimePicker2.TabIndex = 19;
        dateTimePicker2.TabStop = false;
        // 
        // dateTimePicker
        // 
        dateTimePicker.Location = new Point(568, 45);
        dateTimePicker.Margin = new Padding(3, 2, 3, 2);
        dateTimePicker.Name = "dateTimePicker";
        dateTimePicker.Size = new Size(156, 23);
        dateTimePicker.TabIndex = 9;
        dateTimePicker.TabStop = false;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(530, 46);
        label9.Name = "label9";
        label9.Size = new Size(34, 15);
        label9.TabIndex = 18;
        label9.Text = "Date:";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(284, 46);
        label8.Name = "label8";
        label8.Size = new Size(44, 15);
        label8.TabIndex = 17;
        label8.Text = "Airline:";
        // 
        // airlineFilterCmbBox
        // 
        airlineFilterCmbBox.AutoCompleteMode = AutoCompleteMode.Suggest;
        airlineFilterCmbBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        airlineFilterCmbBox.FormattingEnabled = true;
        airlineFilterCmbBox.Items.AddRange(new object[] { "All", "American Airlines", "Bahamasair", "British Airways", "Caribbean Airlines", "Copa Airlines", "SouthWest", "Inter Caribbean", "United Airlines" });
        airlineFilterCmbBox.Location = new Point(345, 44);
        airlineFilterCmbBox.Margin = new Padding(3, 2, 3, 2);
        airlineFilterCmbBox.Name = "airlineFilterCmbBox";
        airlineFilterCmbBox.Size = new Size(174, 23);
        airlineFilterCmbBox.TabIndex = 8;
        airlineFilterCmbBox.TabStop = false;
        airlineFilterCmbBox.Text = "All";
        airlineFilterCmbBox.SelectedIndexChanged += airlineFilterCmbBox_SelectedIndexChanged;
        // 
        // historyListDataGrid
        // 
        historyListDataGrid.AllowUserToAddRows = false;
        historyListDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        historyListDataGrid.AutoGenerateColumns = false;
        historyListDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        historyListDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        historyListDataGrid.Columns.AddRange(new DataGridViewColumn[] { slipIdDataGridViewTextBoxColumn, Airline, flightNumberDataGridViewTextBoxColumn, customerNameDataGridViewTextBoxColumn, agentNameDataGridViewTextBoxColumn, guardNameDataGridViewTextBoxColumn, dateTimeDataGridViewTextBoxColumn, startTimeDataGridViewTextBoxColumn, endTimeDataGridViewTextBoxColumn });
        historyListDataGrid.DataSource = slipBindingSource1;
        historyListDataGrid.Location = new Point(5, 70);
        historyListDataGrid.Margin = new Padding(3, 2, 3, 2);
        historyListDataGrid.MultiSelect = false;
        historyListDataGrid.Name = "historyListDataGrid";
        historyListDataGrid.RowHeadersWidth = 51;
        historyListDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        historyListDataGrid.Size = new Size(1012, 319);
        historyListDataGrid.TabIndex = 0;
        historyListDataGrid.TabStop = false;
        historyListDataGrid.CellMouseDown += historyListDataGrid_CellMouseDown;
        // 
        // slipIdDataGridViewTextBoxColumn
        // 
        slipIdDataGridViewTextBoxColumn.DataPropertyName = "SlipId";
        slipIdDataGridViewTextBoxColumn.HeaderText = "Slip Id";
        slipIdDataGridViewTextBoxColumn.MinimumWidth = 6;
        slipIdDataGridViewTextBoxColumn.Name = "slipIdDataGridViewTextBoxColumn";
        // 
        // Airline
        // 
        Airline.DataPropertyName = "Airline";
        Airline.HeaderText = "Airline";
        Airline.MinimumWidth = 6;
        Airline.Name = "Airline";
        Airline.ReadOnly = true;
        // 
        // flightNumberDataGridViewTextBoxColumn
        // 
        flightNumberDataGridViewTextBoxColumn.DataPropertyName = "FlightNumber";
        flightNumberDataGridViewTextBoxColumn.HeaderText = "Flight Number";
        flightNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
        flightNumberDataGridViewTextBoxColumn.Name = "flightNumberDataGridViewTextBoxColumn";
        // 
        // customerNameDataGridViewTextBoxColumn
        // 
        customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
        customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
        customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
        customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
        // 
        // agentNameDataGridViewTextBoxColumn
        // 
        agentNameDataGridViewTextBoxColumn.DataPropertyName = "AgentName";
        agentNameDataGridViewTextBoxColumn.HeaderText = "Agent Name";
        agentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
        agentNameDataGridViewTextBoxColumn.Name = "agentNameDataGridViewTextBoxColumn";
        // 
        // guardNameDataGridViewTextBoxColumn
        // 
        guardNameDataGridViewTextBoxColumn.DataPropertyName = "GuardName";
        guardNameDataGridViewTextBoxColumn.HeaderText = "Guard Name";
        guardNameDataGridViewTextBoxColumn.MinimumWidth = 6;
        guardNameDataGridViewTextBoxColumn.Name = "guardNameDataGridViewTextBoxColumn";
        // 
        // dateTimeDataGridViewTextBoxColumn
        // 
        dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
        dataGridViewCellStyle1.Format = "D";
        dataGridViewCellStyle1.NullValue = null;
        dateTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
        dateTimeDataGridViewTextBoxColumn.HeaderText = "Date";
        dateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
        dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
        // 
        // startTimeDataGridViewTextBoxColumn
        // 
        startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
        dataGridViewCellStyle2.Format = "t";
        dataGridViewCellStyle2.NullValue = null;
        startTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
        startTimeDataGridViewTextBoxColumn.HeaderText = "Start Time";
        startTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
        startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
        // 
        // endTimeDataGridViewTextBoxColumn
        // 
        endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
        dataGridViewCellStyle3.Format = "t";
        dataGridViewCellStyle3.NullValue = null;
        endTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
        endTimeDataGridViewTextBoxColumn.HeaderText = "End Time";
        endTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
        endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
        // 
        // slipBindingSource1
        // 
        slipBindingSource1.DataSource = typeof(Models.Slip);
        // 
        // slipBindingSource2
        // 
        slipBindingSource2.DataSource = typeof(Models.Slip);
        // 
        // slipBindingSource
        // 
        slipBindingSource.DataSource = typeof(Models.Slip);
        // 
        // guardNameCmbBox
        // 
        guardNameCmbBox.AutoCompleteMode = AutoCompleteMode.Suggest;
        guardNameCmbBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        guardNameCmbBox.FormattingEnabled = true;
        guardNameCmbBox.Location = new Point(114, 274);
        guardNameCmbBox.Margin = new Padding(3, 2, 3, 2);
        guardNameCmbBox.Name = "guardNameCmbBox";
        guardNameCmbBox.Size = new Size(214, 23);
        guardNameCmbBox.TabIndex = 8;
        guardNameCmbBox.SelectedIndexChanged += guardNameCmbBox_SelectedIndexChanged;
        // 
        // startTime
        // 
        startTime.CustomFormat = "hh:mm tt";
        startTime.Format = DateTimePickerFormat.Custom;
        startTime.Location = new Point(78, 172);
        startTime.Margin = new Padding(3, 2, 3, 2);
        startTime.Name = "startTime";
        startTime.ShowUpDown = true;
        startTime.Size = new Size(114, 23);
        startTime.TabIndex = 5;
        // 
        // endTime
        // 
        endTime.CustomFormat = "hh:mm tt";
        endTime.Format = DateTimePickerFormat.Custom;
        endTime.Location = new Point(73, 206);
        endTime.Margin = new Padding(3, 2, 3, 2);
        endTime.Name = "endTime";
        endTime.ShowUpDown = true;
        endTime.Size = new Size(114, 23);
        endTime.TabIndex = 6;
        // 
        // airlineCmbBox
        // 
        airlineCmbBox.AutoCompleteCustomSource.AddRange(new string[] { "American Airlines", "Bahamasair", "British Airways", "Caribbean Airlines", "Copa Airlines", "SouthWest", "Inter Caribbean", "United Airlines" });
        airlineCmbBox.AutoCompleteMode = AutoCompleteMode.Suggest;
        airlineCmbBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        airlineCmbBox.FormattingEnabled = true;
        airlineCmbBox.Items.AddRange(new object[] { "American Airlines", "Bahamasair", "British Airways", "Caribbean Airlines", "Copa Airlines", "SouthWest", "Inter Caribbean", "United Airlines" });
        airlineCmbBox.Location = new Point(56, 34);
        airlineCmbBox.Margin = new Padding(3, 2, 3, 2);
        airlineCmbBox.Name = "airlineCmbBox";
        airlineCmbBox.Size = new Size(272, 23);
        airlineCmbBox.TabIndex = 1;
        // 
        // fltNumTxtBox
        // 
        fltNumTxtBox.Location = new Point(106, 66);
        fltNumTxtBox.Margin = new Padding(3, 2, 3, 2);
        fltNumTxtBox.Name = "fltNumTxtBox";
        fltNumTxtBox.Size = new Size(110, 23);
        fltNumTxtBox.TabIndex = 2;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Location = new Point(64, 0);
        dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(156, 23);
        dateTimePicker1.TabIndex = 0;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(3, 2);
        label10.Name = "label10";
        label10.Size = new Size(34, 15);
        label10.TabIndex = 21;
        label10.Text = "Date:";
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Padding = new Padding(5, 2, 0, 2);
        menuStrip1.Size = new Size(1430, 24);
        menuStrip1.TabIndex = 22;
        menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem1, exitToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(37, 20);
        fileToolStripMenuItem.Text = "File";
        // 
        // toolStripMenuItem3
        // 
        toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { excelToolStripMenuItem });
        toolStripMenuItem3.Name = "toolStripMenuItem3";
        toolStripMenuItem3.Size = new Size(180, 22);
        toolStripMenuItem3.Text = "Export";
        // 
        // excelToolStripMenuItem
        // 
        excelToolStripMenuItem.Name = "excelToolStripMenuItem";
        excelToolStripMenuItem.Size = new Size(180, 22);
        excelToolStripMenuItem.Text = "Excel";
        excelToolStripMenuItem.Click += excelToolStripMenuItem_Click;
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new Size(177, 6);
        // 
        // exitToolStripMenuItem
        // 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.Size = new Size(180, 22);
        exitToolStripMenuItem.Text = "Exit";
        exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
        // 
        // toolsToolStripMenuItem
        // 
        toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewEmployeeToolStripMenuItem, employeeDataViewerToolStripMenuItem, toolStripMenuItem2, printSlipsToolStripMenuItem });
        toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
        toolsToolStripMenuItem.Size = new Size(46, 20);
        toolsToolStripMenuItem.Text = "Tools";
        // 
        // addNewEmployeeToolStripMenuItem
        // 
        addNewEmployeeToolStripMenuItem.Name = "addNewEmployeeToolStripMenuItem";
        addNewEmployeeToolStripMenuItem.Size = new Size(191, 22);
        addNewEmployeeToolStripMenuItem.Text = "Add New Employee";
        addNewEmployeeToolStripMenuItem.Click += addNewEmpleeToolStripMenuItem_Click;
        // 
        // employeeDataViewerToolStripMenuItem
        // 
        employeeDataViewerToolStripMenuItem.Name = "employeeDataViewerToolStripMenuItem";
        employeeDataViewerToolStripMenuItem.Size = new Size(191, 22);
        employeeDataViewerToolStripMenuItem.Text = "Employee Data Viewer";
        employeeDataViewerToolStripMenuItem.Click += employeeSlipDataToolStripMenuItem_Click;
        // 
        // toolStripMenuItem2
        // 
        toolStripMenuItem2.Name = "toolStripMenuItem2";
        toolStripMenuItem2.Size = new Size(188, 6);
        // 
        // printSlipsToolStripMenuItem
        // 
        printSlipsToolStripMenuItem.Name = "printSlipsToolStripMenuItem";
        printSlipsToolStripMenuItem.Size = new Size(191, 22);
        printSlipsToolStripMenuItem.Text = "Print Slips";
        printSlipsToolStripMenuItem.Click += printSlipsToolStripMenuItem_Click;
        // 
        // slipIdTxtB
        // 
        slipIdTxtB.AutoCompleteMode = AutoCompleteMode.Suggest;
        slipIdTxtB.Location = new Point(114, 240);
        slipIdTxtB.Margin = new Padding(3, 2, 3, 2);
        slipIdTxtB.Name = "slipIdTxtB";
        slipIdTxtB.Size = new Size(214, 23);
        slipIdTxtB.TabIndex = 7;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(3, 242);
        label11.Name = "label11";
        label11.Size = new Size(43, 15);
        label11.TabIndex = 24;
        label11.Text = "Slip ID:";
        // 
        // tabControl1
        // 
        tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Controls.Add(tabPage3);
        tabControl1.Location = new Point(10, 39);
        tabControl1.Margin = new Padding(3, 2, 3, 2);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(1419, 507);
        tabControl1.TabIndex = 25;
        tabControl1.TabStop = false;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(iWillWalkChkB);
        tabPage1.Controls.Add(serviceNoLongerNeededChkB);
        tabPage1.Controls.Add(holidayChkB);
        tabPage1.Controls.Add(overTimeChbK);
        tabPage1.Controls.Add(label10);
        tabPage1.Controls.Add(groupBox1);
        tabPage1.Controls.Add(slipIdTxtB);
        tabPage1.Controls.Add(label1);
        tabPage1.Controls.Add(label11);
        tabPage1.Controls.Add(label2);
        tabPage1.Controls.Add(dateTimePicker1);
        tabPage1.Controls.Add(label3);
        tabPage1.Controls.Add(passengerNameTxtBox);
        tabPage1.Controls.Add(fltNumTxtBox);
        tabPage1.Controls.Add(label4);
        tabPage1.Controls.Add(airlineCmbBox);
        tabPage1.Controls.Add(agentNameTxtBox);
        tabPage1.Controls.Add(endTime);
        tabPage1.Controls.Add(label5);
        tabPage1.Controls.Add(startTime);
        tabPage1.Controls.Add(label6);
        tabPage1.Controls.Add(guardNameCmbBox);
        tabPage1.Controls.Add(label7);
        tabPage1.Controls.Add(submitBTN);
        tabPage1.Location = new Point(4, 24);
        tabPage1.Margin = new Padding(3, 2, 3, 2);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3, 2, 3, 2);
        tabPage1.Size = new Size(1411, 479);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Slip Entry";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // iWillWalkChkB
        // 
        iWillWalkChkB.AutoSize = true;
        iWillWalkChkB.Location = new Point(5, 344);
        iWillWalkChkB.Margin = new Padding(3, 2, 3, 2);
        iWillWalkChkB.Name = "iWillWalkChkB";
        iWillWalkChkB.Size = new Size(81, 19);
        iWillWalkChkB.TabIndex = 28;
        iWillWalkChkB.Text = "I Will Walk";
        iWillWalkChkB.UseVisualStyleBackColor = true;
        // 
        // serviceNoLongerNeededChkB
        // 
        serviceNoLongerNeededChkB.AutoSize = true;
        serviceNoLongerNeededChkB.Location = new Point(5, 313);
        serviceNoLongerNeededChkB.Margin = new Padding(3, 2, 3, 2);
        serviceNoLongerNeededChkB.Name = "serviceNoLongerNeededChkB";
        serviceNoLongerNeededChkB.Size = new Size(166, 19);
        serviceNoLongerNeededChkB.TabIndex = 27;
        serviceNoLongerNeededChkB.Text = "Service No Longer Needed";
        serviceNoLongerNeededChkB.UseVisualStyleBackColor = true;
        // 
        // holidayChkB
        // 
        holidayChkB.AutoSize = true;
        holidayChkB.Location = new Point(214, 344);
        holidayChkB.Margin = new Padding(3, 2, 3, 2);
        holidayChkB.Name = "holidayChkB";
        holidayChkB.Size = new Size(67, 19);
        holidayChkB.TabIndex = 26;
        holidayChkB.Text = "Holiday";
        holidayChkB.UseVisualStyleBackColor = true;
        // 
        // overTimeChbK
        // 
        overTimeChbK.AutoSize = true;
        overTimeChbK.Location = new Point(214, 313);
        overTimeChbK.Margin = new Padding(3, 2, 3, 2);
        overTimeChbK.Name = "overTimeChbK";
        overTimeChbK.Size = new Size(75, 19);
        overTimeChbK.TabIndex = 25;
        overTimeChbK.Text = "Overtime";
        overTimeChbK.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(groupBox3);
        tabPage2.Controls.Add(dataGridView2);
        tabPage2.Location = new Point(4, 24);
        tabPage2.Margin = new Padding(3, 2, 3, 2);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3, 2, 3, 2);
        tabPage2.Size = new Size(1411, 479);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Slip tracker";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(radioButton3);
        groupBox3.Controls.Add(radioButton2);
        groupBox3.Controls.Add(radioButton1);
        groupBox3.Location = new Point(5, 34);
        groupBox3.Margin = new Padding(3, 2, 3, 2);
        groupBox3.Name = "groupBox3";
        groupBox3.Padding = new Padding(3, 2, 3, 2);
        groupBox3.Size = new Size(162, 116);
        groupBox3.TabIndex = 13;
        groupBox3.TabStop = false;
        groupBox3.Text = "Filters:";
        // 
        // radioButton3
        // 
        radioButton3.AutoSize = true;
        radioButton3.Location = new Point(5, 78);
        radioButton3.Margin = new Padding(3, 2, 3, 2);
        radioButton3.Name = "radioButton3";
        radioButton3.Size = new Size(95, 19);
        radioButton3.TabIndex = 2;
        radioButton3.Text = "Not Received";
        radioButton3.UseVisualStyleBackColor = true;
        radioButton3.CheckedChanged += radioButton_CheckedChanged;
        // 
        // radioButton2
        // 
        radioButton2.AutoSize = true;
        radioButton2.Location = new Point(5, 56);
        radioButton2.Margin = new Padding(3, 2, 3, 2);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(72, 19);
        radioButton2.TabIndex = 1;
        radioButton2.Text = "Received";
        radioButton2.UseVisualStyleBackColor = true;
        radioButton2.CheckedChanged += radioButton_CheckedChanged;
        // 
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.Checked = true;
        radioButton1.Location = new Point(5, 33);
        radioButton1.Margin = new Padding(3, 2, 3, 2);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(39, 19);
        radioButton1.TabIndex = 0;
        radioButton1.TabStop = true;
        radioButton1.Text = "All";
        radioButton1.UseVisualStyleBackColor = true;
        radioButton1.CheckedChanged += radioButton_CheckedChanged;
        // 
        // dataGridView2
        // 
        dataGridView2.AllowUserToAddRows = false;
        dataGridView2.AllowUserToDeleteRows = false;
        dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView2.Columns.AddRange(new DataGridViewColumn[] { id, EmployeeName, dateCreated, received, receivedDate });
        dataGridView2.Location = new Point(172, 0);
        dataGridView2.Margin = new Padding(3, 2, 3, 2);
        dataGridView2.Name = "dataGridView2";
        dataGridView2.ReadOnly = true;
        dataGridView2.RowHeadersWidth = 51;
        dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView2.Size = new Size(1233, 460);
        dataGridView2.TabIndex = 11;
        // 
        // id
        // 
        id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        id.DataPropertyName = "SlipID";
        id.HeaderText = "Slip ID";
        id.MinimumWidth = 6;
        id.Name = "id";
        id.ReadOnly = true;
        // 
        // EmployeeName
        // 
        EmployeeName.DataPropertyName = "EmployeeName";
        EmployeeName.HeaderText = "Employee Name";
        EmployeeName.MinimumWidth = 6;
        EmployeeName.Name = "EmployeeName";
        EmployeeName.ReadOnly = true;
        EmployeeName.Width = 125;
        // 
        // dateCreated
        // 
        dateCreated.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dateCreated.DataPropertyName = "CreatedDate";
        dataGridViewCellStyle4.Format = "f";
        dataGridViewCellStyle4.NullValue = null;
        dateCreated.DefaultCellStyle = dataGridViewCellStyle4;
        dateCreated.HeaderText = "Date Created";
        dateCreated.MinimumWidth = 6;
        dateCreated.Name = "dateCreated";
        dateCreated.ReadOnly = true;
        dateCreated.Resizable = DataGridViewTriState.True;
        // 
        // received
        // 
        received.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        received.DataPropertyName = "Received";
        received.HeaderText = "Received";
        received.MinimumWidth = 6;
        received.Name = "received";
        received.ReadOnly = true;
        received.Resizable = DataGridViewTriState.True;
        received.SortMode = DataGridViewColumnSortMode.Automatic;
        // 
        // receivedDate
        // 
        receivedDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        receivedDate.DataPropertyName = "ReceivedDate";
        dataGridViewCellStyle5.Format = "f";
        receivedDate.DefaultCellStyle = dataGridViewCellStyle5;
        receivedDate.HeaderText = "Received Date";
        receivedDate.MinimumWidth = 6;
        receivedDate.Name = "receivedDate";
        receivedDate.ReadOnly = true;
        // 
        // tabPage3
        // 
        tabPage3.Controls.Add(importBTN);
        tabPage3.Controls.Add(logsTxtB);
        tabPage3.Controls.Add(validateChkB);
        tabPage3.Controls.Add(csvPathTxtb);
        tabPage3.Controls.Add(csvBtn);
        tabPage3.Controls.Add(label16);
        tabPage3.Location = new Point(4, 24);
        tabPage3.Margin = new Padding(3, 2, 3, 2);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new Padding(3, 2, 3, 2);
        tabPage3.Size = new Size(1411, 479);
        tabPage3.TabIndex = 2;
        tabPage3.Text = "Importer";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // importBTN
        // 
        importBTN.Location = new Point(131, 94);
        importBTN.Margin = new Padding(3, 2, 3, 2);
        importBTN.Name = "importBTN";
        importBTN.Size = new Size(82, 22);
        importBTN.TabIndex = 5;
        importBTN.Text = "Import";
        importBTN.UseVisualStyleBackColor = true;
        importBTN.Click += importBTN_Click;
        // 
        // logsTxtB
        // 
        logsTxtB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        logsTxtB.Location = new Point(22, 131);
        logsTxtB.Margin = new Padding(3, 2, 3, 2);
        logsTxtB.Multiline = true;
        logsTxtB.Name = "logsTxtB";
        logsTxtB.ReadOnly = true;
        logsTxtB.ScrollBars = ScrollBars.Both;
        logsTxtB.Size = new Size(1384, 348);
        logsTxtB.TabIndex = 4;
        // 
        // validateChkB
        // 
        validateChkB.AutoSize = true;
        validateChkB.Location = new Point(22, 97);
        validateChkB.Margin = new Padding(3, 2, 3, 2);
        validateChkB.Name = "validateChkB";
        validateChkB.Size = new Size(95, 19);
        validateChkB.TabIndex = 3;
        validateChkB.Text = "Validate Only";
        validateChkB.UseVisualStyleBackColor = true;
        // 
        // csvPathTxtb
        // 
        csvPathTxtb.Location = new Point(22, 55);
        csvPathTxtb.Margin = new Padding(3, 2, 3, 2);
        csvPathTxtb.Name = "csvPathTxtb";
        csvPathTxtb.ReadOnly = true;
        csvPathTxtb.Size = new Size(405, 23);
        csvPathTxtb.TabIndex = 2;
        // 
        // csvBtn
        // 
        csvBtn.Location = new Point(431, 54);
        csvBtn.Margin = new Padding(3, 2, 3, 2);
        csvBtn.Name = "csvBtn";
        csvBtn.Size = new Size(82, 22);
        csvBtn.TabIndex = 1;
        csvBtn.Text = "...";
        csvBtn.UseVisualStyleBackColor = true;
        csvBtn.Click += csvBtn_Click;
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Location = new Point(22, 14);
        label16.Name = "label16";
        label16.Size = new Size(181, 15);
        label16.TabIndex = 0;
        label16.Text = "Please select a CSV file to import.";
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.ImageScalingSize = new Size(20, 20);
        contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.Size = new Size(108, 48);
        // 
        // editToolStripMenuItem
        // 
        editToolStripMenuItem.Name = "editToolStripMenuItem";
        editToolStripMenuItem.Size = new Size(107, 22);
        editToolStripMenuItem.Text = "Edit";
        editToolStripMenuItem.Click += editToolStripMenuItem_Click;
        // 
        // deleteToolStripMenuItem
        // 
        deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
        deleteToolStripMenuItem.Size = new Size(107, 22);
        deleteToolStripMenuItem.Text = "Delete";
        deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1430, 548);
        Controls.Add(tabControl1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Margin = new Padding(3, 2, 3, 2);
        Name = "Form1";
        Text = "More Secuirty Wheelchair Slip Manager";
        Load += Form1_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)historyListDataGrid).EndInit();
        ((System.ComponentModel.ISupportInitialize)slipBindingSource1).EndInit();
        ((System.ComponentModel.ISupportInitialize)slipBindingSource2).EndInit();
        ((System.ComponentModel.ISupportInitialize)slipBindingSource).EndInit();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        tabPage2.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
        tabPage3.ResumeLayout(false);
        tabPage3.PerformLayout();
        contextMenuStrip1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private ComboBox comboBox1;
    private Label label2;
    private TextBox fltNumTxtBox;
    private TextBox passengerNameTxtBox;
    private Label label3;
    private TextBox agentNameTxtBox;
    private Label label4;
    private Label label5;
    private TextBox textBox5;
    private Label label6;
    private TextBox textBox6;
    private Label label7;
    private Button submitBTN;
    private GroupBox groupBox1;
    private DataGridView historyListDataGrid;
    private DateTimePicker dateTimePicker;
    private Label label9;
    private Label label8;
    private ComboBox airlineFilterCmbBox;
    private ComboBox guardNameCmbBox;
    private DateTimePicker startTime;
    private DateTimePicker endTime;
    private ComboBox airlineCmbBox;
    private DateTimePicker dateTimePicker1;
    private Label label10;
    private BindingSource slipBindingSource;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private TextBox slipIdTxtB;
    private Label label11;
    private BindingSource slipBindingSource1;
    private BindingSource slipBindingSource2;
    private DataGridViewTextBoxColumn slipIdDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn flightNumberDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn agentNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn guardNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
    private Label label12;
    private DateTimePicker dateTimePicker2;
    private Label label15;
    private ComboBox employeeCmb2;
    private Label label14;
    private Label label13;
    private Button filterBTN;
    private DataGridViewTextBoxColumn Airline;
    private GroupBox groupBox2;
    private Label slipCntLBL;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private DataGridView dataGridView2;
    private GroupBox groupBox3;
    private RadioButton radioButton3;
    private RadioButton radioButton2;
    private RadioButton radioButton1;
    private ToolStripSeparator toolStripMenuItem1;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem toolStripMenuItem3;
    private ToolStripMenuItem excelToolStripMenuItem;
    private ToolStripMenuItem toolsToolStripMenuItem;
    private ToolStripMenuItem addNewEmployeeToolStripMenuItem;
    private ToolStripMenuItem printSlipsToolStripMenuItem;
    private ToolStripMenuItem employeeDataViewerToolStripMenuItem;
    private ToolStripSeparator toolStripMenuItem2;
    private DataGridViewTextBoxColumn id;
    private DataGridViewTextBoxColumn EmployeeName;
    private DataGridViewTextBoxColumn dateCreated;
    private DataGridViewCheckBoxColumn received;
    private DataGridViewTextBoxColumn receivedDate;
    private CheckBox holidayChkB;
    private CheckBox overTimeChbK;
    private CheckBox iWillWalkChkB;
    private CheckBox serviceNoLongerNeededChkB;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem editToolStripMenuItem;
    private ToolStripMenuItem deleteToolStripMenuItem;
    private TabPage tabPage3;
    private TextBox csvPathTxtb;
    private Button csvBtn;
    private Label label16;
    private TextBox logsTxtB;
    private CheckBox validateChkB;
    private Button importBTN;
}
