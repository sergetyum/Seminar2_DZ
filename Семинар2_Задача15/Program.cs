// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число:");
int number = int.Parse (Console.ReadLine());
if (number >= 1 && number <= 7)
{
   if (number >= 1 && number <= 5)
   {
    Console.Write("Это рабочий день.");
   }
   else
   {
   Console.Write("Это выходной день.");
   }
}
else
{
Console.Write("Число не является днем недели.");
}