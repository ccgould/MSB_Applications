namespace MsbSlipManagerWinForm;

partial class EmployeeDetails
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
        groupBox1 = new GroupBox();
        dataGridView1 = new DataGridView();
        id = new DataGridViewTextBoxColumn();
        dateCreated = new DataGridViewCheckBoxColumn();
        received = new DataGridViewCheckBoxColumn();
        recievedDate = new DataGridViewTextBoxColumn();
        label1 = new Label();
        nameLbl = new Label();
        label2 = new Label();
        label3 = new Label();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(nameLbl);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(250, 450);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "groupBox1";
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, dateCreated, received, recievedDate });
        dataGridView1.Location = new Point(256, 12);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(542, 438);
        dataGridView1.TabIndex = 1;
        // 
        // id
        // 
        id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        id.HeaderText = "Slip ID";
        id.MinimumWidth = 6;
        id.Name = "id";
        id.ReadOnly = true;
        // 
        // dateCreated
        // 
        dateCreated.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dateCreated.HeaderText = "Date Created";
        dateCreated.MinimumWidth = 6;
        dateCreated.Name = "dateCreated";
        dateCreated.ReadOnly = true;
        dateCreated.Resizable = DataGridViewTriState.True;
        dateCreated.SortMode = DataGridViewColumnSortMode.Automatic;
        // 
        // received
        // 
        received.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        received.HeaderText = "Recieved";
        received.MinimumWidth = 6;
        received.Name = "received";
        received.ReadOnly = true;
        received.Resizable = DataGridViewTriState.True;
        received.SortMode = DataGridViewColumnSortMode.Automatic;
        // 
        // recievedDate
        // 
        recievedDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        recievedDate.HeaderText = "Recieved Date";
        recievedDate.MinimumWidth = 6;
        recievedDate.Name = "recievedDate";
        recievedDate.ReadOnly = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(6, 33);
        label1.Name = "label1";
        label1.Size = new Size(52, 20);
        label1.TabIndex = 0;
        label1.Text = "Name:";
        // 
        // nameLbl
        // 
        nameLbl.AutoSize = true;
        nameLbl.Location = new Point(64, 33);
        nameLbl.Name = "nameLbl";
        nameLbl.Size = new Size(18, 20);
        nameLbl.TabIndex = 1;
        nameLbl.Text = "...";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(64, 72);
        label2.Name = "label2";
        label2.Size = new Size(18, 20);
        label2.TabIndex = 3;
        label2.Text = "...";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(6, 72);
        label3.Name = "label3";
        label3.Size = new Size(27, 20);
        label3.TabIndex = 2;
        label3.Text = "ID:";
        // 
        // EmployeeDetails
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(dataGridView1);
        Controls.Add(groupBox1);
        Name = "EmployeeDetails";
        Text = "Employee Details";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn id;
    private DataGridViewCheckBoxColumn dateCreated;
    private DataGridViewCheckBoxColumn received;
    private DataGridViewTextBoxColumn recievedDate;
    private Label nameLbl;
    private Label label1;
    private Label label2;
    private Label label3;
}