// Задать двумерный массив следующим правилом: Aₘₙ = m+n
Console.OutputEncoding = System.Text.Encoding.UTF8;


void Fill(int [,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = i + j;
        }
    }
}

void Print(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}    ");
        }
        Console.WriteLine();
    }

}

Console.WriteLine("Пусть наш массив задан размерами m=4 и n=9");
Console.WriteLine("Тогда массив,заданный следующим правилом: Aₘₙ = m+n будет такой ");
int m = 14,n = 19;
int [,] array = new int [m,n];

Fill(array);
Console.WriteLine();
Print(array);



