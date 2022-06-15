using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Solver
{
    internal class SudokuSolver 
    {
    private char[][] _sudokuBoard;
    private Dictionary<string, HashSet<char>> _possibleCellValues;
    private HashSet<char> _allowedSudokuValues;

    public SudokuSolver()
    {
        _allowedSudokuValues = new HashSet<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        //initBoard();
        //initMediumBoard();
        //initExtremeBoard();
        //initExtremeBoard1();
        //initExtremeBoard2();
        //initEvilBoard();
        //initEvil13June();
        initEvil15June();
        printSudokuBorad();
        FindPossibleCellValues();
        printPossibleValueDictionary();
    }

    private void initBoard()
    {
        _sudokuBoard = new char[9][];
        _sudokuBoard[0] = new char[9] { '5', '3', '.', '.', '7', '.', '.', '.', '.' };
        _sudokuBoard[1] = new char[9] { '6', '.', '.', '1', '9', '5', '.', '.', '.' };
        _sudokuBoard[2] = new char[9] { '.', '9', '8', '.', '.', '.', '.', '6', '.' };
        _sudokuBoard[3] = new char[9] { '8', '.', '.', '.', '6', '.', '.', '.', '3' };
        _sudokuBoard[4] = new char[9] { '4', '.', '.', '8', '.', '3', '.', '.', '1' };
        _sudokuBoard[5] = new char[9] { '7', '.', '.', '.', '2', '.', '.', '.', '6' };
        _sudokuBoard[6] = new char[9] { '.', '6', '.', '.', '.', '.', '2', '8', '.' };
        _sudokuBoard[7] = new char[9] { '.', '.', '.', '4', '1', '9', '.', '.', '5' };
        _sudokuBoard[8] = new char[9] { '.', '.', '.', '.', '8', '.', '.', '7', '9' };
    }

    private void initMediumBoard()
    {
        _sudokuBoard = new char[9][];
        _sudokuBoard[0] = new char[9] { '6', '.', '.', '3', '.', '.', '.', '5', '.' };
        _sudokuBoard[1] = new char[9] { '9', '.', '2', '5', '.', '.', '.', '.', '6' };
        _sudokuBoard[2] = new char[9] { '.', '5', '.', '.', '1', '.', '.', '9', '.' };
        _sudokuBoard[3] = new char[9] { '.', '.', '.', '.', '.', '.', '1', '2', '.' };
        _sudokuBoard[4] = new char[9] { '.', '.', '3', '6', '.', '9', '5', '.', '.' };
        _sudokuBoard[5] = new char[9] { '.', '9', '8', '.', '.', '.', '.', '.', '.' };
        _sudokuBoard[6] = new char[9] { '.', '3', '.', '.', '7', '.', '.', '6', '.' };
        _sudokuBoard[7] = new char[9] { '7', '.', '.', '.', '.', '2', '9', '.', '1' };
        _sudokuBoard[8] = new char[9] { '.', '1', '.', '.', '.', '8', '.', '.', '5' };
    }

    private void initExtremeBoard()
    {
        _sudokuBoard = new char[9][];
        _sudokuBoard[0] = new char[9] { '.', '.', '.', '7', '.', '8', '.', '.', '5' };
        _sudokuBoard[1] = new char[9] { '.', '.', '.', '.', '4', '.', '2', '1', '.' };
        _sudokuBoard[2] = new char[9] { '.', '.', '.', '.', '.', '6', '3', '.', '.' };
        _sudokuBoard[3] = new char[9] { '.', '9', '.', '.', '8', '.', '5', '.', '7' };
        _sudokuBoard[4] = new char[9] { '.', '.', '.', '5', '.', '7', '.', '.', '.' };
        _sudokuBoard[5] = new char[9] { '6', '.', '5', '.', '2', '.', '.', '4', '.' };
        _sudokuBoard[6] = new char[9] { '.', '.', '3', '6', '.', '.', '.', '.', '.' };
        _sudokuBoard[7] = new char[9] { '.', '2', '4', '.', '3', '.', '.', '.', '.' };
        _sudokuBoard[8] = new char[9] { '8', '.', '.', '1', '.', '4', '.', '.', '.' };
    }

    private void initExtremeBoard1()
    {
        _sudokuBoard = new char[9][];
        _sudokuBoard[0] = new char[9] { '5', '6', '.', '.', '.', '.', '.', '3', '.' };
        _sudokuBoard[1] = new char[9] { '.', '.', '.', '8', '3', '.', '1', '.', '.' };
        _sudokuBoard[2] = new char[9] { '3', '.', '.', '.', '.', '7', '8', '9', '.' };
        _sudokuBoard[3] = new char[9] { '6', '.', '2', '.', '.', '8', '.', '.', '.' };
        _sudokuBoard[4] = new char[9] { '.', '9', '.', '.', '.', '.', '.', '6', '.' };
        _sudokuBoard[5] = new char[9] { '.', '.', '.', '7', '.', '.', '9', '.', '1' };
        _sudokuBoard[6] = new char[9] { '.', '3', '5', '4', '.', '.', '.', '.', '9' };
        _sudokuBoard[7] = new char[9] { '.', '.', '4', '.', '7', '2', '.', '.', '.' };
        _sudokuBoard[8] = new char[9] { '.', '7', '.', '.', '.', '.', '.', '1', '3' };
    }

    private void initExtremeBoard2()
    {
        _sudokuBoard = new char[9][];
        _sudokuBoard[0] = new char[9] { '5', '.', '.', '4', '.', '.', '.', '.', '.' };
        _sudokuBoard[1] = new char[9] { '.', '.', '.', '.', '.', '9', '.', '1', '2' };
        _sudokuBoard[2] = new char[9] { '9', '8', '6', '1', '.', '.', '.', '.', '.' };
        _sudokuBoard[3] = new char[9] { '.', '.', '.', '.', '2', '6', '1', '.', '.' };
        _sudokuBoard[4] = new char[9] { '.', '.', '9', '.', '.', '.', '7', '.', '.' };
        _sudokuBoard[5] = new char[9] { '.', '.', '8', '3', '7', '.', '.', '.', '.' };
        _sudokuBoard[6] = new char[9] { '.', '.', '.', '.', '.', '4', '2', '8', '3' };
        _sudokuBoard[7] = new char[9] { '1', '4', '.', '2', '.', '.', '.', '.', '.' };
        _sudokuBoard[8] = new char[9] { '.', '.', '.', '.', '.', '5', '.', '.', '1' };
    }

    private void initEvilBoard()
    {
        _sudokuBoard = new char[9][];
        _sudokuBoard[0] = new char[9] { '.', '.', '1', '.', '.', '7', '.', '.', '9' };
        _sudokuBoard[1] = new char[9] { '.', '3', '.', '.', '5', '.', '.', '7', '.' };
        _sudokuBoard[2] = new char[9] { '4', '.', '.', '2', '.', '.', '5', '.', '.' };
        _sudokuBoard[3] = new char[9] { '3', '.', '.', '4', '.', '.', '7', '.', '.' };
        _sudokuBoard[4] = new char[9] { '.', '2', '.', '.', '9', '.', '.', '4', '.' };
        _sudokuBoard[5] = new char[9] { '.', '.', '8', '.', '.', '1', '.', '.', '3' };
        _sudokuBoard[6] = new char[9] { '.', '.', '4', '.', '.', '2', '.', '.', '5' };
        _sudokuBoard[7] = new char[9] { '.', '7', '.', '.', '8', '.', '.', '2', '.' };
        _sudokuBoard[8] = new char[9] { '5', '.', '.', '1', '.', '.', '9', '.', '.' };
    }

    private void initEvil13June()
    {
        _sudokuBoard = new char[9][];
        _sudokuBoard[0] = new char[9] { '.', '.', '4', '.', '9', '.', '1', '.', '.' };
        _sudokuBoard[1] = new char[9] { '.', '1', '.', '6', '.', '7', '.', '9', '.' };
        _sudokuBoard[2] = new char[9] { '6', '.', '.', '.', '1', '.', '.', '.', '5' };
        _sudokuBoard[3] = new char[9] { '.', '6', '.', '.', '.', '.', '.', '1', '.' };
        _sudokuBoard[4] = new char[9] { '9', '.', '3', '.', '.', '.', '2', '.', '7' };
        _sudokuBoard[5] = new char[9] { '.', '4', '.', '.', '.', '.', '.', '3', '.' };
        _sudokuBoard[6] = new char[9] { '5', '.', '.', '.', '3', '.', '.', '.', '1' };
        _sudokuBoard[7] = new char[9] { '.', '8', '.', '9', '.', '1', '.', '6', '.' };
        _sudokuBoard[8] = new char[9] { '.', '.', '9', '.', '7', '.', '4', '.', '.' };
    }

    private void initEvil15June()
    {
        _sudokuBoard = new char[9][];
        _sudokuBoard[0] = new char[9] { '5', '.', '.', '.', '.', '.', '.', '.', '1' };
        _sudokuBoard[1] = new char[9] { '.', '.', '8', '.', '1', '.', '5', '.', '.' };
        _sudokuBoard[2] = new char[9] { '.', '6', '4', '.', '3', '.', '2', '7', '.' };
        _sudokuBoard[3] = new char[9] { '.', '.', '.', '1', '.', '3', '.', '.', '.' };
        _sudokuBoard[4] = new char[9] { '.', '8', '9', '.', '.', '.', '1', '4', '.' };
        _sudokuBoard[5] = new char[9] { '.', '.', '.', '2', '.', '4', '.', '.', '.' };
        _sudokuBoard[6] = new char[9] { '.', '4', '5', '.', '7', '.', '8', '3', '.' };
        _sudokuBoard[7] = new char[9] { '.', '.', '3', '.', '5', '.', '9', '.', '.' };
        _sudokuBoard[8] = new char[9] { '9', '.', '.', '.', '.', '.', '.', '.', '5' };
    }

    public char[][] getSudokuBoard()
    {
        return _sudokuBoard;
    }

    public void printSudokuBorad()
    {
        if (_sudokuBoard != null)
        {
            Console.Write("||-----||-----||-----||");
            Console.WriteLine();

            for (int i = 0; i < _sudokuBoard.Length; i++)
            {
                Console.Write("|");
                for (int j = 0; j < _sudokuBoard[i].Length; j++)
                {
                    if (_sudokuBoard[i][j] != '.')
                        Console.Write("|" + _sudokuBoard[i][j]);
                    else
                        Console.Write("| ");

                    if (j == 2 || j == 5 || j == 8)
                    {
                        Console.Write("|");
                    }
                }

                Console.Write("|");
                Console.WriteLine();

                if (i == 2 || i == 5 || i == 8)
                {
                    Console.Write("||-----||-----||-----||");
                    Console.WriteLine();
                }

            }
        }
    }

    private HashSet<char> scanForPossibleCellValues(HashSet<char> _boardRow, HashSet<char> _boardColumn, HashSet<char> _boardMatrix)
    {
        HashSet<char> tempSet = new HashSet<char>();
        tempSet.UnionWith(this._allowedSudokuValues);
        tempSet.ExceptWith(_boardMatrix);
        tempSet.ExceptWith(_boardColumn);
        tempSet.ExceptWith(_boardRow);

        return tempSet;
    }

    private void FindPossibleCellValues()
    {
        _possibleCellValues = new Dictionary<string, HashSet<char>>();

        for (int row = 0; row < _sudokuBoard.Length; row++)
        {
            for (int col = 0; col < _sudokuBoard[row].Length; col++)
            {
                if (_sudokuBoard[row][col] == '.')
                {
                    _possibleCellValues.Add("" + row + ";" + col + "", scanForValues(row, col));
                }
            }
        }
    }

    private void printPossibleValueDictionary()
    {
        foreach (KeyValuePair<string, HashSet<char>> kvp in _possibleCellValues)
        {
            Console.Write(kvp.Key + " : ");
            Console.Write(string.Join(",", kvp.Value));
            Console.WriteLine();
        }
    }

    private HashSet<char> scanForValues(int rowIndex, int colIndex)
    {
        HashSet<char> tempSet = new HashSet<char>();
        HashSet<char> rowSet = new HashSet<char>();
        HashSet<char> colSet = new HashSet<char>();
        HashSet<char> matrixSet = new HashSet<char>();

        for (int col = 0; col < _sudokuBoard.Length; col++)
        {
            if (_sudokuBoard[rowIndex][col] != '.')
            {
                rowSet.Add(_sudokuBoard[rowIndex][col]);
            }
        }

        for (int row = 0; row < _sudokuBoard.Length; row++)
        {
            if (_sudokuBoard[row][colIndex] != '.')
            {
                colSet.Add(_sudokuBoard[row][colIndex]);
            }
        }

        int matrixStartRow = rowIndex - (rowIndex % 3);
        int matrixStartCol = colIndex - (colIndex % 3);

        for (int row = matrixStartRow; row < (matrixStartRow + 3); row++)
        {
            for (int col = matrixStartCol; col < (matrixStartCol + 3); col++)
            {
                if (_sudokuBoard[row][col] != '.')
                {
                    matrixSet.Add(_sudokuBoard[row][col]);
                }
            }
        }

        tempSet = scanForPossibleCellValues(rowSet, colSet, matrixSet);

        return tempSet;
    }

    // Print methods
    public void PrintResults()
    {
        printSudokuBorad();
        printPossibleValueDictionary();
    }

    // ** Solve Sudoku **
    public void SolveSudoku(char[][] board)
    {
        FillSinglePossibleValues();
        PrintResults();
    }

    // ** Fill single possible Values
    public void FillSinglePossibleValues()
    {
        Dictionary<string, HashSet<char>> singleValueList = _possibleCellValues.Where(x => x.Value.Count == 1).ToDictionary(x => x.Key, x => x.Value);

        while (singleValueList.Count > 0)
        {
            foreach (KeyValuePair<string, HashSet<char>> kvp in singleValueList)
            {
                if (kvp.Value.Count == 1)
                {
                    FilltheCellValue(kvp.Key, kvp.Value.ElementAt(0));
                }
            }

            singleValueList = _possibleCellValues.Where(x => x.Value.Count == 1).ToDictionary(x => x.Key, x => x.Value);
        }
    }

    public void FilltheCellValue(string key, char value)
    {
        string[] keySplits = key.Split(';');
        int rowIndex = Convert.ToInt16(keySplits[0]);
        int colIndex = Convert.ToInt16(keySplits[1]);

        _sudokuBoard[rowIndex][colIndex] = value;
        //Console.WriteLine(rowIndex + ":" + colIndex + " = " + value);

        //remove value from cell list
        _possibleCellValues[key].Remove(value);

        //remove value from row list
        for (int i = 0; i < 9; i++)
        {
            if (i != colIndex)
            {
                string rowListKey = rowIndex + ";" + i;
                if (_possibleCellValues.ContainsKey(rowListKey))
                {
                    //Console.WriteLine(rowListKey + " = " + value);
                    _possibleCellValues[rowListKey].Remove(value);
                }
            }
        }

        //remove value from col list
        for (int i = 0; i < 9; i++)
        {
            if (i != rowIndex)
            {
                string colListKey = i + ";" + colIndex;
                if (_possibleCellValues.ContainsKey(colListKey))
                {
                    //Console.WriteLine(colListKey + " = " + value);
                    _possibleCellValues[colListKey].Remove(value);
                }
            }
        }

        //remove value from matrix list
        int matrixStartRow = rowIndex - (rowIndex % 3);
        int matrixStartCol = colIndex - (colIndex % 3);

        for (int row = matrixStartRow; row < (matrixStartRow + 3); row++)
        {
            if (row != rowIndex)
            {
                for (int col = matrixStartCol; col < (matrixStartCol + 3); col++)
                {
                    if (col != colIndex)
                    {
                        string matrixListKey = row + ";" + col;
                        if (_possibleCellValues.ContainsKey(matrixListKey))
                        {
                            //Console.WriteLine(matrixListKey + " = " + value);
                            _possibleCellValues[matrixListKey].Remove(value);
                        }
                    }
                }
            }
        }

    }

    // ** count single occurence element
    // ** row scan, col scan, matrix scan


}
}
