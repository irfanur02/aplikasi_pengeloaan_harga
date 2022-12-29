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
    public partial class KelolaMesin : Form
    {
        string idMesin;

        public KelolaMesin()
        {
            InitializeComponent();
        }

        public void loadDGVMesin()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM mesin";
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            dgvMesin.DataSource = dt;
            dgvMesin.Columns[0].Visible = false;

            command.Dispose();
        }

        private void KelolaMesin_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            loadDGVMesin();
            connection.Close();
        }

        private void cmbNamaMesin_MouseDown(object sender, MouseEventArgs e)
        {
            cmbNamaMesin.Items.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
                string query = "SELECT nama_mesin FROM mesin ORDER BY nama_mesin ASC";
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbNamaMesin.Items.Add(reader.GetString("nama_mesin"));
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

        public void clearInputValue()
        {
            cmbNamaMesin.Text = "";
            txtModelMesin.Text = "";
            txtSeriMesin.Text = "";
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            connection.Open();
            MySqlCommand command = new MySqlCommand();

            command = connection.CreateCommand();
            string namaMesin, modelMesin, seriMesin;

            namaMesin = cmbNamaMesin.Text;
            modelMesin = txtModelMesin.Text;
            seriMesin = txtSeriMesin.Text;

            if (btnTambah.Text == "Tambah")
            {
                command.CommandText = "INSERT INTO mesin VALUES('', '" + namaMesin.ToUpper() + "', '" + modelMesin.ToUpper() + "', '" + seriMesin.ToUpper() + "')";
            }
            else if (btnTambah.Text == "Edit")
            {
                command.CommandText = "UPDATE mesin SET merek_mesin = '" + namaMesin.ToUpper() + "', model_mesin = '" + modelMesin.ToUpper() + "', seri_mesin = '" + seriMesin.ToUpper() + "' WHERE id_mesin = " + idMesin + "";
                btnBatal.Visible = false;
                btnTambah.Text = "Tambah";
            }
            command.ExecuteNonQuery();
            command.Dispose();

            loadDGVMesin();
            connection.Close();

            clearInputValue();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            btnBatal.Visible = true;
            btnTambah.Text = "Edit";
            var baris = dgvMesin.CurrentRow.Index;

            idMesin = dgvMesin.Rows[baris].Cells[0].Value.ToString();
            cmbNamaMesin.Text = dgvMesin.Rows[baris].Cells[1].Value.ToString();
            txtModelMesin.Text = dgvMesin.Rows[baris].Cells[2].Value.ToString();
            txtSeriMesin.Text = dgvMesin.Rows[baris].Cells[3].Value.ToString();
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

            var baris = dgvMesin.CurrentRow.Index;
            idMesin = dgvMesin.Rows[baris].Cells[0].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Yakin ingin menghapus ?", "Hapus Data", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM mesin WHERE id_mesin = " + idMesin + "";
                command.ExecuteNonQuery();
                command.Dispose();

                loadDGVMesin();
                connection.Close();
            }
        }

        private void txtCariMesin_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM mesin WHERE merek_mesin LIKE '%" + txtCariMesin.Text + "%'";
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            dgvMesin.DataSource = dt;
            dgvMesin.Columns[0].Visible = false;

            command.Dispose();
            connection.Close();
        }
    }
}
