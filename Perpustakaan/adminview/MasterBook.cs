using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Perpustakaan
{
    public partial class MasterBook : UserControl
    {
        int? idBuku;
        public MasterBook()
        {
            InitializeComponent();
            ShowData();
            ClearFields();
        }

        public void ShowData()
        {
            try
            {
                ManageConnection.OpenConn();

                SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand("SELECT * FROM buku", connection.konek));
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
        public void ClearFields()
        {
            txtTitle.Text = null;
            txtAuthor.Text = null;
            txtPublisher.Text = null;
            txtReleaseYear.Text = null;
            numStok.Value = 0;
        }
        public bool IsDataInvalid()
        {
            bool errorPresent = false;
            string msg = "";

            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                msg = string.Concat(msg + "The title field cannot be empty! \n");
                errorPresent = true;
            }

            if (string.IsNullOrEmpty(txtAuthor.Text))
            {
                msg = string.Concat(msg + "The author field cannot be empty! \n");
                errorPresent = true;
            }

            if (string.IsNullOrEmpty(txtPublisher.Text))
            {
                msg = string.Concat(msg + "The publisher field cannot be empty! \n");
                errorPresent = true;
            }

            if (string.IsNullOrEmpty(txtReleaseYear.Text))
            {
                msg = string.Concat(msg + "The release year field cannot be empty! \n");
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
                    SqlCommand addData = new SqlCommand("INSERT into buku values (@judul,@pengarang,@penerbit,@tahunterbit,@stok)", connection.konek);

                    addData.Parameters.AddWithValue("@judul", txtTitle.Text);
                    addData.Parameters.AddWithValue("@pengarang", txtAuthor.Text);
                    addData.Parameters.AddWithValue("@penerbit", txtPublisher.Text);
                    addData.Parameters.AddWithValue("@tahunterbit", txtReleaseYear.Text);
                    addData.Parameters.AddWithValue("@stok", numStok.Value);
                    addData.ExecuteNonQuery();
                    ManageConnection.CloseConn();

                    MessageBox.Show("Data added successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Failed to add book data!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EditData()
        {
            if (dataGridView1.CurrentRow.Selected == true && idBuku != null)
            {
                if (!IsDataInvalid())
                {
                    try
                    {
                        ManageConnection.OpenConn();

                        SqlCommand updateData = new SqlCommand("UPDATE buku set judul_buku=@judul, pengarang=@pengarang, penerbit=@penerbit,  tahun_terbit=@tahunterbit, stok=@stok  WHERE id_buku=@id_buku", connection.konek);
                        updateData.Parameters.AddWithValue("@id_buku", SqlDbType.VarChar).Value = idBuku;
                        updateData.Parameters.AddWithValue("@judul", txtTitle.Text);
                        updateData.Parameters.AddWithValue("@pengarang", txtAuthor.Text);
                        updateData.Parameters.AddWithValue("@penerbit", txtPublisher.Text);
                        updateData.Parameters.AddWithValue("@tahunterbit", txtReleaseYear.Text);
                        updateData.Parameters.AddWithValue("@stok", numStok.Value);
                        updateData.ExecuteNonQuery();

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
            if (dataGridView1.CurrentRow.Selected == true && idBuku != null)
            {
                try
                {
                    ManageConnection.OpenConn();

                    SqlCommand deleteData = new SqlCommand("DELETE buku WHERE id_buku=@id_buku", connection.konek);
                    deleteData.Parameters.AddWithValue("@id_buku", SqlDbType.VarChar).Value = idBuku;
                    deleteData.ExecuteNonQuery();


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

                    SqlCommand cmd = new SqlCommand("SELECT * FROM buku WHERE buku.judul_buku LIKE '%' + @query + '%' OR buku.pengarang LIKE '%' + @query + '%' OR buku.penerbit LIKE '%' + @query + '%' OR buku.tahun_terbit LIKE '%' + @query + '%' OR buku.stok LIKE '%' + @query + '%';", connection.konek);
                    cmd.Parameters.AddWithValue("@query", txtSearch.Text.Trim());
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];

            idBuku = (int)selectedRow.Cells[0].Value;

            txtTitle.Text = selectedRow.Cells[1].Value.ToString();
            txtAuthor.Text = selectedRow.Cells[2].Value.ToString();
            txtPublisher.Text = selectedRow.Cells[3].Value.ToString();
            txtReleaseYear.Text = selectedRow.Cells[4].Value.ToString();
            numStok.Value = (int)selectedRow.Cells[5].Value;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DeleteData();
        }
    }
}
