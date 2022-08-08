int a1 = 2;
int b1 = 3;
int c1 = 4;
int a2 = 44;
int b2 = 34;
int c2 = 66;
int a3 = 44;
int b3 = 44;
int c3 = 777;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c3 > max) max = c3;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;
Console.WriteLine(max);