namespace LoanAmountCalculator
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoanInputPanel = new System.Windows.Forms.Panel();
            this.lbl_TotalInterest = new System.Windows.Forms.Label();
            this.txt_LoanPeriod = new System.Windows.Forms.TextBox();
            this.txt_InterestRate = new System.Windows.Forms.TextBox();
            this.txt_LoanAmount = new System.Windows.Forms.TextBox();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.lbl_InterestRate = new System.Windows.Forms.Label();
            this.label_LoanPeriod = new System.Windows.Forms.Label();
            this.label_LoanAmount = new System.Windows.Forms.Label();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.OutputTable = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LoanInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoanInputPanel
            // 
            this.LoanInputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoanInputPanel.BackColor = System.Drawing.Color.LightBlue;
            this.LoanInputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoanInputPanel.Controls.Add(this.lbl_TotalInterest);
            this.LoanInputPanel.Controls.Add(this.txt_LoanPeriod);
            this.LoanInputPanel.Controls.Add(this.txt_InterestRate);
            this.LoanInputPanel.Controls.Add(this.txt_LoanAmount);
            this.LoanInputPanel.Controls.Add(this.radio2);
            this.LoanInputPanel.Controls.Add(this.radio1);
            this.LoanInputPanel.Controls.Add(this.lbl_InterestRate);
            this.LoanInputPanel.Controls.Add(this.label_LoanPeriod);
            this.LoanInputPanel.Controls.Add(this.label_LoanAmount);
            this.LoanInputPanel.Controls.Add(this.button_Calculate);
            this.LoanInputPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanInputPanel.Location = new System.Drawing.Point(0, 0);
            this.LoanInputPanel.Name = "LoanInputPanel";
            this.LoanInputPanel.Size = new System.Drawing.Size(981, 145);
            this.LoanInputPanel.TabIndex = 0;
            // 
            // lbl_TotalInterest
            // 
            this.lbl_TotalInterest.AutoSize = true;
            this.lbl_TotalInterest.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_TotalInterest.Location = new System.Drawing.Point(12, 110);
            this.lbl_TotalInterest.Name = "lbl_TotalInterest";
            this.lbl_TotalInterest.Size = new System.Drawing.Size(17, 25);
            this.lbl_TotalInterest.TabIndex = 11;
            this.lbl_TotalInterest.Text = " ";
            // 
            // txt_LoanPeriod
            // 
            this.txt_LoanPeriod.Location = new System.Drawing.Point(446, 27);
            this.txt_LoanPeriod.Name = "txt_LoanPeriod";
            this.txt_LoanPeriod.Size = new System.Drawing.Size(159, 22);
            this.txt_LoanPeriod.TabIndex = 9;
            this.txt_LoanPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_HandleLoanPeriod);
            // 
            // txt_InterestRate
            // 
            this.txt_InterestRate.Location = new System.Drawing.Point(845, 27);
            this.txt_InterestRate.Name = "txt_InterestRate";
            this.txt_InterestRate.Size = new System.Drawing.Size(101, 22);
            this.txt_InterestRate.TabIndex = 8;
            this.txt_InterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_HandleKeyPress);
            // 
            // txt_LoanAmount
            // 
            this.txt_LoanAmount.Location = new System.Drawing.Point(121, 27);
            this.txt_LoanAmount.Name = "txt_LoanAmount";
            this.txt_LoanAmount.Size = new System.Drawing.Size(166, 22);
            this.txt_LoanAmount.TabIndex = 7;
            this.txt_LoanAmount.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.txt_LoanAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_HandleKeyPress);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.radio2.Location = new System.Drawing.Point(520, 59);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(52, 19);
            this.radio2.TabIndex = 6;
            this.radio2.Text = "Years";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Checked = true;
            this.radio1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.radio1.Location = new System.Drawing.Point(429, 59);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(66, 19);
            this.radio1.TabIndex = 5;
            this.radio1.TabStop = true;
            this.radio1.Text = "Months";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // lbl_InterestRate
            // 
            this.lbl_InterestRate.AutoSize = true;
            this.lbl_InterestRate.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_InterestRate.Location = new System.Drawing.Point(745, 27);
            this.lbl_InterestRate.Name = "lbl_InterestRate";
            this.lbl_InterestRate.Size = new System.Drawing.Size(98, 20);
            this.lbl_InterestRate.TabIndex = 4;
            this.lbl_InterestRate.Text = "Interest Rate:";
            // 
            // label_LoanPeriod
            // 
            this.label_LoanPeriod.AutoSize = true;
            this.label_LoanPeriod.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label_LoanPeriod.Location = new System.Drawing.Point(350, 27);
            this.label_LoanPeriod.Name = "label_LoanPeriod";
            this.label_LoanPeriod.Size = new System.Drawing.Size(94, 20);
            this.label_LoanPeriod.TabIndex = 3;
            this.label_LoanPeriod.Text = "Loan Period:";
            // 
            // label_LoanAmount
            // 
            this.label_LoanAmount.AutoSize = true;
            this.label_LoanAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label_LoanAmount.Location = new System.Drawing.Point(12, 27);
            this.label_LoanAmount.Name = "label_LoanAmount";
            this.label_LoanAmount.Size = new System.Drawing.Size(105, 20);
            this.label_LoanAmount.TabIndex = 2;
            this.label_LoanAmount.Text = "Loan Amount:";
            this.label_LoanAmount.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button_Calculate
            // 
            this.button_Calculate.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.button_Calculate.Location = new System.Drawing.Point(429, 106);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(128, 30);
            this.button_Calculate.TabIndex = 1;
            this.button_Calculate.Text = "Calculate";
            this.button_Calculate.UseVisualStyleBackColor = true;
            this.button_Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // OutputTable
            // 
            this.OutputTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OutputTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.OutputTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OutputTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OutputTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OutputTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.OutputTable.Location = new System.Drawing.Point(0, 452);
            this.OutputTable.Name = "OutputTable";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OutputTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.OutputTable.Size = new System.Drawing.Size(981, 345);
            this.OutputTable.TabIndex = 1;
            this.OutputTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(2, 151);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.Name = "Principal Amount Paid";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Legend = "Legend1";
            series2.Name = "Interest Amount Paid";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(978, 299);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(981, 798);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.OutputTable);
            this.Controls.Add(this.LoanInputPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Loan repayment calculator";
            this.LoanInputPanel.ResumeLayout(false);
            this.LoanInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoanInputPanel;
        private System.Windows.Forms.Button button_Calculate;
        private System.Windows.Forms.Label lbl_InterestRate;
        private System.Windows.Forms.Label label_LoanPeriod;
        private System.Windows.Forms.Label label_LoanAmount;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.TextBox txt_LoanPeriod;
        private System.Windows.Forms.TextBox txt_InterestRate;
        private System.Windows.Forms.TextBox txt_LoanAmount;
        private System.Windows.Forms.DataGridView OutputTable;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbl_TotalInterest;
    }
}

