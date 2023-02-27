// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.Write("ededi daxil edin:");
string str_number = Console.ReadLine(); 

int n=Convert.ToInt32(str_number);

int temp,k;
int sum = 0;

temp = n;
while (n != 0)
{
    k = n % 10; //121%10=1;   12%10=2;    1%10=1
    sum = (sum * 10) + k;  //0*10+1=1;    1*10+2=12;    12*10+1=121
    n = n / 10;  //121/10=12;    12/10=1;   1/10=0

}

if (temp == sum)
{
    Console.Write(temp + " " + "palindrom ededdir");
}

else
{
    Console.Write(temp + " " + "palindrom eded deyil");
}
