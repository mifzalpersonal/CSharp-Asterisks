using System;


class Program
{
    static void Main()
    {
        int tinggi;


        Console.Write("Masukkan tinggi piramida: ");
        tinggi = int.Parse(Console.ReadLine());


        for (int i = 1; i <= tinggi; i++)
        {
           
            for (int j = 1; j <= tinggi - i; j++)
            {
                Console.Write(" ");
            }


           
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }


           
            Console.Write("  "); 


           
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }


            Console.WriteLine(); 
        }
    }
}
