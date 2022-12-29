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
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void masterMesinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewKelolaMesin = new KelolaMesin();
            viewKelolaMesin.Show();
        }

        private void masterBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewKelolaBarang = new KelolaBarang();
            viewKelolaBarang.Show();
        }

        private void masterJasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewKelolaJasa = new KelolaJasa();
            viewKelolaJasa.Show();
        }

        private void masterMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewKelolaMitra = new KelolaMitra();
            viewKelolaMitra.Show();
        }

        private void buatPenawaranToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var viewCreatePenawaran = new CreatePenawaran();
            viewCreatePenawaran.Show();
        }

        private void lihatPenawaranToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var viewPenawaran = new ViewPenawaran();
            viewPenawaran.Show();
        }
    }
}
