using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace Perpustakaan
{
    public partial class adminLogin : Form
    {
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;
        public adminLogin()
        {
            InitializeComponent();
        }

        private void Log_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM[user] WHERE username = '" + username.Text + "'AND password = '" + password.Text + "'";
                command = new SqlCommand(sql, connection.konek);
                adapter = new SqlDataAdapter(command);
                tabel = new DataTable();
                adapter.Fill(tabel);

                if (tabel.Rows.Count > 0)
                {
                    foreach (DataRow dr in tabel.Rows)
                    {
                        using (SqlConnection conn = new SqlConnection(connection.konek.ConnectionString))
                        {
                            conn.Open();
                            using (SqlCommand command = new SqlCommand(sql, conn))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        userinfo.info = reader.GetString(1);
                                    }
                                }
                            }
                        }


                        if (dr["role"].ToString() == "admin")
                        {
                            AdminForm form = new AdminForm(this);
                            form.Show();
                        }
                        else if (dr["role"].ToString() == "siswa")
                        {
                            SiswaForm form = new SiswaForm(this);
                            form.Show();
                        }
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("invalid login please check username and password");
                    ManageConnection.CloseConn();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " +  ex.Message);
            }
            
        }
    }
}