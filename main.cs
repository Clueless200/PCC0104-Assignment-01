using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a denomination: ");
        decimal bills = decimal.Parse(Console.ReadLine());

        string person = GetPersonalityFromBanknote(bills);
        if (bills != 0)
        {
            Console.WriteLine($"{person} is found in Php {bills}");
        }
        else
        {
            Console.WriteLine("No Person is found");
        }
    static string GetPersonalityFromBanknote(decimal  denomination)
    {
        string person = null;

        if (denomination == 1)
        {
            person = "Jose Rizal";
        }
        else if (denomination == 5)
        {
            person = "Emilio Aguinaldo";
        }
        else if (denomination == 10)
        {
            person = "Andres Bonifacio & Apolinario Mabini";
        }
        else if (denomination == 50)
        {
            person = "Sergio Osmena";
        }
        else if (denomination == 100)
        {
            person = "Manuel A. Roxas";
        }
        else if (denomination == 200)
        {
            person = "Diosdado Macapagal";
        }
        else if (denomination == 500)
        {
            person = "Corazon Aquino";
        }
        else if (denomination == 1000)
        {
            person = "Josefa Llanes Escoda";
        }

        return person;
    }
}
}