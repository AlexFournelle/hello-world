using System;
using System.Text;


namespace Proj1_chaines
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Declaration de l'unique variable
            int repetition;

            // Saisie de la valeur de repetition
            Console.WriteLine("Entrez un nombre de répétitions, svp: ");
            repetition = Convert.ToInt32(Console.ReadLine());

            // Initialisation d'un stringbuilder
            StringBuilder sb = new StringBuilder();
            
            // Les boucles imbriquees qui font tout le travail
            for (int i=1; i<=repetition; i++) {
                for (int i2=0; i2<i; i2++) { 
                    sb.Append('*');
                }
                sb.Append('#');
            }

            // Output du resultat
            Console.WriteLine(sb.ToString());
            Console.Read(); // So as to keep the console open
        }
    }
}
