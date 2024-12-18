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

namespace _231116042_muhammet_efe_kök_final_proje_3.PersonelGorevFormlari
{
    public partial class FrmCagriDetayGiris : Form
    {
        public FrmCagriDetayGiris()
        {
            InitializeComponent();
        }

        istakipEntities db = new istakipEntities();

        public int id;
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCagriDetayGiris_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtID.Text = id.ToString();
            string saat, tarih;
            tarih = DateTime.Now.ToShortDateString();
            saat = DateTime.Now.ToShortTimeString();
            txtTarih.Text = tarih;
            txtSaat.Text = saat;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TblCagriDetaylar t = new TblCagriDetaylar();
            t.Cagri = int.Parse(txtID.Text);
            t.Saat = txtSaat.Text;
            t.Tarih = DateTime.Parse(txtTarih.Text);
            t.Aciklama = txtAciklama.Text;
            db.TblCagriDetaylars.Add(t);
            db.SaveChanges();

            XtraMessageBox.Show("Çağrı Detayı Sisteme Başarılı Bir Şekilde Kaydedildi");

        }
    }
}
