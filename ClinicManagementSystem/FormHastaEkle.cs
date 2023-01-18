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
    public partial class FormHastaEkle : Form
    {
        public FormHastaEkle()
        {
            InitializeComponent();
        }

        private void FormHastaEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            CrudManager crudManager = new CrudManager();
            crudManager.hastaEkle(txtHastaAd.Text,txtTCNumber.Text,txtAdress.Text,txtMedeniDurum.Text,txtDogumYeri.Text, txtDogumTarihi.Text,txtTelefonNo.Text);

        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
            this.Hide();
        }
    }
}
