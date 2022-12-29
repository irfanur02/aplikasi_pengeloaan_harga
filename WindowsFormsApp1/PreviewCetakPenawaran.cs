using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace WindowsFormsApp1
{
    public partial class PreviewCetakPenawaran : Form
    {
        ReportDocument CR = new ReportDocument();

        public PreviewCetakPenawaran()
        {
            InitializeComponent();
        }

        private void PreviewCetakPenawaran_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;database=db_cvktm");
            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            connection.Open();

            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM mitra";
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            CR.Load("CRPenawaran.rpt");
            CR.SetDataSource(dt);
            CRViewer.ReportSource = CR;
        }
    }
}
