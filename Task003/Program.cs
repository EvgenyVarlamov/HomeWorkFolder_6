/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

Console.WriteLine("Введите десятичное число:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"В двоичной системе получим: {BinarNumber(number)}");

int BinarNumber(int num)
{
    string resultTemporary = String.Empty;
    string result = String.Empty;

    while(num != 0)
    {
        resultTemporary += num % 2;
        num = num / 2;
    }

    for(int i = 0; i < resultTemporary.Length; i++)
    {
        result += resultTemporary[resultTemporary.Length - 1 - i];
    }

    return Convert.ToInt32(result);
}