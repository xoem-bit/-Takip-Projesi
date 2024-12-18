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
    public partial class FrmPersonelFormu : Form
    {
        public FrmPersonelFormu()
        {
            InitializeComponent();
        }
        public string mail;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlari.FrmAktifGorevler frm = new PersonelGorevFormlari.FrmAktifGorevler();
            frm.mail2 = mail;
            frm.MdiParent = this;
            frm.Show();

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlari.FrmPasifGorevler frm = new PersonelGorevFormlari.FrmPasifGorevler();
            frm.mail2 = mail;
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlari.FrmCagriListesi frm = new PersonelGorevFormlari.FrmCagriListesi();
            frm.mail2 = mail;
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmPersonelFormu_Load(object sender, EventArgs e)
        {
            this.Text = mail.ToString();
        }
    }
}
