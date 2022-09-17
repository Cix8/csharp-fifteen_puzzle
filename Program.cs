//int[] grid = new int[16];

//for (int i = 0; i < grid.Length - 1; i++)
//{
//    grid[i] = i + 1;
//}

//int[] grid = { 1,3,2,5,4,10,12,11,6,8,15,7,9,0,14,13 };
int[] grid = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,0,15 };

void PrintGrid(int[] grid)
{
    for (int i = 0; i < grid.Length; i++)
    {
        if (i < 4)
        {

            Console.Write(grid[i]);
            Console.Write(" ");

        } else if (i == 4)
        {
            Console.WriteLine();
            Console.Write(grid[i]);
            Console.Write(" ");

        } else if (i > 4 && i < 8)
        {

            Console.Write(grid[i]);
            Console.Write(" ");
        
        } else if (i == 8)
        {
            Console.WriteLine();
            Console.Write(grid[i]);
            Console.Write(" ");

        } else if (i > 8 && i < 12)
        {

            Console.Write(grid[i]);
            Console.Write(" ");

        } else if (i == 12)
        {

            Console.WriteLine();
            Console.Write(grid[i]);
            Console.Write(" ");

        } else if (i < 16)
        {

            Console.Write(grid[i]);
            Console.Write(" ");
        
        }
    }
    Console.WriteLine();
}

PrintGrid(grid);

void InitGame(int[] grid)
{
    Console.WriteLine("Quale numero vuoi spostare?");
    int numbToMove = Convert.ToInt32(Console.ReadLine());

    int zeroIndex = Array.IndexOf(grid, 0);
    int numbIndex = Array.IndexOf(grid, numbToMove);

    if (zeroIndex - 4 == numbIndex || zeroIndex + 4 == numbIndex || 
        (zeroIndex + 1 == numbIndex && numbIndex != 3 && numbIndex != 7 && numbIndex != 11 ) || 
        (zeroIndex - 1 == numbIndex && numbIndex != 4 && numbIndex != 7 && numbIndex != 11))
    {
        grid[zeroIndex] = numbToMove;
        grid[numbIndex] = 0;
    } else
    {
        Console.WriteLine("Non puoi muovere quel numero, riprova");
    }

    PrintGrid(grid);
}

bool continua = true;

do
{
    InitGame(grid);

    bool youWin = false;

    for (int i = 0; i < grid.Length - 2; i++)
    {
        if (grid[i] == grid[i + 1] - 1)
        {
            youWin = true;
        } else
        {
            youWin = false;
            break;
        }
    }

    if (youWin)
    {
        continua = false;
    }
} while (continua);

if (!continua) { 
    Console.WriteLine("Hai vinto");
}
