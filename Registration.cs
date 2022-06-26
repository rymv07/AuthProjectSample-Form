using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AuthProjectSample
{
    public partial class Regfrm : Form
    {
        private SqlConnection conn;
        private SqlDataReader dtread;
        private SqlCommand cmd;

        public Regfrm()
        {
            InitializeComponent();
        }




        private void Regfrm_Load(object sender, EventArgs e)
        {

            conn = new SqlConnection(@"Data Source=RYMV\SQLEXPRESS;Initial Catalog=sample_db;Integrated Security=True");
            conn.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginfrm login = new Loginfrm();
            login.ShowDialog();
        }

        private void regSubmit_Click(object sender, EventArgs e)
        {
            if (confirmTxt.Text != string.Empty || passwordTxt.Text != string.Empty || usernameTxt.Text != string.Empty)
            {
                if (passwordTxt.Text == confirmTxt.Text)
                {
                    cmd = new SqlCommand("select * from userdata_info where username='" + usernameTxt.Text + "'", conn);
                    dtread = cmd.ExecuteReader();
                    if (dtread.Read())
                    {
                        dtread.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dtread.Close();
                        cmd = new SqlCommand("insert into userdata_info values(@username,@password)", conn);
                        cmd.Parameters.AddWithValue("username", usernameTxt.Text);
                        cmd.Parameters.AddWithValue("password", passwordTxt.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created. Please proceed to login", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Password Doesn't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
