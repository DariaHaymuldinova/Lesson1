// Программа: показывает четные числа от 1 до N

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
int k = 1;
while (true)
{
if (k % 2 == 0)
{
    Console.WriteLine(k + "");
}
k++;
if (k > number)
{
    break;
}
}
Console.ReadLine();
