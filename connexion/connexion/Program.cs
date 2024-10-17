using System.Runtime.InteropServices.Marshalling;

class My_Class
{
    public static void Main(string[] args)
    {
        Connexion();
    }

    public static void Connexion() {
        bool end;
        Console.WriteLine("Bienvenue dans le simulateur de connexion!");
        string signIn = ObtenirReponse("creer votre identifiant");
        //création de l'identifiant 

        string password = ObtenirReponse("creer votre mot de passe");
        //creation du mot de passe

        Console.WriteLine("Inscription réussit. Veuillez-vous connecter.");
        Console.WriteLine(" ");
        Connexion();
        

       



        string ObtenirReponse(string message)
        {
            string informationConnexion = "XX";
            Console.WriteLine(message);
            informationConnexion = Console.ReadLine();
            return informationConnexion;
        }
        bool Connexion()
        {
            int tentativeConnexionMax = 3;
            int numberOfTentativeConnexion = 1;

            bool estAuthentifie = false;

            Console.WriteLine($"Tentative de connexion. Vous avez {tentativeConnexionMax} essais maximum");

            while (estAuthentifie)
            {
                Console.WriteLine($"Essaie {numberOfTentativeConnexion} sur {tentativeConnexionMax}");
                estAuthentifie = Tentativeconnexion(signIn, password);
                numberOfTentativeConnexion = AfficherResultatConnexion(estAuthentifie, numberOfTentativeConnexion);
            }
            if (numberOfTentativeConnexion == tentativeConnexionMax)
            {
                Console.WriteLine("acces bloqué");
                return false;
            }
            else {
                Console.WriteLine("acces autorise");
                return true;
            }
        }
        bool Tentativeconnexion(string identifiant, string password)
        {
            string verifIdentifiant = "XXX";
            string verifPassword = "XXX";

            Console.WriteLine("Entrez votre identifiant");
            verifIdentifiant = Console.ReadLine();

            Console.WriteLine("Entrez votre mot de passe");
            verifPassword = Console.ReadLine();

            if (verifIdentifiant == identifiant && verifPassword == password)
            {

                return true;
            }

            return false;
        }

        int AfficherResultatConnexion(bool estAuthentifie, int tentative)
        {
            if (estAuthentifie)
            {
                Console.WriteLine($"Connexion réussie!");
                return tentative;
            }
            else
            {
                tentative++;
            }
            return tentative;
        }
    } 


}

