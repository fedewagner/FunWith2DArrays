namespace FunWith2DArrays;

public static class ColorfulBoard
{
    public static void DisplayColorfulBoard(int dimensionX, int dimensionY)
    {
        int[,] userArray = new int [dimensionX, dimensionY];

        //Print the upper border (one extra at the beginning and one at the end)
        Console.Write("+");
        for (int column = 0; column < userArray.GetLength(0); column++)
        {
            Console.Write("--++--");
        }
        Console.Write("+");
        Console.WriteLine();

        int item = 1;
            
        //fill the array
        for (int row = 0; row < dimensionY; row++)
        {
            //print first Character each row
            Console.Write("|");
            for (int col = 0; col < dimensionX; col++)
            {

                if (col % 2 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    userArray[col, row] = item;
                    item++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    userArray[col, row] = item;
                    item++;
                }
                    
                //Print the output
                if (userArray[col, row] < 10)
                {Console.Write("  " + "0" + userArray[col, row] + "  ");}
                else
                {
                    if (userArray[col, row] >= 100)
                    {
                        Console.Write("  " + userArray[col, row] + " ");   
                    }
                    else
                    {
                        Console.Write("  " + userArray[col, row] + "  ");    
                    }
                }
                
                Console.ForegroundColor = ConsoleColor.White;
            }
                
            //print last Character each row
            Console.Write("|");
            Console.WriteLine();
        }
            
        //Print the bottom border(one extra at the beginning and one at the end)
        Console.Write("+");
        for (int column = 0; column < userArray.GetLength(0); column++)
        {
            Console.Write("--++--");
        }
        Console.Write("+");
    }
}