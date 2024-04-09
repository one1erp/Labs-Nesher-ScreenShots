using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace ScreenShots
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += new EventHandler(Form1_Load);
            List<PricelistEntry> list = new List<PricelistEntry>
                                            {
                                                new PricelistEntry("ספירה כללית", "תי  885/3", "3 ימים", true, "350"),
                                                new PricelistEntry("קוליפורמים", "USDA/FDA", "יום", false, "200"),
                                                new PricelistEntry("E. Coli", "תי  885/3", "יומיים",false, "200"),
                                                new PricelistEntry("שמרים", "USDA/FDA", "יום", true, "150"),
                                                new PricelistEntry("זרחן", "תי  885/3", "3 ימים", true, "0")
                                            };


            dataGridView1.DataSource = list;
            
//            dataGridView1.Rows[3].DefaultCellStyle.BackColor = Color.Red;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows[4].DefaultCellStyle.BackColor= Color.Red;
        }
    }

//    private void GridView_CellClick(object sender, DataGridViewCellEventArgs e){
//
//        DataGridViewCellStyle CellStyle = new DataGridViewCellStyle();
//        CellStyle.BackColor = Color.Red;
//        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = CellStyle;
//
//    }

    public class PricelistEntry
    {
        public PricelistEntry(string name, string price)
        {
            Name = name;            
            Price = price;
        }

        public PricelistEntry(string name, string teken, string time, bool hasmaha, string price)
        {
            Name = name;
            Teken = teken;
            Time = time;
            Hasmaha = hasmaha;
            Price = price;
        }

        public string Name { get; set; }
        public string Teken { get; set; }
        public string Time { get; set; }
        public bool Hasmaha { get; set; }
        public string Price { get; set; }

    }
}
