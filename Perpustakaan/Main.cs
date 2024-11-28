using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perpustakaan
{
    internal class Main
    {
        public static bool ValidateBookStock(int idBuku, int jumlahPinjam)
        {
            try
            {
                ManageConnection.OpenConn();
                SqlCommand query = new SqlCommand("SELECT * FROM buku WHERE id_buku=@id_buku",connection.konek);
                query.Parameters.AddWithValue("@id_buku", idBuku);
                SqlDataAdapter asdbadsghasdhg = new SqlDataAdapter(query);
                DataTable dt = new DataTable();
                asdbadsghasdhg.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        //If there current book stock is not enough, cancel the action
                        if ((int)dr["stok"] < jumlahPinjam)
                        {
                            MessageBox.Show("Stok tidak cukup untuk memenuhi peminjaman! Stok buku saat ini : " + dr["stok"].ToString() + "");
                    
                            dt.Dispose();
                            return false;
                        }
                        dt.Dispose();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
                return false;
            }
            finally
            {
                if (connection.konek.State == ConnectionState.Open)
                   connection.konek.Close();
            }
        }


        public static void ReduceBookStock(int idBuku, int jumlahPinjam)
        {
            ValidateBookStock(idBuku, jumlahPinjam);
            string connectionString = connection.konek.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand updateStok = new SqlCommand(
                        "UPDATE buku SET stok = stok - @jumlahpinjam WHERE id_buku = @id_buku AND stok >= @jumlahpinjam",
                        conn
                    );
                    updateStok.Parameters.AddWithValue("@id_buku", idBuku);
                    updateStok.Parameters.AddWithValue("@jumlahpinjam", jumlahPinjam);
                    updateStok.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
                }
                finally
                {
                    if (conn.State.Equals(ConnectionState.Open))
                    {
                        conn.Close();
                    }
                }
            }
        }


        public static void AddBookStock(int idBuku, int jumlahPinjam)
        {
            try
            {
                using (SqlCommand cmdUpdateStock = new SqlCommand("UPDATE buku set stok=stok+@jumlahpinjam  WHERE id_buku=@id_buku AND stok >= @jumlahpinjam", new SqlConnection(connection.konek.ConnectionString)))
                {
                    cmdUpdateStock.Parameters.AddWithValue("@id_buku", idBuku);
                    cmdUpdateStock.Parameters.AddWithValue("@jumlahpinjam", jumlahPinjam);

                    cmdUpdateStock.Connection.Open(); // Use a separate connection
                    cmdUpdateStock.ExecuteNonQuery();
                    cmdUpdateStock.Connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
            }
            finally
            {

            }

        }

        // Check for duplicate book under one peminjaman
        public static bool CheckDuplicate(int idPeminjaman, int idBuku)
        {
            try
            {
                ManageConnection.OpenConn();
                string qry = @"
        SELECT COUNT(*) 
        FROM peminjaman_buku 
        WHERE id_peminjaman = @id_peminjaman AND id_buku = @id_buku";

                SqlCommand cmd = new SqlCommand(qry,connection.konek);
                cmd.Parameters.AddWithValue("@id_peminjaman", idPeminjaman);
                cmd.Parameters.AddWithValue("@id_buku", idBuku);


                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
            }
            finally
            {
                ManageConnection.CloseConn();
            }
            return false;
        }

    }
}
