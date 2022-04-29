/*Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

int [] array = GetArray(5);

PrintArray(array);

for(int i = 0; i < array.Length / 2; i++)
{
    int temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length -1 - i] = temp;
}

PrintArray(array);

void FillArray( int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1, 10);
        }
}

void PrintArray(int[] array)
{
     for(int i = 0; i < array.Length; i++)
         {
            Console.Write(array[i] + " "); ; 
         }
    Console.WriteLine();     
}

int[] GetArray(int length)
{
    int[] newArray = new int[length];
    FillArray(newArray);
    return newArray;
}