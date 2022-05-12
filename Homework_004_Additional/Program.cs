/* В переменной string есть секретное сообщение, во второй есть пароль. 
Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.*/

string message = "<Данное секретное сообщение не предназначено для публичного просмотра>";
int password = 123;  // Пароль, можно установить случайный - new Random().Next(0, 10)
int tryOpen = 3;     // Количество попыток ввода пароля

Console.WriteLine("У вас есть 3 попыткии ввести пароль");

for (int i = 1; i <= tryOpen; i++)
{
    Console.Write($"Ваша {i}-я попытка: ");

    if (Convert.ToInt32(Console.ReadLine()) == password) 
    {
        Console.WriteLine("Пароль введен правильно");
        Console.WriteLine(message);
        break;
    }
    else if(i == tryOpen)
    {
        Console.WriteLine("Доступ заблокирован");
    }
}