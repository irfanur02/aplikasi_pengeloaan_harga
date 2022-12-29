using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ViewHarga : Form
    {
        public ViewHarga()
        {
            InitializeComponent();
        }

        private void cmbMitra_MouseDown(object sender, MouseEventArgs e)
        {
            cmbMitra.Items.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
                string query = "SELECT mi.nama_mitra FROM penawaran pe JOIN mitra mi on pe.id_mitra = mi.id_mitra GROUP BY mi.nama_mitra ORDER BY nama_mitra ASC";
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbMitra.Items.Add(reader.GetString("nama_mitra"));
                }

                command.Dispose();
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbTahun_MouseDown(object sender, MouseEventArgs e)
        {
            cmbTahun.Items.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
                string query = "SELECT LEFT(tanggal_penawaran, 4) AS tahun FROM penawaran GROUP BY tanggal_penawaran ORDER BY tanggal_penawaran DESC";
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbTahun.Items.Add(reader.GetString("tahun"));
                }

                command.Dispose();
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string mitra, tahun;
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            command = connection.CreateCommand();

            mitra = cmbMitra.Text;
            tahun = cmbTahun.Text;

            if (cmbMitra.SelectedItem == null && cmbTahun.SelectedItem == null && txtBarang.Text == "")
            {
                command.CommandText = "SELECT pe.nomor_penawaran, mi.nama_mitra, pe.tanggal_penawaran, ba.nama_barang, ba.model_barang, ba.seri_barang, dp.harga_penjualan, ROUND((dp.harga_penjualan / dp.jumlah_barang)) as `harga satuan`, dp.jumlah_barang, dp.diskon FROM penawaran pe JOIN detail_penawaran dp ON pe.nomor_penawaran = dp.nomor_penawaran JOIN barang ba ON dp.id_barang = ba.id_barang JOIN mitra mi ON pe.id_mitra = mi.id_mitra ORDER BY pe.tanggal_penawaran DESC, pe.nomor_penawaran DESC";
            } else if(cmbMitra.SelectedItem != null && cmbTahun.SelectedItem != null && txtBarang.Text != "")
            {
                command.CommandText = "SELECT pe.nomor_penawaran, pe.tanggal_penawaran, ba.nama_barang, ba.model_barang, ba.seri_barang, dp.harga_penjualan, ROUND((dp.harga_penjualan / dp.jumlah_barang)) as `harga satuan`, dp.jumlah_barang, dp.diskon FROM penawaran pe JOIN detail_penawaran dp ON pe.nomor_penawaran = dp.nomor_penawaran JOIN barang ba ON dp.id_barang = ba.id_barang JOIN mitra mi ON pe.id_mitra = mi.id_mitra WHERE ba.nama_barang LIKE '%" + txtBarang.Text + "%' AND mi.nama_mitra = '" + mitra + "' AND LEFT(pe.tanggal_penawaran, 4) = " + tahun + " ORDER BY pe.tanggal_penawaran DESC, pe.nomor_penawaran DESC";
            } else if(cmbMitra.SelectedItem != null || txtBarang.Text != "")
            {
                labelPenawaranMitra.Text = ":  " + mitra;
                command.CommandText = "SELECT pe.nomor_penawaran, pe.tanggal_penawaran, ba.nama_barang, ba.model_barang, ba.seri_barang, dp.harga_penjualan, ROUND((dp.harga_penjualan / dp.jumlah_barang)) as `harga satuan`, dp.jumlah_barang, dp.diskon FROM penawaran pe JOIN detail_penawaran dp ON pe.nomor_penawaran = dp.nomor_penawaran JOIN barang ba ON dp.id_barang = ba.id_barang JOIN mitra mi ON pe.id_mitra = mi.id_mitra WHERE ba.nama_barang LIKE '%" + txtBarang.Text + "%' AND mi.nama_mitra = '" + mitra + "' ORDER BY pe.tanggal_penawaran DESC, pe.nomor_penawaran DESC";
            }
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            dgvPenawaranHarga.DataSource = dt;

            command.Dispose();
            connection.Close();
        }

        private void txtBarang_TextChanged(object sender, EventArgs e)
        {
            string mitra, tahun;
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            command = connection.CreateCommand();

            mitra = cmbMitra.Text;
            tahun = cmbTahun.Text;

            if (cmbMitra.SelectedItem == null && cmbTahun.SelectedItem == null)
            {
                command.CommandText = "SELECT pe.nomor_penawaran, mi.nama_mitra, pe.tanggal_penawaran, ba.nama_barang, ba.model_barang, ba.seri_barang, dp.harga_penjualan, ROUND((dp.harga_penjualan / dp.jumlah_barang)) as `harga satuan`, dp.jumlah_barang, dp.diskon FROM penawaran pe JOIN detail_penawaran dp ON pe.nomor_penawaran = dp.nomor_penawaran JOIN barang ba ON dp.id_barang = ba.id_barang JOIN mitra mi ON pe.id_mitra = mi.id_mitra WHERE ba.nama_barang LIKE '%" + txtBarang.Text + "%' ORDER BY pe.tanggal_penawaran DESC, pe.nomor_penawaran DESC";
            }
            else if (cmbMitra.SelectedItem != null && cmbTahun.SelectedItem != null)
            {
                command.CommandText = "SELECT pe.nomor_penawaran, pe.tanggal_penawaran, ba.nama_barang, ba.model_barang, ba.seri_barang, dp.harga_penjualan, ROUND((dp.harga_penjualan / dp.jumlah_barang)) as `harga satuan`, dp.jumlah_barang, dp.diskon FROM penawaran pe JOIN detail_penawaran dp ON pe.nomor_penawaran = dp.nomor_penawaran JOIN barang ba ON dp.id_barang = ba.id_barang JOIN mitra mi ON pe.id_mitra = mi.id_mitra WHERE ba.nama_barang LIKE '%" + txtBarang.Text + "%' AND mi.nama_mitra = '" + mitra + "' AND LEFT(pe.tanggal_penawaran, 4) = " + tahun + " ORDER BY pe.tanggal_penawaran DESC, pe.nomor_penawaran DESC";
            }
            else if (cmbMitra.SelectedItem != null)
            {
                labelPenawaranMitra.Text = ":  " + mitra;
                command.CommandText = "SELECT pe.nomor_penawaran, pe.tanggal_penawaran, ba.nama_barang, ba.model_barang, ba.seri_barang, dp.harga_penjualan, ROUND((dp.harga_penjualan / dp.jumlah_barang)) as `harga satuan`, dp.jumlah_barang, dp.diskon FROM penawaran pe JOIN detail_penawaran dp ON pe.nomor_penawaran = dp.nomor_penawaran JOIN barang ba ON dp.id_barang = ba.id_barang JOIN mitra mi ON pe.id_mitra = mi.id_mitra WHERE ba.nama_barang LIKE '%" + txtBarang.Text + "%' AND mi.nama_mitra = '" + mitra + "' ORDER BY pe.tanggal_penawaran DESC, pe.nomor_penawaran DESC";
            }
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            dgvPenawaranHarga.DataSource = dt;

            command.Dispose();
            connection.Close();
        }
    }
}
