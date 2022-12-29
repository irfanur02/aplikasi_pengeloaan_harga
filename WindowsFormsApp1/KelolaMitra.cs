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
    public partial class KelolaMitra : Form
    {
        string idMitra;

        public KelolaMitra()
        {
            InitializeComponent();
        }

        public void loadDGVMitra()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM mitra";
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            dgvMitra.DataSource = dt;
            dgvMitra.Columns[0].Visible = false;
            dgvMitra.Columns[1].Width = 200;
            dgvMitra.Columns[2].Width = 300;

            command.Dispose();
        }

        private void KelolaMitra_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            loadDGVMitra();
            connection.Close();
        }

        public void clearInputValue()
        {
            txtNamaMitra.Text = "";
            txtAlamatMitra.Text = "";
            txtNoTelp.Text = "";
            txtNoFax.Text = "";
            txtEmail.Text = "";
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            connection.Open();
            MySqlCommand command = new MySqlCommand();

            command = connection.CreateCommand();
            string namaMitra, alamatMitra, noTelp, noFax, email;

            namaMitra = txtNamaMitra.Text;
            alamatMitra = txtAlamatMitra.Text;
            noTelp = txtNoTelp.Text;
            noFax = txtNoFax.Text;
            email = txtEmail.Text;

            if (btnTambah.Text == "Tambah")
            {
                command.CommandText = "INSERT INTO mitra VALUES('', '" + namaMitra.ToUpper() + "', '" + alamatMitra.ToUpper() + "', '" + noTelp + "', '" + noFax + "', '" + email + "')";
            }
            else if (btnTambah.Text == "Edit")
            {
                command.CommandText = "UPDATE mitra SET nama_mitra = '" + namaMitra.ToUpper() + "', alamat_mitra = '" + alamatMitra.ToUpper() + "', nomor_telp_mitra = '" + noTelp + "', nomor_fax_mitra = '" + noFax + "', email_mitra = '" + email + "' WHERE id_mitra = " + idMitra + "";
                btnBatal.Visible = false;
                btnTambah.Text = "Tambah";
            }
            command.ExecuteNonQuery();
            command.Dispose();

            loadDGVMitra();
            connection.Close();

            clearInputValue();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            btnBatal.Visible = true;
            btnTambah.Text = "Edit";
            var baris = dgvMitra.CurrentRow.Index;

            idMitra = dgvMitra.Rows[baris].Cells[0].Value.ToString();
            txtNamaMitra.Text = dgvMitra.Rows[baris].Cells[1].Value.ToString();
            txtAlamatMitra.Text = dgvMitra.Rows[baris].Cells[2].Value.ToString();
            txtNoTelp.Text = dgvMitra.Rows[baris].Cells[3].Value.ToString();
            txtNoFax.Text = dgvMitra.Rows[baris].Cells[4].Value.ToString();
            txtEmail.Text = dgvMitra.Rows[baris].Cells[5].Value.ToString();
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

            var baris = dgvMitra.CurrentRow.Index;
            idMitra = dgvMitra.Rows[baris].Cells[0].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Yakin ingin menghapus ?", "Hapus Data", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM mitra WHERE id_mitra = " + idMitra + "";
                command.ExecuteNonQuery();
                command.Dispose();

                loadDGVMitra();
                connection.Close();
            }
        }

        private void txtCariMitra_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM mitra WHERE nama_mitra LIKE '%" + txtCariMitra.Text + "%'";
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            dgvMitra.DataSource = dt;
            dgvMitra.Columns[0].Visible = false;

            command.Dispose();
            connection.Close();
        }
    }
}
