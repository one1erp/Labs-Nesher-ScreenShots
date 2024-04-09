using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Font = System.Drawing.Font;

namespace ScreenShots
{
    public partial class SekerHoze : Form
    {
        public SekerHoze()
        {
            InitializeComponent();
//            List<PricelistEntry> list = new List<PricelistEntry>
//                                            {
//                                                new PricelistEntry("ספירה כללית", "350"),
//                                                new PricelistEntry("קוליפורמים",  "200"),
//                                                new PricelistEntry("E. Coli",  "200"),
//                                                new PricelistEntry("שמרים",  "150"),
//                                                new PricelistEntry("זרחן", "80")
//                                            };
//            lstPriceList.DataSurce = list;

            dgvTestSeker.AutoGenerateColumns = false;
            //            dgvTestSeker.Columns.Add("TestTemplateId", "ID");
            //            dgvTestSeker.Columns.Add("TestTemplateName", "שם הבדיקה");
            dgvTestSeker.Columns.Add("TestTemplateDescription", "סוג הבדיקה");
            dgvTestSeker.Columns.Add("TestTemplateMethod", "תקן");
            dgvTestSeker.Columns.Add("TestTemplateReturnTime", "זמן קבלת תוצאה");

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn(false);
            checkBoxColumn.HeaderText = "הסמכה";
            checkBoxColumn.Name = "TestTemplateHasmacha";
            dgvTestSeker.Columns.Add(checkBoxColumn);

            dgvTestSeker.Columns.Add("TestTemplateBasePrice", "מחיר");
            dgvTestSeker.Columns.Add("TestTemplateFinalPrice", "מחיר סופי");


            dgvTestSeker.DefaultCellStyle.Font = new Font(dgvTestSeker.DefaultCellStyle.Font.FontFamily, 8.25f);
            dgvTestSeker.ColumnHeadersDefaultCellStyle.Font = new Font(dgvTestSeker.ColumnHeadersDefaultCellStyle.Font.FontFamily, 8.25f);
            dgvTestSeker.AlternatingRowsDefaultCellStyle.Font = new Font(dgvTestSeker.AlternatingRowsDefaultCellStyle.Font.FontFamily, 8.25f);


            dgvTestSeker.DataSource = TestTemplate.GetTests();
            dgvTestSeker.Columns[0].DataPropertyName = "TestTemplateDescription";
            dgvTestSeker.Columns[1].DataPropertyName = "TestTemplateMethod";
            dgvTestSeker.Columns[2].DataPropertyName = "TestTemplateReturnTime";
            dgvTestSeker.Columns[3].DataPropertyName = "TestTemplateHasmacha";
            dgvTestSeker.Columns[4].DataPropertyName = "TestTemplateBasePrice";
            dgvTestSeker.Columns[5].DataPropertyName = "TestTemplateFinalPrice";
        }
        
    }

    public class TestTemplate
    {
        public string TestTemplateName { get; set; }
        public string TestTemplateDescription { get; set; }
        public int TestTemplateBasePrice { get; set; }
        public int FinalPrice { get; set; }
        public bool TestTemplateHasmacha { get; set; }
        public string TestTemplateReturnTime { get; set; }
        public string TestTemplateMethod { get; set; }

        public int TestTemplateFinalPrice { get; set; }
        //        public int TestTemplateAdditionalDiscount { get; set; }


        public TestTemplate(  string ttDescription, int ttBasePrice, int finalPrice ,bool ttHasmacha, string ttReturnTime, string ttTestMethod)
        {
//            TestTemplateName = ttName;
            TestTemplateDescription = ttDescription;
            TestTemplateBasePrice = ttBasePrice;
            TestTemplateFinalPrice = finalPrice;
            TestTemplateHasmacha = ttHasmacha;
            TestTemplateReturnTime = ttReturnTime;
            TestTemplateMethod = ttTestMethod;

            //            TestTemplateAdditionalDiscount = 0;
        }

        public static List<TestTemplate> GetTests()
        {
//            return null;

            return new List<TestTemplate> { new TestTemplate( "סלמונלה", 100, 90, true, "יומיים", "USDA/FDA"),
                                            new TestTemplate( "ספירה כללית", 150, 135, false, "יום", "תי 880"),
                                            new TestTemplate( "ליסטריה", 200, 180, true, "יום", "תי 880"),
                                            new TestTemplate( "E. coli", 300, 270, true, "יומיים", "USDA/FDA")};
        }


    }

    
}
