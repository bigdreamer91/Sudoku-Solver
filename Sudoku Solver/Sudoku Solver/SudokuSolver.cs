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
            //initEvil15June();
            //initEasy1();
            //initMedium1();
            //initHard1();
            //initExtreme1();
            //initExtreme2();
            //initEvil22June();
            //initEvil22June212();
            //initEvil22June217();
            //initEvil22June217012();
            //initEvil22June217015();
            //initEvil22June217015002();
            //initEvil22June217015008();
            //initEvil22June217015008061();
            //initEvil22June217015008062();
            //initEvil22June217015008062041();
            //initExecessive22June();
            //initEgrgious22June();
            //initEgrgious22JuneStep1cell043();
            //initEgrgious22JuneStep1cell044();
            //initEcruciating22June();
            //initExtreme22June();
            initExtreme23June();
            printSudokuBorad();
        FindPossibleCellValues();
        printPossibleValueDictionary();
    }

        private void initEvil22June()
        {
            _sudokuBoard = new char[9][];
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

        private void initEvil22June212()
        {
            _sudokuBoard = new char[9][];
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

        private void initEvil22June217()
        {
            _sudokuBoard = new char[9][];
            _sudokuBoard[0] = new char[9] { '.', '.', '4', '6', '.', '.', '.', '.', '3' };
            _sudokuBoard[1] = new char[9] { '.', '9', '6', '.', '3', '.', '.', '7', '.' };
            _sudokuBoard[2] = new char[9] { '1', '7', '3', '.', '.', '4', '5', '.', '.' };
            _sudokuBoard[3] = new char[9] { '3', '8', '.', '.', '.', '9', '6', '5', '.' };
            _sudokuBoard[4] = new char[9] { '.', '6', '.', '.', '8', '.', '3', '2', '.' };
            _sudokuBoard[5] = new char[9] { '.', '.', '5', '3', '.', '.', '.', '.', '8' };
            _sudokuBoard[6] = new char[9] { '.', '3', '8', '1', '.', '.', '.', '.', '5' };
            _sudokuBoard[7] = new char[9] { '.', '1', '.', '.', '7', '.', '.', '3', '.' };
            _sudokuBoard[8] = new char[9] { '6', '.', '.', '.', '.', '3', '9', '.', '.' };
        }

        private void initEvil22June217012()
        {
            _sudokuBoard = new char[9][];
            _sudokuBoard[0] = new char[9] { '.', '2', '4', '6', '.', '7', '.', '.', '3' };
            _sudokuBoard[1] = new char[9] { '.', '9', '6', '.', '3', '.', '.', '7', '.' };
            _sudokuBoard[2] = new char[9] { '1', '7', '3', '.', '.', '4', '5', '.', '.' };
            _sudokuBoard[3] = new char[9] { '3', '8', '.', '.', '.', '9', '6', '5', '.' };
            _sudokuBoard[4] = new char[9] { '.', '6', '.', '.', '8', '.', '3', '2', '.' };
            _sudokuBoard[5] = new char[9] { '.', '.', '5', '3', '.', '.', '.', '.', '8' };
            _sudokuBoard[6] = new char[9] { '.', '3', '8', '1', '.', '.', '.', '.', '5' };
            _sudokuBoard[7] = new char[9] { '.', '1', '.', '.', '7', '.', '.', '3', '.' };
            _sudokuBoard[8] = new char[9] { '6', '.', '.', '.', '.', '3', '9', '.', '.' };
        }

        private void initEvil22June217015()
        {
            _sudokuBoard = new char[9][];
            _sudokuBoard[0] = new char[9] { '.', '5', '4', '6', '.', '7', '.', '.', '3' };
            _sudokuBoard[1] = new char[9] { '.', '9', '6', '.', '3', '.', '.', '7', '.' };
            _sudokuBoard[2] = new char[9] { '1', '7', '3', '.', '.', '4', '5', '.', '.' };
            _sudokuBoard[3] = new char[9] { '3', '8', '.', '.', '.', '9', '6', '5', '.' };
            _sudokuBoard[4] = new char[9] { '.', '6', '.', '.', '8', '.', '3', '2', '.' };
            _sudokuBoard[5] = new char[9] { '.', '.', '5', '3', '.', '.', '.', '.', '8' };
            _sudokuBoard[6] = new char[9] { '.', '3', '8', '1', '.', '.', '.', '.', '5' };
            _sudokuBoard[7] = new char[9] { '.', '1', '.', '.', '7', '.', '.', '3', '.' };
            _sudokuBoard[8] = new char[9] { '6', '.', '.', '.', '.', '3', '9', '.', '.' };
        }

        private void initEvil22June217015002()
        {
            _sudokuBoard = new char[9][];
            _sudokuBoard[0] = new char[9] { '2', '5', '4', '6', '.', '7', '.', '.', '3' };
            _sudokuBoard[1] = new char[9] { '.', '9', '6', '.', '3', '.', '.', '7', '.' };
            _sudokuBoard[2] = new char[9] { '1', '7', '3', '.', '.', '4', '5', '.', '.' };
            _sudokuBoard[3] = new char[9] { '3', '8', '.', '.', '.', '9', '6', '5', '.' };
            _sudokuBoard[4] = new char[9] { '.', '6', '.', '.', '8', '.', '3', '2', '.' };
            _sudokuBoard[5] = new char[9] { '.', '.', '5', '3', '.', '.', '.', '.', '8' };
            _sudokuBoard[6] = new char[9] { '.', '3', '8', '1', '.', '.', '.', '.', '5' };
            _sudokuBoard[7] = new char[9] { '5', '1', '.', '.', '7', '.', '.', '3', '.' };
            _sudokuBoard[8] = new char[9] { '6', '.', '.', '.', '5', '3', '9', '.', '.' };
        }

        private void initEvil22June217015008()
        {
            _sudokuBoard = new char[9][];
            _sudokuBoard[0] = new char[9] { '8', '5', '4', '6', '.', '7', '.', '.', '3' };
            _sudokuBoard[1] = new char[9] { '.', '9', '6', '.', '3', '.', '.', '7', '.' };
            _sudokuBoard[2] = new char[9] { '1', '7', '3', '.', '.', '4', '5', '.', '.' };
            _sudokuBoard[3] = new char[9] { '3', '8', '.', '.', '.', '9', '6', '5', '.' };
            _sudokuBoard[4] = new char[9] { '.', '6', '.', '.', '8', '.', '3', '2', '.' };
            _sudokuBoard[5] = new char[9] { '.', '.', '5', '3', '.', '.', '.', '.', '8' };
            _sudokuBoard[6] = new char[9] { '.', '3', '8', '1', '.', '.', '.', '.', '5' };
            _sudokuBoard[7] = new char[9] { '5', '1', '.', '.', '7', '.', '.', '3', '.' };
            _sudokuBoard[8] = new char[9] { '6', '.', '.', '.', '5', '3', '9', '.', '.' };
        }

        private void initEvil22June217015008061()
        {
            _sudokuBoard = new char[9][];
            _sudokuBoard[0] = new char[9] { '8', '5', '4', '6', '.', '7', '1', '.', '3' };
            _sudokuBoard[1] = new char[9] { '2', '9', '6', '.', '3', '.', '.', '7', '.' };
            _sudokuBoard[2] = new char[9] { '1', '7', '3', '.', '.', '4', '5', '.', '.' };
            _sudokuBoard[3] = new char[9] { '3', '8', '.', '.', '.', '9', '6', '5', '.' };
            _sudokuBoard[4] = new char[9] { '.', '6', '.', '.', '8', '.', '3', '2', '.' };
            _sudokuBoard[5] = new char[9] { '.', '.', '5', '3', '.', '.', '.', '.', '8' };
            _sudokuBoard[6] = new char[9] { '.', '3', '8', '1', '.', '.', '.', '.', '5' };
            _sudokuBoard[7] = new char[9] { '5', '1', '.', '.', '7', '.', '.', '3', '.' };
            _sudokuBoard[8] = new char[9] { '6', '.', '.', '.', '5', '3', '9', '.', '.' };
        }

        private void initEvil22June217015008062()
        {
            _sudokuBoard = new char[9][];
            _sudokuBoard[0] = new char[9] { '8', '5', '4', '6', '.', '7', '2', '.', '3' };
            _sudokuBoard[1] = new char[9] { '2', '9', '6', '.', '3', '.', '.', '7', '.' };
            _sudokuBoard[2] = new char[9] { '1', '7', '3', '.', '.', '4', '5', '.', '.' };
            _sudokuBoard[3] = new char[9] { '3', '8', '.', '.', '.', '9', '6', '5', '.' };
            _sudokuBoard[4] = new char[9] { '.', '6', '.', '.', '8', '.', '3', '2', '.' };
            _sudokuBoard[5] = new char[9] { '.', '.', '5', '3', '.', '.', '.', '.', '8' };
            _sudokuBoard[6] = new char[9] { '.', '3', '8', '1', '.', '.', '.', '.', '5' };
            _sudokuBoard[7] = new char[9] { '5', '1', '.', '.', '7', '.', '.', '3', '.' };
            _sudokuBoard[8] = new char[9] { '6', '.', '.', '.', '5', '3', '9', '.', '.' };
        }

        private void initEvil22June217015008062041()
        {
            _sudokuBoard = new char[9][];
            _sudokuBoard[0] = new char[9] { '8', '5', '4', '6', '1', '7', '2', '.', '3' };
            _sudokuBoard[1] = new char[9] { '2', '9', '6', '.', '3', '.', '.', '7', '.' };
            _sudokuBoard[2] = new char[9] { '1', '7', '3', '.', '.', '4', '5', '.', '.' };
            _sudokuBoard[3] = new char[9] { '3', '8', '.', '.', '.', '9', '6', '5', '.' };
            _sudokuBoard[4] = new char[9] { '.', '6', '.', '.', '8', '.', '3', '2', '.' };
            _sudokuBoard[5] = new char[9] { '.', '.', '5', '3', '.', '.', '.', '.', '8' };
            _sudokuBoard[6] = new char[9] { '.', '3', '8', '1', '.', '.', '.', '.', '5' };
            _sudokuBoard[7] = new char[9] { '5', '1', '.', '.', '7', '.', '.', '3', '.' };
            _sudokuBoard[8] = new char[9] { '6', '.', '.', '.', '5', '3', '9', '.', '.' };
        }

        private void initEvil22June217015008062049()
        {
            _sudokuBoard = new char[9][];
            _sudokuBoard[0] = new char[9] { '8', '5', '4', '6', '9', '7', '2', '.', '3' };
            _sudokuBoard[1] = new char[9] { '2', '9', '6', '.', '3', '.', '.', '7', '.' };
            _sudokuBoard[2] = new char[9] { '1', '7', '3', '.', '.', '4', '5', '.', '.' };
            _sudokuBoard[3] = new char[9] { '3', '8', '.', '.', '.', '9', '6', '5', '.' };
            _sudokuBoard[4] = new char[9] { '.', '6', '.', '.', '8', '.', '3', '2', '.' };
            _sudokuBoard[5] = new char[9] { '.', '.', '5', '3', '.', '.', '.', '.', '8' };
            _sudokuBoard[6] = new char[9] { '.', '3', '8', '1', '.', '.', '.', '.', '5' };
            _sudokuBoard[7] = new char[9] { '5', '1', '.', '.', '7', '.', '.', '3', '.' };
            _sudokuBoard[8] = new char[9] { '6', '.', '.', '.', '5', '3', '9', '.', '.' };
        }

        private void initExecessive22June()
        {
            _sudokuBoard = new char[9][];
            _sudokuBoard[0] = new char[9] { '.', '.', '2', '1', '.', '.', '.', '.', '5' };
            _sudokuBoard[1] = new char[9] { '.', '4', '.', '.', '5', '.', '.', '1', '.' };
            _sudokuBoard[2] = new char[9] { '1', '.', '.', '.', '.', '8', '6', '.', '.' };
            _sudokuBoard[3] = new char[9] { '8', '.', '.', '.', '.', '3', '4', '.', '.' };
            _sudokuBoard[4] = new char[9] { '.', '9', '.', '.', '7', '.', '.', '3', '.' };
            _sudokuBoard[5] = new char[9] { '.', '.', '6', '8', '.', '.', '.', '.', '2' };
            _sudokuBoard[6] = new char[9] { '.', '.', '9', '3', '.', '.', '.', '.', '1' };
            _sudokuBoard[7] = new char[9] { '.', '6', '.', '.', '1', '.', '.', '9', '.' };
            _sudokuBoard[8] = new char[9] { '7', '.', '.', '.', '.', '4', '3', '.', '.' };
        }

        private void initEgrgious22June()
        {
            _sudokuBoard = new char[9][];
            _sudokuBoard[0] = new char[9] { '.', '7', '.', '.', '.', '.', '.', '.', '.' };
            _sudokuBoard[1] = new char[9] { '.', '.', '.', '.', '.', '7', '1', '.', '3' };
            _sudokuBoard[2] = new char[9] { '.', '2', '5', '.', '6', '.', '4', '.', '.' };
            _sudokuBoard[3] = new char[9] { '.', '1', '.', '.', '5', '.', '.', '.', '.' };
            _sudokuBoard[4] = new char[9] { '.', '.', '2', '3', '.', '6', '5', '.', '.' };
            _sudokuBoard[5] = new char[9] { '.', '.', '.', '.', '9', '.', '.', '2', '.' };
            _sudokuBoard[6] = new char[9] { '.', '.', '4', '.', '2', '.', '3', '9', '.' };
            _sudokuBoard[7] = new char[9] { '6', '.', '9', '8', '.', '.', '.', '.', '.' };
            _sudokuBoard[8] = new char[9] { '.', '.', '.', '.', '.', '.', '.', '6', '.' };
        }

        private void initEgrgious22JuneStep1cell043()
        {
            _sudokuBoard = new char[9][];
            _sudokuBoard[0] = new char[9] { '.', '7', '.', '.', '3', '.', '.', '8', '.' };
            _sudokuBoard[1] = new char[9] { '.', '.', '.', '2', '.', '7', '1', '5', '3' };
            _sudokuBoard[2] = new char[9] { '.', '2', '5', '1', '6', '.', '4', '7', '9' };
            _sudokuBoard[3] = new char[9] { '.', '1', '.', '.', '5', '2', '9', '3', '.' };
            _sudokuBoard[4] = new char[9] { '.', '.', '2', '3', '.', '6', '5', '.', '.' };
            _sudokuBoard[5] = new char[9] { '.', '.', '.', '.', '9', '.', '.', '2', '.' };
            _sudokuBoard[6] = new char[9] { '.', '.', '4', '6', '2', '.', '3', '9', '.' };
            _sudokuBoard[7] = new char[9] { '6', '.', '9', '8', '.', '.', '.', '.', '.' };
            _sudokuBoard[8] = new char[9] { '2', '.', '.', '.', '.', '.', '.', '6', '.' };
        }

        private void initEgrgious22JuneStep1cell044()
        {
            _sudokuBoard = new char[9][];
            _sudokuBoard[0] = new char[9] { '.', '7', '.', '.', '4', '.', '.', '8', '.' };
            _sudokuBoard[1] = new char[9] { '.', '.', '.', '2', '.', '7', '1', '5', '3' };
            _sudokuBoard[2] = new char[9] { '.', '2', '5', '1', '6', '.', '4', '7', '9' };
            _sudokuBoard[3] = new char[9] { '.', '1', '.', '.', '5', '2', '9', '3', '.' };
            _sudokuBoard[4] = new char[9] { '.', '.', '2', '3', '.', '6', '5', '.', '.' };
            _sudokuBoard[5] = new char[9] { '.', '.', '.', '.', '9', '.', '.', '2', '.' };
            _sudokuBoard[6] = new char[9] { '.', '.', '4', '6', '2', '.', '3', '9', '.' };
            _sudokuBoard[7] = new char[9] { '6', '.', '9', '8', '.', '.', '.', '.', '.' };
            _sudokuBoard[8] = new char[9] { '2', '.', '.', '.', '.', '.', '.', '6', '.' };
        }

        private void initEcruciating22June()
        {
            _sudokuBoard = new char[9][];
            _sudokuBoard[0] = new char[9] { '5', '.', '.', '.', '3', '.', '.', '.', '6' };
            _sudokuBoard[1] = new char[9] { '.', '.', '.', '4', '.', '9', '.', '.', '.' };
            _sudokuBoard[2] = new char[9] { '.', '.', '3', '.', '5', '.', '1', '.', '.' };
            _sudokuBoard[3] = new char[9] { '.', '9', '.', '.', '.', '.', '.', '8', '.' };
            _sudokuBoard[4] = new char[9] { '7', '.', '4', '.', '8', '.', '5', '.', '1' };
            _sudokuBoard[5] = new char[9] { '.', '5', '.', '.', '.', '.', '.', '6', '.' };
            _sudokuBoard[6] = new char[9] { '.', '.', '9', '.', '4', '.', '3', '.', '.' };
            _sudokuBoard[7] = new char[9] { '.', '.', '.', '2', '.', '1', '.', '.', '.' };
            _sudokuBoard[8] = new char[9] { '6', '.', '.', '.', '9', '.', '.', '.', '7' };
        }

        private void initExtreme22June()
        {
            _sudokuBoard = new char[9][];
            _sudokuBoard[0] = new char[9] { '8', '.', '.', '.', '6', '.', '.', '.', '3' };
            _sudokuBoard[1] = new char[9] { '.', '.', '.', '9', '.', '2', '.', '.', '.' };
            _sudokuBoard[2] = new char[9] { '.', '.', '9', '.', '5', '.', '6', '.', '.' };
            _sudokuBoard[3] = new char[9] { '.', '5', '.', '.', '.', '.', '.', '4', '.' };
            _sudokuBoard[4] = new char[9] { '9', '.', '2', '.', '1', '.', '5', '.', '7' };
            _sudokuBoard[5] = new char[9] { '.', '3', '.', '.', '.', '.', '.', '8', '.' };
            _sudokuBoard[6] = new char[9] { '.', '.', '7', '.', '2', '.', '3', '.', '.' };
            _sudokuBoard[7] = new char[9] { '.', '.', '.', '8', '.', '9', '.', '.', '.' };
            _sudokuBoard[8] = new char[9] { '4', '.', '.', '.', '3', '.', '.', '.', '5' };
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

        private void initEasy1()
        {        
            _sudokuBoard = new char[9][];
            _sudokuBoard[0] = new char[9] { '.', '.', '.', '9', '4', '.', '.', '.', '7' };
            _sudokuBoard[1] = new char[9] { '3', '4', '.', '.', '.', '.', '.', '.', '1' };
            _sudokuBoard[2] = new char[9] { '.', '2', '.', '.', '.', '1', '.', '6', '9' };
            _sudokuBoard[3] = new char[9] { '.', '1', '.', '4', '2', '.', '.', '3', '.' };
            _sudokuBoard[4] = new char[9] { '6', '.', '3', '.', '.', '.', '8', '.', '2' };
            _sudokuBoard[5] = new char[9] { '.', '8', '.', '.', '7', '3', '.', '9', '.' };
            _sudokuBoard[6] = new char[9] { '2', '9', '.', '5', '.', '.', '.', '7', '.' };
            _sudokuBoard[7] = new char[9] { '7', '.', '.', '.', '.', '.', '.', '1', '8' };
            _sudokuBoard[8] = new char[9] { '8', '.', '.', '.', '1', '2', '.', '.', '.' };
        }

        private void initMedium1()
        {
            _sudokuBoard = new char[9][];
            _sudokuBoard[0] = new char[9] { '6', '3', '9', '.', '.', '.', '.', '.', '2' };
            _sudokuBoard[1] = new char[9] { '.', '.', '.', '.', '.', '.', '.', '9', '7' };
            _sudokuBoard[2] = new char[9] { '.', '.', '4', '.', '3', '2', '.', '.', '.' };
            _sudokuBoard[3] = new char[9] { '.', '.', '.', '.', '6', '.', '2', '.', '9' };
            _sudokuBoard[4] = new char[9] { '.', '6', '.', '5', '.', '7', '.', '8', '.' };
            _sudokuBoard[5] = new char[9] { '7', '.', '2', '.', '9', '.', '.', '.', '.' };
            _sudokuBoard[6] = new char[9] { '.', '.', '.', '1', '8', '.', '9', '.', '.' };
            _sudokuBoard[7] = new char[9] { '8', '2', '.', '.', '.', '.', '.', '.', '.' };
            _sudokuBoard[8] = new char[9] { '4', '.', '.', '.', '.', '.', '8', '6', '3' };
        }

        private void initHard1()
        {
            _sudokuBoard = new char[9][];
            _sudokuBoard[0] = new char[9] { '.', '.', '.', '2', '.', '9', '.', '.', '.' };
            _sudokuBoard[1] = new char[9] { '.', '4', '.', '7', '.', '.', '8', '.', '.' };
            _sudokuBoard[2] = new char[9] { '1', '6', '.', '.', '.', '.', '3', '.', '.' };
            _sudokuBoard[3] = new char[9] { '3', '5', '.', '.', '.', '.', '.', '.', '7' };
            _sudokuBoard[4] = new char[9] { '7', '.', '.', '.', '9', '.', '.', '.', '8' };
            _sudokuBoard[5] = new char[9] { '8', '.', '.', '.', '.', '.', '.', '3', '1' };
            _sudokuBoard[6] = new char[9] { '.', '.', '9', '.', '.', '.', '.', '2', '3' };
            _sudokuBoard[7] = new char[9] { '.', '.', '5', '.', '.', '1', '.', '6', '.' };
            _sudokuBoard[8] = new char[9] { '.', '.', '.', '6', '.', '3', '.', '.', '.' };
        }

        private void initExtreme1()
        {
            _sudokuBoard = new char[9][];
            _sudokuBoard[0] = new char[9] { '.', '.', '.', '6', '.', '.', '2', '.', '.' };
            _sudokuBoard[1] = new char[9] { '.', '.', '1', '3', '.', '9', '.', '.', '5' };
            _sudokuBoard[2] = new char[9] { '.', '9', '4', '.', '.', '.', '.', '.', '.' };
            _sudokuBoard[3] = new char[9] { '.', '6', '8', '.', '7', '.', '.', '.', '3' };
            _sudokuBoard[4] = new char[9] { '.', '.', '.', '.', '1', '.', '.', '.', '.' };
            _sudokuBoard[5] = new char[9] { '3', '.', '.', '.', '6', '.', '9', '2', '.' };
            _sudokuBoard[6] = new char[9] { '.', '.', '.', '.', '.', '.', '5', '9', '.' };
            _sudokuBoard[7] = new char[9] { '4', '.', '.', '5', '.', '2', '3', '.', '.' };
            _sudokuBoard[8] = new char[9] { '.', '.', '3', '.', '.', '4', '.', '.', '.' };
        }

        private void initExtreme2()
        {
            _sudokuBoard = new char[9][];
            _sudokuBoard[0] = new char[9] { '5', '6', '.', '.', '.', '3', '.', '.', '.' };
            _sudokuBoard[1] = new char[9] { '3', '.', '.', '.', '4', '.', '.', '.', '.' };
            _sudokuBoard[2] = new char[9] { '1', '.', '.', '7', '.', '6', '.', '2', '.' };
            _sudokuBoard[3] = new char[9] { '6', '.', '.', '.', '9', '7', '.', '.', '.' };
            _sudokuBoard[4] = new char[9] { '9', '.', '7', '.', '.', '.', '8', '.', '5' };
            _sudokuBoard[5] = new char[9] { '.', '.', '.', '5', '6', '.', '.', '.', '4' };
            _sudokuBoard[6] = new char[9] { '.', '3', '.', '6', '.', '9', '.', '.', '2' };
            _sudokuBoard[7] = new char[9] { '.', '.', '.', '.', '7', '.', '.', '.', '8' };
            _sudokuBoard[8] = new char[9] { '.', '.', '.', '3', '.', '.', '.', '5', '1' };
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

        private void initExtreme23June()
        {
            _sudokuBoard = new char[9][];
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

        public void printDuplicateBorad(char[][] _duplicateBoard)
        {
            if (_duplicateBoard != null)
            {
                Console.Write("||-----||-----||-----||");
                Console.WriteLine();

                for (int i = 0; i < _duplicateBoard.Length; i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < _duplicateBoard[i].Length; j++)
                    {
                        if (_duplicateBoard[i][j] != '.')
                            Console.Write("|" + _duplicateBoard[i][j]);
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
            fillSingleCountOccurence();
            PrintResults();
            //duplicateFillTrialValues();
        } 

    // Check if possible cell values empty
      public bool isPossibleValuesEmpty()
        {
            Dictionary<string, HashSet<char>> possibleValueList = _possibleCellValues.Where(x => x.Value.Count > 0).ToDictionary(x => x.Key, x => x.Value);
            if(possibleValueList.Count == 0)
            {
                return true;
            }

            return false;
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

        public bool hasConflict(int rowIndex, int colIndex, char value)
        {
            // row scan
            for (int i = 0; i < 9; i++)
            {
                if (i != colIndex)
                {
                    if(_sudokuBoard[rowIndex][i] == value)
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

    public void FilltheCellValue(string key, char value)
    {
            if (isPossibleValuesEmpty())
            {
                return;
            }

        string[] keySplits = key.Split(';');
        int rowIndex = Convert.ToInt16(keySplits[0]);
        int colIndex = Convert.ToInt16(keySplits[1]);

            if (_sudokuBoard[rowIndex][colIndex] != '.')
            {
                return;
            }

            if (hasConflict(rowIndex, colIndex, value))
            {
                return;
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

            runFilledCellScan(key);

    }
         
    // ** count single occurence element
    // ** row scan, col scan, matrix scan
    public void fillSingleCountOccurence()
    {
            if (isPossibleValuesEmpty())
            {
                return;
            }

            // Row scan for single count occurence
            Console.WriteLine("Row scan");
       for(int row=0; row < 9; row++)
            {
                Dictionary<char, int> cellValueCount = new Dictionary<char, int>();
                Dictionary<char, string> valueFirstLocation = new Dictionary<char, string>();

                for(int col=0; col < 9; col++)
                {
                    string rowScanKey = row + ";" + col;
                    if (_possibleCellValues.ContainsKey(rowScanKey))
                    {
                        foreach(char cellValue in _possibleCellValues[rowScanKey])
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
                foreach(KeyValuePair<char, int> cellValue in cellValueCount)
                {
                    //Console.WriteLine(cellValue.Key + " : " + cellValue.Value);
                    if(cellValue.Value == 1)
                    {
                        Console.Write(cellValue.Key + " : " + cellValue.Value);
                        if (valueFirstLocation.ContainsKey(cellValue.Key))
                        {
                            Console.Write(" : Row-location : " + valueFirstLocation[cellValue.Key] + " ");
                            FilltheCellValue(valueFirstLocation[cellValue.Key], cellValue.Key);
                        }
                    }
                } 
                Console.WriteLine();
            }

            // Col scan
            Console.WriteLine("Col scan");
            for (int col=0; col < 9; col++)
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
                            FilltheCellValue(valueFirstLocation[cellValue.Key], cellValue.Key);
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
                                FilltheCellValue(valueFirstLocation[cellValue.Key], cellValue.Key);
                            }
                        }
                    }
                    Console.WriteLine();

                }
            }

        }

        public void exitWithError(string errorMsg)
        {
            Console.WriteLine(errorMsg);
            PrintResults();
            System.Environment.Exit(0);
        }

        public void errorPossibleCellValue(string cellIndex)
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
                        if(_possibleCellValues[rowScanKey].Count == 0 && _sudokuBoard[rowIndex][colIndex] == '.')
                        {
                            exitWithError("Empty possible value on empty cell ----- Error");
                        }

                        if (_possibleCellValues[rowScanKey].Count == 1)
                        {
                            if (singleCellValue.Contains(_possibleCellValues[rowScanKey].ElementAt(0)))
                            {
                                exitWithError("Single Possible value already exists ----- Error");
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
                            exitWithError("Empty possible value on empty cell ----- Error");
                        }

                        if (_possibleCellValues[colScanKey].Count == 1)
                        {
                            if (singleCellValue.Contains(_possibleCellValues[colScanKey].ElementAt(0)))
                            {
                                exitWithError("Single Possible value already exists ----- Error");
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
                                exitWithError("Empty possible value on empty cell ----- Error");
                            }

                            if (_possibleCellValues[matrixScanKey].Count == 1)
                            {
                                if (singleCellValue.Contains(_possibleCellValues[matrixScanKey].ElementAt(0)))
                                {
                                    exitWithError("Single Possible value already exists ----- Error");
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
        }

        public void runFilledCellScan(string cellIndex)
        {
            if (isPossibleValuesEmpty())
            {
                return;
            }

            errorPossibleCellValue(cellIndex);

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
            for (int i=0; i<9; i++)
            {
               
                if(i != colIndex)
                {
                    string rowScanKey = rowIndex + ";" + i;
                    if (_possibleCellValues.ContainsKey(rowScanKey))
                    {
                        if(_possibleCellValues[rowScanKey].Count == 1)
                        {
                            Console.WriteLine("Single Value : " + _possibleCellValues[rowScanKey].ElementAt(0) + " -- cellIndex : " + rowScanKey);
                            FilltheCellValue(rowScanKey, _possibleCellValues[rowScanKey].ElementAt(0));
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
                        FilltheCellValue(valueFirstLocation[cellValue.Key], cellValue.Key);
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
                            FilltheCellValue(colScanKey, _possibleCellValues[colScanKey].ElementAt(0));
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
                        FilltheCellValue(valueFirstLocation[cellValue.Key], cellValue.Key);
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
                                    FilltheCellValue(matrixScanKey, _possibleCellValues[matrixScanKey].ElementAt(0));
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
                        FilltheCellValue(valueFirstLocation[cellValue.Key], cellValue.Key);
                    }
                }
            }
            Console.WriteLine();
        }

        public void duplicateFillTrialValues()
        {
            //Dictionary<string, string> variationValues = new Dictionary<string, string>();
            HashSet<string> variationValues = new HashSet<string>();

            KeyValuePair<string, HashSet<char>> singleValueList = _possibleCellValues.Where(x => x.Value.Count == 2).ToDictionary(x => x.Key, x => x.Value).FirstOrDefault();
            
            if(singleValueList.Key != null && singleValueList.Value != null)
            {
                foreach(char value in singleValueList.Value)
                {
                    string variationValue = singleValueList.Key + "_" + value + "#";
                    variationValues.Add(variationValue);
                }
            }

            foreach(string varaitaionPair in variationValues)
            {
                Console.WriteLine("Variation Pair :- " + varaitaionPair);
            }

            runDuplicateFillTrialValues(variationValues);
        }

        public void runDuplicateFillTrialValues(HashSet<string> variationValues)
        {
            foreach(string variationValue in variationValues)
            {
                char[][] _duplicateBoard = new char[9][];
                for(int i=0; i<9; i++)
                {
                    _duplicateBoard[i] = new char[9];
                    for(int j=0; j<9; j++)
                    {
                        _duplicateBoard[i][j] = _sudokuBoard[i][j];
                    }
                }
                printDuplicateBorad(_duplicateBoard);

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

                printDuplicateBorad(_duplicateBoard);
                runDuplicateFilling(_duplicateBoard);
            }
        }

        public void runDuplicateFilling(char[][] _duplicateBoard)
        {
            Dictionary<string, HashSet<char>> _duplicatePossibleValues = new Dictionary<string, HashSet<char>>(); ;
            FindDuplicatePossibleCellValues(_duplicateBoard, _duplicatePossibleValues);
        }

        private void FindDuplicatePossibleCellValues(char[][] _duplicateBoard, Dictionary<string, HashSet<char>> _duplicatePossibleValues)
        {
            for (int row = 0; row < _duplicateBoard.Length; row++)
            {
                for (int col = 0; col < _duplicateBoard[row].Length; col++)
                {
                    if (_duplicateBoard[row][col] == '.')
                    {
                        _duplicatePossibleValues.Add("" + row + ";" + col + "", scanForDuplicateValues(row, col, _duplicateBoard));
                    }
                }
            }
        }

        private HashSet<char> scanForDuplicateValues(int rowIndex, int colIndex, char[][] _duplicateBoard)
        {
            HashSet<char> tempSet = new HashSet<char>();
            HashSet<char> rowSet = new HashSet<char>();
            HashSet<char> colSet = new HashSet<char>();
            HashSet<char> matrixSet = new HashSet<char>();

            for (int col = 0; col < _duplicateBoard.Length; col++)
            {
                if (_duplicateBoard[rowIndex][col] != '.')
                {
                    rowSet.Add(_duplicateBoard[rowIndex][col]);
                }
            }

            for (int row = 0; row < _duplicateBoard.Length; row++)
            {
                if (_duplicateBoard[row][colIndex] != '.')
                {
                    colSet.Add(_duplicateBoard[row][colIndex]);
                }
            }

            int matrixStartRow = rowIndex - (rowIndex % 3);
            int matrixStartCol = colIndex - (colIndex % 3);

            for (int row = matrixStartRow; row < (matrixStartRow + 3); row++)
            {
                for (int col = matrixStartCol; col < (matrixStartCol + 3); col++)
                {
                    if (_duplicateBoard[row][col] != '.')
                    {
                        matrixSet.Add(_duplicateBoard[row][col]);
                    }
                }
            }

            tempSet = scanForPossibleCellValues(rowSet, colSet, matrixSet);

            return tempSet;
        }

    }
}
