using System;

class Program
{
    static void Main()
    {
        int jämnaTal = 0; 

        Console.WriteLine("Skriv in 10 heltal:");

        
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Ange tal {i}: ");
            int tal = int.Parse(Console.ReadLine());

            
            if (tal % 2 == 0)
            {
                jämnaTal++; 
            }
        }

        
        Console.WriteLine($"Antalet jämna tal du skrev in är: {jämnaTal}");
    }
}

