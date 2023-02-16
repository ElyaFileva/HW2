Console.Clear();

int num = new Random().Next(1, 8);
bool day = true;
Console.Write($"Число: {num}, выходной день: ");
if (num >= 6)
  Console.WriteLine(day);
else
  Console.WriteLine(!day);