/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трех значное число ");
int number1 = Convert.ToInt32( Console.ReadLine());

if ( number1 > 99 && number1 < 1000)
{
    int num = (number1 / 10);
    int result = num % 10;
    Console.Write(result + " - является второй цифрой числа - " + number1);
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
if (number2 > 99)
{
    var myInt = int.Parse(nums[2].ToString());
    Console.WriteLine(number2 + " - Третьяция цифра - " + myInt);
}
else if (number2 < -99) {
    var myInt = int.Parse(nums[3].ToString());
    Console.WriteLine(number2 + " - Третьяция цифра - " + myInt);
}
else if (number2 < 100 && number2 >= 0) {
    Console.WriteLine(number2 + " - Третьей цифры тут нет, попробуйте ещё раз.");
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
int result = numberDay;
if (numberDay < 5)
{
    Console.WriteLine(strArray[numberDay] + " этот День не выходной");
}
else if (numberDay < 7) 
{
    Console.WriteLine(strArray[numberDay] + " этот День выходной");
}
else if (numberDay == 0 && numberDay < 0)
{
    Console.Write("Вы ввели неправильный день недели, попробуйте ещё раз");
}
else {
        Console.Write("Вы ввели неправильный день недели, попробуйте ещё раз"); // Здесь должна быть проверка на строку, но не готов настолько углубится в этот странный язык С#
}