using System.Collections.Generic;

namespace LD1_14.Code
{
    public class Land
    {
        private List<int[,]> Islands;
        private int NumbOfISlands;

        /// <summary>
        /// A predefined Land object
        /// </summary>
        /// <param name="numbOfIslands">Number of different plots of land</param>
        /// <param name="islands">List with data about plots of land</param>
        public Land(int numbOfIslands, List<int[,]> islands)
        {
            Islands = new List<int[,]>(islands);
            this.NumbOfISlands = numbOfIslands;
        }

        /// <summary>
        /// Returns data about specified plot of land
        /// </summary>
        /// <param name="index">index of wanted plot</param>
        /// <returns>data about specified plot of land</returns>
        public int[,] GetIsland(int index)
        {
            if (index >= 0 && index <= Islands.Count)
            {
                return this.Islands[index];
            }
            else
                return null;
        }

        /// <summary>
        /// Returns number of different plots of land
        /// </summary>
        /// <returns>number of different plots of land</returns>
        public int GetNumb()
        {
            return this.NumbOfISlands;
        }

        public override string ToString()
        {
            string line = "";
            for (int k = 0; k < NumbOfISlands; k++)
            {
                int[,] island = Islands[k];
                line+= (string.Format("Ploto matmenys: {0} x {1} \n", island.GetLength(0), island.GetLength(1)));
                line+=(new string('-', island.GetLength(1) + 2)+"\n");
                for (int i = 0; i < island.GetLength(0); i++)
                {
                    line +=('|');
                    for (int j = 0; j < island.GetLength(1); j++)
                    {
                        line += (island[i, j].ToString());
                    }
                    line += ('|');
                    line += ("\n");

                }
                line += (new string('-', island.GetLength(1) + 2)+"\n");
            }

            return line;
        }
    }
}