namespace FunWith2DArrays;

public static class ChessBoard
{
    public static void DisplayChessBoard(int dimensionX, int dimensionY)
    {
        char[,] userArray = new char [dimensionX, dimensionY];

        //Print the upper border (one extra at the beginning and one at the end)
        Console.Write("*");
        for (int column = 0; column < userArray.GetLength(1); column++)
        {
            Console.Write("###");
        }
        Console.Write("*");
        Console.WriteLine();
            
        //fill the array
        for (int i = 0; i < dimensionX; i++)
        {
            //print first Character each row
            Console.Write("#");
            for (int j = 0; j < dimensionY; j++)
            {

                if ((i % 2 == 0 && j % 2 == 0) || (i % 2 != 0 && j % 2 != 0))
                {
                    userArray[i, j] = 'X';    
                }
                else
                {
                    userArray[i, j] = '0';
                }
                    
                //Print the output
                Console.Write(" " + userArray[i, j] + " ");
            }
                
            //print last Character each row
            Console.Write("#");
            Console.WriteLine();
        }
            
        //Print the bottom border(one extra at the beginning and one at the end)
        Console.Write("*");
        for (int column = 0; column < userArray.GetLength(1); column++)
        {
            Console.Write("###");
        }
        Console.Write("*");
    }
}