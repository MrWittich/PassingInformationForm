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
    public partial class Confirmation : Form
    {
        string fName;
        string lName;
        string email;
        bool sms;
        bool reports;
        bool transactions;

        public Confirmation(string f, string l, string e, bool s, bool r, bool t)
        {
            InitializeComponent();
            fName = f;
            lName = l;
            email = e;
            sms = s;
            reports = r;
            transactions = t;
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            lblFName.Text = fName;
            lblLName.Text = lName;
            lblEmail.Text = email;

            if(sms)
            {
                lblSMS.Text = "✓";
            }

            if (reports)
            {
                lblReports.Text = "✓";
            }

            if (transactions)
            {
                lblTransactions.Text = "✓";
            }
        }
    }
}
