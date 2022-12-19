using static System.Console;

int number = int.Parse(ReadLine());
int count = 1;

if (number > 0)
{
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
}
else
{
    while (count >= number)
    {
        if (number - count < -1 && count % 2 == 0)
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
        count-=1;
    }
}
