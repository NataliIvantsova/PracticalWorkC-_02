// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int InputInt(string messege)
{
    System.Console.Write(messege);//введите сообщение
    int x = Convert.ToInt32(Console.ReadLine());//значению х = прочитать строку
    return x;//вывести значение х из предыдущей строки
}
int DayNumber = InputInt("Введите цифру, обозначающую день недели> ");

if(DayNumber>6 && DayNumber<9)
{
    System.Console.WriteLine($"'этот день является выходным");
}
if(DayNumber>0 && DayNumber<7)
{
    System.Console.WriteLine($"этот день не является выходным, он рабочий");
}
else
{
    System.Console.WriteLine("такого дня недели не существует");
}
