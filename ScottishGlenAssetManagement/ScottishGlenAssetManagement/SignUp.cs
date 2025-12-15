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

namespace ScottishGlenAssetManagement
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void SubmitSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn;
                string connString = "Data Source=lochnagar.abertay.ac.uk;Initial Catalog=sql2300625;User ID=sql2300625;Password=Dinglechalk100110";

                conn = new SqlConnection(connString);

                conn.Open();

                conn.Close();
                Console.WriteLine("Connection Established Successfully");

                SelectionScreen f2 = new SelectionScreen();
                f2.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                SelectionScreen f2 = new SelectionScreen();
                f2.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
