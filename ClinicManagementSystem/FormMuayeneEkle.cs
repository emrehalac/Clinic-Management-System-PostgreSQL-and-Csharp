using Npgsql;
using NpgsqlTypes;
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
    public partial class FormMuayeneEkle : Form
    {
        public FormMuayeneEkle()
        {
            InitializeComponent();
            
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
            this.Hide();

        }
         public static int kutu_sayac = 0;
        public static int ilacSayisiSayac = 1;
        private void btnHastaKontrol_Click(object sender, EventArgs e)
        {
            CrudManager crudManager = new CrudManager();
            if (crudManager.hastaMı(txtTCNumber.Text))
            {
                MessageBox.Show("Bilgileri girilen hasta sistemimizde kayıtlı bulunmaktadır. Muayene işlemine devam edebilirsiniz!");
            }
            else
                MessageBox.Show("Bilgileri girilen hasta sistemimizde mevcut değildir.");

        }

        private void checkBoxRecete_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRecete.Checked)
            {
                MessageBox.Show("Checkbox checked");
                lblBarkodNo.Visible = true;
                lblKutuSayisi.Visible = true;
                txtBarkodNo.Visible = true;
                txtKutuSayisi.Visible = true;
                btnMuayeneOlustur.Visible = false;
                btnReceteOlustur.Visible = true;
                btnBaskaİlacEkle.Visible = true;

            }
        }

        private void FormMuayeneEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnMuayeneOlustur_Click(object sender, EventArgs e)
        {
            // Muayene ve hasta ekleme Operasyonlarımızın yer aldığı sınıfı ve sınıf içerisindeki methodları çağıralım. Hepsi bu kadar. :) 
            CrudManager crudManager = new CrudManager();
            crudManager.muayeneEkle(txtTCNumber.Text,Convert.ToDateTime(txtMuayeneTarihi.Text),txtSikayet.Text,txtTani.Text,txtTedavi.Text);
            
            
           
                
        }

        private void btnReceteOlustur_Click(object sender, EventArgs e)
        {
            CrudManager crudManager=new CrudManager();
            
            // Dönecek olan değer muayene id'dir ve bu değeri ait olan muayene kaydı ve hastanın reçetesi ile ilişkilendirmeliyiz.
            int muayeneID = crudManager.muayeneEkle(txtTCNumber.Text, Convert.ToDateTime(txtMuayeneTarihi.Text), txtSikayet.Text, txtTani.Text, txtTedavi.Text);

            // PostgreSQL Database bağlantısı yapıp sonrasında komutlarımızı tanımlayalım. 
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=123456");
            conn.Open();

            NpgsqlCommand commandAddRecete = new NpgsqlCommand();
            NpgsqlCommand commandAddRecete_Ilac = new NpgsqlCommand();
            
            commandAddRecete_Ilac.Connection = conn;
            commandAddRecete.Connection = conn;

            commandAddRecete.Parameters.AddWithValue("@kimlik_no", txtTCNumber.Text);
            commandAddRecete_Ilac.Parameters.AddWithValue("@kutu_sayisi", Convert.ToInt32(txtKutuSayisi.Text));
      
            commandAddRecete_Ilac.Parameters.AddWithValue("@barkod_no", Convert.ToInt32(txtBarkodNo.Text));

            commandAddRecete.CommandType = CommandType.Text;
            commandAddRecete_Ilac.CommandType = CommandType.Text;
            
            // sorgularımızı yazalım ve ilk sorgudan dönen recete no'yu diğer sorguya parametre olarak verelim. 
            commandAddRecete.Parameters.AddWithValue("@muayene_id", muayeneID);
            commandAddRecete.CommandText = "INSERT INTO receteler(muayene_id) VALUES(@muayene_id) RETURNING recete_id";
            commandAddRecete_Ilac.CommandText = "INSERT INTO receteler_ilaclar (recete_id, kutu_sayisi, barkod_no ) VALUES (@recete_id, @kutu_sayisi, @barkod_no)";
            int recete_id = Convert.ToInt32(commandAddRecete.ExecuteScalar());

           
            commandAddRecete_Ilac.Parameters.AddWithValue("@recete_id", recete_id);


            commandAddRecete_Ilac.ExecuteNonQuery();















        }


        
        private void checkboxilacEkle_CheckedChanged(object sender, EventArgs e)
        {
            
            //if (checkboxilacEkle.Checked == true) 
            //{
            //    ilacSayisi = Convert.ToInt32(txtKutuSayisi.Text) + ilacSayisi;

            //    txtBarkodNo.Clear();
            //    txtKutuSayisi.Clear();
            //    checkboxilacEkle.Checked = false;
                

            //}
            
        }
         
        private void btnBaskaİlacEkle_Click(object sender, EventArgs e)
        {
            int kutuSayisi = Convert.ToInt32(txtKutuSayisi.Text);
            //kutu_sayac = kutu_sayac + kutuSayisi;
            
            
            txtBarkodNo.Clear();
            if( kutuSayisi > 3 || ilacSayisiSayac > 5)
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz. Bir ilaç için yazılan kutu sayınız 3'ten fazla veya reçetede 5'ten fazla ilaç bulunamaz!");
                MessageBox.Show("Şuanki girdiğiniz ilaç için kutu sayınız :" + kutuSayisi + " \n Reçetenizde bulunan toplam ilaç çeşidi: " + ilacSayisiSayac);
            }
            ilacSayisiSayac = ilacSayisiSayac + 1;
            txtKutuSayisi.Clear();

        }

        private void txtKutuSayisi_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
