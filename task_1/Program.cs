// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами,
// округлёнными до одного знака.

void Task_1()
{
    int rows = 3;
    int culumns = 4;
    double[,] numbers = new double[rows, culumns];

    FillArray(numbers);
    PrintArray(numbers);
}

void FillArray(double[,] numbers)
{
    int rows = numbers.GetLength(0);
    int culumns = numbers.GetLength(1);
    Random rand = new Random();
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < culumns; j++)
        {
            numbers[i, j] = Math.Round(rand.NextDouble()*20 - 10, 1);
            
        } 
    }
}
void PrintArray(double[,] numbers)
{
    int rows = numbers.GetLength(0);
    int culumns = numbers.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < culumns; j++)
        {
            Console.Write(numbers[i, j] + " ");
        }
        Console.WriteLine(""); 
    }
}
Task_1();