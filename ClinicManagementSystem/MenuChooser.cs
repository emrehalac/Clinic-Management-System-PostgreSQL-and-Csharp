using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem
{
    internal class MenuChooser
    {
        public void ChooseMenu(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                        FormHastaEkle formHastaEkle = new FormHastaEkle();
                        formHastaEkle.Text = "Hasta Ekleme Sayfasına Hoşgeldiniz!";
                        formHastaEkle.Show();
                    break;
                      
                case 1:
                        FormMuayeneEkle formMuayeneEkle = new FormMuayeneEkle();
                        formMuayeneEkle.Show();
                        formMuayeneEkle.Text = "Muayene Ekleme Sayfasına Hoşgeldiniz!";
                    break;

                case 2: 
                        ReceteListele receteListele = new ReceteListele();
                        receteListele.Text = "Recetele Listeleme Sayfasına Hoşgeldiniz";
                        receteListele.Show();
                    break;

                case 3: 
                        MuayeneListele muayeneListele = new MuayeneListele();
                        muayeneListele.Text = "Muayene Listeleme Sayfasına Hoşgeldiniz";
                        muayeneListele.Show();
                    break;

               
                        
                   
            }
               



        }
    }
}
