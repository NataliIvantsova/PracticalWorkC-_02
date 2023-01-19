// 1/Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


int InputInt(string messege)// вводим целочисленное значение InputInt содержащее строку сообщения
{
    System.Console.Write(messege);//введите сообщение
    int x = Convert.ToInt32(Console.ReadLine());//значению х = прочитать строку
    return x;//вывести значение х из предыдущей строки
}

int a = InputInt("Введите трёхзначное число > ");

if(a>99 && a<1000)
{
    int result1 = a / 10;
    int result = result1 % 10;
     
    System.Console.WriteLine($"вторая цифра числа {a} > {result}");
}
else
{
      System.Console.WriteLine($"число {a} не является трёхзначным");
}
