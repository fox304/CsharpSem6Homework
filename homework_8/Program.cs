// В прямоугольной матрице найти строку с наименьшей суммой элементов.


Console.OutputEncoding = System.Text.Encoding.UTF8;


void Fill(int [,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(10);
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

int Change(int [,] arr)
{
    int sum = 0,indexmin = 0;
    int min = 10000;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i,j];  
            
        }
        Console.WriteLine($" сумма элементов {i+1} строки равна {sum} ");
        if (sum < min) 
        {
            min = sum;
            indexmin = i;
        }
   
        sum = 0;
        
    }
    return indexmin;
}

Console.WriteLine($" Пусть дана матрица 7 на 3 ,тогда ");
int [,] array = new int [7,3];
Fill(array);
Print(array);
Console.WriteLine();
Console.WriteLine($" \nстрока с наименьшей суммой элементов номер : {Change(array)+1}");