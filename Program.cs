Задача 1
Console.Clear();
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int NaturalNumber(int n, int m)
{
  if (n == m) return n;
  else Console.Write($"{NaturalNumber(n, m + 1)}, ");
  return m;
}

int n = Prompt("Input N: ");
if (n < 1)
{
  Console.WriteLine("Ввдите положительное число!");
  return;
}
Console.WriteLine(NaturalNumber(n, 1));

Задача 2

void Mton(int n, int m)
{
    if(m != n)
    {
        if(n > m)
        {
            Mton(n - 1, m);
            System.Console.WriteLine(n + " ");
        } else
        {
            Mton(n, m - 1);
            System.Console.WriteLine(m + " ");
        }
    }
    else
    System.Console.WriteLine(n + " ");
}

Mton (1, 15);

Задача 3

int AkermanFn(int m, int n)
{
    if(n == 0) return n + 1;
    if(m > 0 && m == 0) return
    AkermanFn(m - 1, 1);
    if(m> 0 && n > 0) return
    AkermanFn(m - 1, AkermanFn(m, n - 1));
    return 0;
}

System.Console.WriteLine(" Введите неотрицательное число N: ");
System.Console.WriteLine(" Введите неотрицательное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
AkermanFn(m, n);