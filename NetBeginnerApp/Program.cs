long[] Fib = new long[100];

Console.WriteLine(Fibonachi(50));

long Fibonachi(int n)
{
    if (n < 2) return n;
    if (Fib[n] == 0)
        Fib[n] = Fibonachi(n - 1) + Fibonachi(n - 2);
    return Fib[n];
}

long Factorial(int n)
{
    if (n == 0) return 1;
    return Factorial(n - 1) * n;
}

Console.WriteLine(Sum(1, 2, 3));
Console.WriteLine(Sum(1, 2, 3, 4, 5));

int Sum(params int[] numbers)
{
    int sum = 0;
    for(int i = 0; i < numbers.Length; i++)
        sum += numbers[i];
    return sum;
}

//int n = 15;
//Func(ref n);
//Console.WriteLine(n);

//void Func(ref readonly int arg)
//{
//    //arg = 500;
//}

void Types()
{
    int in1 = 2225;

    byte b1 = 35; // 0..255
    System.Byte b2;

    b1 = (byte)in1;

    sbyte sb1 = (sbyte)b1; // -128..127
    System.SByte sb2;

    short sh1; // -32768..32767
    System.Int16 sh2;

    ushort ush1; // 0..65535
    System.UInt16 ush2;

    int i1; // -2147483648..2147483647
    System.Int32 i2;
    i1 = 123;
    i1 = 0b0101010;
    i1 = 0x123A;

    uint ui1 = 1U; // 0..4294967295
    System.UInt32 ui2;

    long l1 = 145L; // signed long
    System.Int64 l2;

    ulong ul1 = 54356UL; // unsigned long
    System.UInt64 ul2;

    float x1 = 10.5F;
    System.Single x2;

    double x3;
    System.Double x4;

    decimal x5;
    System.Decimal x6;

    char ch1;
    System.Char ch2;

    bool f1;
    System.Boolean f2;

    string s1;
    System.String s2;

    object obj1;
    System.Object obj2;

    var n = 10;
    var m = n;

    Console.WriteLine("Hello");
    Console.WriteLine("World");

    bool s = System.Int32
                   .TryParse(Console.ReadLine(),
                             out int result);
    Console.WriteLine(s);
    Console.WriteLine(result);

    int result2 = Convert.ToInt32(Console.ReadLine());

    float x10 = 10.5F;
    int result3 = Convert.ToInt32(x10);
}
