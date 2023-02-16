Console.Clear();

int num = new Random().Next(100, 1000);
Console.WriteLine($"Число: {num}");
int secondValue = (num / 10) % 10;
Console.WriteLine(secondValue);