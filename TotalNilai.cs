using System;

class Tugas4
{
    static void Main()
    {
        Console.Write("Berapa jumlah nilai? ");
        int jumlah = Convert.ToInt32(Console.ReadLine());

        int[] nilai = new int[jumlah];
        int total = 0;

        for (int i = 0; i < jumlah; i++)
        {
            Console.Write("Masukkan nilai ke-" + (i + 1) + ": ");
            nilai[i] = Convert.ToInt32(Console.ReadLine());
            total += nilai[i];
        }

        double rata = (double)total / jumlah;

        Console.WriteLine("Total: " + total);
        Console.WriteLine("Rata-rata: " + rata);
    }
}