Console.WriteLine("M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("N = ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(A(M,N));

static int A(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return A(n - 1, 1);
    else
        return A(n - 1, A(n, m - 1));
}