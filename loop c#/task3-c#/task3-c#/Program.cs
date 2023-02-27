// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;

Console.Write("ededi daxil edin:");
string str_number = Console.ReadLine(); 

int n= Convert.ToInt32(str_number);

int sum = 0;
int j;

for(int i=2; i < n; i++)
{
    for (j = 2; j < i; j++)
    {
        if (i % j == 0)
            break;
    }
    if (i == j)
    sum += i;
}
Console.Write(sum); 


