using LD1_14.Code;
using System;
using System.IO;

namespace LD1_14
{
    public partial class Forma1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string[] Lines = File.ReadAllLines(Server.MapPath("App_Data/U3.txt"));
            WebForm1.PrintDataTable(Lines, Table1);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Visible = true;
            Land lands =InOutUtils.ReadData(Server.MapPath("/App_data/U3.txt"));
            InOutUtils.PrintData(Server.MapPath("/App_data/Duomenys.txt"), lands);
            WebForm1.PrintResultTable(lands, Table2);
            InOutUtils.PrintResults(Server.MapPath("/App_data/Rezultatai.txt"), lands);
        }
    }
}