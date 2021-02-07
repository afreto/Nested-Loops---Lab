using System;

namespace _04._Sum_of_Two_Numbers
{
class Program
{
static void Main(string[] args)
{

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());
int count = 0;
for (int i = num1; i <=num2; i++)
{
for (int j = num1; j <=num2; j++)
{
count++;
if (i+j==magicNumber)
{
Console.WriteLine($"Combination N:{count} ({i} + {j} = {magicNumber})");
return;
}
}
}
Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
}
}
}