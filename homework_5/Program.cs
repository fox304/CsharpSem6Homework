// Написать программу, которая обменивает элементы первой строки и последней строки

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
            
            Console.Write($"{arr[i,j]}   ");
        }
        Console.WriteLine();
    }
}


void ChangeArray(int [,] arr)
{
    int temp;

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        temp = arr[0,i];
        arr[0,i] = arr[arr.GetLength(0)-1,i];
        arr[arr.GetLength(0)-1,i] = temp;
    }

}

Console.WriteLine("Пусть нам задан массив размером 4 на 7 ,тогда");
int [,] array = new int [4,7];
Fill(array);
Print(array);
Console.WriteLine();
Console.WriteLine("обменивая элементы первой и последней строки, получим ");
Console.WriteLine();
ChangeArray(array);
Print(array);