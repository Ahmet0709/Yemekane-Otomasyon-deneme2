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
        YemekhaneotomasyonuEntities1 db = new YemekhaneotomasyonuEntities1();


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
         void listele()
        {
            üyedatagrid.DataSource = db.Üye.ToList();

        }

        private void Üyepanel_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void üyedatagrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          /*  tbID.Text = üyedatagrid.CurrentRow.Cells[0].Value.ToString();
            tbad.Text = üyedatagrid.CurrentRow.Cells[2].Value.ToString();
            tbsoyad.Text = üyedatagrid.CurrentRow.Cells[3].Value.ToString();
            tbTC.Text = üyedatagrid.CurrentRow.Cells[1].Value.ToString();
            tbbirim.Text = üyedatagrid.CurrentRow.Cells[4].Value.ToString();
            tbGörev.Text = üyedatagrid.CurrentRow.Cells[5].Value.ToString(); */
        }

        private void btnekle_Click(object sender, EventArgs e)
        {

            Üye uyeler = new Üye();
            uyeler.Ad = tbad.Text;
            uyeler.Soyad = tbsoyad.Text;
            uyeler.Tckimlikno = tbTC.Text;
            uyeler.Görev = tbGörev.Text;
            uyeler.Birim = tbbirim.Text;
            db.Üye.Add(uyeler);
            db.SaveChanges();
            listele();
        }

        private void btnpasif_Click(object sender, EventArgs e)
        {
            
            
            
            
            
            
            /*  int ad = Convert.ToInt32(tbad.Text);
            var x = db.Üye.Find(ad); 
            db.Üye.Remove(x); 
            db.SaveChanges();
            listele(); */
        }
    }
}
