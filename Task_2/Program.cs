﻿Console.WriteLine("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (n > 0)
{
    sum += n % 10;
    n /= 10;
}
Console.WriteLine(sum);