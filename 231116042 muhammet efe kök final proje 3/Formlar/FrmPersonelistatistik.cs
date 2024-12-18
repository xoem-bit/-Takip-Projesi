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
    public partial class FrmPersonelistatistik : Form
    {
        public FrmPersonelistatistik()
        {
            InitializeComponent();
        }

        istakipEntities db = new istakipEntities();

        private void FrmPersonelistatistik_Load(object sender, EventArgs e)
        {
            ToplamDepartman.Text = db.TblDepartmanlars.Count().ToString();
            FirmaSayisi.Text = db.TblFirmalars.Count().ToString();
            toplamPersonelSayi.Text = db.TblPersonels.Count().ToString();
            AktifisSayi.Text = db.TblGorevlers.Count(x => x.Durum == true).ToString();
            PasifisSayisi.Text = db.TblGorevlers.Count(x => x.Durum == false).ToString();
            SonGorev.Text = db.TblGorevlers.OrderByDescending(x => x.ID).Select(x => x.Aciklama).FirstOrDefault();
            SonGorevTarihi.Text = db.TblGorevlers.OrderByDescending(x => x.ID).Select(x => x.Tarih).FirstOrDefault().ToString();
            İsYapilanSehir.Text = db.TblFirmalars.Select(x => x.il).Distinct().Count().ToString();
            SektorSayisi.Text = db.TblFirmalars.Select(x => x.Sektor).Distinct().Count().ToString();
            DateTime bugun = DateTime.Today;
            BugunAcilanGorevler.Text = db.TblGorevlers.Count(x => x.Tarih == bugun).ToString();
            var d1 = db.TblGorevlers.GroupBy(x => x.GorevAlan).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            AyinPersoneli.Text = db.TblPersonels.Where(x => x.ID == d1).Select(y => y.Ad + y.Soyad).FirstOrDefault().ToString();
            AyinDepartmani.Text = db.TblDepartmanlars.Where(x => x.ID == db.TblPersonels.Where(t => t.ID == d1).Select(z => z.Departman).FirstOrDefault()).Select(y => y.Ad).FirstOrDefault().ToString();
        }
    }
}
