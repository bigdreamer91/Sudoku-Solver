using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Solver
{
    internal class ReusableCode
    {
        private HashSet<char> _allowedSudokuValues = new HashSet<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public enum ErrorCode
        {
            ExitIteration = 1,
            HasConflict = 2,
            PossibleValuesEmpty = 3,
            IsNotEmptyCell = 4,
            NoError = 5
        }

        public void printSudokuBorad(char [][] _sudokuBoard)
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

        public void FindPossibleCellValues(char[][] _sudokuBoard, Dictionary<string, HashSet<char>> _possibleCellValues)
        {
            for (int row = 0; row < _sudokuBoard.Length; row++)
            {
                for (int col = 0; col < _sudokuBoard[row].Length; col++)
                {
                    if (_sudokuBoard[row][col] == '.')
                    {
                        _possibleCellValues.Add("" + row + ";" + col + "", scanForValues(row, col, _sudokuBoard));
                    }
                }
            }
        }

        public HashSet<char> scanForValues(int rowIndex, int colIndex, char[][] _sudokuBoard)
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

        public HashSet<char> scanForPossibleCellValues(HashSet<char> _boardRow, HashSet<char> _boardColumn, HashSet<char> _boardMatrix)
        {
            HashSet<char> tempSet = new HashSet<char>();
            tempSet.UnionWith(this._allowedSudokuValues);
            tempSet.ExceptWith(_boardMatrix);
            tempSet.ExceptWith(_boardColumn);
            tempSet.ExceptWith(_boardRow);

            return tempSet;
        }

        public void printPossibleValueDictionary(Dictionary<string, HashSet<char>> _possibleCellValues)
        {
            foreach (KeyValuePair<string, HashSet<char>> kvp in _possibleCellValues)
            {
                Console.Write(kvp.Key + " : ");
                Console.Write(string.Join(",", kvp.Value));
                Console.WriteLine();
            }
        }

        public ErrorCode FillSinglePossibleValues(char[][] _sudokuBoard, Dictionary<string, HashSet<char>> _possibleCellValues)
        {
            Dictionary<string, HashSet<char>> singleValueList = _possibleCellValues.Where(x => x.Value.Count == 1).ToDictionary(x => x.Key, x => x.Value);

            while (singleValueList.Count > 0)
            {
                foreach (KeyValuePair<string, HashSet<char>> kvp in singleValueList)
                {
                    if (kvp.Value.Count == 1)
                    {
                        ErrorCode err = FilltheCellValue(kvp.Key, kvp.Value.ElementAt(0), _sudokuBoard, _possibleCellValues);
                        if(err != ErrorCode.NoError)
                        {
                            return err;
                        }
                    }
                }

                singleValueList = _possibleCellValues.Where(x => x.Value.Count == 1).ToDictionary(x => x.Key, x => x.Value);
            }

            return ErrorCode.NoError;
        }

        public bool isPossibleValuesEmpty(Dictionary<string, HashSet<char>> _possibleCellValues)
        {
            Dictionary<string, HashSet<char>> possibleValueList = _possibleCellValues.Where(x => x.Value.Count > 0).ToDictionary(x => x.Key, x => x.Value);
            if (possibleValueList.Count == 0)
            {
                return true;
            }

            return false;
        }

        public bool hasConflict(int rowIndex, int colIndex, char value, char[][] _sudokuBoard)
        {
            // row scan
            for (int i = 0; i < 9; i++)
            {
                if (i != colIndex)
                {
                    if (_sudokuBoard[rowIndex][i] == value)
                    {
                        return true;
                    }
                }
            }

            //remove value from col list
            for (int i = 0; i < 9; i++)
            {
                if (i != rowIndex)
                {
                    if (_sudokuBoard[i][colIndex] == value)
                    {
                        return true;
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
                            if (_sudokuBoard[row][col] == value)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        public ErrorCode FilltheCellValue(string key, char value, char[][] _sudokuBoard, Dictionary<string, HashSet<char>> _possibleCellValues)
        {
            if (isPossibleValuesEmpty(_possibleCellValues))
            {
                return ErrorCode.PossibleValuesEmpty;
            }

            string[] keySplits = key.Split(';');
            int rowIndex = Convert.ToInt16(keySplits[0]);
            int colIndex = Convert.ToInt16(keySplits[1]);

            if (_sudokuBoard[rowIndex][colIndex] != '.')
            {
                //return ErrorCode.IsNotEmptyCell;
                return ErrorCode.NoError;
            }

            if (hasConflict(rowIndex, colIndex, value, _sudokuBoard))
            {
                //return ErrorCode.HasConflict;
                return ErrorCode.NoError;
            }

            Console.WriteLine();
            Console.WriteLine("################### Fill the cell value - key : " + key + " --- value : " + value + " --- ################");
            Console.WriteLine();

            _sudokuBoard[rowIndex][colIndex] = value;
            //Console.WriteLine(rowIndex + ":" + colIndex + " = " + value);

            //remove value from cell list
            //_possibleCellValues[key].Remove(value);
            _possibleCellValues[key].Clear();

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

            ErrorCode err = runFilledCellScan(key, _sudokuBoard, _possibleCellValues);
            return err;
        }

        public void PrintResults(char[][] _sudokuBoard, Dictionary<string, HashSet<char>> _possibleCellValues)
        {
            printSudokuBorad(_sudokuBoard);
            printPossibleValueDictionary(_possibleCellValues);
        }

        public ErrorCode exitWithError(string errorMsg, char[][] _sudokuBoard, Dictionary<string, HashSet<char>> _possibleCellValues)
        {
            Console.WriteLine(errorMsg);
            PrintResults(_sudokuBoard, _possibleCellValues);
            //System.Environment.Exit(0);
            return ErrorCode.ExitIteration;
        }

        public ErrorCode errorPossibleCellValue(string cellIndex, char[][] _sudokuBoard, Dictionary<string, HashSet<char>> _possibleCellValues)
        {
            string[] keySplits = cellIndex.Split(';');
            int rowIndex = Convert.ToInt16(keySplits[0]);
            int colIndex = Convert.ToInt16(keySplits[1]);

            HashSet<Char> singleCellValue = new HashSet<Char>();

            Console.WriteLine("Row Scan");
            for (int i = 0; i < 9; i++)
            {

                if (i != colIndex)
                {
                    string rowScanKey = rowIndex + ";" + i;
                    if (_possibleCellValues.ContainsKey(rowScanKey))
                    {
                        if (_possibleCellValues[rowScanKey].Count == 0 && _sudokuBoard[rowIndex][colIndex] == '.')
                        {
                            return exitWithError("Empty possible value on empty cell ----- Error", _sudokuBoard, _possibleCellValues);
                        }

                        if (_possibleCellValues[rowScanKey].Count == 1)
                        {
                            if (singleCellValue.Contains(_possibleCellValues[rowScanKey].ElementAt(0)))
                            {
                                return exitWithError("Single Possible value already exists ----- Error", _sudokuBoard, _possibleCellValues);
                            }
                            else
                            {
                                singleCellValue.Add(_possibleCellValues[rowScanKey].ElementAt(0));
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Col Scan");
            singleCellValue = new HashSet<Char>();
            for (int i = 0; i < 9; i++)
            {
                if (i != rowIndex)
                {
                    string colScanKey = i + ";" + colIndex;
                    if (_possibleCellValues.ContainsKey(colScanKey))
                    {
                        if (_possibleCellValues[colScanKey].Count == 0 && _sudokuBoard[rowIndex][colIndex] == '.')
                        {
                            return exitWithError("Empty possible value on empty cell ----- Error", _sudokuBoard, _possibleCellValues);
                        }

                        if (_possibleCellValues[colScanKey].Count == 1)
                        {
                            if (singleCellValue.Contains(_possibleCellValues[colScanKey].ElementAt(0)))
                            {
                                return exitWithError("Single Possible value already exists ----- Error", _sudokuBoard, _possibleCellValues);
                            }
                            else
                            {
                                singleCellValue.Add(_possibleCellValues[colScanKey].ElementAt(0));
                            }
                        }

                    }
                }
            }

            Console.WriteLine("Matrix Scan");
            singleCellValue = new HashSet<Char>();
            int matrixStartRow = rowIndex - (rowIndex % 3);
            int matrixStartCol = colIndex - (colIndex % 3);

            for (int row = matrixStartRow; row < (matrixStartRow + 3); row++)
            {
                for (int col = matrixStartCol; col < (matrixStartCol + 3); col++)
                {
                    string matrixScanKey = row + ";" + col;
                    if (matrixScanKey != cellIndex)
                    {

                        if (_possibleCellValues.ContainsKey(matrixScanKey))
                        {
                            if (_possibleCellValues[matrixScanKey].Count == 0 && _sudokuBoard[rowIndex][colIndex] == '.')
                            {
                                return exitWithError("Empty possible value on empty cell ----- Error", _sudokuBoard, _possibleCellValues);
                            }

                            if (_possibleCellValues[matrixScanKey].Count == 1)
                            {
                                if (singleCellValue.Contains(_possibleCellValues[matrixScanKey].ElementAt(0)))
                                {
                                    return exitWithError("Single Possible value already exists ----- Error", _sudokuBoard, _possibleCellValues);
                                }
                                else
                                {
                                    singleCellValue.Add(_possibleCellValues[matrixScanKey].ElementAt(0));
                                }
                            }
                        }
                    }
                }
            }

            return ErrorCode.NoError;
        }

        public ErrorCode runFilledCellScan(string cellIndex, char[][] _sudokuBoard, Dictionary<string, HashSet<char>> _possibleCellValues)
        {
            if (isPossibleValuesEmpty(_possibleCellValues))
            {
                return ErrorCode.PossibleValuesEmpty;
            }

            ErrorCode err = errorPossibleCellValue(cellIndex, _sudokuBoard, _possibleCellValues);

            if (err != ErrorCode.NoError)
            {
                return err;
            }
            //errorPossibleCellValue(cellIndex, _sudokuBoard, _possibleCellValues);

            Console.WriteLine();
            Console.WriteLine("################ Run Filled Scan : -- " + cellIndex + " -- ##############################");
            Console.WriteLine();

            string[] keySplits = cellIndex.Split(';');
            int rowIndex = Convert.ToInt16(keySplits[0]);
            int colIndex = Convert.ToInt16(keySplits[1]);

            Dictionary<char, int> cellValueCount = new Dictionary<char, int>();
            Dictionary<char, string> valueFirstLocation = new Dictionary<char, string>();

            // Row scan
            Console.WriteLine("Row scan");
            for (int i = 0; i < 9; i++)
            {

                if (i != colIndex)
                {
                    string rowScanKey = rowIndex + ";" + i;
                    if (_possibleCellValues.ContainsKey(rowScanKey))
                    {
                        if (_possibleCellValues[rowScanKey].Count == 1)
                        {
                            Console.WriteLine("Single Value : " + _possibleCellValues[rowScanKey].ElementAt(0) + " -- cellIndex : " + rowScanKey);
                            err = FilltheCellValue(rowScanKey, _possibleCellValues[rowScanKey].ElementAt(0), _sudokuBoard, _possibleCellValues);
                            if (err != ErrorCode.NoError)
                            {
                                return err;
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            foreach (char cellValue in _possibleCellValues[rowScanKey])
                            {
                                if (!cellValueCount.ContainsKey(cellValue))
                                {
                                    cellValueCount.Add(cellValue, 1);
                                    valueFirstLocation.Add(cellValue, rowScanKey);
                                }
                                else
                                {
                                    cellValueCount[cellValue]++;
                                }
                            }
                        }
                    }
                }
            }

            Console.Write("Row - " + rowIndex + " : ");
            foreach (KeyValuePair<char, int> cellValue in cellValueCount)
            {
                //Console.WriteLine(cellValue.Key + " : " + cellValue.Value);
                if (cellValue.Value == 1)
                {
                    Console.Write(cellValue.Key + " : " + cellValue.Value);
                    if (valueFirstLocation.ContainsKey(cellValue.Key))
                    {
                        Console.Write(" : Row-location : " + valueFirstLocation[cellValue.Key] + " ");
                        err = FilltheCellValue(valueFirstLocation[cellValue.Key], cellValue.Key, _sudokuBoard, _possibleCellValues);
                        if (err != ErrorCode.NoError)
                        {
                            return err;
                        }
                    }
                }
            }
            Console.WriteLine();

            // col scan
            Console.WriteLine("Col scan");
            cellValueCount = new Dictionary<char, int>();
            valueFirstLocation = new Dictionary<char, string>();

            for (int i = 0; i < 9; i++)
            {
                if (i != rowIndex)
                {
                    string colScanKey = i + ";" + colIndex;
                    if (_possibleCellValues.ContainsKey(colScanKey))
                    {
                        if (_possibleCellValues[colScanKey].Count == 1)
                        {
                            Console.WriteLine("Single Value : " + _possibleCellValues[colScanKey].ElementAt(0) + " -- cellIndex : " + colScanKey);
                            err = FilltheCellValue(colScanKey, _possibleCellValues[colScanKey].ElementAt(0), _sudokuBoard, _possibleCellValues);
                            if (err != ErrorCode.NoError)
                            {
                                return err;
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            foreach (char cellValue in _possibleCellValues[colScanKey])
                            {
                                if (!cellValueCount.ContainsKey(cellValue))
                                {
                                    cellValueCount.Add(cellValue, 1);
                                    valueFirstLocation.Add(cellValue, colScanKey);
                                }
                                else
                                {
                                    cellValueCount[cellValue]++;
                                }
                            }
                        }

                    }
                }
            }

            Console.Write("Col - " + colIndex + " : ");
            foreach (KeyValuePair<char, int> cellValue in cellValueCount)
            {
                //Console.WriteLine(cellValue.Key + " : " + cellValue.Value);
                if (cellValue.Value == 1)
                {
                    Console.Write(cellValue.Key + " : " + cellValue.Value);
                    if (valueFirstLocation.ContainsKey(cellValue.Key))
                    {
                        Console.Write(" : col-location : " + valueFirstLocation[cellValue.Key] + " ");
                        err = FilltheCellValue(valueFirstLocation[cellValue.Key], cellValue.Key, _sudokuBoard, _possibleCellValues);
                        if (err != ErrorCode.NoError)
                        {
                            return err;
                        }
                    }
                }
            }
            Console.WriteLine();

            // Matrix scan
            Console.WriteLine("Matrix scan");
            cellValueCount = new Dictionary<char, int>();
            valueFirstLocation = new Dictionary<char, string>();
            int matrixStartRow = rowIndex - (rowIndex % 3);
            int matrixStartCol = colIndex - (colIndex % 3);

            for (int row = matrixStartRow; row < (matrixStartRow + 3); row++)
            {
                for (int col = matrixStartCol; col < (matrixStartCol + 3); col++)
                {
                    string matrixScanKey = row + ";" + col;
                    if (matrixScanKey != cellIndex)
                    {

                        if (_possibleCellValues.ContainsKey(matrixScanKey))
                        {
                            if (_possibleCellValues[matrixScanKey].Count == 1)
                            {
                                Console.WriteLine("Single Value : " + _possibleCellValues[matrixScanKey].ElementAt(0) + " -- cellIndex : " + matrixScanKey);
                                err = FilltheCellValue(matrixScanKey, _possibleCellValues[matrixScanKey].ElementAt(0), _sudokuBoard, _possibleCellValues);
                                if (err != ErrorCode.NoError)
                                {
                                    return err;
                                }
                                Console.WriteLine();
                            }
                            else
                            {
                                foreach (char cellValue in _possibleCellValues[matrixScanKey])
                                {
                                    if (!cellValueCount.ContainsKey(cellValue))
                                    {
                                        cellValueCount.Add(cellValue, 1);
                                        valueFirstLocation.Add(cellValue, matrixScanKey);
                                    }
                                    else
                                    {
                                        cellValueCount[cellValue]++;
                                    }
                                }
                            }

                        }
                    }
                }
            }

            Console.Write("Matrix - " + rowIndex + ";" + colIndex + " : ");
            foreach (KeyValuePair<char, int> cellValue in cellValueCount)
            {
                //Console.WriteLine(cellValue.Key + " : " + cellValue.Value);
                if (cellValue.Value == 1)
                {
                    Console.Write(cellValue.Key + " : " + cellValue.Value);
                    if (valueFirstLocation.ContainsKey(cellValue.Key))
                    {
                        Console.Write(" : matrix-cell-location : " + valueFirstLocation[cellValue.Key] + " ");
                        err = FilltheCellValue(valueFirstLocation[cellValue.Key], cellValue.Key, _sudokuBoard, _possibleCellValues);
                        if (err != ErrorCode.NoError)
                        {
                            return err;
                        }
                    }
                }
            }
            Console.WriteLine();

            return ErrorCode.NoError;
        }

        public ErrorCode fillSingleCountOccurence(char[][] _sudokuBoard, Dictionary<string, HashSet<char>> _possibleCellValues)
        {
            if (isPossibleValuesEmpty(_possibleCellValues))
            {
                return ErrorCode.PossibleValuesEmpty;
            }

            // Row scan for single count occurence
            Console.WriteLine("Row scan");
            for (int row = 0; row < 9; row++)
            {
                Dictionary<char, int> cellValueCount = new Dictionary<char, int>();
                Dictionary<char, string> valueFirstLocation = new Dictionary<char, string>();

                for (int col = 0; col < 9; col++)
                {
                    string rowScanKey = row + ";" + col;
                    if (_possibleCellValues.ContainsKey(rowScanKey))
                    {
                        foreach (char cellValue in _possibleCellValues[rowScanKey])
                        {
                            if (!cellValueCount.ContainsKey(cellValue))
                            {
                                cellValueCount.Add(cellValue, 1);
                                valueFirstLocation.Add(cellValue, rowScanKey);
                            }
                            else
                            {
                                cellValueCount[cellValue]++;
                            }
                        }
                    }
                }

                Console.Write("Row - " + row + " : ");
                foreach (KeyValuePair<char, int> cellValue in cellValueCount)
                {
                    //Console.WriteLine(cellValue.Key + " : " + cellValue.Value);
                    if (cellValue.Value == 1)
                    {
                        Console.Write(cellValue.Key + " : " + cellValue.Value);
                        if (valueFirstLocation.ContainsKey(cellValue.Key))
                        {
                            Console.Write(" : Row-location : " + valueFirstLocation[cellValue.Key] + " ");
                             ErrorCode err = FilltheCellValue(valueFirstLocation[cellValue.Key], cellValue.Key, _sudokuBoard, _possibleCellValues);
                            if (err != ErrorCode.NoError)
                            {
                                return err;
                            }
                        }
                    }
                }
                Console.WriteLine();
            }

            // Col scan
            Console.WriteLine("Col scan");
            for (int col = 0; col < 9; col++)
            {
                Dictionary<char, int> cellValueCount = new Dictionary<char, int>();
                Dictionary<char, string> valueFirstLocation = new Dictionary<char, string>();

                for (int row = 0; row < 9; row++)
                {
                    string colScanKey = row + ";" + col;
                    if (_possibleCellValues.ContainsKey(colScanKey))
                    {
                        foreach (char cellValue in _possibleCellValues[colScanKey])
                        {
                            if (!cellValueCount.ContainsKey(cellValue))
                            {
                                cellValueCount.Add(cellValue, 1);
                                valueFirstLocation.Add(cellValue, colScanKey);
                            }
                            else
                            {
                                cellValueCount[cellValue]++;
                            }
                        }
                    }
                }

                Console.Write("Col - " + col + " : ");
                foreach (KeyValuePair<char, int> cellValue in cellValueCount)
                {
                    //Console.WriteLine(cellValue.Key + " : " + cellValue.Value);
                    if (cellValue.Value == 1)
                    {
                        Console.Write(cellValue.Key + " : " + cellValue.Value);
                        if (valueFirstLocation.ContainsKey(cellValue.Key))
                        {
                            Console.Write(" : col-location : " + valueFirstLocation[cellValue.Key] + " ");
                            ErrorCode err = FilltheCellValue(valueFirstLocation[cellValue.Key], cellValue.Key, _sudokuBoard, _possibleCellValues);
                            if (err != ErrorCode.NoError)
                            {
                                return err;
                            }
                        }
                    }
                }
                Console.WriteLine();
            }

            //Matrix Scan
            Console.WriteLine("Matrix scan");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Dictionary<char, int> cellValueCount = new Dictionary<char, int>();
                    Dictionary<char, string> valueFirstLocation = new Dictionary<char, string>();

                    int startrow = 3 * (i % 3);
                    int startcol = 3 * (j % 3);

                    for (int row = startrow; row < (startrow + 3); row++)
                    {
                        for (int col = startcol; col < (startcol + 3); col++)
                        {
                            string matrixScanKey = row + ";" + col;
                            if (_possibleCellValues.ContainsKey(matrixScanKey))
                            {
                                foreach (char cellValue in _possibleCellValues[matrixScanKey])
                                {
                                    if (!cellValueCount.ContainsKey(cellValue))
                                    {
                                        cellValueCount.Add(cellValue, 1);
                                        valueFirstLocation.Add(cellValue, matrixScanKey);
                                    }
                                    else
                                    {
                                        cellValueCount[cellValue]++;
                                    }
                                }
                            }
                        }
                    }

                    Console.Write("Matrix - " + startrow + ";" + startcol + " : ");
                    foreach (KeyValuePair<char, int> cellValue in cellValueCount)
                    {
                        //Console.WriteLine(cellValue.Key + " : " + cellValue.Value);
                        if (cellValue.Value == 1)
                        {
                            Console.Write(cellValue.Key + " : " + cellValue.Value);
                            if (valueFirstLocation.ContainsKey(cellValue.Key))
                            {
                                Console.Write(" : matrix-cell-location : " + valueFirstLocation[cellValue.Key] + " ");
                                ErrorCode err = FilltheCellValue(valueFirstLocation[cellValue.Key], cellValue.Key, _sudokuBoard, _possibleCellValues);
                                if (err != ErrorCode.NoError)
                                {
                                    return err;
                                }
                            }
                        }
                    }
                    Console.WriteLine();

                }
            }

            return ErrorCode.NoError;

        }

        public HashSet<string> findVariationValueStrings(Dictionary<string, HashSet<char>> _possibleCellValues)
        {
            HashSet<string> variationStrings = new HashSet<string>();
            KeyValuePair<string, HashSet<char>> singleValueList = _possibleCellValues.Where(x => x.Value.Count == 2).ToDictionary(x => x.Key, x => x.Value).FirstOrDefault();
            if (singleValueList.Key != null && singleValueList.Value != null)
            {
                foreach (char value in singleValueList.Value)
                {
                    string variationValue = singleValueList.Key + "_" + value + "#";
                    variationStrings.Add(variationValue);
                }
            }

            return variationStrings;
        }

        public ErrorCode duplicateFillTrialValues(char[][] _sudokuBoard, Dictionary<string, HashSet<char>> _possibleCellValues)
        {
            //Dictionary<string, string> variationValues = new Dictionary<string, string>();
            HashSet<string> variationValues = new HashSet<string>();

            //KeyValuePair<string, HashSet<char>> singleValueList = _possibleCellValues.Where(x => x.Value.Count == 2).ToDictionary(x => x.Key, x => x.Value).FirstOrDefault();

            //if (singleValueList.Key != null && singleValueList.Value != null)
            //{
            //    foreach (char value in singleValueList.Value)
            //    {
            //        string variationValue = singleValueList.Key + "_" + value + "#";
            //        variationValues.Add(variationValue);
            //    }
            //}

            HashSet<string> variationStrings = findVariationValueStrings(_possibleCellValues);
            foreach(string variationStr in variationStrings)
            {
                variationValues.Add(variationStr);
            }

            foreach (string varaitaionPair in variationValues)
            {
                Console.WriteLine("Variation Pair :- " + varaitaionPair);
            }

            runDuplicateFillTrialValues(variationValues, _sudokuBoard);
            return ErrorCode.NoError;
        }

        public void runDuplicateFillTrialValues(HashSet<string> variationValues, char[][] _sudokuBoard)
        {
            HashSet<string> tempVariationList = variationValues.Select(x => x).ToHashSet();

            while (tempVariationList.Count > 0)
            {
                foreach (string variationValue in tempVariationList)
                {
                    char[][] _duplicateBoard = new char[9][];
                    Dictionary<string, HashSet<char>> _duplicatePossibleValues = new Dictionary<string, HashSet<char>>();

                    for (int i = 0; i < 9; i++)
                    {
                        _duplicateBoard[i] = new char[9];
                        for (int j = 0; j < 9; j++)
                        {
                            _duplicateBoard[i][j] = _sudokuBoard[i][j];
                        }
                    }
                    printSudokuBorad(_duplicateBoard);

                    string[] valueSplits = variationValue.Split('#');
                    if (valueSplits.Length > 0)
                    {
                        foreach (string varSpl in valueSplits)
                        {
                            string[] elemSplits = varSpl.Split('_');
                            foreach (string elemSplit in elemSplits)
                            {
                                Console.WriteLine(elemSplit);
                            }

                            if (elemSplits.Length > 1)
                            {
                                string[] keySplits = elemSplits[0].Split(';');
                                int rowIndex = Convert.ToInt16(keySplits[0]);
                                int colIndex = Convert.ToInt16(keySplits[1]);

                                Console.WriteLine("Row index :- " + rowIndex + " Col Index :- " + colIndex + " Cell Value :- " + elemSplits[1]);

                                _duplicateBoard[rowIndex][colIndex] = elemSplits[1].ToCharArray()[0];
                            }
                        }
                    }

                    printSudokuBorad(_duplicateBoard);
                    FindPossibleCellValues(_duplicateBoard, _duplicatePossibleValues);
                    printPossibleValueDictionary(_duplicatePossibleValues);
                    ErrorCode err = runDuplicateFilling(_duplicateBoard, _duplicatePossibleValues);

                    if(err == ErrorCode.PossibleValuesEmpty)
                    {
                        PrintResults(_duplicateBoard, _duplicatePossibleValues);
                        System.Environment.Exit(0);
                    }
                    else if (err != ErrorCode.NoError)
                    {
                        variationValues.Remove(variationValue);
                    }
                else if (err == ErrorCode.NoError)
                    {
                        //if (isPossibleValuesEmpty(_duplicatePossibleValues))
                        //{
                        //    System.Environment.Exit(0);
                        //}
                        variationValues.Remove(variationValue);
                        HashSet<string> variationStrings = findVariationValueStrings(_duplicatePossibleValues);
                        foreach (string variationStr in variationStrings)
                        {
                            //Console.WriteLine("Variation Pair :- " + variationValue + variationStr);
                            variationValues.Add(variationValue + variationStr);
                        }
                    }
                }

                foreach(string variationVal in variationValues)
                {
                    Console.WriteLine("Variation Pair :- " + variationVal);
                }
            tempVariationList = variationValues.Select(x => x).ToHashSet();
        }


    }

        public ErrorCode runDuplicateFilling(char[][] _duplicateBoard, Dictionary<string, HashSet<char>> _duplicatePossibleValues)
        {
            //Dictionary<string, HashSet<char>> _duplicatePossibleValues = new Dictionary<string, HashSet<char>>();
            //FindPossibleCellValues(_duplicateBoard, _duplicatePossibleValues);
            //printPossibleValueDictionary(_duplicatePossibleValues);

            ErrorCode err = FillSinglePossibleValues(_duplicateBoard, _duplicatePossibleValues);
            PrintResults(_duplicateBoard, _duplicatePossibleValues);

            if(err == ErrorCode.NoError)
            {
                err = fillSingleCountOccurence(_duplicateBoard, _duplicatePossibleValues);
            }
            
            PrintResults(_duplicateBoard, _duplicatePossibleValues);

            return err;
        }
    }
}
