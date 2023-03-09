int a = 5;
int b = 7;

int max1 = a;
if (a > max1) max1 = a;
if (b > max1) max1 = b;

Console.Write("из ");
Console.Write(a);
Console.Write(" и ");
Console.Write(b);
Console.Write(" max = ");
Console.WriteLine(max1);


int c = 2;
int d = 10;

int max = c;
if (c > max) max = c;
if (d > max) max = d;

Console.Write("из ");
Console.Write(c);
Console.Write(" и ");
Console.Write(d);
Console.Write(" max = ");
Console.WriteLine(max);


int f = -9;
int g = -3;

int max2 = f;
if (f > max2) max2 = f;
if (g > max2) max2 = g;

Console.Write("из ");
Console.Write(f);
Console.Write(" и ");
Console.Write(g);
Console.Write(" max = ");
Console.WriteLine(max2);