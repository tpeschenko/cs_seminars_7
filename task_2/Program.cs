// Напишите программу, которая на вход
// принимает индексы элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

void Task_2()
{
    int rows = 3;
    int culumns = 4;
    int[,] numbers = new int[rows, culumns];

    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("");
    PrintIndex(numbers, 2, 2);
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
            numbers[i, j] = rand.Next(0, 9);
            
        } 
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
void PrintIndex(int[,] numbers, int indexI, int indexJ)
{
 try
 {
    Console.Write($"Элемент массива под индексом: {indexI}, {indexJ} = {numbers[indexI, indexJ]}");
 }
 catch (IndexOutOfRangeException)
 {
    Console.Write("Такого элемента нет в массиве");
 }
 

}
Task_2();
