using _231116042_muhammet_efe_kök_final_proje_3.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231116042_muhammet_efe_kök_final_proje_3.Formlar
{
    public partial class FrmGorevDetaylar : Form
    {
        public FrmGorevDetaylar()
        {
            InitializeComponent();
        }

        istakipEntities db = new istakipEntities();

        private void FrmGorevDetaylar_Load(object sender, EventArgs e)
        {
            db.TblGorevDetaylars.Load();
            bindingSource1.DataSource = db.TblGorevDetaylars.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }

        private void görevDetaySilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
