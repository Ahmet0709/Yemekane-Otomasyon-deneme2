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
            baglanti.Close();
        }

        public Üyepanel()
        {
            InitializeComponent();
        }

        private void Üyepanel_Load(object sender, EventArgs e)
        {
            uyegetir();
        }
    }
}
