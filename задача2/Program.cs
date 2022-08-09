// Программа: находит большее число из двух чисел

Console.WriteLine("Введите два числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine("{0} наибольшее число", numberA);
}
else
{
    Console.WriteLine("{0} наибольшее число", numberB);
}
Console.ReadLine();