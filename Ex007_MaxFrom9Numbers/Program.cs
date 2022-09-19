int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int[] numbers = { 15, 21, 39, 12, 2311, 33, 13, 23, 313 };

Console.WriteLine(Max(
    Max(numbers[0], numbers[1], numbers[2]),
    Max(numbers[3], numbers[4], numbers[5]),
    Max(numbers[6], numbers[7], numbers[8])
    ));