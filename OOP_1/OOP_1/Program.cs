using System.Text;

internal class Program
{
    private static void Main()
    {
        bool a = true;
        byte b = 17;
        sbyte c = -100;
        char d = 's';
        decimal e = 10 / 3;
        double f = 4.22222;
        float g = 5.722222F;
        int iValue = 8;
        uint uiValue = 100000;
        nint k = 5;
        nuint l = 15;
        long m = 4444;
        ulong n = 555;
        short o = 32767;
        ushort p = 65535;
        a = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine(a);
        d = Convert.ToChar(Console.ReadLine());
        Console.WriteLine(d);
        iValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(iValue);
        b = Convert.ToByte(Console.ReadLine());
        Console.WriteLine(b);
        c = Convert.ToSByte(Console.ReadLine());
        Console.WriteLine(c);
        e = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine(e);
        f = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(f);
        g = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine(g);
        uiValue = Convert.ToUInt32((Console.ReadLine()));
        Console.WriteLine(uiValue);
        k = nint.Parse(Console.ReadLine());
        Console.WriteLine(k);
        l = nuint.Parse(Console.ReadLine());
        Console.WriteLine(l);
        m = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine(m);
        n = Convert.ToUInt64(Console.ReadLine());
        Console.WriteLine(n);
        o = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(o);
        p = Convert.ToUInt16(Console.ReadLine());
        Console.WriteLine(p);
        Console.WriteLine("\n");



        f = f + iValue;
        Console.WriteLine(f.GetType());
        g = g + iValue;
        Console.WriteLine(g.GetType());
        iValue = iValue * b;
        Console.WriteLine(iValue.GetType());
        m = m + iValue;
        Console.WriteLine(m.GetType());
        iValue = iValue + b;
        Console.WriteLine(iValue.GetType());
        Console.WriteLine();


        iValue = 13;
        object BoxedInt = iValue;
        Console.WriteLine(BoxedInt);
        int UnboxedInt = (int)BoxedInt;
        

        var str = "Hello";
        Console.WriteLine(str);

        int? nValue = null;
        if (nValue == null)
        {
            Console.WriteLine("nvalue = null");
        }
        nValue = 15;
        Console.WriteLine(nValue + "\n");

        var letter = 'c';
        


        Console.WriteLine("aaa" == "kkk");
        string str1 = "Hello world !";
        string str2 = "Green car";
        string str3 = "Windows 7";
        Console.WriteLine(str1 + str2);
        str2 = str3;
        Console.WriteLine(str2);
        Console.WriteLine(str1.Substring(6));
        string[] words = str1.Split();
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
        Console.WriteLine(str2.Insert(8, str1));
        Console.WriteLine(str2.Replace("dows", ""));
        str2 = $"Im {iValue} years old";
        Console.WriteLine(str2);
        string? str4 = null;
        if (string.IsNullOrEmpty(str4))
        {
            Console.WriteLine("nullstring");
        }
        StringBuilder newstr = new StringBuilder();
        newstr.Append(str1);
        newstr.Remove(3, 1);
        newstr.Remove(8, 1);
        newstr.Append("-");
        newstr.Insert(0, "-");
        Console.WriteLine(newstr + "\n");


        int[,] ints = { { 2, 3 }, { 4, 5 } };
        for (int i = 0; i < ints.GetLength(0); i++)
        {
            for (int j = 0; j < ints.GetLength(1); j++)
            {
                Console.Write(ints[i, j] + "\t");
            }
            Console.WriteLine();
        }


        string[] strings = { "HELLO WWWWWWWW", "fghjkl aaaaaaaa" };
        int position;
        position = Convert.ToInt32(Console.ReadLine());
        string newstring;
        newstring = Console.ReadLine();
        strings[position] = newstring;
        foreach (var Value in strings)
        {
            Console.Write(Value+ "\t");
        }
        Console.WriteLine();



        double[][] doubles = new double[3][];
        doubles[0] = new double[] { 2.1, 2.7 };
        doubles[1] = new double[] { 1.2222, 2, 5.4 };
        doubles[2] = new double[] { 2, 2,2,7.55 };

        for (int i = 0; i < doubles.Length; i++)
        {
            for (int j = 0; j < doubles[i].Length; j++)
            {
                doubles[i][j] = Convert.ToDouble(Console.ReadLine());
            }
        }


        for (int i = 0; i < doubles.Length; i++)
        {
            for (int j = 0; j < doubles[i].Length; j++)
            {
                Console.Write(doubles [i][j] + "\t");
            }
            Console.WriteLine();
        }
        var iarray = new int[]{ 2, 4 };
        var letters = "fghjk";


        Tuple <int,string> tupleo= new Tuple<int, string>(6, "hgfds");
        var testTuple = (Age:  7, name: "hello", simb: 'w', strs:"world", cost:999);
        Console.WriteLine(testTuple);
        Console.WriteLine($"{testTuple.Item1} {testTuple.Item3} {testTuple.Item4}");
        var (item1, item2, item3, item4, item5) = testTuple;
        Console.WriteLine(tupleo.Item1);
        Console.WriteLine(item2);
        Console.WriteLine(testTuple.strs);
        int[] A = { 1, 2, 7, 11, -3 };
        Foo(A,"sad");
        Foo2();
        Foo3();

     Tuple <int,int,int,char> Foo(int[] arr,string str)
    {
        Tuple<int, int, int, char> tuple = new Tuple<int, int, int, char>(arr.Max(), arr.Min(), arr.Sum(), str[0]);
        return tuple;
    }
     void Foo2()
    {
        int a = int.MaxValue;
        int result = checked(++a);
    }
     void Foo3()
    {
        int a = int.MaxValue;
        int result = unchecked(++a);
    }

    }

 
}