using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class ReceteListele : Form
    {
        public ReceteListele()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SELECT receteler.recete_id, muayene.muayene_id, muayene.muayene_tarihi
            //FROM receteler INNER JOIN muayene
            //ON receteler.muayene_id = muayene.muayene_id
            //ORDER BY muayene.muayene_tarihi ASC;

        }

        private void btnReceteListele_Click(object sender, EventArgs e)
        {
            CrudManager crudManager = new CrudManager();
            crudManager.receteListele(dataGridView1);
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
            this.Hide();
        }
    }
}
