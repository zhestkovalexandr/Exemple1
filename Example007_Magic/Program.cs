﻿Console.Clear();
//Console.SetCursorPosition(10, 4);
//System.Console.WriteLine("+");

int xa = 1, ya = 1,
    xb = 1, yb = 20,
    xc = 20, yc = 20;

Console.SetCursorPosition(xa, ya);
System.Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
System.Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
System.Console.WriteLine("+");

int x = xa, y = xb;

int count = 10;

while (count < 10000)
{
    int what = new Random().Next(0, 3); // [0;3) 0 1 2
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(what == 1)
    {
        x = (x+xb) / 2;
        y = (y+yb) / 2;
    }

    if(what == 2)
    {
        x = (x+xc) / 2;
        y = (y+yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    System.Console.WriteLine("+");
    count = count + 1;
}








