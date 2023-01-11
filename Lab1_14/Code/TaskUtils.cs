namespace LD1_14.Code
{
    public class TaskUtils
    {
        /// <summary>
        /// Determines if area is an island using its area
        /// </summary>
        /// <param name="Island">Array with the land data</param>
        /// <param name="currentRow">Row being checked</param>
        /// <param name="currentColumn">Column being checked </param>
        /// <param name="area">Area of current island</param>
        static void FindIsland(int[,] Island, int currentRow, int currentColumn, ref int area)
        {
            int row = Island.GetLength(0);
            int column = Island.GetLength(1);
            
            if (currentRow < 0 || currentColumn < 0 || currentRow > (row - 1) || currentColumn > (column - 1) || Island[currentRow, currentColumn] != 1)
            {
                return;
            }

            if (Island[currentRow, currentColumn] == 1)
            {

                area++;
                Island[currentRow, currentColumn] = 0;
                FindIsland(Island, currentRow + 1, currentColumn, ref area); 
                FindIsland(Island, currentRow - 1, currentColumn, ref area); 
                FindIsland(Island, currentRow, currentColumn + 1, ref area); 
                FindIsland(Island, currentRow, currentColumn - 1, ref area); 
                FindIsland(Island, currentRow + 1, currentColumn + 1, ref area);
                FindIsland(Island, currentRow - 1, currentColumn - 1, ref area); 
                FindIsland(Island, currentRow + 1, currentColumn - 1, ref area); 
                FindIsland(Island, currentRow - 1, currentColumn + 1, ref area); 
            }
        }

        /// <summary>
        /// Finds number of different islands
        /// </summary>
        /// <param name="Island">Array with the land data</param>
        /// <returns>Number of islands</returns>
        public static int IslandCount(int[,] Island)
        {
            int[,] Temp = (int[,])Island.Clone();
            int row = Temp.GetLength(0);
            int column = Temp.GetLength(1);
            int count = 0;
            int temp=0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (Temp[i, j] == 1)
                    {
                        Temp[i, j] = 0;
                        count++;
                        FindIsland(Temp, i + 1, j,ref temp);
                        FindIsland(Temp, i - 1, j, ref temp);
                        FindIsland(Temp, i, j + 1, ref temp);
                        FindIsland(Temp, i, j - 1, ref temp);
                        FindIsland(Temp, i + 1, j + 1, ref temp);
                        FindIsland(Temp, i - 1, j - 1, ref temp);
                        FindIsland(Temp, i + 1, j - 1, ref temp);
                        FindIsland(Temp, i - 1, j + 1, ref temp);
                    }
                }
            }
            return count;
        }

        /// <summary>
        /// Finds the biggest island
        /// </summary>
        /// <param name="Island">Array with the land data</param>
        /// <returns>Area of the biggest island</returns>
        public static int MaxIslandArea(int[,] Island)
        {
            int[,] Temp = (int[,])Island.Clone();
            int row = Temp.GetLength(0);
            int column = Temp.GetLength(1);
            int area;
            int maxArea = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    area = 0;
                    if (Temp[i, j] == 1)
                    {
                        area++;
                        Temp[i, j] = 0;
                        FindIsland(Temp, i + 1, j, ref area);
                        FindIsland(Temp, i - 1, j, ref area);
                        FindIsland(Temp, i, j + 1, ref area);
                        FindIsland(Temp, i, j - 1, ref area);
                        FindIsland(Temp, i + 1, j + 1, ref area);
                        FindIsland(Temp, i - 1, j - 1, ref area);
                        FindIsland(Temp, i + 1, j - 1, ref area);
                        FindIsland(Temp, i - 1, j + 1, ref area);
                    }
                    if (area>= maxArea)
                    {
                        maxArea = area;
                    }
                }
            }
            return maxArea;
        }

    }
}