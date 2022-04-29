/* Задача 59. В прямоугольной матрице найти строку с наименьшей суммой элементов. */

Console.WriteLine("Введите количество строк матрицы");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(); 

int[,] matrix = new int[rows, columns];
ArrayCreation(matrix);
Console.WriteLine(); 
CheckSumOfRow(matrix);

void ArrayCreation(int[,] array)       // Метод/функция содания и вывода двумерного массива в виде таблицы
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();  
    }
}

void CheckSumOfRow(int[,] array)       // Метод/функция вычисления и вывода минимальной суммы строки и её номера
{                                      // Нумерация выведенной строки начинается с 1, а не с 0 !!!
    int minSum = 0;
    int index = 0;
    int rowNumber = 0;

    while(index < array.GetLength(1))
    {
        minSum += array[0, index];
        index++;
    }
    
    for(int i = 1; i < array.GetLength(0); i++)
    {
        int tempSum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            tempSum += array[i, j];
        }

        if(minSum > tempSum)
        {
            minSum = tempSum;
            rowNumber = i;
        } 
    }
    Console.WriteLine($"Строка {rowNumber + 1}, с минимальной суммой элементов {minSum}");
}