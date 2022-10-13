// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Задача 27. Введите число, чтобы получить сумму цифр в числе");

Console.Write("Число: ");
int number = int.Parse(Console.ReadLine());
int result = 0;

for (int i = 0; i < number.ToString().Length; i++) 
{
    result = result + int.Parse(number.ToString()[i].ToString());
}

Console.WriteLine($"{number} -> {result}");
