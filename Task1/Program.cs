// Задайте значения M и N. Напишите программу, которая выведет 
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int InputNumbers(string input) 
{
  Console.Write(input);
  return Convert.ToInt32(Console.ReadLine());
}
void PrintSumm(int m, int n)
{
  if (n<m) return;
  PrintSumm(m, n-1);
  if (n%2==0) System.Console.Write(n +"; ");
}

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

PrintSumm(m, n);