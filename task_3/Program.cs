// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 5 3
// 8 4 6 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.

void Task_2()
{
    int rows = 3;
    int culumns = 4;
    int[,] numbers = new int[rows, culumns];

    FillArray(numbers);
    PrintArray(numbers);
    FindAverage(numbers);
    
}

void FillArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int culumns = numbers.GetLength(1);
    Random rand = new Random();
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < culumns; j++)
        {
            numbers[i, j] = rand.Next(0, 10);
            
        } 
    }
}

void FindAverage(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int culumns = numbers.GetLength(1);
    for(int i = 0; i < culumns; i++)
    {
        double сulumnsAverage = 0;
        double sum = 0;
        int count = 0; 
        for(int j = 0; j < rows; j++)
        {
            sum += numbers[j, i];
            count ++;
            
        }
    sum = Math.Round(sum / count, 1);
    Console.Write(sum + "  ");
    }

}


void PrintArray(int[,] numbers)
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
Task_2();