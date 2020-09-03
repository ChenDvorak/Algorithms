/*
 *  word search
 *  given a 2D board and a word, find if the word exists in the grid.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.LeetCode
{
    public class WordSearch
    {
        private bool[,] _flags;
        private char[][] _board;
        private string _word;
        private int _row, _column;
        public bool Run(char[][] board, string word)
        {
            if (board.Length == 0)
                return false;

            _flags = new bool[board.Length, board[0].Length];
            _board = board;
            _word = word;
            _row = _board.Length;
            _column = _board[0].Length;

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (Dfs(0, i, j))
                        return true;
                }
            }
            return false;
        }

        private bool Dfs(int wordIndex, int i, int j)
        {
            if (wordIndex >= _word.Length)
                return true;
            
            if (_word[wordIndex] != _board[i][j] || _flags[i, j])
                return false;
            
            _flags[i, j] = true;

            int nextIndex = wordIndex + 1;
            if (i > 0)
                if (Dfs(nextIndex, i - 1, j))
                    return true;
            if (j < _column - 1)
                if (Dfs(nextIndex, i, j + 1))
                    return true;
            if (i < _row - 1)
                if (Dfs(nextIndex, i + 1, j))
                    return true;
            if (j > 0)
                if (Dfs(nextIndex, i, j - 1))
                    return true;

            _flags[i, j] = false;
            return false;
        }
    }
}
