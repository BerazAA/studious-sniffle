using System.Collections.Generic;
using System.IO;

namespace LD1_14.Code
{
    public class InOutUtils
    {
        /// <summary>
        /// Reads data from the file
        /// </summary>
        /// <param name="fileName"> Name of the file</param>
        /// <returns>Object with data about different plots of land</returns>
        public static Land ReadData(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                int numbOfIslands = int.Parse(reader.ReadLine());
                List<int[,]> Islands = new List<int[,]>(numbOfIslands);
                for (int i = 0; i < numbOfIslands; i++)
                {
                    string[] parts = reader.ReadLine().Split(' ');
                    int column = int.Parse(parts[0]);
                    int row = int.Parse(parts[1]);
                    int[,] island = new int[column, row];
                    for (int j = 0; j < column; j++)
                    {
                        string line = reader.ReadLine();
                        for (int k = 0; k < line.Length; k++)
                        {
                            island[j, k] = line[k] - '0';
                        }
                    }
                    Islands.Add(island);
                }
                Land Lands = new Land(numbOfIslands, Islands);
                return Lands;
            }
        }

        /// <summary>
        /// Prints inicial data to a txt file
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <param name="Lands">Object with data about different plots of land</param>
        public static void PrintData (string fileName, Land Lands)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("Žemės plotų sk. : {0}",Lands.GetNumb());
                writer.WriteLine(Lands.ToString());
            }
        }
        /// <summary>
        /// Prints results to a txt file
        /// </summary>
        /// <param name="filename">Name of the file</param>
        /// <param name="Lands">Object with data about different plots of land</param>
        public static void PrintResults ( string filename, Land Lands)
        {
            
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(new string('-', 40));
                writer.WriteLine("| {0,-14} | {1,-19} |", "Salų skaičius", "Didž. salos plotas");
                writer.WriteLine(new string('-', 40));
                for (int k = 0; k < Lands.GetNumb(); k++)
                {
                    int[,] island = Lands.GetIsland(k);
                    if (TaskUtils.IslandCount(island) == 0 && TaskUtils.MaxIslandArea(island) == 0)
                    {
                        writer.WriteLine("| {0,-36} |","Salų nėra");
                        writer.WriteLine(new string('-', 40));
                    }
                    else
                    {
                        writer.WriteLine("| {0,14} | {1,19} |", TaskUtils.IslandCount(island), TaskUtils.MaxIslandArea(island));
                        writer.WriteLine(new string('-', 40));
                    }
                }
            }
        }
    }
}