// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты



Console.OutputEncoding = System.Text.Encoding.UTF8;


void Fill(int [,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // if (i%2==0 && j%2==0) arr[i,j] = i*i + j*j;
            arr[i,j] = new Random().Next(100);
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


void FillSquareOddAndEvenOfIndex(int [,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0) arr[i,j] *= arr[i,j];
            
        }
    }
}

Console.WriteLine("Меняем элементы массива по схеме:");
Console.WriteLine("заменить элементы, у которых оба индекса чётные на их квадраты");
Console.WriteLine("Пусть массив будет размером 6 на 7 ");


int [,] array = new int [6,7];

Fill(array);
Console.WriteLine();
Print(array);
Console.WriteLine();
Console.WriteLine("Тогда исходный массив станет таким  ");
FillSquareOddAndEvenOfIndex(array);
Console.WriteLine();
Print(array);