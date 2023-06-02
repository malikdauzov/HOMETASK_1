// See https://aka.ms/new-console-template for more information
int Number = 0;
Console.WriteLine("Get number");
Number = Convert.ToInt32(Console.ReadLine());
if (Number % 2 == 0)
{
    Console.WriteLine("Number is even");
}
else
{
    Console.WriteLine("Number is odd ");
}

