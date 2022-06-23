// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Sudoku_Solver;

//string varValue = "2;1_7#0;1_5#0;0_8#0;6_2#0;4_1#";
//string[] varSplits = varValue.Split('#');
//foreach(string varSplit in varSplits)
//{
//    Console.WriteLine(varSplit);
//}
//if(varSplits.Length > 0)
//{
//    foreach(string varSpl in varSplits)
//    {
//        string[] elemSplits = varSpl.Split('_');
//        foreach (string elemSplit in elemSplits)
//        {
//            Console.WriteLine(elemSplit);
//        }

//        if (elemSplits.Length > 1)
//        {
//            string[] keySplits = elemSplits[0].Split(';');
//            int rowIndex = Convert.ToInt16(keySplits[0]);
//            int colIndex = Convert.ToInt16(keySplits[1]);

//            Console.WriteLine("Row index :- " + rowIndex + " Col Index :- " + colIndex + " Cell Value :- " + elemSplits[1]);
//        }
//    }
//}

//SudokuSolver sudokuSolver = new SudokuSolver();
//sudokuSolver.SolveSudoku(sudokuSolver.getSudokuBoard());

RoughWork rough = new RoughWork();
char[][] _sudokuBoard = rough.getSudokuBoard();
rough.solveSudoku(_sudokuBoard);

//for (int i = 0; i < 3; i = i++)
//{
//    for (int row = i; row < 9; row = i + 3)
//    {
//        int matrixStartCol = row * (row % 3);
//        for (int col = matrixStartCol; col < (matrixStartCol + 3); col++)
//        {
//            //string matrixListKey = row + ";" + col;
//            string matrixListKey = col.ToString();
//            Console.Write(" " + matrixListKey + " ");
//        }
//        Console.WriteLine();
//    }
//}

//for (int i = 0; i < 3; i++)
//{
//    int matrixStartCol = i * (i % 3);
//        for (int col = matrixStartCol; col < (matrixStartCol + 3); col++)
//        {
//            string matrixListKey = i + ";" + col;
//            Console.Write(matrixListKey);
//        }
//}

//for(int i=0; i<3; i++)
//{
//    for(int j=0; j<3; j++)
//    {
//        int startrow = 3 * (i % 3);
//        int startcol = 3 * (j % 3);

//        //Console.Write(" " + startrow + " ; " + startcol + " ");
//        Console.WriteLine();

//        for (int row=startrow; row<(startrow+3); row++)
//        {
//            for(int col=startcol; col<(startcol+3); col++)
//            {
//                Console.Write(" " + row + " ; " + col + " ");
//            }
//            Console.WriteLine();
//        }

//    }
//    Console.WriteLine();
//}