Console.WriteLine("Input number of bushes 3 =< N =< 1000: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];

if (N < 3 || N > 1000)
    Console.WriteLine("error");
else
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 1001);
        Console.Write(arr[i] + " ");
    }

Console.WriteLine();
int max = arr[0];
int maxIndex = 0;
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
        maxIndex = i;
    }
}

int sum = arr[maxIndex] + arr[maxIndex - 1] + arr[maxIndex + 1];
Console.WriteLine(sum);
