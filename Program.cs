namespace annee_bissextile;

class Program
{
    static void Main(string[] args)
    {
        // Une application console qui indique si l’année (du calendrier grégorien. Par exemple, 2026) rentrée par l’utilisateur est bissextile ou non.
        // Les années bissextiles sont soit divisibles par 4 mais pas par 100, soit divisibles par 400.

        // Etape 1 : on déclare les variables
        int annee;

        // Etape 2 : on demande à l'utilisateur d'entrer une année
        Console.Write("> Veuillez insérer une année : ");
        annee = Convert.ToInt32(Console.ReadLine());

        // Etape 3 : on vérifie si l'année est divisible par 4 mais pas par 100, OU si l'année est divisible par 400
        if ((annee % 4 == 0 && annee % 100 != 0) || (annee % 400 == 0))
        {
            // Si au moins l'un de ces deux critères est respecté, l'année est bissextile
            Console.WriteLine(annee + " est une année bissextile.");
        }
        else
        {
            // Sinon, dans tous les autres cas, c'est une année commune
            Console.WriteLine(annee + " n'est pas une année bissextile.");
        }
    }
}