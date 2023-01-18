using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    internal class CrudManager
    {
        public void hastaEkle(string hastaAd, string hastaTCNo , string adres , string medeniDurum , string dogumYeri , string dogumTarihi , string telefonNo)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=123456");
            
            
            conn.Open();
            NpgsqlCommand command_add = new NpgsqlCommand();
            command_add.Connection = conn;

            command_add.Parameters.AddWithValue("@ad_soyad", hastaAd);
            command_add.Parameters.AddWithValue("@kimlik_no", hastaTCNo);
            command_add.Parameters.AddWithValue("@adres", adres);
            command_add.Parameters.AddWithValue("@medeni_durum", medeniDurum);
            command_add.Parameters.AddWithValue("@dogum_yeri", dogumYeri);
            command_add.Parameters.AddWithValue("@dogum_tarihi", dogumTarihi);
            command_add.Parameters.AddWithValue("@telefon", telefonNo);
            command_add.CommandType = System.Data.CommandType.Text;
            command_add.CommandText = "insert into hasta (ad_soyad, kimlik_no, adres , medeni_durum , dogum_yeri , dogum_tarihi , telefon) values (@ad_soyad, @kimlik_no , @adres, @medeni_durum, @dogum_yeri, @dogum_tarihi , @telefon)";
            NpgsqlDataReader dr = command_add.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);

            }
            command_add.Dispose();
            conn.Close();

            MessageBox.Show( hastaAd +  "isimli hastanız Başarıyla Sisteme Eklendi!");
        }

        public int muayeneEkle(string kimlik_no, DateTime muayene_tarihi, string sikayet,string tani, string tedavi)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=123456");
            

            conn.Open();
            NpgsqlCommand commandAddMuayene = new NpgsqlCommand();
            commandAddMuayene.Connection = conn;
            commandAddMuayene.Parameters.AddWithValue("@kimlik_no", kimlik_no);
            commandAddMuayene.Parameters.AddWithValue("@muayene_tarihi", muayene_tarihi);
            commandAddMuayene.Parameters.AddWithValue("@sikayet", sikayet);
            commandAddMuayene.Parameters.AddWithValue("@tani", tani);
            commandAddMuayene.Parameters.AddWithValue("@tedavi", tedavi);
            
            commandAddMuayene.CommandType = System.Data.CommandType.Text;
            commandAddMuayene.CommandText = "INSERT INTO muayene (kimlik_no, muayene_tarihi, sikayet, tani, tedavi) VALUES (@kimlik_no, @muayene_tarihi, @sikayet, @tani, @tedavi) RETURNING muayene_id";
            // HASTA KONTROLÜ DE YAPILMASI GEREKİYOR. EĞER GEÇERLİ HASTA TC'Sİ GİRİLMEDİYSE HATA ATMALI..

            int muayene_id = Convert.ToInt32(commandAddMuayene.ExecuteScalar());
            NpgsqlDataReader reader = commandAddMuayene.ExecuteReader();

            if(reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);

            }
            commandAddMuayene.Dispose();
            conn.Close();

            MessageBox.Show(kimlik_no + " T.C kimlik numaralı hastanıza muayene/reçeteniz  Başarıyla Oluşturuldu!");
            return muayene_id;
        }

        public Boolean hastaMı(string kimlik_no)
        {
            //

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=123456");
            conn.Open();

            NpgsqlCommand commandGet = new NpgsqlCommand();
            commandGet.Connection = conn;
            commandGet.CommandType = CommandType.Text;

            commandGet.Parameters.AddWithValue("@kimlik_no", kimlik_no);
            commandGet.CommandText = "SELECT COUNT(*) FROM Hasta WHERE kimlik_No = @kimlik_no";


            return (long)commandGet.ExecuteScalar() > 0;

        }

        public void muayeneListele(DataGridView dataGridView1)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=123456");
            conn.Open();

            NpgsqlCommand commandList = new NpgsqlCommand();
            commandList.Connection = conn;
            commandList.CommandType = CommandType.Text;
            commandList.CommandText = "select muayene.muayene_id, hasta.kimlik_no , hasta.ad_soyad , hasta.telefon , muayene.sikayet, muayene.tani , muayene.tedavi , muayene.recete_id from muayene inner join hasta on muayene.kimlik_no = hasta.kimlik_no; ";
            
            // yazılan sorgudan dönenleri şimdi datagridview1 ismindeki grafiğimize yazdıralım.
            NpgsqlDataReader reader = commandList.ExecuteReader();
            if (reader.Read())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

            }
            commandList.Dispose();
            conn.Close();
        }

        public void receteListele(DataGridView dataGridView1)
        {
            //
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=123456");
            conn.Open();

            NpgsqlCommand commandList = new NpgsqlCommand();
            commandList.Connection = conn;
            commandList.CommandType = CommandType.Text;
            commandList.CommandText = "select receteler.recete_id , receteler.muayene_id , receteler_ilaclar.barkod_no , receteler_ilaclar.kutu_sayisi , muayene.muayene_tarihi as recete_tarihi from receteler inner join receteler_ilaclar on receteler.recete_id = receteler_ilaclar.recete_id INNER JOIN muayene ON receteler.muayene_id = muayene.muayene_id order by recete_tarihi;";
            // yazılan sorgudan dönenleri şimdi datagridview1 ismindeki grafiğimize yazdıralım.
            NpgsqlDataReader reader = commandList.ExecuteReader();
            if (reader.Read())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

            }
            commandList.Dispose();
            conn.Close();
        }



    }
 }

