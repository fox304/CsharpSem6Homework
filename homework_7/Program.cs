// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
//                             что это невозможно (в случае, если матрица не квадратная).
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


void Change(int [,] arr)
{
    int temp = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i; j < arr.GetLength(1); j++)
        {
            temp = arr[i,j];
            arr[i,j] = arr[j,i];
            arr[j,i] = temp;
            
        }
        
        
    }
}

int m = 0,n = 0;
while (true)
{
    Console.WriteLine("Введите размеры матрицы : ");
    Console.WriteLine("Введите m ");
    m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите n ");
    n = int.Parse(Console.ReadLine());
    if (m==n) break;                   //если матрица квадратная , то выход из цикла
    Console.WriteLine("Поскольку матрица не квадратная  , то заменить строки на столбцы невозможно ");
    Console.WriteLine("попробуйте ещё раз  ");

}

Console.WriteLine("Итак , у нас такая матрица  ");
int [,] array = new int [m,n];
Fill(array);
Print(array);
Console.WriteLine();
Console.WriteLine("После замены строк на столбцы  получилась вот такая   ");
Change(array);
Console.WriteLine();
Print(array);
