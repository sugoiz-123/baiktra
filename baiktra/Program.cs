using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];
        Console.WriteLine("Nhap gia tri cua cac phan tu: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu thu: {i + 1}: ");
            a[i] = int.Parse(Console.ReadLine());
        }
        int max = a[0];
        int vitri = 0;

        for (int i = 1; i < n; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
                vitri = i;
            }
        }
        Console.WriteLine("----------------------------");
        Console.WriteLine($"Phan tu lon nhat la: {max}");
        Console.WriteLine($"Vi Tri: {vitri + 1}");
    }
}
