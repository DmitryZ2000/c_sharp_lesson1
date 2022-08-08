int Max(int arg1, int arg2, int arg3)
{
   int res = arg1;
   if (arg2 > res)  res = arg2;
   if (arg3 > res)  res = arg3;
   return res;
}
//              0   1   2   3   4   5   6   7   8
int[] array = { 13, 23, 33, 46, 52, 16, 267, 88, 39 };
array[0] = 12;

int max = Max(
    Max(array[0],array[1],array[2]),
    Max(array[3],array[4],array[5]),
    Max(array[6],array[7],array[8])
);
Console.WriteLine(max);