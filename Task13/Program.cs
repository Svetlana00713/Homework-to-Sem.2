// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введи число: ");
int N = Convert.ToInt32(Console.ReadLine());
string NText = Convert.ToString(N);
if (NText.Length > 2)
{
  Console.WriteLine("Третья цифра: " + NText[2]);
}
else 
{
  Console.WriteLine("Третьей цифры нет");
}