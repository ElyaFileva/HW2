Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num / 10 == 0 || num / 100 == 0)
{
  Console.WriteLine("Третьей цифры нет");
}
else
{
  while (num != 0)
  {
    if (num / 1000 == 0)
    {
      Console.WriteLine(Math.Abs(num % 10));
      break;
    }
    else
    {
      num = num / 10;
    }
  }
}