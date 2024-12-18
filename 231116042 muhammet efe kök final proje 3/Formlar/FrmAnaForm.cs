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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        istakipEntities db = new istakipEntities();

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblGorevlers
                                       select new
                                       {
                                           x.Aciklama,
                                          Ad_Soyad = x.TblPersonel.Ad + " " + x.TblPersonel.Soyad,
                                          x.Durum
                                       }).Where(y => y.Durum == true).ToList();
            gridView1.Columns["Durum"].Visible = false;
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            gridControl2.DataSource = (from x in db.TblGorevDetaylars
                                       select new
                                       {
                                           Görev = x.TblGorevler.Aciklama,
                                           x.Aciklama,
                                           x.Tarih
                                       }).Where(x => x.Tarih == bugun).ToList();
            gridControl3.DataSource = (from x in db.TblCagrilars
                                       select new
                                       {
                                           x.TblFirmalar.Ad,
                                           x.Konu,
                                           x.Tarih,
                                           x.Durum
                                       }).Where(x => x.Durum == true).ToList();
            gridView3.Columns["Durum"].Visible = false;
            gridControl4.DataSource = (from x in db.TblFirmalars
                                       select new
                                       {
                                           x.Ad,
                                           x.Telefon,
                                           x.Mail
                                       }).ToList();
            int aktif_cagrilar = db.TblCagrilars.Where(x => x.Durum == true).Count();
            int pasif_cagrilar = db.TblCagrilars.Where(x => x.Durum == false).Count();
            chartControl1.Series["Series 1"].Points.AddPoint("Aktif Çağrılar", aktif_cagrilar);
            chartControl1.Series["Series 1"].Points.AddPoint("Pasif Çağrılar", pasif_cagrilar);
        }
    }
}
