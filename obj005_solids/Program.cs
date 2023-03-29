Console.Clear();
Console.Write("n: ");
int n = int.Parse(Console.ReadLine());
for (int i = -n; i < n + 1;i++){
    Console.Write($"{i}");
}