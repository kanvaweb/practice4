// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// ввод элеменетов через консоль (через запятую. использовать метод string.Split())

Console.Write("Задача 29. Введите числа через запятую: ");
string numbers = Console.ReadLine();
string[] array = numbers.Split(',');
int result = 0;

for (int i = 0; i < array.Length; i++) 
    result = result + int.Parse(array[i].ToString());

Console.WriteLine($"{numbers} -> {result}");
