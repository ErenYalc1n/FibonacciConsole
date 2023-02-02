int a = 1, b = 1, c, i;
Console.Write("Fibonacci basamak sayısını giriniz: ");
i=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a);
Console.WriteLine(b);
for(int j=2; j<i; j++)
{
    c = a + b;
    a = b;
    b = c;
    Console.WriteLine(c);
}


