Console.Clear();

int xa = 40, ya = 4,
    xb = 4, yb = 16,
    xd = 80, yd = 16;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xd, yd);
Console.WriteLine("+");

int x = xa, y = ya;
int count = 0;
while (count <1000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xd) / 2;
        y = (y + yd) / 2;
    }
Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count++;
}
