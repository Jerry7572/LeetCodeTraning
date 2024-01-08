/*
 * @lc app=leetcode id=63 lang=csharp
 *
 * [63] Unique Paths II
 */

// @lc code=start
public class Solution
{
// 0 0 0 0 0  1 1  1  1  1        8 7 6 5
// 0 0 0 0 0  1 2  3  4  5                4 3 2 1
// 0 0 0 0 0  1 3  6 10 15
// 0 0 0 0 0  1 4 10 20 35
// 0 0 0 0 0  1 5 15 35 70
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        int[][] obstacleGridTemp = obstacleGrid.Select(row => row.ToArray()).ToArray();
        bool haveOneFlag = false;

        for (int i = 0; i < obstacleGrid[0].Length; i++)
        {
            if (haveOneFlag)
            {
                obstacleGridTemp[0][i] = 0;
                continue;
            }
            if (obstacleGrid[0][i] == 1)
            {
                obstacleGridTemp[0][i] = 0;
                haveOneFlag = true;
                continue;

            }
            obstacleGridTemp[0][i] = 1;
        }
        haveOneFlag = false;

        for (int i = 0; i < obstacleGrid.Length; i++)
        {
            if (haveOneFlag)
            {
                obstacleGridTemp[i][0] = 0;
                continue;
            }
            if (obstacleGrid[i][0] == 1)
            {
                obstacleGridTemp[i][0] = 0;
                haveOneFlag = true;
                continue;

            }
            obstacleGridTemp[i][0] = 1;
        }
        haveOneFlag = false;
        if (obstacleGrid.Length == 1)
        {
            return obstacleGridTemp[obstacleGrid.Length - 1][obstacleGrid[0].Length - 1];

        }

        for (int i = 1; i < obstacleGrid.Length; i++)
        {
            for (int j = 1; j < obstacleGrid[i].Length; j++)
            {
                if (obstacleGrid[i][j] == 1)
                {
                    obstacleGridTemp[i][j] = 0;
                    continue;
                }
                obstacleGridTemp[i][j] = obstacleGridTemp[i - 1][j] + obstacleGridTemp[i][j - 1];

            }

        }
        return obstacleGridTemp[obstacleGrid.Length - 1][obstacleGrid[0].Length - 1];
    }


}
// @lc code=end

// 41/41 cases passed (58 ms)
// Your runtime beats 97.65 % of csharp submissions
// Your memory usage beats 6.74 % of csharp submissions (40.4 MB)