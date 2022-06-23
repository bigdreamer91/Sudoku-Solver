using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sudoku_Solver.ReusableCode;

namespace Sudoku_Solver
{
    internal class RoughWork
    {
        private void initEvil22June(char[][] _sudokuBoard)
        {
            _sudokuBoard[0] = new char[9] { '.', '.', '4', '6', '.', '.', '.', '.', '3' };
            _sudokuBoard[1] = new char[9] { '.', '9', '.', '.', '3', '.', '.', '7', '.' };
            _sudokuBoard[2] = new char[9] { '1', '.', '.', '.', '.', '4', '5', '.', '.' };
            _sudokuBoard[3] = new char[9] { '3', '.', '.', '.', '.', '9', '6', '.', '.' };
            _sudokuBoard[4] = new char[9] { '.', '6', '.', '.', '8', '.', '.', '2', '.' };
            _sudokuBoard[5] = new char[9] { '.', '.', '5', '3', '.', '.', '.', '.', '8' };
            _sudokuBoard[6] = new char[9] { '.', '.', '8', '1', '.', '.', '.', '.', '5' };
            _sudokuBoard[7] = new char[9] { '.', '1', '.', '.', '7', '.', '.', '3', '.' };
            _sudokuBoard[8] = new char[9] { '6', '.', '.', '.', '.', '3', '9', '.', '.' };
        }

        private void initEvil22June212(char[][] _sudokuBoard)
        {
            _sudokuBoard[0] = new char[9] { '.', '.', '4', '6', '.', '.', '.', '.', '3' };
            _sudokuBoard[1] = new char[9] { '.', '9', '6', '.', '3', '.', '.', '7', '.' };
            _sudokuBoard[2] = new char[9] { '1', '2', '3', '.', '.', '4', '5', '.', '.' };
            _sudokuBoard[3] = new char[9] { '3', '8', '.', '.', '.', '9', '6', '5', '.' };
            _sudokuBoard[4] = new char[9] { '.', '6', '.', '.', '8', '.', '3', '2', '.' };
            _sudokuBoard[5] = new char[9] { '.', '.', '5', '3', '.', '.', '.', '.', '8' };
            _sudokuBoard[6] = new char[9] { '.', '3', '8', '1', '.', '.', '.', '.', '5' };
            _sudokuBoard[7] = new char[9] { '.', '1', '.', '.', '7', '.', '.', '3', '.' };
            _sudokuBoard[8] = new char[9] { '6', '.', '.', '.', '.', '3', '9', '.', '.' };
        }

        private void initEvil23June(char[][] _sudokuBoard)
        {
            _sudokuBoard[0] = new char[9] { '.', '.', '1', '5', '.', '.', '.', '.', '9' };
            _sudokuBoard[1] = new char[9] { '.', '4', '.', '.', '2', '.', '.', '1', '.' };
            _sudokuBoard[2] = new char[9] { '8', '.', '.', '.', '.', '7', '3', '.', '.' };
            _sudokuBoard[3] = new char[9] { '5', '.', '.', '.', '.', '1', '8', '.', '.' };
            _sudokuBoard[4] = new char[9] { '.', '9', '.', '.', '5', '.', '.', '7', '.' };
            _sudokuBoard[5] = new char[9] { '.', '.', '2', '3', '.', '.', '.', '.', '6' };
            _sudokuBoard[6] = new char[9] { '.', '.', '4', '2', '.', '.', '.', '.', '1' };
            _sudokuBoard[7] = new char[9] { '.', '5', '.', '.', '6', '.', '.', '4', '.' };
            _sudokuBoard[8] = new char[9] { '3', '.', '.', '.', '.', '8', '9', '.', '.' };
        }

        private void initExcessive23June(char[][] _sudokuBoard)
        {
            _sudokuBoard[0] = new char[9] { '3', '.', '.', '.', '.', '.', '.', '.', '7' };
            _sudokuBoard[1] = new char[9] { '.', '.', '9', '4', '.', '7', '8', '.', '.' };
            _sudokuBoard[2] = new char[9] { '.', '5', '.', '.', '8', '.', '.', '1', '.' };
            _sudokuBoard[3] = new char[9] { '.', '2', '.', '.', '1', '.', '.', '7', '.' };
            _sudokuBoard[4] = new char[9] { '.', '.', '1', '5', '.', '4', '3', '.', '.' };
            _sudokuBoard[5] = new char[9] { '.', '3', '.', '.', '9', '.', '.', '4', '.' };
            _sudokuBoard[6] = new char[9] { '.', '4', '.', '.', '2', '.', '.', '8', '.' };
            _sudokuBoard[7] = new char[9] { '.', '.', '8', '1', '.', '6', '2', '.', '.' };
            _sudokuBoard[8] = new char[9] { '6', '.', '.', '.', '.', '.', '.', '.', '9' };
        }

