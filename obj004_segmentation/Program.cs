Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
double num=double.Parse(Console.ReadLine());
double y=num%10;

Console.WriteLine($"{y}");