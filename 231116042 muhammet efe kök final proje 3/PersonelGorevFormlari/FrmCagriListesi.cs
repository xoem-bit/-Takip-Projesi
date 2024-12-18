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
    public partial class FrmCagriListesi : Form
    {
        public FrmCagriListesi()
        {
            InitializeComponent();
        }

        istakipEntities db = new istakipEntities();
        public string mail2;

        private void FrmCagriListesi_Load(object sender, EventArgs e)
        {
            var personelid = db.TblPersonels.Where(x => x.Mail == mail2).Select(y => y.ID).FirstOrDefault();
            this.Text = personelid.ToString();

            gridControl1.DataSource = (from x in db.TblCagrilars
                                       select new
                                       {
                                           x.ID,
                                           x.TblFirmalar.Ad,
                                           x.TblFirmalar.Telefon,
                                           x.TblFirmalar.Mail,
                                           x.Aciklama,
                                           x.CagriPersonel,
                                           x.Durum
                                       }).Where(y => y.Durum == true && y.CagriPersonel == personelid).ToList();

            gridView1.Columns["Durum"].Visible = false;
            gridView1.Columns["CagriPersonel"].Visible = false;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmCagriDetayGiris fr = new FrmCagriDetayGiris();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
