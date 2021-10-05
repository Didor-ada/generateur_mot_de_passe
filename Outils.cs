using System;
using System.Collections.Generic;
using System.Text;

// FormationCS.outils.DemanderNombrePositifNonNul

namespace FormationCS
{
    static class Outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue, "Erreur : le nombre doit être positif et non nul.");
        }


        public static int DemanderNombreEntre(string question, int min, int max, string messageErreurPersonnalise = null) // = "" rend le paramètre optionnel
        {
            // DemanderNombre(question)
            // Si le nombre est bien entre min et max -> ERREUR / boucler

            int nombre = DemanderNombre(question);
            if ((nombre >= min) && (nombre <= max))
            {
                // valide
                return nombre;
            }
            if (messageErreurPersonnalise == null)
            {
                Console.WriteLine("Erreur : le nombre doit être compris en " + min + " et " + max);
            }
            else
            {
                Console.WriteLine(messageErreurPersonnalise);
            }

            Console.WriteLine();

            return DemanderNombreEntre(question, min, max);
        }


        static int DemanderNombre(string question)
        {
            //poser la question
            //réupérer la réponse
            //convertir
            //gérer l'erreur de conversion
            //boucler tant qu'on a pas reçu une réponse valide (qui contient des chiffres)
            while (true)
            {
                Console.WriteLine(question);
                string reponse = Console.ReadLine();
                try
                {
                    int reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine("Erreur : vous devez rentrer un nombre");
                    Console.WriteLine();
                }
            }
        }
    }
}
