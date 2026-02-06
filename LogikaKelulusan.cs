using System;

class Tugas3
{
    static void Main()
    {
        Console.Write("Masukkan nilai: ");
        int nilai = Convert.ToInt32(Console.ReadLine());

        if (nilai >= 75)
        {
            Console.WriteLine("Nilai: " + nilai);
            Console.WriteLine("Status: LULUS");
        }
        else
        {
            Console.WriteLine("Nilai: " + nilai);
            Console.WriteLine("Status: TIDAK LULUS");
        }
    }
}
