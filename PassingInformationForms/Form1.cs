using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassingInformationForms
{
    public partial class Form1 : Form
    {
        string fName;
        string lName;
        string email;
        bool SMS;
        bool reports;
        bool transactions;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSMSMessage.Text = "";
            lblReportsMessage.Text = "";
            lblTransactionsMessage.Text = "";

            lblSMSMessage.ForeColor = System.Drawing.Color.Orange;
            lblTransactionsMessage.ForeColor = System.Drawing.Color.Purple;
            lblReportsMessage.ForeColor = System.Drawing.Color.Red;
        }

        private void chkSMS_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSMS.Checked)
            {
                lblSMSMessage.Text = "Service Rates May Apply.";
            }
            else
            {
                lblSMSMessage.Text = "";
            }
        }

        private void chkReports_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReports.Checked)
            {
                lblReportsMessage.Text = "Service Rates May Apply.";
            }
            else
            {
                lblReportsMessage.Text = "";
            }
        }

        private void chkTransactions_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTransactions.Checked)
            {
                lblTransactionsMessage.Text = "Service Rates May Apply.";
            }
            else
            {
                lblTransactionsMessage.Text = "";
            }
        }

        private void Signup()
        {
            fName = txtFName.Text;
            lName = txtLName.Text;
            email = txtEmail.Text;
            SMS = chkSMS.Checked;
            reports = chkReports.Checked;
            transactions = chkTransactions.Checked;

            Confirmation n = new Confirmation(fName, lName, email, SMS, reports, transactions);
            n.Show();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Signup();
        }
    }
}
