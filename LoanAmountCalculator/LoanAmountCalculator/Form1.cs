using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanAmountCalculator
{
    public partial class Form1 : Form
    {

        //Initializing the variables necessary for to be used in the function Calculate_Click.
        double LoanAmount, InterestRate;
        int LoanPeriod;

        public Form1()
        {
            //Initializing all the components
            InitializeComponent();
            
            //Setting the chart to display all the intervals in the X axis.
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                        
            //Displaying value when hovering the mouse over the bars in the cart.
            chart1.Series["Principal Amount Paid"].ToolTip = "Principal : #VALY";
            chart1.Series["Interest Amount Paid"].ToolTip = "Interest : #VALY";


        }


        private void Calculate_Click(object sender, EventArgs e)
        {            

            //Checking for null or empty values.
            if (txt_LoanAmount == null || string.IsNullOrWhiteSpace(txt_LoanAmount.Text))
            {
                //Displaying the message box when NO Loan Amount is entered.
                MessageBox.Show("Please enter a Loan Amount.");
            }

            else if (txt_LoanPeriod == null || string.IsNullOrWhiteSpace(txt_LoanPeriod.Text))
            {
                //Displaying the message box when NO Loan Period is entered.
                MessageBox.Show("Please enter a Loan Period.");
            }

            else if (txt_InterestRate == null || string.IsNullOrWhiteSpace(txt_InterestRate.Text))
            {
                //Displaying the message box when NO Interest Rate is entered.
                MessageBox.Show("Please enter a Interest Rate.");
            }


            else
            {
                //Checking if months or year is selected.
                if (radio2.Checked == true)
                {
                    //If the selected radio button is years, it is multiplied by 12 to obtain the months.
                    LoanPeriod = (int) Math.Round(Convert.ToDouble(txt_LoanPeriod.Text) , 0);
                    LoanPeriod *= 12;
                }

                else
                {
                    //If Loan Period is in months, it is left as such and this is the default value.
                    LoanPeriod = Convert.ToInt32(txt_LoanPeriod.Text);

                }

                //Loan Amount and Interest Rate values are fetched from the text box.
                LoanAmount = Convert.ToDouble(txt_LoanAmount.Text);
                InterestRate = Convert.ToDouble(txt_InterestRate.Text);

                //Clearing existing title to ensure there is no overlap during subsequent calculations.
                chart1.Titles.Clear();

                //Giving a title to the chart.
                chart1.Titles.Add("Ratios of the Principal and Interest paid per month.");

                //Clearing the existing legends, so that it is only displayed once the calculate button is clicked.
                chart1.Legends.Clear();

                //Adding the legends to the chart while the calculate button is clicked.
                chart1.Legends.Add("Legend1");

                //Clearing the charts for every subsequent run to ensure there is no overlay.
                chart1.Series["Principal Amount Paid"].Points.Clear();
                chart1.Series["Interest Amount Paid"].Points.Clear();

                //Defining the outputTable variable which will be used to create the datatabale for the loan calculation.
                DataTable outputTable = new DataTable();

                //Clearing the label - lbl_TotalInterest.Text for susequent runs.
                lbl_TotalInterest.Text = "";

                //Passing the values into the funtion - calculationsLoan() to obtain the datatable that can be stored into the outputTable.
                outputTable = calculationsLoan(LoanAmount, LoanPeriod, InterestRate);

                //Changing the color of thes Datagridview / OutputTable header.
                OutputTable.EnableHeadersVisualStyles = false;
                OutputTable.ColumnHeadersDefaultCellStyle.BackColor = Color.Lavender;

                //This outputs the outputTable (Datatable) to the Datagridview
                OutputTable.DataSource = outputTable;
            }


        }

        public DataTable calculationsLoan(double LoanAmount, int LoanPeriod, double InterestRate)
        {
            //This will hold all the calculations.

            //Initializing the necessary variables.
            double PaymentAmount, PrincipalAmountPaid, InterestAmountPaid, LoanOutstanding, TotalInterestAmountPaid;

            //Setting th Total Interest Amount Paid to 0, this prevents overlapping of total values during subsequent runs.
            TotalInterestAmountPaid = 0;

            //Defining the DataTable and adding the columns to it.
            DataTable table = new DataTable();
            table.Columns.Add("Payment no.", typeof(int));
            table.Columns.Add("Payment amount", typeof(Double));
            table.Columns.Add("Principal amount paid", typeof(Double));
            table.Columns.Add("Interest amount paid", typeof(Double));
            table.Columns.Add("Loan outstanding balance", typeof(Double));

            //Converting the annual interest to a monthly one.
            InterestRate = (InterestRate) / (1200);
            LoanOutstanding = LoanAmount;

            //Using the loop to fill the table wth values.
            for (int i = 1; i <= LoanPeriod; i++)
            {
                //Using math.pow to calculate ((1 + InterestRate)^(LoanPeriod)).
                double InterestPowered = Math.Pow((1 + InterestRate), LoanPeriod);

                //Calculating the payment amount.
                PaymentAmount = (InterestRate * LoanAmount) *  InterestPowered / (InterestPowered - 1);

                //Calculating the Principal Amount paid.
                double InterestPrincipalPowered = Math.Pow((1 + InterestRate), (1 + LoanPeriod - i));

                PrincipalAmountPaid = PaymentAmount / InterestPrincipalPowered;

                //Calculating the Interest Amount Paid.
                InterestAmountPaid = PaymentAmount - PrincipalAmountPaid;

                //Calculating the LoanOutstanding;
                LoanOutstanding -= PrincipalAmountPaid;

                //Calculating the Total Interest Amount Paid.
                TotalInterestAmountPaid += InterestAmountPaid;

                //Adding values to the Datatable one at a time.
                table.Rows.Add(i, PaymentAmount.ToString("F"), PrincipalAmountPaid.ToString("F"), InterestAmountPaid.ToString("F"), LoanOutstanding.ToString("F"));

                //Added X and Y to the chart.
                chart1.Series["Principal Amount Paid"].Points.AddXY(i  , PrincipalAmountPaid.ToString("F"));
                chart1.Series["Interest Amount Paid"].Points.AddXY(i , InterestAmountPaid.ToString("F"));
            }

            //The total amount interest paid is displayed in the label.
            lbl_TotalInterest.Text = "Total Interest Paid : " + TotalInterestAmountPaid.ToString("F");

            //Returning the DataTable.
            return table;

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_HandleKeyPress(object sender, KeyPressEventArgs e)
        {
            //The condition only allows numbers and does not let the user type alphabets or special characters.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //The condition checks for one decimal point.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
        }

        private void textBox_HandleLoanPeriod(object sender, KeyPressEventArgs e)
        {
            //The condition only allows numbers and does not let the user type alphabets or special characters.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //The condition checks decimal points and prevents any decimal points.
            if ((e.KeyChar == '.')) //&& ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }
    }
}
