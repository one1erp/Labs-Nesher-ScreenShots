using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenShots
{
    public partial class Hazmana : Form
    {
        public Hazmana()
        {
            InitializeComponent();
            radGridView1.Rows.Add("1", "", "חומוס", "חומוס 200 גרם", "12/12/2012","A-123","24","עוגיפלצת","14/12/2012","1-222-1","חומוס ממש טעים!");
            radGridView1.Rows.Add("2", "", "סלט קר", "טחינה אסלי", "12/12/2012", "B-123", "25", "הלקוח", "14/12/2012", "1-222-2", "");
            radGridView1.Rows.Add("3", "", "סלט קר", "עמבה בבקבוק", "13/12/2012", "A-123", "24", "אריק", "14/12/2012", "1-222-3", "");
            radGridView1.Rows.Add("4", "", "סחוג", "סחוג תימני מקורי", "13/12/2012","A-123","12","בנץ","14/12/2012","1-222-4","זהירות, חריף!");
            radGridView1.Rows.Add("5", "", "אריסה", "אריזת אריסה", "15/12/2012", "C-123", "13", "הלקוח", "16/12/2012", "1-222-5", "");
            radGridView1.Rows.Add("6", "", "חמוצים", "מלפפון בחומץ גדול", "15/12/2012","A-123","23","עוגיפלצת","16/12/2012","1-222-6","");
            radGridView1.Rows.Add("7", "", "אוכל מטוגן", "צ'יפס", "14/12/2012","A-123","16","כרובי","17/12/2012","1-222-7","חומוצ'יפסלט?");
            radGridView1.Rows.Add("8", "", "סלט קר", "סלט סלק", "12/12/2012","D-123","17","כרובי","14/12/2012","1-222-8","");
            radGridView1.Rows.Add("9", "", "בשר", "שיפודי אנטריקוט", "15/12/2012", "A-123", "19", "הלקוח", "16/12/2012", "1-222-9", "");
            radGridView1.Rows.Add("10", "", "שתיה חמה", "קפה שחור נחלה עם הל", "14/12/2012","F-123","20","עוגיפלצת","16/12/2012","1-222-10","");


            comboBox4.SelectedIndex = 0;
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            TestAssignment t= new TestAssignment();
            t.ShowDialog();
        }

      
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLabs.Text == "מים")
            {
                lblWater.Visible = true;
                dtWater.Visible = true;
                lblTemp.Visible = true;
                txtTEmp.Visible = true;
                button1.Visible = true;
//                MessageBox.Show(txtComments.Height.ToString());
//                txtComments.Height = 108;
            }
            else
            {
                lblWater.Visible = false;
                dtWater.Visible = false;
                lblTemp.Visible = false;
                txtTEmp.Visible = false;
                button1.Visible = false;
//                txtComments.Height = 54;
            }
        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox4.Text.Contains("לקוח"))
            {
//                comboBox4.Text = "נדגם עי הלקוח";
                btnCopyDogem.Visible = false;
                cmbDogem.Visible = false;
            }
            else
            {
//                comboBox4.Text = "נדגם עי המעבדה";
                btnCopyDogem.Visible = true;
                cmbDogem.Visible = true;
            }
        }
    
    }

}
