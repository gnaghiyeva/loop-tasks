// See https://aka.ms/new-console-template for more information

Console.Write("ededi daxil edin:");
string str_number = Console.ReadLine();

int n= Convert.ToInt32(str_number);

int count = 0;
//int i = 2;
if(n==1 || n == 0)
{
    Console.Write(n + " " + "ne sade ne de murekkebdir.");
}

else
{
    for(int i=2; i < n; i++)
    {
        if (n % i == 0)
        {
            count++;
        }
    }

    if(count == 0)
    {
        Console.Write(n + " " + "sade ededir.");
    }
    else
    {
        Console.Write(n + " " + "murekkeb ededdir.");
    }
}
