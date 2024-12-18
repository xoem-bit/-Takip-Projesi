using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231116042_muhammet_efe_kök_final_proje_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        Formlar.FrmDepartmanlar frm;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new Formlar.FrmDepartmanlar();
                frm.MdiParent = this;
                frm.Show();
            }

        }
        Formlar.FrmPersoneller frm2;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new Formlar.FrmPersoneller();
                frm2.MdiParent = this;
                frm2.Show();
            }

        }
        Formlar.FrmPersonelistatistik frm3;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new Formlar.FrmPersonelistatistik();
                frm3.MdiParent = this;
                frm3.Show();
            }

        }
        Formlar.FrmGorevListesi frm4;
        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new Formlar.FrmGorevListesi();
                frm4.MdiParent = this;
                frm4.Show();
            }

        }
        Formlar.FrmGorev frm5;
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm5 = new Formlar.FrmGorev();
            frm5.Show();
        }
        Formlar.FrmGorevDetaylar frm6;
        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm6 = new Formlar.FrmGorevDetaylar();
            frm6.Show();
        }
        Formlar.FrmAnaForm frm7;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm7 == null || frm7.IsDisposed)
            {
                frm7 = new Formlar.FrmAnaForm();
                frm7.MdiParent = this;
                frm7.Show();
            }
        }
        Formlar.FrmAktifCagrilar fr8;
        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             

            if (fr8 == null || fr8.IsDisposed)
            {
                fr8 = new Formlar.FrmAktifCagrilar();
                fr8.MdiParent = this;
                fr8.Show();
            }

        }
    }
}
