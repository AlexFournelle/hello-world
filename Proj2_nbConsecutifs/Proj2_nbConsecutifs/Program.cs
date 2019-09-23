using System;

namespace Proj2_nbConsecutifs
{
/* 
 * Lire des nombres tant qu'ils sont consécutifs et n'ont pas la valeur 999
 * Exercice scolaire java, refait pour apprivoiser C#
 */
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration des variables
            int nbTest, nb;
            bool interruption;

            // Saisie du premier nombre
            Console.WriteLine("SVP, entrez un nombre de départ (999 pour sortir): ");
            nbTest = Convert.ToInt32(Console.ReadLine());

            // Filtre immédiatement la valeur de sortie (999)
            if (nbTest != 999) {
                /* La boucle va considérer comme consécutives les valeurs
                ordonnées normalement ou à rebours */
                interruption = false;
                while (interruption == false) {
                    Console.WriteLine("SVP, entrez un nouveau nombre (999 pour sortir): ");
                    nb = Convert.ToInt32(Console.ReadLine());

                    if (((nbTest - nb == 1) || (nbTest - nb == -1)) && (nbTest != 999)) {
                        nbTest = nb;
                    }
                    else { interruption = true; }
                }
            }
            Console.WriteLine("Séquence interrompue. Merci, à bientôt.");
            Console.ReadLine(); // Pour garder la console ouverte
        }
    }
}
