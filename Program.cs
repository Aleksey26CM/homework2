/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трех значное число ");
int number1 = Convert.ToInt32( Console.ReadLine());

if ( number1 > 100 && number1 < 1000)
{
    int num = (number1 / 10);
    int result = num % 10;
    Console.Write(result);
}
else 
{
    Console.Write("Ошибка Вы не соблюдаете правила !");
}

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введите трех значное число ");
int number2 = Convert.ToInt32( Console.ReadLine());
string nums = number2.ToString();
if (number2 > 100)
{
    var myInt = int.Parse(nums[2].ToString());
    Console.WriteLine(myInt);
}
else 
{
Console.WriteLine("Вы не соблюдали правила");
}


/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите день недели от 1 - 7 ");
int numberDay = Convert.ToInt32( Console.ReadLine()) - 1;
string[] strArray =  new string [] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

if (numberDay < 7)
{
Console.WriteLine(strArray[numberDay]);
}
else
{
    Console.WriteLine("Вы не соблюдаете правила!");
}