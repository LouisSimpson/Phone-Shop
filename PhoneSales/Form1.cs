using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneSales
{
    public partial class Form1 : Form
    {
        //shop contains a list of mobiles and a current index
        
        Shop shop;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shop = new Shop();
            //mobiles are added below
            ApplePhone applephone = new ApplePhone("Apple", "Iphone4", 300, "OSx", new DateTime(2015, 4, 21), MobilePhone.Condition.poor, new DateTime(2010, 6, 24));
            ApplePhone applephone1 = new ApplePhone("Apple", "Iphone4s", 350, "OSx", new DateTime(2015, 5, 12), MobilePhone.Condition.fair, new DateTime(2011, 10, 14));
            ApplePhone applephone2 = new ApplePhone("Apple", "Iphone5", 500, "OSx", new DateTime(2016, 6, 8), MobilePhone.Condition.good, new DateTime(2012, 9, 21));
            ApplePhone applephone3 = new ApplePhone("Apple", "Iphone5s", 525, "OSx", new DateTime(2016, 4, 21), MobilePhone.Condition.good, new DateTime(2013, 9, 20));
            ApplePhone applephone4 = new ApplePhone("Apple", "Iphone6", 600, "OSx", new DateTime(2016, 10, 3), MobilePhone.Condition.mint, new DateTime(2014, 9, 19));
            ApplePhone applephone5 = new ApplePhone("Apple", "Iphone7", 750, "OSx", new DateTime(2016, 12, 20), MobilePhone.Condition.mint, new DateTime(2016, 9, 16));
            AndroidPhone androidphone = new AndroidPhone("Samsung", "S5", 400, "Android KitKat ", new DateTime(2015, 3, 28), MobilePhone.Condition.fair, new DateTime(2014, 4, 11));
            AndroidPhone androidphone1 = new AndroidPhone("Samsung", "S6", 500, "Android Lollipop", new DateTime(2015, 6, 11), MobilePhone.Condition.good, new DateTime(2015, 4, 10));
            AndroidPhone androidphone2 = new AndroidPhone("OnePlus", "3", 300, "Android Marshmallow", new DateTime(2016, 6, 21), MobilePhone.Condition.mint, new DateTime(2016, 6, 14));
            AndroidPhone androidphone3 = new AndroidPhone("Oneplus", "3T", 375, "Android OxygenOS", new DateTime(2016, 11, 29), MobilePhone.Condition.mint, new DateTime(2016, 11, 28));
            AndroidPhone androidphone4 = new AndroidPhone("HTC", "One M9", 425, "Android Lollipop", new DateTime(2015, 8, 13), MobilePhone.Condition.poor, new DateTime(2015, 4, 10));
            WindowsPhone windowsphone1 = new WindowsPhone("Nokia", "Lumia", 300, "Windows OS", new DateTime(2015, 5, 12), MobilePhone.Condition.mint, new DateTime(2014, 7, 10));
            shop.AddMobile(applephone);
            shop.AddMobile(applephone1);
            shop.AddMobile(applephone2);
            shop.AddMobile(applephone3);
            shop.AddMobile(applephone4);
            shop.AddMobile(applephone5);
            shop.AddMobile(androidphone);
            shop.AddMobile(androidphone1);
            shop.AddMobile(androidphone2);
            shop.AddMobile(androidphone3);
            shop.AddMobile(androidphone4);
            shop.AddMobile(windowsphone1);
            //mobiles are displayed on the form in accordance to the displaymobileohone method
            DisplayMobilePhone();



        }

        private void DisplayMobilePhone()
        {
            labelCurrentPhone.Text = string.Format("viewing {0} of {1}", shop.MobileCurrentlyDisplayed + 1, shop.NumberOfMobiles);

            textBoxPhone.Text = shop.DescribeCurrentMobile();

            


        }



        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            shop.StepToPreviousMobilePhone();
            DisplayMobilePhone();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            shop.StepToNextMobilePhone();
            DisplayMobilePhone();
        }

        private void listViewPhone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            string[] row = { textBox1.Text, textBox2.Text };
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
             
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
