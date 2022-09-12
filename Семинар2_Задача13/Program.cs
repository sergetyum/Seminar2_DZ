// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:");
int number = int.Parse (Console.ReadLine());
number = Math.Abs (number); // Допускаем для анализа отрицательные числа.
if (number > 99) // Отсекаем числа менее трех знаков.
{
string numbertext = Convert.ToString(number); // Конвертируем число в строку.
Console.Write($"Третья цифра: {numbertext[2]}"); // Выводим в терминал третий символ строки.
}
else
{
Console.Write("Третьей цифры нет.");
}