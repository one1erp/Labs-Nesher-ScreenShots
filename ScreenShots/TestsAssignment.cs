using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ScreenShots
{
    public partial class TestAssignment : Form
    {
        public TestAssignment()
        {
            InitializeComponent();

//            ((GridTableElement) radGridView1.GridElement).TableHeaderHeight = 500;

            radGridView1.CellFormatting += new CellFormattingEventHandler(radGridView1_CellFormatting);

            radGridView1.Rows.Add("1", "F12345/12.1", "סלטים","חומוס 200 גרם",  "124", true, true, false, false, true, false, false);
            radGridView1.Rows.Add("2", "F12345/12.2", "סלטים","טחינה אסלי",  "125", true, true, false, false, true, true, false);
            radGridView1.Rows.Add("3", "F12345/12.3", "סלטים","עמבה בבקבוק",  "12", false, true, false, false, true, true, false);
            radGridView1.Rows.Add("4", "F12345/12.4", "סלטים","סחוג תימני מקורי",  "333", false, true, false, false, true, false, false);
            radGridView1.Rows.Add("5", "F12345/12.5", "סלטים","אריזת אריסה",  "444", true, true, false, false, true, true, false);
            radGridView1.Rows.Add("6", "F12345/12.6", "חמוצים","מלפפון בחומץ גדול", "5",  true, true, false, false, true, false, false);
            radGridView1.Rows.Add("7", "F12345/12.7", "מטוגנים","צ'יפס",  "1212", false, true, false, false, true, true, false);
            radGridView1.Rows.Add("8", "F12345/12.8", "סלטים","סלט סלק",  "334", true, true, false, false, false, true, false);
            radGridView1.Rows.Add("9", "F12345/12.9", "בשר", "שיפודי אנטריקוט", "331", true, true, false, false, true, true, false);
            radGridView1.Rows.Add("10", "F12345/12.10","משקאות חמים", "קפה שחור נחלה עם הל", "111",  true, false, false, false, false, true, false);


        }

        void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.ColumnInfo.Index == 0 || e.CellElement.ColumnInfo.Index == 1 || e.CellElement.ColumnInfo.Index == 2 || e.CellElement.ColumnInfo.Index == 3 || e.CellElement.ColumnInfo.Index == 4)
            {
                e.CellElement.BackColor = Color.Wheat;
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local);
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            radGridView1.SaveLayout("c:\\set.xml");
        }

        private void TestAssignment_Load(object sender, EventArgs e)
        {
//            radGridView1.LoadLayout("c:\\set.xml");
        }

        
    }

}
