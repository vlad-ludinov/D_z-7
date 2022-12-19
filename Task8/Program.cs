using static System.Console;

int number = int.Parse(ReadLine());
int count = 1;

while (count <= number)
{
    if (number - count > 1 && count % 2 == 0)
    {
        Write($"{count}, ");
    }
    else
    {
        if (count % 2 == 0)
        {
            Write(count);
        }
    }
    count+=1;
}
