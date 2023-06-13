using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotMuchAppenin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            string fname = fnameTB.Text;
            string sname = snTB.Text;
            string country = countryLB.GetItemText(countryLB.SelectedIndex);
            char gender;
            if (mRB.Checked == true)
            {
                gender = 'M';
            }
            else if (fRB.Checked == true)
            {
                gender = 'F';
            }
            else
            {
                gender = '?';
            }
            bool CS;
            if (cCB.Checked)
            {
                CS = true;
            }
            else
            {
                CS = false;
            }
            bool JS;
            if (jsCB.Checked)
            {
                JS = true;
            }
            else
            {
                JS = false;
            }
            bool python;
            if (pythonCB.Checked)
            {
                python = true;
            }
            else
            {
                python = false;
            }
                
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO users VALUES (" + fname + "," + sname + "," + country + "," + gender + "," + CS + ","
                + JS + "," + python + ")");

            string connectionString = "server=(local)formPracticeDataSet.xss";

            using (SqlConnection _con = new SqlConnection(connectionString))
            {
                string queryStatement = "SELECT TOP 5 * FROM dbo.Customers ORDER BY CustomerID";

                using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                {
                    DataTable customerTable = new DataTable("Top5Customers");

                    SqlDataAdapter _dap = new SqlDataAdapter(sqlCommand);

                    DataSet ds = new DataSet("users");

                    _con.Open();
                    _dap.Update(ds);
                    _con.Close();

                }
            }
        }
    }
}
