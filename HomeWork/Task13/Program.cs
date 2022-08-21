// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int val = 32679;
int result = 0;

void Task13()
{
    while (val>=1000)
    {
        val = val/10;
    }
    result = val % 10;
 }

if (val > 99)
    {
        Task13();
        Console.WriteLine(result);
    }

else
{Console.WriteLine("Третьей цифры нет");}