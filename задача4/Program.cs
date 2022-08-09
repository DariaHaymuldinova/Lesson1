// Программа: находит большее число из трех чисел

Console.WriteLine("Введите три числа: ");
int numberA = Convert.ToInt32(Console.ReadLine()); 
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());
if ((numberA > numberB) && (numberA > numberC))
{
    Console.WriteLine("{0} наибольшее число", numberA);
}
else if ((numberA < numberB) && (numberB > numberC))
{
    Console.WriteLine("{0} наибольшее число", numberB);
}
else
{
    Console.WriteLine("{0} наибольшее число", numberC);
}
Console.ReadLine();
