Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    Console.WriteLine("Максимальное" + a);
if (b > a)
    Console.WriteLine("Максимальное" + b);
if (a == b)
    Console.WriteLine("равны");