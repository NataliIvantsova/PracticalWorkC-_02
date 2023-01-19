// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int InputInt(string messege)
{
    System.Console.Write(messege);//введите сообщение
    int x = Convert.ToInt32(Console.ReadLine());//значению х = прочитать строку
    return x;//вывести значение х из предыдущей строки
}

int a = InputInt("Введите число > ");

if(a<100)
{
    System.Console.Write($"в числе {a} третьей цифры нет");
}
else
{
     while(a>=1000)
     {
        a = a/10;
     }
     int result = a%10;
     System.Console.WriteLine($"{result}");
}
