/*
 * @lc app=leetcode id=36 lang=csharp
 *
 * [36] Valid Sudoku
 */

// @lc code=start
public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        if (!isSudoku(board, true))
        {
            return false;
        }

        if (!isSudoku(board, false))
        {
            return false;
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (!isAreaSudoku(board, 3, 3 * i, 3 * j))
                {
                    return false;
                }
            }
        }

        return true;
    }

    private bool isSudoku(char[][] board, bool isStand)
    {
        for (int i = 0; i < board.Length; i++)
        {
            char[] tempArr = new char[9];
            for (int j = 0; j < board[i].Length; j++)
            {
                char temp = isStand ? board[i][j] : board[j][i];
                if (temp != '.' && tempArr.Contains(temp))
                {
                    return false;
                }
                tempArr[j] = temp;
            }
        }
        return true;
    }

    private bool isAreaSudoku(char[][] board, int length, int x, int y)
    {
        char[] temp = new char[9];
        int count = 0;
        for (int i = x; i < x + length; i++)
        {
            for (int j = y; j < y + length; j++)
            {
                if (board[i][j] != '.' && temp.Contains(board[i][j]))
                {
                    return false;
                }
                temp[count++] = board[i][j];
            }
        }

        return true;
    }

}
