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

namespace _231116042_muhammet_efe_kök_final_proje_3.PersonelGorevFormlari
{
    public partial class FrmPasifGorevler : Form
    {
        public FrmPasifGorevler()
        {
            InitializeComponent();
        }

        istakipEntities db = new istakipEntities();
        public string mail2;

        private void FrmPasifGorevler_Load(object sender, EventArgs e)
        {
            var personelid = db.TblPersonels.Where(x => x.Mail == mail2).Select(y => y.ID).FirstOrDefault();

            var degerler = (from x in db.TblGorevlers
                            select new
                            {
                                x.ID,
                                x.Aciklama,
                                x.Tarih,
                                x.GorevAlan,
                                x.Durum
                            }).Where(x => x.GorevAlan == 2 && x.Durum == false).ToList();

            gridControl1.DataSource = degerler;
            gridView1.Columns["GorevAlan"].Visible = false;
            gridView1.Columns["Durum"].Visible = false;
        }
    }
}
