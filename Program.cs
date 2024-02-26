using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleziona un'operazione:");
        Console.WriteLine("1. Addizione");
        Console.WriteLine("2. Sottrazione");
        Console.WriteLine("3. Moltiplicazione");
        Console.WriteLine("4. Divisione");
        
        int scelta = Convert.ToInt32(Console.ReadLine());

        double risultato = 0;

        switch (scelta)
        {
            case 1:
                risultato = Somma();
                break;
            case 2:
                risultato = Sottrazione();
                break;
            case 3:
                risultato = Moltiplicazione();
                break;
            case 4:
                risultato = Divisione();
                break;
            default:
                Console.WriteLine("Scelta non valida");
                break;
        }

        Console.WriteLine($"Il risultato è: {risultato}");
    }

    static double Somma()
    {
        Console.WriteLine("Inserisci il primo numero:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Inserisci il secondo numero:");
        double b = Convert.ToDouble(Console.ReadLine());
        return a + b;
    }

    static double Sottrazione()
    {
        Console.WriteLine("Inserisci il primo numero:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Inserisci il secondo numero:");
        double b = Convert.ToDouble(Console.ReadLine());
        return a - b;
    }

    static double Moltiplicazione()
    {
        Console.WriteLine("Inserisci il primo numero:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Inserisci il secondo numero:");
        double b = Convert.ToDouble(Console.ReadLine());
        return a * b;
    }

    static double Divisione()
    {
        Console.WriteLine("Inserisci il dividendo:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Inserisci il divisore:");
        double b = Convert.ToDouble(Console.ReadLine());
        if (b == 0)
        {
            Console.WriteLine("Impossibile dividere per zero.");
            return 0;
        }
        return a / b;
    }
}
