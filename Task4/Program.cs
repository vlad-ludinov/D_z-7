using static System.Console;

int a = int.Parse(ReadLine());
int b = int.Parse(readLine());
int c = int.Parse(ReadLine());

if (a >= b && a >= c)
{
    max = a;
}
else
    if (c >= b)
    {
        max = c;
    }
    else
    {
        max = b;
    }