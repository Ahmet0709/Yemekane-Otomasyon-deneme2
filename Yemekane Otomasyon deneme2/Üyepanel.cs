using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiniExcelLibs;

namespace Yemekane_Otomasyon_deneme2
{
    public partial class Üyepanel : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adapter;

        void uyegetir()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=YemekhaneOtomasyonu-3; Integrated Security=SSPI");
            baglanti.Open();
            adapter = new SqlDataAdapter("SELECT *FROM Uyeler", baglanti);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            üyedatagrid.DataSource = tablo;
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        void Datagrid1colon()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Ad/ Soyad";
            dataGridView1.Columns[2].HeaderText = "TC Kimlik Numarası";
            dataGridView1.Columns[3].HeaderText = "Birim";
            dataGridView1.Columns[1].HeaderText = "Görev";
        }

        void üyegrid()
        {
            üyedatagrid.Columns[0].HeaderText = "ID";
            üyedatagrid.Columns[1].HeaderText = "Ad/ Soyad";
            üyedatagrid.Columns[2].HeaderText = "TC Kimlik Numarası";
            üyedatagrid.Columns[3].HeaderText = "Birim";
            üyedatagrid.Columns[1].HeaderText = "Görev";
        }

        public Üyepanel()
        {
            InitializeComponent();
        }

        private void Üyepanel_Load(object sender, EventArgs e)
        {
            uyegetir();
            Datagrid1colon();
            üyegrid();
        }

        private void üyedatagrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = üyedatagrid.CurrentRow.Cells[0].Value.ToString();
            tbadSoyad.Text = üyedatagrid.CurrentRow.Cells[1].Value.ToString();
            tbTC.Text = üyedatagrid.CurrentRow.Cells[2].Value.ToString();
            tbbirim.Text = üyedatagrid.CurrentRow.Cells[3].Value.ToString();
            tbGörev.Text = üyedatagrid.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
