/*Cette classe est une classe de base permettant de représenter un joueur qui sera représenté par un Nom et un
type de jeton (X ou O). Prévoir les accesseurs ainsi que le constructeur de cette classe. Elle devra avoir les
méthodes suivantes :
- int GetColonne() : permet au joueur de choisir la colonne ou jouer et qui retourne la colonne choisie.
- void Jouer(Grille grille) : cette méthode sera réécrite dans les classe JoueurHumain et JoueurIA. Elle
permet pour le JoueurHumain de choisir la colonne ou jouer et si celle-ci est valide de positionner le
jeton dans la grille. Pour le JoueurIA elle permet de sélectionner une colonne ou jouer suivant
l'algorithme IA et de positionner le jeton. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPuissance4
{
    class Joueur
    {
        //Attributs
        protected string nom;
        protected char typeJeton;

        //Getter et Setter
        protected string Nom { get => nom; set => nom = value; }
        protected char TypeJeton { get => typeJeton; set => typeJeton = value; }
        // Constructeur :
        public Joueur()
        {
        }
        public Joueur(string nom, char typeJeton)
        {
            this.nom = nom;
            this.typeJeton = typeJeton;
        }
        //Méthodes : 
        // méthode qui permet au joueur de choisir la colonne avec un TryParse qui permet d'éviter les bug en cas de mauvaise entrée.
        public int GetColonne() {
            Console.WriteLine("Choisissez une colonne pour jouer (1 à 7)");
            string s =  Console.ReadLine();
            int colonne = 0;
            bool okey = int.TryParse(s, out colonne);
            // while permettant choix uniquement entre 1 et 7
            while (colonne<1 || colonne>7|| okey == false){
                Console.WriteLine("Ce n'est pas un int ou ne pas entrer 0");
                s = Console.ReadLine();
                okey = int.TryParse(s, out colonne);
            }
            return Convert.ToInt32(s);
        }
        // méthode annonçant à qui est le tour de jouer
        public virtual void Jouer(Grille grille) {
            Console.WriteLine("C'est au tour de " + this.nom + " de jouer !");
        }
    }
}
