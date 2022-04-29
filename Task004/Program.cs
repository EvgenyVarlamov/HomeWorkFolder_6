/* Задача 44: Не используя рекурсию, выведите первые N чисел 
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
 */

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[number];

Fibonacci(arr);
PrintArray(arr);

void Fibonacci(int[] result)
{
    for(int i = 0; i < result.Length; i++)
    {
        if(i == 0) result[i] = 0;
        else if(i == 1) result[i] = 1;
        else result[i] = result[i - 1] + result[i -2];
    }
}

void PrintArray(int[] array)
{
     for(int i = 0; i < array.Length; i++)
         {
             Console.Write(array[i]);
             if(i <arr.Length - 1 )Console.Write(", ");
         }
    Console.WriteLine();     
}