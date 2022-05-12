/* Продолжаем прокачивать приложение с командами. 
Добавить к программе, которая заканчивается, 
когда пишем exit еще 4 команды (их можно придумать самому). Например: 
- SetName – Установить имя 
- Help – вывести список команд 
- SetPassword – Установить пароль 
- WriteName – вывести имя после ввода пароля */

string[] CommandList = {"Calculation",           // Массив с названиями команд
                        "SetName",
                        "SetPassword",
                        "WriteName",
                        "Help",
                        "Exit"};
HelpFunction();                                  // Вызов списка команд при запуске программы

string? yourName = String.Empty;
string? yourPassword = String.Empty;

while(true)                                      // Бесконечный цикл
{
    Console.Write("Главное меню > ");
    Console.WriteLine("Введите команду: ");
    string? command = Console.ReadLine();
    if(command?.ToLower() == "calculation")
    {   
        Console.WriteLine("Подменю <Calculation>: ");
        Console.Write("Введите первое число A: ");
        double numberFirst = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число B: ");
        double numberSecond = Convert.ToDouble(Console.ReadLine());
        double sum = numberFirst + numberSecond;
        Console.WriteLine("A + B = " + sum);
        double differenceA = numberFirst - numberSecond;
        Console.WriteLine("A - B = " + differenceA);
        double differenceB = numberSecond - numberFirst;
        Console.WriteLine("B - A = " + differenceB);
        double multiplication = numberFirst * numberSecond;
        Console.WriteLine("A * B = " + multiplication);
        double divisionA = Math.Round(numberFirst / numberSecond, 2);
        Console.WriteLine("A / B = " + divisionA);
        double divisionB = Math.Round(numberSecond / numberFirst, 2);
        Console.WriteLine("B / A = " + divisionB);
    }
    else if (command?.ToLower() == "setname")
    {
        Console.WriteLine("Подменю <SetName>: ");
        Console.Write("Введите ваше имя: ");
        yourName = Console.ReadLine();
    }
    else if (command?.ToLower() == "setpassword")
    {
        Console.WriteLine("Подменю <SetPassword>: ");
        yourPassword = SetPassword();
        Console.WriteLine("Ваш пароль принят: " + yourPassword);
    }
    else if (command?.ToLower() == "writename")
    {
        Console.WriteLine("Подменю <WriteName>: ");
        if (yourPassword != String.Empty && yourName != String.Empty)
        {
            Console.WriteLine($"Ваше имя - {yourName}");
        }
        else if (yourPassword == String.Empty && yourName != String.Empty)
        {
            Console.WriteLine("Необходимо ввести пароль");
        }
        else if (yourPassword != String.Empty && yourName == String.Empty)
        {
            Console.WriteLine("Необходимо ввести имя");
        }
        else
        {
            Console.WriteLine("Необходимо ввести имя и пароль");
        }
    }
    else if (command?.ToLower() == "help")
    {
        HelpFunction();
    }
    else if (command?.ToLower() == "exit")
    {
        Console.WriteLine("Работа с программой завершена");
        break;
    }
    else
    {
        Console.WriteLine("Такой команды не существует");
    }
}

void HelpFunction()                              // Метод/функция вызова списка команд
{
    Console.WriteLine("Список команд:");
    for (int i = 0; i < CommandList.Length; i++)
    {
        Console.Write($"<{CommandList[i]}> ");
    }
    Console.WriteLine();
}

string SetPassword()                             // Метод/функция ввода пароля
{
    
    string? pass = String.Empty;
    for(;;)                                      // Бесконечный цикл с помощью оператора for в теле метода
    {
        Console.WriteLine("Сгенерировать пароль: Gen");
        Console.WriteLine("Ввести свой пароль: My");
        string? inputPassType = Console.ReadLine();
        if (inputPassType?.ToLower() == "gen")
        {
            Console.WriteLine("Введите длину пароля: ");
            int passwordLenth = Convert.ToInt32(Console.ReadLine());
            pass = SetRandomPassword(passwordLenth);
            break;
        }
        else if (inputPassType?.ToLower() == "my")
        {
            Console.WriteLine("Введите пароль: ");
            pass = Console.ReadLine() + "";
            if (pass != String.Empty && pass != " ")
            {
                break;
            }
            else
            {
                Console.WriteLine("Пароль не введен");
            }
        }
        else
        {
            Console.WriteLine("Необходимо ввести: Gen или My");
        }
    }
    return pass;
}

string SetRandomPassword(int passLenth)          // Метод/функция генератора пароля
{
    string[] letters = {"A", "a", "B", "b", "C", "c", "D", "d", "E", "e", "F", "f", "G", "g", "H", "h"};
    char[] symbols = {'!', '@', '#', '$', '%', '^', '&', '*'};
    string password = String.Empty;
    for(int i = 0; i < passLenth; i++)
    {
        string number = Convert.ToString(new Random().Next(0, 10));
        string letter = letters[new Random().Next(0, letters.Length)];
        string symbol = Convert.ToString(symbols[new Random().Next(0, symbols.Length)]);
        int randomFill = new Random().Next(0, 3);
        if (randomFill == 0) password += number;
        else if (randomFill == 1) password += letter;
        else password += symbol;        
    }
    Console.WriteLine(password);
    return password;
}