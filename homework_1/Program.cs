// Показать двумерный массив размером m×n заполненный вещественными числами

Console.OutputEncoding = System.Text.Encoding.UTF8;

void Fill(double [,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().NextDouble()*100;
        }
    }


}
void Print(double [,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
    


}



Console.WriteLine("Введите размеры матрицы: ");
Console.WriteLine("Первый размер m ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Второй размер n ");
int n = int.Parse(Console.ReadLine());
double [,] massive = new double [m,n];

Fill(massive);
Print(massive);