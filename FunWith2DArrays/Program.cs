namespace FunWith2DArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int SELECTION_CHESS = 1;
            const int SELECTION_COLORFUL_BOARD = 2;
            
            //ask user the type of board he wants
            Console.WriteLine("Please indicate the type of board you would like to choose:");
            Console.WriteLine($"{SELECTION_CHESS} => Chess Board");
            Console.WriteLine($"{SELECTION_COLORFUL_BOARD} => Colorful with numbers Board");
            int selection = int.Parse(Console.ReadKey(true).KeyChar.ToString());
            while (selection != SELECTION_CHESS && selection != SELECTION_COLORFUL_BOARD)
            {
                Console.WriteLine("Please choose one of the following: 1 or 2");
                selection = int.Parse(Console.ReadKey(true).KeyChar.ToString());
            }

            //ask the user what dimension he wants for columns
            int dimensionColumns, dimensionRows;
            Console.WriteLine("Please select the amount of columns dimension (from 1 to 9): ");
            int selectionColumns = int.Parse(Console.ReadKey(true).KeyChar.ToString());
            while (selectionColumns < 1 || selectionColumns > 10)
            {
                Console.WriteLine("From 1 to 9!");
                selectionColumns = int.Parse(Console.ReadKey(true).KeyChar.ToString());
            }

            //ask the user what dimension he wants for rows
            Console.WriteLine("Please select the amount of rows dimension (from 1 to 9): ");
            int selectionRows = int.Parse(Console.ReadKey(true).KeyChar.ToString());
            while (selectionRows < 1 || selectionRows > 10)
            {
                Console.WriteLine("From 1 to 9!");
                selectionRows = int.Parse(Console.ReadKey(true).KeyChar.ToString());
            }
            
            //print the array
            switch (selection)
            {
                case 1: FunWith2DArrays.ChessBoard.DisplayChessBoard(selectionColumns, selectionRows);
                    break;
                case 2: FunWith2DArrays.ColorfulBoard.DisplayColorfulBoard(selectionColumns, selectionRows);
                    break;
            }
            
            
        }
    }
}