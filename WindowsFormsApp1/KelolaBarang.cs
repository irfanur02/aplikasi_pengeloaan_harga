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
    public partial class KelolaBarang : Form
    {
        public string idBarang;

        public KelolaBarang()
        {
            InitializeComponent();
        }

        public void loadDGVBarang()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM barang";
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            dgvBarang.DataSource = dt;
            dgvBarang.Columns[0].Visible = false;

            command.Dispose();
        }

        private void KelolaBarang_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            loadDGVBarang();
            connection.Close();
        }

        private void cmbNamaBarang_MouseDown(object sender, MouseEventArgs e)
        {
            cmbNamaBarang.Items.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
                string query = "SELECT nama_barang FROM barang ORDER BY nama_barang ASC";
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbNamaBarang.Items.Add(reader.GetString("nama_barang"));
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

        private void cmbSatuanBarang_MouseMove(object sender, MouseEventArgs e)
        {
            cmbSatuanBarang.Items.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
                string query = "SELECT satuan_barang FROM barang GROUP BY satuan_barang ORDER BY satuan_barang ASC";
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbSatuanBarang.Items.Add(reader.GetString("satuan_barang"));
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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            connection.Open();
            MySqlCommand command = new MySqlCommand();

            command = connection.CreateCommand();
            string namaBarang, modelBarang, seriBarang, satuanBarang;

            namaBarang = cmbNamaBarang.Text;
            modelBarang = txtModelBarang.Text;
            seriBarang = txtSeriBarang.Text;
            satuanBarang = cmbSatuanBarang.Text;

            if(btnTambah.Text == "Tambah")
            {
                command.CommandText = "INSERT INTO barang VALUES('', '" + namaBarang.ToUpper()  + "', '" + modelBarang.ToUpper() + "', '" + seriBarang.ToUpper() + "', '" + satuanBarang.ToUpper() + "')";
            } else if(btnTambah.Text == "Edit")
            {
                command.CommandText = "UPDATE barang SET nama_barang = '" + namaBarang.ToUpper() + "', model_barang = '" + modelBarang.ToUpper() + "', seri_barang = '" + seriBarang.ToUpper() + "', satuan_barang = '" + satuanBarang.ToUpper() + "' WHERE id_barang = " + idBarang + "";
                btnBatal.Visible = false;
                btnTambah.Text = "Tambah";
            }
            command.ExecuteNonQuery();
            command.Dispose();

            loadDGVBarang();
            connection.Close();

            clearInputValue();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            btnBatal.Visible = true;
            btnTambah.Text = "Edit";
            var baris = dgvBarang.CurrentRow.Index;

            idBarang = dgvBarang.Rows[baris].Cells[0].Value.ToString();
            cmbNamaBarang.Text = dgvBarang.Rows[baris].Cells[1].Value.ToString();
            txtModelBarang.Text = dgvBarang.Rows[baris].Cells[2].Value.ToString();
            txtSeriBarang.Text = dgvBarang.Rows[baris].Cells[3].Value.ToString();
            cmbSatuanBarang.Text = dgvBarang.Rows[baris].Cells[4].Value.ToString();

        }

        public void clearInputValue()
        {
            cmbNamaBarang.Text = "";
            txtModelBarang.Text = "";
            txtSeriBarang.Text = "";
            cmbSatuanBarang.Text = "";
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearInputValue();
            btnTambah.Text = "Tambah";
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            connection.Open();
            MySqlCommand command = new MySqlCommand();

            var baris = dgvBarang.CurrentRow.Index;
            idBarang = dgvBarang.Rows[baris].Cells[0].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Yakin ingin menghapus ?", "Hapus Data", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM barang WHERE id_barang = " + idBarang + "";
                command.ExecuteNonQuery();
                command.Dispose();

                loadDGVBarang();
                connection.Close();
            }
        }

        private void txtCariBarang_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM barang WHERE nama_barang LIKE '%" + txtCariBarang.Text + "%'";
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            dgvBarang.DataSource = dt;
            dgvBarang.Columns[0].Visible = false;

            command.Dispose();
            connection.Close();
        }
    }
}
