Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (a >= count)
{
   if (count % 2 == 0)
      Console.WriteLine(count + ", ");
count ++;
}