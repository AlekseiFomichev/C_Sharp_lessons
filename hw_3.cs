//Задание 1. Приложение по определению чётного или нечётного числа

/*Console.WriteLine("Введите число, чтобы узнать четное оно или нет: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0) Console.Write($"{number} четное число");
else Console.WriteLine($"{number} нечетное число");*/

//Задание 2. Программа подсчёта суммы карт в игре «21»

/*Console.WriteLine("Приветствую, шулер! Сколько карт на руках? Напиши числом ...");
int counter = int.Parse(Console.ReadLine());
int card = 0;
int summCard = 0;
for (int i = 1; i <= counter; i++)
{
    Console.Write($"Введите {i}-е значение карты: ");
    string userNumber = Console.ReadLine();
    switch(userNumber)
    {
        case "6": card = 6; break;
        case "7": card = 7; break;
        case "8": card= 8; break;
        case "9": card = 9; break;
        case "10": card = 10; break;
        case "j": card = 10; break;
        case "q": card = 10; break;
        case "k": card = 10; break;
        case "t": card = 10; break;
    }
    summCard += card;
}
Console.WriteLine($"У тебя {summCard}");
Console.ReadKey();
*/

//Задание 3. Проверка простого числа

/*Console.WriteLine("Введите целое число, чтобы узнать простое оно или нет: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 1 && number > number -1)
{
    if (number % 2 == 0)
    {
        Console.WriteLine($" число {number} не является простым");
    }
    else if (number % number == 0 && number % 1 == 0)
    {
        Console.Write($"{number} - простое число");
    }
    break;
}
*/

//Задание 4. Наименьший элемент в последовательности

/*Console.WriteLine("Введите длину последовательности: ...");
int sequence = int.Parse(Console.ReadLine());
int minValue = int.MaxValue;
for (; sequence > 0; sequence--)
{
    Console.WriteLine("Введите последовательно целые числа(нажатие Enter после каждого числа): ...");
    int number = int.Parse(Console.ReadLine());
    minValue = minValue > number ? number : minValue;
}
Console.WriteLine($"наименьший элемент последовательности - {minValue}");*/


//Задание 5. Игра «Угадай число»

Console.WriteLine("Введите максимальное число для вашего диапазона: 0 - ...");
int maxValue = int.Parse(Console.ReadLine());
Random random = new Random();
int secretNumber = random.Next(1, maxValue + 1);
int myNumber;

while (true)
{
    Console.WriteLine("Введите число: ");
    string secret = Console.ReadLine();
    if (string.IsNullOrEmpty(secret)) ;
    {
        Console.WriteLine($"Было число {secretNumber} ");
        break;
    }
    myNumber = int.Parse(secret);
    if (myNumber == secretNumber)
    {
        Console.WriteLine("WINNER! WINNER! WINNER!");
        break;
    }
    else if (myNumber > secretNumber)
    {
        Console.WriteLine("Мимо, попробуй меньшее число");
    }
    else Console.WriteLine("Мимо, попробуй большее число");
}
Console.ReadKey();
