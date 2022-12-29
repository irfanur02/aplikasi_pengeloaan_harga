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
    public partial class ViewPenawaran : Form
    {
        public ViewPenawaran()
        {
            InitializeComponent();
        }

        private void ViewPenawaran_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "SELECT pe.nomor_penawaran, pe.tanggal_penawaran, mi.nama_mitra, CONCAT(me.merek_mesin, '" + " " + "', me.model_mesin) AS `mesin` FROM penawaran pe JOIN mitra mi ON pe.id_mitra = mi.id_mitra JOIN mesin me ON pe.id_mesin = me.id_mesin ORDER BY pe.nomor_penawaran DESC";
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            dgvPenawaran.DataSource = dt;
            dgvPenawaran.Columns[2].Width = 200;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvPenawaran.Columns.Add(btn);
            btn.HeaderText = "aksi";
            btn.Text = "detail penawaran";
            btn.Name = "btnDetailPenawran";
            btn.UseColumnTextForButtonValue = true;

            command.Dispose();
            connection.Close();
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

        private void cmbMitra_SelectedValueChanged(object sender, EventArgs e)
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

            if(tahun != "")
            {
                command.CommandText = "SELECT pe.nomor_penawaran, pe.tanggal_penawaran, mi.nama_mitra, CONCAT(me.merek_mesin, '" + " " + "', me.model_mesin) AS `mesin` FROM penawaran pe JOIN mitra mi ON pe.id_mitra = mi.id_mitra JOIN mesin me ON pe.id_mesin = me.id_mesin WHERE mi.nama_mitra = '" + mitra + "' AND LEFT(pe.tanggal_penawaran, 4) = " + tahun + " ORDER BY pe.nomor_penawaran DESC";
            } else
            {
                command.CommandText = "SELECT pe.nomor_penawaran, pe.tanggal_penawaran, mi.nama_mitra, CONCAT(me.merek_mesin, '" + " " + "', me.model_mesin) AS `mesin` FROM penawaran pe JOIN mitra mi ON pe.id_mitra = mi.id_mitra JOIN mesin me ON pe.id_mesin = me.id_mesin WHERE mi.nama_mitra = '" + mitra + "' ORDER BY pe.nomor_penawaran DESC";
            }            
            
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            dgvPenawaran.DataSource = dt;
            dgvPenawaran.Columns[2].Width = 200;

            command.Dispose();
            connection.Close();
        }

        private void cmbTahun_SelectedValueChanged(object sender, EventArgs e)
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

            if (mitra != "")
            {
                command.CommandText = "SELECT pe.nomor_penawaran, pe.tanggal_penawaran, mi.nama_mitra, CONCAT(me.merek_mesin, '" + " " + "', me.model_mesin) AS `mesin` FROM penawaran pe JOIN mitra mi ON pe.id_mitra = mi.id_mitra JOIN mesin me ON pe.id_mesin = me.id_mesin WHERE LEFT(pe.tanggal_penawaran, 4) = " + tahun + " AND mi.nama_mitra = '" + mitra + "' ORDER BY pe.nomor_penawaran DESC";
            }
            else
            {
                command.CommandText = "SELECT pe.nomor_penawaran, pe.tanggal_penawaran, mi.nama_mitra, CONCAT(me.merek_mesin, '" + " " + "', me.model_mesin) AS `mesin` FROM penawaran pe JOIN mitra mi ON pe.id_mitra = mi.id_mitra JOIN mesin me ON pe.id_mesin = me.id_mesin WHERE LEFT(pe.tanggal_penawaran, 4) = " + tahun + " ORDER BY pe.nomor_penawaran DESC";
            }

            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            dgvPenawaran.DataSource = dt;
            dgvPenawaran.Columns[2].Width = 200;

            command.Dispose();
            connection.Close();
        }

        private void dgvPenawaran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string noPenawaran;
            if (e.ColumnIndex == 4)
            {
                noPenawaran = dgvPenawaran.Rows[e.RowIndex].Cells[0].Value.ToString();
                var viewDetailPenawaran = new ViewDetailPenawaran(noPenawaran);
                viewDetailPenawaran.Show();
            }
        }
    }
}
