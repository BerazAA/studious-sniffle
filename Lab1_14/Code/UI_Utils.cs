using System.Web.UI.WebControls;

namespace LD1_14.Code
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        /// <summary>
        /// Displays the table with inicial data
        /// </summary>
        /// <param name="Lines">Lines of inicial data</param>
        /// <param name="Table1">Modifiable table</param>
        public static void PrintDataTable (string[] Lines, Table Table1)
        {
            foreach (string line in Lines)
            {
                TableRow row = new TableRow();
                TableCell data = new TableCell();
                data.Text = line;
                row.Cells.Add(data);
                Table1.Rows.Add(row);
            }
        }

        /// <summary>
        /// Displays the table with results
        /// </summary>
        /// <param name="lands">Object with data about different plots of land</param>
        /// <param name="Table2">Modifiable table</param>
        public static void PrintResultTable (Land lands, Table Table2)
        {
            for (int k = 0; k < lands.GetNumb(); k++)
            {
                int[,] island = lands.GetIsland(k);
                TableRow row = new TableRow();
                TableCell data = new TableCell();
                if (TaskUtils.IslandCount(island) == 0 && TaskUtils.MaxIslandArea(island) == 0)
                {
                    data.Text = "Salų nėra";
                }
                else
                {
                    data.Text = string.Format("{0} {1}", TaskUtils.IslandCount(island), TaskUtils.MaxIslandArea(island));
                }
                row.Cells.Add(data);
                Table2.Rows.Add(row);
            }
        }
    }


}