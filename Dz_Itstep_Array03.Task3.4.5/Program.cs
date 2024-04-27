class Program
{
    static void Main(string[] args)
    {
        //Task 3
        //int[] a = new int[5];

        //Console.WriteLine("Enter the 5 numbers(a): ");
        //for (int i = 0; i < a.Length; i++)
        //{
        //    a[i] = int.Parse(Console.ReadLine());
        //}
        //Console.WriteLine("A: ");
        //for (int i = 0; i < a.Length; i++)
        //{
        //    Console.Write(a[i] + " ");
        //}
        //Console.WriteLine();
        //int sumA = 0;
        //foreach (var item in a)
        //{
        //    sumA += item;
        //}
        //int dobytokA = 1;
        //foreach (var item in a)
        //{
        //    dobytokA *= item;
        //}
        //Console.Write("Even num A: ");
        //for (int i = 0; i < a.Length; i++)
        //{
        //    if (a[i] % 2 == 0)
        //    {
        //        Console.Write(a[i] + " ");
        //    }
        //}
        //int[,] b = new int[3, 4];
        //console.writeline("b: ");
        //random rnd = new random();
        //for (int i = 0; i < b.getlength(0); i++)
        //{
        //    for (int j = 0; j < b.getlength(1); j++)
        //    {
        //        b[i, j] = rnd.next(1, 100);
        //    }
        //}
        //for (int i = 0; i <= b.getupperbound(0); i++)
        //{
        //    for (int j = 0; j <= b.getupperbound(1); j++)
        //    {
        //        console.write(b[i, j] + " ");
        //    }
        //    console.writeline();
        //}
        //int maxB = b[0, 0];
        //for (int i = 0; i < b.GetLength(0); i++)
        //{
        //    for (int j = 0; j < b.GetLength(1); j++)
        //    {
        //        if (b[i, j] > maxB)
        //        {
        //            maxB = b[i, j];
        //        }
        //    }
        //}
        //int minB = b[0, 0];
        //for (int i = 0; i < b.GetLength(0); i++)
        //{
        //    for (int j = 0; j < b.GetLength(1); j++)
        //    {
        //        if (b[i, j] < minB)
        //        {
        //            minB = b[i, j];
        //        }
        //    }
        //}
        //int sumaB = 0;
        //foreach (var item in b)
        //{
        //    sumaB += item;
        //}
        //int dobytokB = 1;
        //foreach (var item in b)
        //{
        //    dobytokB *= item;
        //}
        //Console.Write("Not even num B: ");
        //for (int i = 0; i < b.GetLength(0); i++)
        //{
        //    for (int j = 0; j < b.GetLength(1); j++)
        //    {
        //        if (b[i, j] % 2 != 0)
        //        {
        //            Console.Write(b[i, j] + " ");
        //        }
        //    }
        //}
        //Console.WriteLine("\nDobytokB: " + dobytokB);
        //Console.WriteLine("DobytokA: " + dobytokA);
        //Console.WriteLine("Max element A: " + a.Max());
        //Console.WriteLine("Min element A: " + a.Min());
        //Console.WriteLine("Zagalna Sum A: " + sumA);
        //Console.WriteLine("Max B: " + maxB);
        //Console.WriteLine("Min B: " + minB);
        //Console.WriteLine("Zagal B: " + sumaB);

        //Task 4
        //int[,] arr = new int[5, 5];
        //Random rnd = new Random();
        //for (int i = 0; i < arr.GetLength(0); i++)
        //{
        //    for (int j = 0; j < arr.GetUpperBound(1); j++)
        //    {
        //        arr[i, j] = rnd.Next(-100, 100 + 1);
        //    }
        //}
        //for (int i = 0; i <= arr.GetUpperBound(0); i++)
        //{
        //    for (int j = 0; j < arr.GetUpperBound(1); j++)
        //    {
        //        Console.Write(arr[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //int max = arr[0, 0];
        //int min = arr[0, 0];
        //foreach (int item in arr)
        //{
        //    if (item > max)
        //        max = item;
        //    if (item < min)
        //        min = item;
        //}
        //int num = 0;
        //bool flagMin = false;
        //foreach (int item in arr)
        //{
        //    if (item == min)
        //        flagMin = true;
        //    else if (item == max)
        //        break;
        //    else if (flagMin)
        //    {
        //        num += item;
        //    }
        //}
        //Console.WriteLine("Min element: " + min);
        //Console.WriteLine("Max element: " + max);
        //Console.WriteLine("The sum of the elements between the minimum and maximum: " + num);

        //Task 5
        int[] arr = new int[10] { 15, 2, 3, 44, 53, 6, 7, 8, 9, 10 };
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Min: " + arr.Min());
        int count = 0;
        foreach (int item in arr)
        {
            if (item - arr.Min() == 5 || arr.Min() - item == 5)
            {
                count++;
            }
        }
        Console.WriteLine($"The number of elements that differ from the minimum by 5: {count}");
    }
}

