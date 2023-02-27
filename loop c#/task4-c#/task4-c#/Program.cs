// See https://aka.ms/new-console-template for more information



Console.Write("en=");
string str_number1 = Console.ReadLine();
int x = Convert.ToInt32(str_number1);

Console.Write("uzunluq=");
string str_number2 = Console.ReadLine();
int y = Convert.ToInt32(str_number2);

for (int i = 1; i <= x; i++)
{
    for (int j = 1; j <= y; j++)
    {
        if (i == 1 || i == x ||
            j == 1 || j == y)
            Console.Write("*");
        else
            Console.Write(" ");
    }
    Console.WriteLine();
}
