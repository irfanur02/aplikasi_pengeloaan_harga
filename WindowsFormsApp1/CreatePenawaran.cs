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
    public partial class CreatePenawaran : Form
    {
        public CreatePenawaran()
        {
            InitializeComponent();
        }

        private void CreatePenawaran_Load(object sender, EventArgs e)
        {

        }

        private void cmbMitra_MouseDown(object sender, MouseEventArgs e)
        {
            cmbMitra.Items.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
                string queryGetMitra = "SELECT nama_mitra FROM mitra ORDER BY nama_mitra ASC";
                connection.Open();
                MySqlCommand commandGetMitra = new MySqlCommand(queryGetMitra, connection);
                MySqlDataReader readerGetMitra = commandGetMitra.ExecuteReader();

                while (readerGetMitra.Read())
                {
                    cmbMitra.Items.Add(readerGetMitra.GetString("nama_mitra"));
                }

                commandGetMitra.Dispose();
                readerGetMitra.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbMesin_MouseDown(object sender, MouseEventArgs e)
        {
            cmbMesin.Items.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
                string queryGetMesin = "SELECT merek_mesin FROM mesin ORDER BY merek_mesin ASC";
                connection.Open();
                MySqlCommand commandGetMesin = new MySqlCommand(queryGetMesin, connection);
                MySqlDataReader readerGetMesin = commandGetMesin.ExecuteReader();

                while (readerGetMesin.Read())
                {
                    cmbMesin.Items.Add(readerGetMesin.GetString("merek_mesin"));
                }

                commandGetMesin.Dispose();
                readerGetMesin.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbBarang_MouseDown(object sender, MouseEventArgs e)
        {
            string barang;
            cmbBarang.Items.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
                string queryGetBarang = "SELECT * FROM barang ORDER BY nama_barang ASC";
                connection.Open();
                MySqlCommand commandGetBarang = new MySqlCommand(queryGetBarang, connection);
                MySqlDataReader readerGetBarang = commandGetBarang.ExecuteReader();

                while (readerGetBarang.Read())
                {
                    barang = readerGetBarang.GetString("nama_barang");
                    barang += " | " + readerGetBarang.GetString("model_barang");
                    barang += " | " + readerGetBarang.GetString("seri_barang");
                    cmbBarang.Items.Add(barang);
                }

                commandGetBarang.Dispose();
                readerGetBarang.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbJasa_MouseDown(object sender, MouseEventArgs e)
        {
            cmbJasa.Items.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
                string queryGetJasa = "SELECT nama_jasa FROM jasa ORDER BY nama_jasa ASC";
                connection.Open();
                MySqlCommand commandGetJasa = new MySqlCommand(queryGetJasa, connection);
                MySqlDataReader readerGetJasa = commandGetJasa.ExecuteReader();

                while (readerGetJasa.Read())
                {
                    cmbJasa.Items.Add(readerGetJasa.GetString("nama_jasa"));
                }

                commandGetJasa.Dispose();
                readerGetJasa.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tepmNamaBarang = cmbBarang.SelectedItem.ToString();
            string[] namaBarang = tepmNamaBarang.Split('|');

            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
                string queryGetBarang = "SELECT id_barang, satuan_barang FROM barang WHERE nama_barang = '" + namaBarang[0] + "'";
                connection.Open();
                MySqlCommand commandGetBarang = new MySqlCommand(queryGetBarang, connection);
                MySqlDataReader readerGetBarang = commandGetBarang.ExecuteReader();

                readerGetBarang.Read();

                labelSatuanBarang.Text = readerGetBarang.GetString("satuan_barang");

                commandGetBarang.Dispose();
                readerGetBarang.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNamaCustomer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                lvNamaCustomer.Items.Add(txtNamaCustomer.Text);
                txtNamaCustomer.Clear();
            }
        }

        private void btnHapusNama_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem ls in lvNamaCustomer.CheckedItems)
            {
                lvNamaCustomer.Items.Remove(ls);
            }
        }

        private void cbDiskon_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDiskon.Checked)
            {
                txtDiskon.Visible = true;
            }
            else
            {
                txtDiskon.Visible = false;
            }
        }

        public void clearBarang()
        {
            cmbBarang.Text = "";
            cmbJasa.Text = "";
            txtDiskon.Text = "";
            txtHarga.Text = "";
            txtJumlah.Text = "";
            cbDiskon.Checked = false;
        }

        private void btnMasukListBarang_Click(object sender, EventArgs e)
        {
            string tepmNamaBarang, idBarang, satuanBarang, jasa, idJasa, diskon, harga, jumlahBarang;
            string[] namaBarang;
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command = connection.CreateCommand();

                if (cmbBarang.SelectedItem != null)
                {
                    tepmNamaBarang = cmbBarang.SelectedItem.ToString();
                    namaBarang = tepmNamaBarang.Split('|');
                    command.CommandText = "SELECT id_barang, satuan_barang FROM barang WHERE nama_barang = '" + namaBarang[0] + "'";
                    MySqlDataReader readerGetBarang = command.ExecuteReader();
                    readerGetBarang.Read();
                    idBarang = readerGetBarang.GetString("id_barang");
                    satuanBarang = readerGetBarang.GetString("satuan_barang");
                    command.Dispose();
                    readerGetBarang.Close();
                    jasa = "-";
                    idJasa = "-";
                }
                else
                {
                    tepmNamaBarang = "-";
                    idBarang = "-";
                    satuanBarang = "-";
                }

                jumlahBarang = txtJumlah.Text;
                harga = txtHarga.Text;

                if (cmbJasa.SelectedItem != null)
                {
                    jasa = cmbJasa.SelectedItem.ToString();
                    command.CommandText = "SELECT id_jasa, harga_jasa FROM jasa WHERE nama_jasa = '" + jasa + "'";
                    MySqlDataReader readerGetJasa = command.ExecuteReader();
                    readerGetJasa.Read();
                    idJasa = readerGetJasa.GetString("id_jasa");
                    harga = readerGetJasa.GetString("harga_jasa");
                    command.Dispose();
                    readerGetJasa.Close();
                    tepmNamaBarang = "-";
                    idBarang = "-";
                    satuanBarang = "-";
                    jumlahBarang = "-";
                }
                else
                {
                    jasa = "-";
                    idJasa = "-";
                }

                if (cbDiskon.Checked == true)
                {
                    diskon = txtDiskon.Text;
                }
                else
                {
                    diskon = "-";
                }

                ListViewItem lv = new ListViewItem();
                lv = lvListBarang.Items.Add(idBarang);
                lv.SubItems.Add(idJasa);
                lv.SubItems.Add(jasa);
                lv.SubItems.Add(tepmNamaBarang);
                lv.SubItems.Add(jumlahBarang);
                lv.SubItems.Add(satuanBarang);
                lv.SubItems.Add(harga);
                lv.SubItems.Add(diskon);

                clearBarang();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKeluarListBarang_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem ls in lvListBarang.CheckedItems)
            {
                lvListBarang.Items.Remove(ls);
            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin data penawaran sudah benar ?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string idMitra, idMesin, mitra, mesin;

                MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command = connection.CreateCommand();

                mitra = cmbMitra.SelectedItem.ToString();
                command.CommandText = "SELECT id_mitra FROM mitra WHERE nama_mitra = '" + mitra + "'";
                MySqlDataReader readerGetBarang = command.ExecuteReader();
                readerGetBarang.Read();
                idMitra = readerGetBarang.GetString("id_mitra");
                readerGetBarang.Close();

                mesin = cmbMesin.SelectedItem.ToString();
                command.CommandText = "SELECT id_mesin FROM mesin WHERE merek_mesin = '" + mesin + "'";
                MySqlDataReader readerGetMesin = command.ExecuteReader();
                readerGetMesin.Read();
                idMesin = readerGetMesin.GetString("id_mesin");
                readerGetMesin.Close();

                // count id penawaran
                string count;
                int counter;
                command.CommandText = "SELECT COUNT(*) AS nomor_penawaran FROM penawaran";
                MySqlDataReader readerGetPenawaran = command.ExecuteReader();
                readerGetPenawaran.Read();
                count = readerGetPenawaran.GetString("nomor_penawaran");

                counter = int.Parse(count) + 1;
                if (counter < 10)
                {
                    count = "000" + counter;
                }
                else if (counter < 100)
                {
                    count = "00" + counter;
                }
                else if (counter < 1000)
                {
                    count = "0" + counter;
                } else
                {
                    count = counter.ToString();
                }

                readerGetPenawaran.Close();

                // insert tabel penawaran
                string ppn;
                if (txtPpn.Text != "")
                {
                    ppn = txtPpn.Text;
                }
                else
                {
                    ppn = "0";
                }
                command.CommandText = "INSERT INTO penawaran VALUES('" + count + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', " + idMesin + ", " + idMitra + ", " + ppn + ", 1)";
                command.ExecuteNonQuery();

                // insert nama customer
                foreach (ListViewItem ls in lvNamaCustomer.Items)
                {
                    command.CommandText = "INSERT INTO customer_pembelian VALUES('" + count + "', '" + ls.SubItems[0].Text.ToString() + "')";
                    command.ExecuteNonQuery();
                }

                // insert detail penewaran
                string diskon;
                foreach (ListViewItem ls in lvListBarang.Items)
                {
                    if (ls.SubItems[0].Text.ToString() != "-")
                    {
                        if (ls.SubItems[7].Text.ToString() != "-")
                        {
                            diskon = ls.SubItems[7].Text.ToString();
                        }
                        else
                        {
                            diskon = "0";
                        }
                        command.CommandText = "INSERT INTO detail_penawaran(nomor_penawaran, id_barang, harga_penjualan, jumlah_barang, diskon) VALUES('" + count + "', " + ls.SubItems[0].Text.ToString() + ", " + ls.SubItems[6].Text.ToString() + ", " + ls.SubItems[4].Text.ToString() + ", " + diskon + ")";
                    }
                    else
                    {
                        command.CommandText = "INSERT INTO detail_penawaran(nomor_penawaran, id_jasa) VALUES('" + count + "', " + ls.SubItems[1].Text.ToString() + ")";
                    }
                    command.ExecuteNonQuery();
                }
                cmbMitra.Text = "";
                cmbMesin.Text = "";
                lvNamaCustomer.Items.Clear();
                lvListBarang.Items.Clear();
            }
        }

        private void btnKelolaMitra_Click(object sender, EventArgs e)
        {
            var viewKelolaMitra = new KelolaMitra();
            viewKelolaMitra.Show();
        }

        private void btnKelolaMesin_Click(object sender, EventArgs e)
        {
            var viewKelolaMesin = new KelolaMesin();
            viewKelolaMesin.Show();
        }

        private void btnKelolaBarang_Click(object sender, EventArgs e)
        {
            var viewKelolaBarang = new KelolaBarang();
            viewKelolaBarang.Show();
        }

        private void btnKelolaJasa_Click(object sender, EventArgs e)
        {
            var viewKelolaJasa = new KelolaJasa();
            viewKelolaJasa.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbMitra.Text = "";
            cmbMesin.Text = "";
            lvNamaCustomer.Items.Clear();
            lvListBarang.Items.Clear();
        }

        private void btnLihatHarga_Click(object sender, EventArgs e)
        {
            var viewHarga = new ViewHarga();
            viewHarga.Show();
        }
    }
}
