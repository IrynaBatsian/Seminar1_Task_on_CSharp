﻿Console.Clear();
Console.Write("Введите любое число: ");
// Для того, чтобы найти последнюю цифру любого числа, необходимо найти остаток при делении на 10.
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(n % 10);

