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
    public partial class FormHomePage : Form
    {
        public FormHomePage()
        {
            InitializeComponent();
            
        }

       public static string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=123456";
        public  void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public  void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxMenu.SelectedIndex;

            // Let's Create an instance of MenuChooser class here which will help us to choose the Selected Item of the ComboboxMenu. So our code will not be like "button click coding style" :) 
            MenuChooser menuChooser = new MenuChooser();
            menuChooser.ChooseMenu(selectedIndex);
            this.Hide();

        }
    }
}
