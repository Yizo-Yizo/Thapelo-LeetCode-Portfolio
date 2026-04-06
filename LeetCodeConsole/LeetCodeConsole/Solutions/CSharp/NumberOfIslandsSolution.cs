public class NumberOfIslandsSolution
{
    public int NumIslands(char[][] grid) 
    {
        int islandCount = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    
                    SinkIsland(grid, i, j);
                    islandCount++;
                }
            }
        }

        return islandCount;
    }

    private void SinkIsland(char[][] grid, int i, int j)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == '0')
        {
            return;
        }

        grid[i][j] = '0'; // Mark the current cell as visited
        
        SinkIsland(grid, i + 1, j); // Go down
        SinkIsland(grid, i, j + 1); // Go right
        SinkIsland(grid, i - 1, j); // Go up
        SinkIsland(grid, i, j - 1); // Go left
    }

}
