using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AuthProjectSample
{
    public partial class Loginfrm : Form
    {
        public Loginfrm()
        {
            InitializeComponent();
        }
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader dtread;

        private void Loginfrm_Load(object sender, EventArgs e)
        {

            conn = new SqlConnection(@"Data Source=RYMV\SQLEXPRESS;Initial Catalog=sample_db;Persist Security Info=True;User ID=sa;Password=msadmin");
            conn.Open();

        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regfrm regfrm = new Regfrm();
            regfrm.ShowDialog();

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            if (pwdloginTxt.Text != string.Empty || usrloginTxt.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from userdata_info where username='" + usrloginTxt.Text + "' and password='" + pwdloginTxt.Text + "'", conn);
                dtread = cmd.ExecuteReader();

                if (dtread.Read())
                {
                    dtread.Close();
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                }
                else
                {
                    dtread.Close();
                    MessageBox.Show("No Account available with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
