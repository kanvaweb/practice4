// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Задача 25. Введите два числа (Основание и Степень)");

Console.Write("Основание (число 1): ");
int osnova = int.Parse(Console.ReadLine());
Console.Write("Степень (число 2): ");
int stepen = int.Parse(Console.ReadLine());

double result = Math.Pow(osnova, stepen);
Console.WriteLine($"{osnova}, {stepen} -> {result}");
