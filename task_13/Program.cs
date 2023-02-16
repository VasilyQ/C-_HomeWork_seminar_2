// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. (номер цифры считается от левого края)
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int value = 1000;
if(number >= 100 && number < 1000000000)
{
    while(value < number)
    {
        value = value * 10;
    }
    value = value / 1000;
    number = (number / value) % 10;
    Console.WriteLine(number);
}

else if(number >= 1000000000)
{
    value = 10000000;
    number = (number / value) % 10;
    Console.WriteLine(number);

}

else
{
    Console.WriteLine("Третьей цифры нет");
}

