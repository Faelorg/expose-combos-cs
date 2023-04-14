internal class Program
{

    public int Factorial(int n)
    {
        if (n == 1) return 1;

        return n * Factorial(n - 1);
    }


    public static int CountUnique(int num)
    {
        List<Char> duplicates = num.ToString().ToCharArray().ToList();
        List<Char> tmpd = new List<char>();
        foreach (var d in duplicates)
        {
            if (!tmpd.Contains(d))
            {
                tmpd.Add(d);
            }
        }

        return tmpd.Count;
    }


    private static void Main(string[] args)
    {
        int num = int.Parse(System.Console.ReadLine());

        int length = num.ToString().ToCharArray().Length;
        //System.Console.WriteLine(num);
        Console.WriteLine(CountUnique(num));
    }



}