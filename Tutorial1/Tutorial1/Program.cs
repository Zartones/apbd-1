
Console.WriteLine("Hello, World!333333333333");

static double Average(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum/arr.Length;
}