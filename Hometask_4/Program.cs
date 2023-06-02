// See https://aka.ms/new-console-template for more information
int Number = 0;
int X = 1;
Console.WriteLine("Get number");
Number = Convert.ToInt32(Console.ReadLine());
while (X < Number)
{
if(X % 2 == 0)
{
    Console.WriteLine(X);
}
X++;
}
