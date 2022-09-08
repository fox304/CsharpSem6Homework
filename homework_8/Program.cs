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
    int sum = 0,indexmin = 0,min = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i; j < arr.GetLength(1); j++)
        {
            sum += arr[i,j];   
        }
        if (sum < min) 
        {
            
            indexmin = i;
        }
        sum = 0;
        
        
    }
    return indexmin;
}


int [,] array = new int [4,3];
Fill(array);
Print(array);
Console.WriteLine($" Строка с наименьшей суммой элементов номер : {Change(array)+1}");



















