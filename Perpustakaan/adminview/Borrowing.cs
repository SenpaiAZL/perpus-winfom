using Microsoft.Data.SqlClient;
using System;
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
    public partial class Borrowing : UserControl
    {

        int? idpeminjaman;
        public Borrowing()
        {
            InitializeComponent();
            DisplayTable();
            ResetValues();
        }

        private void DisplayTable()
        {
            try
            {
                ManageConnection.OpenConn();

                //Fetch data for the main peminjaman table 
                SqlCommand peminjaman = new SqlCommand("SELECT pm.*, u.nama " +
        "FROM peminjaman pm " +
        "JOIN [user] u ON pm.id_user = u.id_user", connection.konek);
                SqlDataAdapter sda = new SqlDataAdapter(peminjaman);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dtgvBorrowing.DataSource = dt;
                sda.Dispose();


                // Fetch data for the name combobox
                SqlCommand kjsdnhkashdkabnxcvcxv = new SqlCommand("SELECT * FROM [user] WHERE role='siswa'", connection.konek);
                sda = new SqlDataAdapter(kjsdnhkashdkabnxcvcxv);
                dt = new DataTable();
                sda.Fill(dt);

                cbName.DataSource = dt;
                cbName.DisplayMember = "nama";
                cbName.ValueMember = "id_user";
                cbName.SelectedIndex = -1;

                // Fetch data for the book titles combobox
                SqlCommand asdgsdhsdgjasgdasdg = new SqlCommand("SELECT * FROM buku", connection.konek);
                sda = new SqlDataAdapter(asdgsdhsdgjasgdasdg);
                dt = new DataTable();
                sda.Fill(dt);

                cbTitle.DataSource = dt;

                cbTitle.DisplayMember = "judul_buku";
                cbTitle.ValueMember = "id_buku";

                cbTitle.SelectedIndex = -1;

                sda.Dispose();
                //Close the connection
                connection.konek.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encountered : " + ex);
            }
            finally
            {
                if (connection.konek.State == ConnectionState.Open)
                    connection.konek.Close();
            }
        }
        private void ResetValues()
        {
            idpeminjaman = null;
            txtBookID.Text = null;
            txtNIS.Text = null;
            cbName.SelectedValue = -1;
            cbTitle.SelectedValue = -1;
            numStock.Value = 0;
            dtgvBorrowingDetail.DataSource = null;
        }

        private void AddNewPeminjaman()
        {
            int idUser = Convert.ToInt32(cbName.SelectedValue);
            int idBuku = Convert.ToInt32(cbTitle.SelectedValue);
            int jumlahPinjam = (int)numStock.Value;
            DateTime tanggalPinjam = DateTime.Now; // get current date 
            DateTime tanggalKembali = tanggalPinjam.AddDays(7);
            int durasiPinjam = 7; // ? tbh idk
            int denda = 0;

            try
            {
                string qryAddPeminjaman = @"
INSERT INTO peminjaman (id_user, tgl_pinjam, tgl_kembali, durasi_pinjam, denda)
VALUES (@id_user, @tgl_pinjam, @tgl_kembali, @durasi_pinjam, @denda);
SELECT SCOPE_IDENTITY();";

                using (SqlConnection conn = new SqlConnection(connection.konek.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmdPeminjaman = new SqlCommand(qryAddPeminjaman, conn))
                    {
                        cmdPeminjaman.Parameters.AddWithValue("@id_user", idUser);
                        cmdPeminjaman.Parameters.AddWithValue("@tgl_pinjam", tanggalPinjam);
                        cmdPeminjaman.Parameters.AddWithValue("@tgl_kembali", tanggalKembali);
                        cmdPeminjaman.Parameters.AddWithValue("@durasi_pinjam", durasiPinjam);
                        cmdPeminjaman.Parameters.AddWithValue("@denda", denda);

                        object result = cmdPeminjaman.ExecuteScalar();
                        int idPeminjaman = Convert.ToInt32(result);

                        if (idBuku > 0 && jumlahPinjam > 0)
                        {
                            DialogResult confirmAdd = MessageBox.Show("Apakah anda hendak menambahakn detail pada peminjaman?", "Konfirmasi", MessageBoxButtons.YesNo);
                            if (confirmAdd == DialogResult.Yes)
                            {
                                idpeminjaman = idPeminjaman;
                                AddDetailPeminjaman();
                            }
                            else if (confirmAdd == DialogResult.No)
                            {
                                MessageBox.Show("Aksi menambahkan detail peminjaman dibatalkan.");
                            }
                        }
                    }
                }

                MessageBox.Show("Peminjaman berhasil ditambahkan.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
            }
            finally
            {
                ManageConnection.CloseConn();
                ResetValues();
                DisplayTable();
            }
        }

        private void AddDetailPeminjaman()
        {
            int idUser = Convert.ToInt32(cbName.SelectedValue);
            int idBuku = Convert.ToInt32(cbTitle.SelectedValue);

            if (Main.CheckDuplicate((int)idpeminjaman, idBuku))
            {
                MessageBox.Show("Buku ini telah terpinjam oleh peminjaman yang sama. Mohon pilih buku lain.");
                return;
            }

            int jumlahPinjam = (int)numStock.Value;

            try
            {
                string qryPeminjamanBuku = @"
INSERT INTO peminjaman_buku (id_peminjaman, id_buku, jml_pinjam)
VALUES (@id_peminjaman, @id_buku, @jml_pinjam);";

                using (SqlConnection conn = new SqlConnection(connection.konek.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmdPeminjamanBuku = new SqlCommand(qryPeminjamanBuku, conn))
                    {
                        cmdPeminjamanBuku.Parameters.AddWithValue("@id_peminjaman", idpeminjaman);
                        cmdPeminjamanBuku.Parameters.AddWithValue("@id_buku", idBuku);
                        cmdPeminjamanBuku.Parameters.AddWithValue("@jml_pinjam", jumlahPinjam);

                        cmdPeminjamanBuku.ExecuteNonQuery();
                    }
                }

                Main.ReduceBookStock(idBuku, jumlahPinjam);

                MessageBox.Show("Detail peminjaman berhasil ditambahkan.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
            }
            finally
            {
                ManageConnection.CloseConn();
                ResetValues();
            }
        }

        private void UpdateData()
        {
            int idUser = Convert.ToInt32(cbName.SelectedValue);
            int idBuku = Convert.ToInt32(cbTitle.SelectedValue);
            int jumlahPinjam = (int)numStock.Value;
            DateTime tanggalPinjam = DateTime.Now; // get current date 
            DateTime tanggalKembali = tanggalPinjam.AddDays(7);

            try
            {

                // Update peminjaman
                string qryUpdatePeminjaman = @"
UPDATE peminjaman
SET tgl_pinjam = @tgl_pinjam, 
    tgl_kembali = @tgl_kembali, 
    durasi_pinjam = DATEDIFF(DAY, @tgl_pinjam, @tgl_kembali)
WHERE id_peminjaman = @id_peminjaman";

                using (SqlConnection conn = new SqlConnection(connection.konek.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand updatePeminjamanCmd = new SqlCommand(qryUpdatePeminjaman, conn))
                    {
                        updatePeminjamanCmd.Parameters.AddWithValue("@tgl_pinjam", tanggalPinjam);
                        updatePeminjamanCmd.Parameters.AddWithValue("@tgl_kembali", tanggalKembali);
                        updatePeminjamanCmd.Parameters.AddWithValue("@id_peminjaman", idpeminjaman);

                        updatePeminjamanCmd.ExecuteNonQuery();
                    }
                }

                // Get currently borrowed book stock by the user
                string qryGetStock = "SELECT jml_pinjam FROM peminjaman_buku WHERE id_buku = @id_buku AND id_peminjaman=@id_peminjaman";
                int currentlyBorrowedStock = 0;

                using (SqlConnection conn = new SqlConnection(connection.konek.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmdGetStock = new SqlCommand(qryGetStock, conn))
                    {
                        cmdGetStock.Parameters.AddWithValue("@id_peminjaman", idpeminjaman);
                        cmdGetStock.Parameters.AddWithValue("@id_buku", idBuku);
                        object result = cmdGetStock.ExecuteScalar();

                        currentlyBorrowedStock = result != null ? Convert.ToInt32(result) : 0;
                    }
                }

                // Add it back to the book stock
                Main.AddBookStock(idBuku, currentlyBorrowedStock);

                // Update peminjaman_buku 
                string updatePeminjamanBukuQuery = @"
UPDATE peminjaman_buku
SET jml_pinjam = @jml_pinjam
WHERE id_peminjaman = @id_peminjaman AND id_buku = @id_buku";

                using (SqlConnection conn = new SqlConnection(connection.konek.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand updatePeminjamanBukuCmd = new SqlCommand(updatePeminjamanBukuQuery, conn))
                    {
                        updatePeminjamanBukuCmd.Parameters.AddWithValue("@jml_pinjam", jumlahPinjam);
                        updatePeminjamanBukuCmd.Parameters.AddWithValue("@id_peminjaman", idpeminjaman);
                        updatePeminjamanBukuCmd.Parameters.AddWithValue("@id_buku", idBuku);

                        updatePeminjamanBukuCmd.ExecuteNonQuery();
                    }
                }

                // Then add it again to reflect the newly added value
                Main.ReduceBookStock(idBuku, jumlahPinjam);
                MessageBox.Show("Data peminjaman berhasil di update!");

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred while updating the data: {ex.Message}");
            }
            finally
            {
                ManageConnection.CloseConn();
                ResetValues();
            }
        }

        private void DeleteData()
        {
            try
            {
                ManageConnection.OpenConn();
                // confirm if the user really want to delete the data 

                // Confirm if the user really wants to delete the data 
                DialogResult confirmDelete = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    // Query to get stock information
                    string qryGetStock = "SELECT id_buku, jml_pinjam FROM peminjaman_buku WHERE id_peminjaman = @id_peminjaman;";
                    DataTable dataTable = new DataTable();

                    using (SqlConnection conn = new SqlConnection(connection.konek.ConnectionString))
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(qryGetStock, conn))
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@id_peminjaman", idpeminjaman);
                            adapter.Fill(dataTable);
                        }
                    }

                    // Iterate over rows in DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        int bookId = Convert.ToInt32(row["id_buku"]);
                        int borrowedStock = Convert.ToInt32(row["jml_pinjam"]);

                        Main.AddBookStock(bookId, borrowedStock);
                    }

                    // Delete every peminjaman detail with the current selected id_peminjaman
                    using (SqlConnection conn = new SqlConnection(connection.konek.ConnectionString))
                    {
                        conn.Open();
                        using (SqlCommand delPeminjamanDetail = new SqlCommand("DELETE FROM peminjaman_buku WHERE id_peminjaman=@id_peminjaman", conn))
                        {
                            delPeminjamanDetail.Parameters.AddWithValue("@id_peminjaman", SqlDbType.VarChar).Value = idpeminjaman;
                            delPeminjamanDetail.ExecuteNonQuery();
                        }
                    }

                    // Delete peminjaman
                    using (SqlConnection conn = new SqlConnection(connection.konek.ConnectionString))
                    {
                        conn.Open();
                        using (SqlCommand delPeminjaman = new SqlCommand("DELETE FROM [peminjaman] WHERE id_peminjaman=@id_peminjaman", conn))
                        {
                            delPeminjaman.Parameters.AddWithValue("@id_peminjaman", SqlDbType.VarChar).Value = idpeminjaman;
                            delPeminjaman.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Data berhasil dihapus");
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
            }
            finally
            {
                ManageConnection.CloseConn();
                ResetValues();
                DisplayTable();

            }

        }


        private void label1_Click(object sender, EventArgs e)
        {
        }

        // Cell clicked action
        private void dtgvBorrowing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {

                int index = e.RowIndex;
                DataGridViewRow selectedRow = dtgvBorrowing.Rows[index];
                idpeminjaman = (int)selectedRow.Cells[0].Value;
                int userid = (int)selectedRow.Cells[1].Value;

                using (SqlConnection conn = new SqlConnection(connection.konek.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand detail = new SqlCommand("SELECT pb.*, b.judul_buku FROM peminjaman_buku pb JOIN buku b ON pb.id_buku = b.id_buku WHERE pb.id_peminjaman = @id_peminjaman;", conn))
                    {
                        detail.Parameters.AddWithValue("@id_peminjaman", idpeminjaman);
                        using (SqlDataAdapter detailsda = new SqlDataAdapter(detail))
                        {
                            DataTable detaildt = new DataTable();
                            detailsda.Fill(detaildt);
                            dtgvBorrowingDetail.DataSource = detaildt;
                        }
                    }
                }

                using (SqlConnection conn = new SqlConnection(connection.konek.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand nis = new SqlCommand("SELECT nis FROM siswa WHERE id_user=@id_user", conn))
                    {
                        nis.Parameters.AddWithValue("@id_user", userid);
                        object result = nis.ExecuteScalar();
                        txtNIS.Text = result.ToString();
                    }
                }

                cbName.SelectedValue = (int)selectedRow.Cells[1].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            AddDetailPeminjaman();
        }

        private void dtgvBorrowingDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int index = e.RowIndex;
            DataGridViewRow selectedRow = dtgvBorrowingDetail.Rows[index];

            cbTitle.SelectedValue = (int)selectedRow.Cells[2].Value;
            txtBookID.Text = selectedRow.Cells[2].Value.ToString();
            numStock.Value = (int)selectedRow.Cells[3].Value;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddNewPeminjaman();
        }
    }
}