        private void initEgrgious23June(char[][] _sudokuBoard)
        {
            _sudokuBoard[0] = new char[9] { '8', '.', '.', '.', '6', '.', '.', '.', '3' };
            _sudokuBoard[1] = new char[9] { '.', '7', '.', '1', '.', '3', '.', '9', '.' };
            _sudokuBoard[2] = new char[9] { '.', '.', '3', '.', '5', '.', '7', '.', '.' };
            _sudokuBoard[3] = new char[9] { '.', '2', '.', '.', '.', '.', '.', '1', '.' };
            _sudokuBoard[4] = new char[9] { '5', '.', '9', '.', '.', '.', '8', '.', '2' };
            _sudokuBoard[5] = new char[9] { '.', '3', '.', '.', '.', '.', '.', '6', '.' };
            _sudokuBoard[6] = new char[9] { '.', '.', '7', '.', '4', '.', '6', '.', '.' };
            _sudokuBoard[7] = new char[9] { '.', '9', '.', '8', '.', '6', '.', '5', '.' };
            _sudokuBoard[8] = new char[9] { '1', '.', '.', '.', '3', '.', '.', '.', '4' };
        }

        private void initExcruciating23June(char[][] _sudokuBoard)
        {
            _sudokuBoard[0] = new char[9] { '.', '.', '7', '5', '.', '.', '.', '.', '9' };
            _sudokuBoard[1] = new char[9] { '.', '5', '.', '.', '3', '.', '.', '6', '.' };
            _sudokuBoard[2] = new char[9] { '6', '.', '.', '.', '.', '1', '8', '.', '.' };
            _sudokuBoard[3] = new char[9] { '1', '.', '.', '.', '.', '3', '2', '.', '.' };
            _sudokuBoard[4] = new char[9] { '.', '9', '.', '.', '4', '.', '.', '3', '.' };
            _sudokuBoard[5] = new char[9] { '.', '.', '6', '1', '.', '.', '.', '.', '8' };
            _sudokuBoard[6] = new char[9] { '.', '.', '2', '9', '.', '.', '.', '.', '3' };
            _sudokuBoard[7] = new char[9] { '.', '6', '.', '.', '5', '.', '.', '2', '.' };
            _sudokuBoard[8] = new char[9] { '4', '.', '.', '.', '.', '8', '6', '.', '.' };
        }

        private void initExtreme23June(char[][] _sudokuBoard)
        {
            _sudokuBoard[0] = new char[9] { '3', '.', '.', '.', '.', '.', '.', '.', '5' };
            _sudokuBoard[1] = new char[9] { '.', '.', '6', '8', '.', '5', '4', '.', '.' };
            _sudokuBoard[2] = new char[9] { '.', '1', '.', '.', '4', '.', '.', '6', '.' };
            _sudokuBoard[3] = new char[9] { '.', '7', '.', '.', '1', '.', '.', '4', '.' };
            _sudokuBoard[4] = new char[9] { '.', '.', '5', '6', '.', '4', '1', '.', '.' };
            _sudokuBoard[5] = new char[9] { '.', '4', '.', '.', '2', '.', '.', '8', '.' };
            _sudokuBoard[6] = new char[9] { '.', '3', '.', '.', '5', '.', '.', '2', '.' };
            _sudokuBoard[7] = new char[9] { '.', '.', '9', '2', '.', '7', '6', '.', '.' };
            _sudokuBoard[8] = new char[9] { '2', '.', '.', '.', '.', '.', '.', '.', '7' };
        }

