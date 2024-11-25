using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan
{
    public partial class MasterOperator : UserControl
    {

        int? idSiswa, idUser;

        public MasterOperator()
        {
            InitializeComponent();
            ShowData();
            ClearFields();
        }

        public void ClearFields()
        {
            txtNIS.Text = null;
            txtName.Text = null;
            txtClass.Text = null;
            txtAddress.Text = null;
            txtEmail.Text = null;
            txtTelp.Text = null;
            txtUsername.Text = null;
            txtPassword.Text = null;

        }

        public void ShowData()
        {
            try
            {
                ManageConnection.OpenConn();

                // -- Why when we mention the table user, we had to put it inside a bracket? --
                // "user" is a reserved word by the sql query (already used for other purposes by the system), so we had to escape it by putting it inside the bracket.
                // You can mention every table inside a bracket if you wish to safeguard it, but saya #malas. 

                SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand("SELECT * FROM siswa INNER JOIN [user] on siswa.id_user  = [user].id_user", connection.konek));
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                //Set the datagridview data source to the newly fetched data
                dataGridView1.DataSource = dt;

                // You might wonder where did the code for setting the data headers go, but i had already set it from the designer view.
                // The designer gave you a nice ui to glance over ur table columns, which i prefer more than manually setting it through code. 
                // Go to the dataGridView properties > 'Edit columns..' if you wish to mess with it. perhaps.

                ManageConnection.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encountered : " + ex);
            }
        }
        public bool IsDataInvalid()
        {
            bool errorPresent = false;
            string msg = "";

            if (string.IsNullOrEmpty(txtNIS.Text))
            {
                msg = string.Concat(msg + "The NIS field cannot be empty! \n");
                errorPresent = true;
            }

            if (string.IsNullOrEmpty(txtName.Text))
            {
                msg = string.Concat(msg + "The name field cannot be empty! \n");
                errorPresent = true;
            }

            if (string.IsNullOrEmpty(txtClass.Text))
            {
                msg = string.Concat(msg + "The class field cannot be empty! \n");
                errorPresent = true;
            }

            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                msg = string.Concat(msg + "The address field cannot be empty! \n");
                errorPresent = true;
            }

            if (string.IsNullOrEmpty(txtTelp.Text))
            {
                msg = string.Concat(msg + "The phone number field cannot be empty! \n");
                errorPresent = true;
            }

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                msg = string.Concat(msg + "The username field cannot be empty! \n");
                errorPresent = true;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                msg = string.Concat(msg + "The password field cannot be empty! \n");
                errorPresent = true;
            }

            if (errorPresent)
            {
                MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return errorPresent;
        }

        public void InsertData()
        {
            if (!IsDataInvalid())
            {
                try
                {
                    ManageConnection.OpenConn();

                    // You might notice the sql query is a bit different. The 'OUTPUT INSERTED.id_user' thing will be useful later- Since we still need the id_user to put into our tabel siswa, this command will output the just inserted id_user, eliminate the use for another sql query only to get the id_user.
                    SqlCommand addUser = new SqlCommand("INSERT INTO [user] (nama, username, password, role, no_telp, email) OUTPUT INSERTED.id_user VALUES (@nama, @username, @password, @role, @telp, @email)", connection.konek);

                    addUser.Parameters.AddWithValue("@nama", txtName.Text);
                    addUser.Parameters.AddWithValue("@username", txtUsername.Text);
                    addUser.Parameters.AddWithValue("@password", txtPassword.Text);
                    addUser.Parameters.AddWithValue("@role", "siswa");
                    addUser.Parameters.AddWithValue("@telp", txtTelp.Text);
                    addUser.Parameters.AddWithValue("@email", txtEmail.Text);

                    // ExecuteScalar is to get the result from our `OUTPUT INSERTED` command earlier.
                    int newUserId = (int)addUser.ExecuteScalar();

                    SqlCommand addSiswa = new SqlCommand(
                        "INSERT INTO siswa (id_user, nis, kelas, alamat) VALUES (@id_user, @nis, @kelas, @alamat)",
                        connection.konek);

                    addSiswa.Parameters.AddWithValue("@id_user", newUserId);
                    addSiswa.Parameters.AddWithValue("@nis", txtNIS.Text);
                    addSiswa.Parameters.AddWithValue("@kelas", txtClass.Text);
                    addSiswa.Parameters.AddWithValue("@alamat", txtAddress.Text);

                    addSiswa.ExecuteNonQuery();
                    ManageConnection.CloseConn();
                    MessageBox.Show("Data added6 successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ShowData();
                    ClearFields();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error encountered : " + ex);
                }
            }
            else
            {
                MessageBox.Show("Failed to add operator data!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditData()
        {
            if (dataGridView1.CurrentRow.Selected == true)
            {
                if (!IsDataInvalid())
                {
                    try
                    {
                        ManageConnection.OpenConn();
                        SqlCommand updateUser = new SqlCommand("UPDATE dbo.[user] SET nama = @nama, username = @username, password = @password, email = @email, no_telp = @no_telp, role = @role WHERE  id_user = @id_user;", connection.konek);
                        SqlCommand updateSiswa = new SqlCommand("UPDATE dbo.siswa SET nis = @nis, kelas = @kelas, alamat = @alamat WHERE  id_user = @id_user;", connection.konek);

                        updateUser.Parameters.AddWithValue("@nama", txtName.Text);
                        updateUser.Parameters.AddWithValue("@username", txtUsername.Text);
                        updateUser.Parameters.AddWithValue("@password", txtPassword.Text);
                        updateUser.Parameters.AddWithValue("@email", txtEmail.Text);
                        updateUser.Parameters.AddWithValue("@no_telp", txtTelp.Text);
                        updateUser.Parameters.AddWithValue("@role", "siswa");
                        updateUser.Parameters.AddWithValue("@id_user", idUser);

                        updateSiswa.Parameters.AddWithValue("@nis", txtNIS.Text);
                        updateSiswa.Parameters.AddWithValue("@kelas", txtClass.Text);
                        updateSiswa.Parameters.AddWithValue("@alamat", txtAddress.Text);
                        updateSiswa.Parameters.AddWithValue("@id_user", idUser);

                        updateUser.ExecuteNonQuery();
                        updateSiswa.ExecuteNonQuery();
                        ManageConnection.CloseConn();

                        MessageBox.Show("Data updated successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ShowData();
                        ClearFields();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error encountered : " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row first!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void DeleteData()
        {
            if (dataGridView1.CurrentRow.Selected == true && idUser != null && idSiswa != null)
            {
                try
                {
                    ManageConnection.OpenConn();
                    SqlCommand deleteStudent = new SqlCommand("DELETE FROM siswa WHERE id_siswa=@id_siswa", connection.konek);
                    deleteStudent.Parameters.AddWithValue("@id_siswa", SqlDbType.VarChar).Value = idSiswa;

                    SqlCommand deleteUser = new SqlCommand("DELETE FROM [user] WHERE id_user=@id_user", connection.konek);
                    deleteUser.Parameters.AddWithValue("@id_user", SqlDbType.VarChar).Value = idUser;

                    deleteStudent.ExecuteNonQuery();
                    deleteUser.ExecuteNonQuery();
                    ManageConnection.CloseConn();
                    MessageBox.Show("Data deleted successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ShowData();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error encountered : " + ex);
                }
            }
            else
            {
                MessageBox.Show("Please select a row first!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SearchData()
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                try
                {
                    ManageConnection.OpenConn();

                    // Joins the user and siswa tables and searches for any matches in the specified columns (nis, nama, kelas, alamat, no_telp, username, and password)
                    SqlCommand cmd = new SqlCommand("SELECT * FROM siswa INNER JOIN [user] on siswa.id_user  = [user].id_user WHERE  siswa.nis LIKE '%' + @query + '%' OR [user].nama LIKE '%' + @query + '%' OR siswa.kelas LIKE '%' + @query + '%' OR siswa.alamat LIKE '%' + @query + '%' OR [user].no_telp LIKE '%' + @query + '%' OR [user].username LIKE '%' + @query + '%' OR [user].password LIKE '%' + @query + '%';", connection.konek);
                    cmd.Parameters.AddWithValue("@query",txtSearch.Text.Trim());
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                    ManageConnection.CloseConn();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error encountered : " + ex);
                }
            }
            else
            {
                ShowData();
            }
        }

        // Get data from the dataGridView when the cell is clicked and fill the respective field accordingly
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];

            idSiswa = (int)selectedRow.Cells[0].Value;
            idUser = (int)selectedRow.Cells[1].Value;

            txtNIS.Text = selectedRow.Cells[2].Value.ToString();
            txtClass.Text = selectedRow.Cells[3].Value.ToString();
            txtAddress.Text = selectedRow.Cells[4].Value.ToString();
            txtName.Text = selectedRow.Cells[6].Value.ToString();
            txtEmail.Text = selectedRow.Cells[8].Value.ToString();
            txtTelp.Text = selectedRow.Cells[9].Value.ToString();
            txtUsername.Text = selectedRow.Cells[10].Value.ToString();
            txtPassword.Text = selectedRow.Cells[11].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertData();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }
    }
}
