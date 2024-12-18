using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _231116042_muhammet_efe_kök_final_proje_3.Entity;

namespace _231116042_muhammet_efe_kök_final_proje_3.Formlar
{
    public partial class FrmAktifCagrilar : Form
    {
        public FrmAktifCagrilar()
        {
            InitializeComponent();
        }

        istakipEntities db = new istakipEntities();

        private void FrmAktifCagrilar_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.TblCagrilars
                            select new
                            {
                                x.ID,
                                x.TblFirmalar.Ad,
                                x.TblFirmalar.Telefon,
                                x.Konu,
                                x.Aciklama,
                                personel = x.TblPersonel.Ad,
                                x.Durum
                            }
               ).Where(y => y.Durum == true).ToList();

            gridControl1.DataSource = degerler;

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmCagriAtama fr = new FrmCagriAtama();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
