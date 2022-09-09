// Написать программу, упорядочивания по убыванию элементы каждой строки двумерного массива.


Console.OutputEncoding = System.Text.Encoding.UTF8;



void Fill(int [,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
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


void RangeArray(int [,] arr)
{
    int [] massive = new int [arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)//создаём одномерный массив из каждой строчки
        {
            massive[j] = arr[i,j];
            
        }
        
        for (int j = 0; j < arr.GetLength(1); j++)//передача массива для упорядычевания в DecreasingArray и создание новой строки
        {
            arr[i,j] = DecreasingArray(massive)[j];
        }
        
    }

}

int [] DecreasingArray(int [] mas)//упорядычеваем одномерный массив в порядке убывания
{
    for (int i = 0; i < mas.Length; i++)
    {
        int max = mas[i];
        for (int j = i; j < mas.Length; j++)
        {
            if (mas[j] > max)
            {
                max = mas[j];
                mas[j] = mas[i];
                mas[i] = max;

            }
        }
    }
    return mas;

}


Console.WriteLine("Допустим у нас массив 10 на 15 ,тогда ");


int [,] array = new int [10,15];
Fill(array);// заполняем массив
Print(array);// распечатываем массив
Console.WriteLine();
Console.WriteLine("Сделаем массив , в котором элементы каждой строки упорядочены по убыванию  ");
RangeArray(array); // упорядычеваем массив
Console.WriteLine();
Print(array);// распечатываем массив после упорядычевания


