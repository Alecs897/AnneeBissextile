namespace annee_bissextile;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quel est ton année ?");
        int annee = Convert.ToInt32(Console.ReadLine());

        if ((annee % 4 == 0 && annee % 100 != 0) || (annee % 400 == 0))
        {
            Console.WriteLine(annee + " est une année bissextile.");
        }
        else
        {
            Console.WriteLine(annee + " n'est pas une année bissextile.");
        }
        // Une application console qui indique si l’année (du calendrier grégorien. Par exemple, 2026) rentrée par l’utilisateur est bissextile ou non.
        // Les années bissextiles sont soit divisibles par 4 mais pas par 100, soit divisibles par 400.

    }
}