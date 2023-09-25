// Задача 4
// Напишите программу, которая принимает на вход три числа 
// и выдает максимальное из этих чисел. 
// а = 2; b = 3; с = 7 -> max = 7
// а = 44; b = 5; с = 78 -> max = 78
// а = 22; b = 3; с = 9 -> max = 22
int numberA, numberB, numberC;

Console.WriteLine("Введите число1: ");
numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число2: ");
numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число3: ");
numberC = Convert.ToInt32(Console.ReadLine());


if ((numberA > numberB) && (numberA > numberC))
{
    Console.WriteLine($"{numberA}");
}
else if ((numberB > numberA) && (numberB > numberC))
{
    Console.WriteLine($"{numberB}");
}
else if ((numberC > numberA) && (numberC > numberB))
{
    Console.WriteLine($"{numberC}");
}