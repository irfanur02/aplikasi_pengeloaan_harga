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
    public partial class KelolaJasa : Form
    {
        string idJasa; 
        public KelolaJasa()
        {
            InitializeComponent();
        }

        public void loadDGVJasa()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM jasa";
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            dgvJasa.DataSource = dt;
            dgvJasa.Columns[0].Visible = false;

            command.Dispose();
        }

        private void KelolaJasa_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            loadDGVJasa();
            connection.Close();
        }

        public void clearInputValue()
        {
            txtNamaJasa.Text = "";
            txtHargaJasa.Text = "";

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            connection.Open();
            MySqlCommand command = new MySqlCommand();

            command = connection.CreateCommand();
            string namaJasa, hargaJasa;

            namaJasa = txtNamaJasa.Text;
            hargaJasa = txtHargaJasa.Text;

            if (btnTambah.Text == "Tambah")
            {
                command.CommandText = "INSERT INTO jasa VALUES('', '" + namaJasa.ToUpper() + "', " + hargaJasa + ")";
            }
            else if (btnTambah.Text == "Edit")
            {
                command.CommandText = "UPDATE jasa SET nama_jasa = '" + namaJasa.ToUpper() + "', harga_jasa = " + hargaJasa + " WHERE id_jasa = " + idJasa + "";
                btnBatal.Visible = false;
                btnTambah.Text = "Tambah";
            }
            command.ExecuteNonQuery();
            command.Dispose();

            loadDGVJasa();
            connection.Close();

            clearInputValue();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            btnBatal.Visible = true;
            btnTambah.Text = "Edit";
            var baris = dgvJasa.CurrentRow.Index;

            idJasa = dgvJasa.Rows[baris].Cells[0].Value.ToString();
            txtNamaJasa.Text = dgvJasa.Rows[baris].Cells[1].Value.ToString();
            txtHargaJasa.Text = dgvJasa.Rows[baris].Cells[2].Value.ToString();
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

            var baris = dgvJasa.CurrentRow.Index;
            idJasa = dgvJasa.Rows[baris].Cells[0].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Yakin ingin menghapus ?", "Hapus Data", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM jasa WHERE id_jasa = " + idJasa + "";
                command.ExecuteNonQuery();
                command.Dispose();

                loadDGVJasa();
                connection.Close();
            }
        }

        private void txtCariJasa_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM jasa WHERE nama_jasa LIKE '%" + txtCariJasa.Text + "%'";
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            dgvJasa.DataSource = dt;
            dgvJasa.Columns[0].Visible = false;

            command.Dispose();
            connection.Close();
        }
    }
}
