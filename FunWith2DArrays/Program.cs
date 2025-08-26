namespace FunWith2DArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int SELECTION_CHESS = 1;
            const int SELECTION_COLORFUL_BOARD = 2;
            const int MIN_NUMBER_OF_DIMENSIONS = 1;
            const int MAX_NUMBER_OF_DIMENSIONS = 9;
            
            //ask user the type of board he wants
            Console.WriteLine("Please indicate the type of board you would like to choose:");
            Console.WriteLine($"{SELECTION_CHESS} => Chess Board");
            Console.WriteLine($"{SELECTION_COLORFUL_BOARD} => Colorful with numbers Board");

            List<int> options = new List<int> { SELECTION_CHESS,  SELECTION_COLORFUL_BOARD };
            int selection;
            bool success;
            do
            {
                Console.WriteLine($"Please choose one of the following: 1 or 2");
                success = int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out selection);
            } while (!success || !options.Contains(selection));
            Console.WriteLine($"Option selected: '{selection}'.");

            //ask the user what dimension he wants for columns
            int selectionColumns;
            do
            {
                Console.WriteLine("Please select the amount of columns (from 1 to 9): ");
                success = int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out selectionColumns);
            } 
            while (!success || selectionColumns < MIN_NUMBER_OF_DIMENSIONS || selectionColumns > MAX_NUMBER_OF_DIMENSIONS);
            Console.WriteLine($"Selected columns: '{selectionColumns}'.");
            
            
            //ask the user what dimension he wants for rows
            int selectionRows;
            do
            {
                Console.WriteLine("Please select the amount of rows (from 1 to 9): ");
                success = int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out selectionRows);
            } 
            while (!success || selectionRows < MIN_NUMBER_OF_DIMENSIONS || selectionRows > MAX_NUMBER_OF_DIMENSIONS);
            Console.WriteLine($"Selected rows: '{selectionRows}'.");
            
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