        private void initExtreme23June109(char[][] _sudokuBoard)
        {
            _sudokuBoard[0] = new char[9] { '3', '.', '4', '.', '6', '.', '.', '.', '5' };
            _sudokuBoard[1] = new char[9] { '9', '.', '6', '8', '.', '5', '4', '.', '.' };
            _sudokuBoard[2] = new char[9] { '5', '1', '.', '.', '4', '.', '.', '6', '.' };
            _sudokuBoard[3] = new char[9] { '.', '7', '.', '.', '1', '.', '.', '4', '.' };
            _sudokuBoard[4] = new char[9] { '.', '.', '5', '6', '.', '4', '1', '.', '.' };
            _sudokuBoard[5] = new char[9] { '.', '4', '.', '.', '2', '.', '.', '8', '.' };
            _sudokuBoard[6] = new char[9] { '.', '3', '.', '.', '5', '6', '.', '2', '.' };
            _sudokuBoard[7] = new char[9] { '.', '5', '9', '2', '.', '7', '6', '.', '.' };
            _sudokuBoard[8] = new char[9] { '2', '6', '.', '4', '.', '.', '.', '5', '7' };
        }

        private void initEvil24June(char[][] _sudokuBoard)
        {
            _sudokuBoard[0] = new char[9] { '.', '.', '4', '.', '1', '.', '5', '.', '.' };
            _sudokuBoard[1] = new char[9] { '.', '1', '.', '.', '.', '5', '.', '2', '.' };
            _sudokuBoard[2] = new char[9] { '6', '.', '.', '8', '.', '.', '.', '.', '7' };
            _sudokuBoard[3] = new char[9] { '.', '9', '.', '.', '.', '.', '4', '.', '.' };
            _sudokuBoard[4] = new char[9] { '1', '.', '.', '.', '9', '.', '.', '.', '3' };
            _sudokuBoard[5] = new char[9] { '.', '.', '6', '.', '.', '.', '.', '9', '.' };
            _sudokuBoard[6] = new char[9] { '7', '.', '.', '.', '.', '9', '.', '.', '6' };
            _sudokuBoard[7] = new char[9] { '.', '8', '.', '5', '.', '.', '.', '4', '.' };
            _sudokuBoard[8] = new char[9] { '.', '.', '3', '.', '8', '.', '7', '.', '.' };
        }

        private void initExecessive24June(char[][] _sudokuBoard)
        {
            _sudokuBoard[0] = new char[9] { '3', '7', '.', '.', '.', '.', '.', '2', '4' };
            _sudokuBoard[1] = new char[9] { '1', '5', '.', '.', '4', '.', '.', '9', '7' };
            _sudokuBoard[2] = new char[9] { '.', '.', '6', '.', '.', '.', '3', '.', '.' };
            _sudokuBoard[3] = new char[9] { '.', '.', '.', '7', '.', '5', '.', '.', '.' };
            _sudokuBoard[4] = new char[9] { '.', '3', '.', '.', '.', '.', '.', '8', '.' };
            _sudokuBoard[5] = new char[9] { '.', '.', '.', '8', '.', '1', '.', '.', '.' };
            _sudokuBoard[6] = new char[9] { '.', '.', '5', '.', '.', '.', '9', '.', '.' };
            _sudokuBoard[7] = new char[9] { '2', '6', '.', '.', '9', '.', '.', '4', '3' };
            _sudokuBoard[8] = new char[9] { '9', '4', '.', '.', '.', '.', '.', '7', '5' };
        }

        private void initEgrgious24June(char[][] _sudokuBoard)
        {
            _sudokuBoard[0] = new char[9] { '.', '.', '7', '.', '.', '.', '9', '.', '.' };
            _sudokuBoard[1] = new char[9] { '.', '5', '.', '1', '.', '8', '.', '4', '.' };
            _sudokuBoard[2] = new char[9] { '2', '.', '.', '.', '.', '.', '.', '.', '1' };
            _sudokuBoard[3] = new char[9] { '.', '9', '.', '4', '.', '5', '.', '8', '.' };
            _sudokuBoard[4] = new char[9] { '.', '.', '.', '.', '6', '.', '.', '.', '.' };
            _sudokuBoard[5] = new char[9] { '.', '7', '.', '9', '.', '2', '.', '6', '.' };
            _sudokuBoard[6] = new char[9] { '7', '.', '.', '.', '.', '.', '.', '.', '6' };
            _sudokuBoard[7] = new char[9] { '.', '1', '.', '5', '.', '4', '.', '3', '.' };
            _sudokuBoard[8] = new char[9] { '.', '.', '4', '.', '.', '.', '2', '.', '.' };
        }

