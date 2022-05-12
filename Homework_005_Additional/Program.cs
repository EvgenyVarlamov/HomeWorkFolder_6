/* Есть программа с бесконечным циклом. 
Когда пользователь вводит exit программа заканчивается */

// Первый вариант
for(;;)
{
    Console.WriteLine("Вы в бесконечном цикле 1");
    string? command = Console.ReadLine();
    if(command?.ToLower() == "exit")
    {
        break;
    } 
    Console.WriteLine("...");
}
/////////////////////////////////////////////////////////////////

// Второй вариант
while(true)
{ Console.WriteLine("Вы в бесконечном цикле 2");
    string? command = Console.ReadLine();
    if(command?.ToLower() != "exit")
    {
        Console.WriteLine("...");
    } 
    else
    {
        break;
    } 
}
/////////////////////////////////////////////////////////////////

// Третий вариант
while(EndlessCycleStop())
{
    Console.WriteLine("Вы в бесконечном цикле 3");
}

bool EndlessCycleStop()
{
    bool result = true;
    string? command = Console.ReadLine();
    if(command?.ToLower() == "exit")
    {
        result = false;
    }     
    return result;
}