int[,] CreateMatrix(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] SortRowElementsFromMinToMax(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            int minIndex = k;
            
            for (int j = k + 1; j < array.GetLength(1); j++)
            {
                if (array[i, j] < array[i,minIndex]) minIndex = j;
            }
            if (minIndex != k)
            {
                int temp = array[i, k];
                array[i, k] = array[i, minIndex];
                array[i, minIndex] = temp;
            }
        }
    }
    return array;
}
Console.Write("Введите число строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateMatrix(rows, columns, min, max);
PrintArray(myArray);
myArray = SortRowElementsFromMinToMax(myArray);
PrintArray(myArray);