        private void initExcruciating24June(char[][] _sudokuBoard)
        {
            _sudokuBoard[0] = new char[9] { '.', '.', '4', '5', '.', '.', '.', '.', '3' };
            _sudokuBoard[1] = new char[9] { '.', '8', '.', '.', '7', '.', '.', '2', '.' };
            _sudokuBoard[2] = new char[9] { '3', '.', '.', '.', '.', '2', '1', '.', '.' };
            _sudokuBoard[3] = new char[9] { '2', '.', '.', '.', '.', '6', '8', '.', '.' };
            _sudokuBoard[4] = new char[9] { '.', '5', '.', '.', '1', '.', '.', '9', '.' };
            _sudokuBoard[5] = new char[9] { '.', '.', '1', '8', '.', '.', '.', '.', '6' };
            _sudokuBoard[6] = new char[9] { '.', '.', '3', '9', '.', '.', '.', '.', '1' };
            _sudokuBoard[7] = new char[9] { '.', '9', '.', '.', '4', '.', '.', '5', '.' };
            _sudokuBoard[8] = new char[9] { '4', '.', '.', '.', '.', '5', '6', '.', '.' };
        }

        private void initExtreme24June(char[][] _sudokuBoard)
        {
            _sudokuBoard[0] = new char[9] { '2', '.', '.', '.', '.', '.', '.', '.', '7' };
            _sudokuBoard[1] = new char[9] { '.', '6', '.', '7', '.', '1', '.', '2', '.' };
            _sudokuBoard[2] = new char[9] { '.', '.', '4', '.', '2', '.', '8', '.', '.' };
            _sudokuBoard[3] = new char[9] { '.', '2', '.', '5', '.', '3', '.', '4', '.' };
            _sudokuBoard[4] = new char[9] { '.', '.', '6', '.', '.', '.', '7', '.', '.' };
            _sudokuBoard[5] = new char[9] { '.', '4', '.', '2', '.', '6', '.', '1', '.' };
            _sudokuBoard[6] = new char[9] { '.', '.', '2', '.', '9', '.', '3', '.', '.' };
            _sudokuBoard[7] = new char[9] { '.', '3', '.', '1', '.', '7', '.', '6', '.' };
            _sudokuBoard[8] = new char[9] { '4', '.', '.', '.', '.', '.', '.', '.', '5' };
        }

        public char[][] getSudokuBoard()
        {
            char[][] board = new char[9][];
            //initEvil22June(board);
            //initEvil22June212(board);
            //initEvil23June(board);
            //initExcessive23June(board);
            //initEgrgious23June(board);
            //initExcruciating23June(board);
            //initExtreme23June(board);
            //initExtreme23June109(board);
            initEvil24June(board);
            //initExecessive24June(board);
            //initEgrgious24June(board);
            //initExcruciating24June(board);
            //initExtreme24June(board);
            return board;
        }
        public void solveSudoku(char[][] _sudokuBoard)
        {
            Dictionary<string, HashSet<char>> _possibleCellValues = new Dictionary<string, HashSet<char>>();
            ReusableCode reusableCode = new ReusableCode();

            // Initialization
            reusableCode.printSudokuBorad(_sudokuBoard);
            reusableCode.FindPossibleCellValues(_sudokuBoard, _possibleCellValues);
            reusableCode.printPossibleValueDictionary(_possibleCellValues);

            // Fill single only possible values
            ErrorCode err = reusableCode.FillSinglePossibleValues(_sudokuBoard, _possibleCellValues);
            reusableCode.PrintResults(_sudokuBoard, _possibleCellValues);

            // Find Single occurence elem and fill
            if(err == ErrorCode.NoError)
            {
               err = reusableCode.fillSingleCountOccurence(_sudokuBoard, _possibleCellValues);
            }
            //reusableCode.fillSingleCountOccurence(_sudokuBoard, _possibleCellValues);
            reusableCode.PrintResults(_sudokuBoard, _possibleCellValues);

            // Duplicate board and iterate by filling possible values
            if(err == ErrorCode.NoError)
            {
               err = reusableCode.duplicateFillTrialValues(_sudokuBoard, _possibleCellValues);
            }
            //reusableCode.duplicateFillTrialValues(_sudokuBoard, _possibleCellValues);
        }
    }
}
