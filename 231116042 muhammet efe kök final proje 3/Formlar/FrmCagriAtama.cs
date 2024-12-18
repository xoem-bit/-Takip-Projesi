using _231116042_muhammet_efe_kök_final_proje_3.Entity;
using DevExpress.XtraEditors;
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
    public partial class FrmCagriAtama : Form
    {
        public FrmCagriAtama()
        {
            InitializeComponent();
        }

        istakipEntities db = new istakipEntities();

        public int id;
        private void FrmCagriAtama_Load(object sender, EventArgs e)
        {
            // LookupEdit için verilerin listelenmesi
            var degerler = (from x in db.TblPersonels
                            select new
                            {
                                x.ID,
                                AdSoyad = x.Ad + " " + x.Soyad
                            }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AdSoyad";
            lookUpEdit1.Properties.DataSource = degerler;

            txtID.Text = id.ToString();
            var gelenveri = db.TblCagrilars.Find(id);
            txtAciklama.Text = gelenveri.Aciklama;
            txtTarih.Text = gelenveri.Tarih.ToString();
            txtKonu.Text = gelenveri.Konu;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var gelenveri = db.TblCagrilars.Find(id);
            gelenveri.Konu = txtKonu.Text;
            gelenveri.Tarih = Convert.ToDateTime(txtTarih.Text);
            gelenveri.Aciklama = txtAciklama.Text;
            gelenveri.CagriPersonel = int.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Çağrıya Başarılı Bir Şekilde Personel Kaydedildi");
        }
    }
}
