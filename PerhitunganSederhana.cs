using System;

class Tugas2
{
    static void Main()
    {
        Console.Write("Masukkan bilangan pertama: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan bilangan kedua: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int tambah = a + b;
        int kurang = a - b;
        int kali = a * b;
        double bagi = (double)a / b;

        Console.WriteLine("Tambah: " + tambah);
        Console.WriteLine("Kurang: " + kurang);
        Console.WriteLine("Kali: " + kali);
        Console.WriteLine("Bagi: " + bagi);
    }
}
