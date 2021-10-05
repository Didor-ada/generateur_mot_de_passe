using FormationCS;
using System;

namespace generateur_mot_de_passe
{
    class Program
    {

        
        static void Main(string[] args)
        {
            const int NB_MOTS_DE_PASSE = 10;

            // 1 - Demander la longueur du mot de passe (DemanderNombre) int longueurMotDePasse = ...
            int longueurMotDePasse = Outils.DemanderNombrePositifNonNul("Longueur du mot de passe : ");

            // Vous voulez un mot de passe avec :
            // 1 - Uniquement des caractères en minuscule
            // 2 - Des caractères minuscules et majuscules 
            // 3 - Des caractères et des chiffres 
            // 4 - Caractères, chiffres et caractères spéciaux

            Console.WriteLine();
            int choixAlphabet = Outils.DemanderNombreEntre("Vous voulez un mot de passe avec :\n" +
                "1 - Uniquement des caractères en minuscule\n" +
                "2 - Des caractères minuscules et majuscules\n" +
                "3 - Des caractères et des chiffres\n" +
                "4 - Caractères, chiffres et caractères spéciaux\n" +
                "Votre choix : ", 1, 4);

            // poser la question
            // en fonction du choix alphabet

            // 2 - Alphabet "abcd1234" 4 "1d4e" -> exemple d'enchainement aléatoire
            // 3 - comment choisir un caractère aléatoire

            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string chiffres = "0123456789";
            string caracteresSpeciaux = "#&+-";
            string alphabet;
            string motDePasse = "";

            Random rand = new Random();

            // Si un if ou elseif ou autre n'a qu'une ligne, on peut se passer d'accolades :
            if (choixAlphabet == 1)
                alphabet = minuscules;
            else if (choixAlphabet == 2)
                alphabet = minuscules + majuscules;
            else if (choixAlphabet == 3)
                alphabet = minuscules + majuscules + chiffres;
            else 
                alphabet = minuscules + majuscules + chiffres + caracteresSpeciaux;

            int longueurAlphabet = alphabet.Length;


            for (int j = 0; j < NB_MOTS_DE_PASSE; j++)
            {
                motDePasse = "";
                for (int i = 0; i < longueurMotDePasse; i++)
                {
                    int index = rand.Next(0, longueurAlphabet);
                    motDePasse += alphabet[index]; // = motDePasse = motDePasse + alphabet[index];
                }

                Console.WriteLine(" Mot de passe : " + motDePasse);
            }


            // 4 - Générer un mot de passe
            // 5 - Améliorations : choix alphabet


        }
    }
}
    