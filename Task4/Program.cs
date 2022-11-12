Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine (+ a > + b);
}
else
{
 Console.WriteLine (+ b > + a);   
}
if (a > c)
{
    Console.WriteLine(+ a > + c);
}
else
{
    Console.WriteLine(+ c > + a);
}
if (b > c)
{
    Console.WriteLine(+ b > + c);
}
else
{
    Console.WriteLine(+ c > + b);
}