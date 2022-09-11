Console.WriteLine("Input two numbers: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int X = A;

for(int i = 2; i <= B; i++)
{
    X = X * A;
}
Console.WriteLine(X);
