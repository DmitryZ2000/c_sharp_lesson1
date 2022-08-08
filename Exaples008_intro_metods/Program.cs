int Max(int arg1, int arg2, int arg3)
{
   int res = arg1;
   if (arg2 > res)  res = arg2;
   if (arg3 > res)  res = arg3;
   return res;
}

int a1 = 2;
int b1 = 3;
int c1 = 4;
int a2 = 44;
int b2 = 3455;
int c2 = 66;
int a3 = 44;
int b3 = 44;
int c3 = 777;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

int max = Max(
            Max(a1, b1, c1), 
            Max(a2, b2, c2), 
            Max(a3, b3, c3));
Console.WriteLine(max);