using _231116042_muhammet_efe_kök_final_proje_3.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231116042_muhammet_efe_kök_final_proje_3.Formlar
{
    public partial class FrmGorevListesi : Form
    {
        public FrmGorevListesi()
        {
            InitializeComponent();
        }

        istakipEntities db = new istakipEntities();

        private void FrmGorevListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblGorevlers select new
            {
                x.Aciklama
            }).ToList();

            AktifGorevSayisi.Text = db.TblGorevlers.Where(x => x.Durum == true).Count().ToString(); 
            PasifGorevSayisi.Text = db.TblGorevlers.Where(x => x.Durum == false).Count().ToString();
            ToplamDepartman.Text = db.TblDepartmanlars.Count().ToString();

            chartControl1.Series["Series 1"].Points.AddPoint("Aktif Görevler", int.Parse(AktifGorevSayisi.Text));
            chartControl1.Series["Series 1"].Points.AddPoint("Pasif Görevler", int.Parse(PasifGorevSayisi.Text));
        }
    }
}
