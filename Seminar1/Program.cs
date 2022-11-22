Console.Clear();
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0 || n % 3 == 0)
  Console.Write("YES");
else
  Console.Write("NO");