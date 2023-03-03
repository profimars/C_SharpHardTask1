//Задача C_SharpHardTask1
//Напишите программу, которая выводит на экран числа от 1 до 100. При этом вместо чисел, 
//кратных трем, программа должна выводить слово Fizz, а вместо чисел, кратных пяти — слово Buzz. 
//Если число кратно пятнадцати, то программа должна выводить слово FizzBuzz. Задача может 
//показаться очевидной, но нужно получить наиболее простое и красивое решение.
//https://github.com/profimars/C_SharpHardTask1
string Fizz = "Fizz";
string Buzz = "Buzz";
string FizzBuzz = "FizzBuzz";
string qq = "";
Random rnd = new Random();
int q = rnd.Next(1, 101);
Console.WriteLine("Сгенерированное число = " + q);
for (int i = 1; i <= q; i++)
{
    if (i % 3 == 0 && i % 15 != 0)
        qq = Fizz;
    else if (i % 5 == 0 && i % 15 != 0)
        qq = Buzz;
    else if (i % 15 == 0)
        qq = FizzBuzz;
    else
        qq = i.ToString();
    Console.Write(qq + "; ");
}


