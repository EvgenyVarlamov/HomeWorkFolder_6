/* Задача 45: Напишите программу, которая будет создавать 
копию заданного массива с помощью поэлементного копирования.
*/

Console.WriteLine("Введите количество элементов массива");
int qty = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[qty];

FillArray(arr, qty);
CopyArray(arr, qty);

void FillArray( int[] array, int quantity)
{
    Console.Write("Массив:        { ");
    for(int i = 0; i < quantity; i++)
        {
             array[i] = new Random().Next(-99, 100);
             Console.Write(array[i]);
             if(i < quantity - 1) Console.Write(", ");
        }
    Console.Write(" }"); 
    Console.WriteLine();    
}

void CopyArray(int[] array, int quantity)
{
    int[] newArray = new int[qty];
    Console.Write("Копия массива: { ");
    for(int i = 0; i < array.Length; i++)
         {
             newArray[i] = array[i];
             Console.Write(newArray[i]);
             if(i < quantity - 1) Console.Write(", ");
         }
    Console.Write(" }"); 
    Console.WriteLine(); 
}