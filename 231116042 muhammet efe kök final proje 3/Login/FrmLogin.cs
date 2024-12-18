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

namespace _231116042_muhammet_efe_kök_final_proje_3.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        istakipEntities db = new istakipEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            var adminvalue = db.TblAdmins.Where(x => x.Kullanici == txtKulAd.Text &&
                                                    x.Sifre == txtSifre.Text).FirstOrDefault();

            if (adminvalue != null)
            {
                XtraMessageBox.Show("Hoşgeldiniz");
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelGorevFormlari.FrmPersonelFormu fr = new PersonelGorevFormlari.FrmPersonelFormu();
            fr.Show();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            var personel = db.TblPersonels.Where(x => x.Mail == txtKulAd.Text && x.Sifre == txtSifre.Text).FirstOrDefault();
            if (personel != null)
            {
                PersonelGorevFormlari.FrmPersonelFormu fr = new PersonelGorevFormlari.FrmPersonelFormu();
                fr.mail = txtKulAd.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatali Giriş");
            }

        }
    }
}
