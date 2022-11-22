Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = (-1) * n; i <= n; i++)
  Console.Write($"{i} "); //интерполяция(при выводе все значения будут в одной строке). Можно записать как Console.Write(i + " "); Обязательно в двойных кавычках пробел.
  

