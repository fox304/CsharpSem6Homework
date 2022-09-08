// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.OutputEncoding = System.Text.Encoding.UTF8;


void Fill(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(10);
            Console.Write($"{arr[i,j]}  ");
        }
        Console.WriteLine();
    }

}

void Calculate(int [,] arr)

{
    
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j,i];
        }
        Console.WriteLine($" Среднее арифметическое {i+1}-го столбца = {sum/arr.GetLength(0)}");
    }

}
Console.WriteLine("Пусть нам дан массив размером 3 на 7 , тогда :");
int [,] array = new int [3,7];
Fill(array);
Calculate(array);