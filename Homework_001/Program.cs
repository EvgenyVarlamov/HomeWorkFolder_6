/* Задача 41. Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

string[] message = { "число",    // 0
                     "числа",    // 1
                     "чисел" };  // 2

int value = InputNumber();
Console.WriteLine($"Вы ввели {value} {GrammarCheck(message, value)} больше 0");

int InputNumber()                             // Метод/функция ввода и подсчёта чисел больше 0
{
  Console.WriteLine("Какое количество чисел желаете ввести?");
  int length = Convert.ToInt32(Console.ReadLine());
  int[] numbers = new int[length];
  int count = 0;
  for(int i = 0; i < length; i++)
  {
      Console.WriteLine($"Введите ваше {i + 1}-е число");
      numbers[i] = Convert.ToInt32(Console.ReadLine());
      if(numbers[i] > 0) count++;
  } 
  return count;
}

string GrammarCheck(string[] msg, int val)    // Метод/функция проверки грамматики для вывода
{
    string text = String.Empty;
    if(val >= 11 && val < 15) text = msg[2];   
    else if(val % 10 == 1) text = msg[0]; 
    else if(val % 10  > 1 && val % 10  < 5) text = msg[1];
    else text = msg[2];
    return text;
}