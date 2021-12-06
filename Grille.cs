using System;
using System.Collections.Generic;
using System.Linq;
/*Cette classe permettra de gérer la grille du jeu. La grille sera constituée d'un tableau de char à 2 dimensions
constituées de 6 lignes et 7 colonnes. Elle aura une méthode permettant d'afficher à chaque tour la grille et le
choix effectué par chaque joueur. Elle devra avoir les méthodes suivantes :
- void Init() : permet d'initialiser la grille avec la valeur 0 dans chaque cellule.
- void Afficher() : permet d'afficher la grille avec le choix de chaque joueur
- char TestGagner() : retourne le joueur gagnant si un joueur à fait une ligne ou une diagonale de 4
jetons de suite.
- int GetLigne(int colonne) : permet de trouver la ligne disponible à partir d'une colonne.
- void Positionner(int ligne, int colonne, char jeton) : permet de positionner un jeton dans la grille
suivant la ligne et la colonne. 
*/
using System.Text;
using System.Threading.Tasks;

namespace TPPuissance4
{
    class Grille
    {
        //Attributs

        private char[,] array = new char[6, 7];
        private bool play = false;
        //Getter et Setter
        public char[,] Array { get => array; set => array = value; }
        public bool Play { get => play; set => play = value; }

        // Constructeur
        public Grille()
        {
        }

        public Grille(char[,] array)
        {
            this.array = array;
        }

        //Méthodes
        //méthode afin d'instancier les valeurs du tableau à 0
        public void Init() 
        {
            //on itére pour les colonnes
            for (int i = 0; i < 7; i++)
            {
                // on itére pour les lignes
                for (int j = 0; j < 6; j++)
                {
                    // on associe au tableau à lignes j et colonnes i la valeur d'une string vide
                    Array[j, i] = ' ';
                }
            }
        }
        // méthode afficher qui permet d'afficher le tableau :  on créé notre tableau en string puis on insère les valeurs dans les différentes casses
        public void Afficher()
        {
             Console.WriteLine("  1   2   3   4   5   6   7");
            //pour la ligne 1 à index 0
            Console.WriteLine("+---+---+---+---+---+---+---+");
            Console.WriteLine("| "+ Array[0, 0]+ " | "+ Array[0, 1]+ " | "+ Array[0, 2]+ " | "+ Array[0, 3]+ " | "+ Array[0, 4]+ " | "+ Array[0, 5]+ " | "+ Array[0, 6]+ " |");
            // pour la ligne 2 à index 1
            Console.WriteLine("+---+---+---+---+---+---+---+");
            Console.WriteLine("| "+ Array[1, 0]+ " | "+ Array[1, 1]+ " | "+ Array[1, 2]+ " | "+ Array[1, 3]+ " | "+ Array[1, 4]+ " | "+ Array[1, 5]+ " | "+ Array[1, 6]+ " |");
            Console.WriteLine("+---+---+---+---+---+---+---+");
            Console.WriteLine("| "+ Array[2, 0]+ " | "+ Array[2, 1]+ " | "+ Array[2, 2]+ " | "+ Array[2, 3]+ " | "+ Array[2, 4]+ " | "+ Array[2, 5]+ " | "+ Array[2, 6]+ " |");
            Console.WriteLine("+---+---+---+---+---+---+---+");
            Console.WriteLine("| "+ Array[3, 0]+ " | "+ Array[3, 1]+ " | "+ Array[3, 2]+ " | "+ Array[3, 3]+ " | "+ Array[3, 4]+ " | "+ Array[3, 5]+ " | "+ Array[3, 6]+ " |");
            Console.WriteLine("+---+---+---+---+---+---+---+");
            Console.WriteLine("| "+ Array[4, 0]+ " | "+ Array[4, 1]+ " | "+ Array[4, 2]+ " | "+ Array[4, 3]+ " | "+ Array[4, 4]+ " | "+ Array[4, 5]+ " | "+ Array[4, 6]+ " |");
            Console.WriteLine("+---+---+---+---+---+---+---+");
            Console.WriteLine("| "+ Array[5, 0]+ " | "+ Array[5, 1]+ " | "+ Array[5, 2]+ " | "+ Array[5, 3]+ " | "+ Array[5, 4]+ " | "+ Array[5, 5]+ " | "+ Array[5, 6]+ " |");
            Console.WriteLine("+---+---+---+---+---+---+---+");
            Console.WriteLine("  1   2   3   4   5   6   7");
        }
        // méthode permettant de récupérer et retourner la ligne
        public int GetLigne(int colonne)
        {
            // on itéère sur les lignes en commançant par la dernière et on fait i--pour aller jusqu'à la 1ère ligne
            for (int i = 5; i >= 0; i--)
            {
                // on récupère la ligne qui est vide (avec une string vide) en partant de la ligne 5 puis on la retourne
                if (array[i, colonne] == ' ')
                {
                    return i;
                }
            }
            return -1;
        }    
        // méthode qui permet de positionner le jeton du joueur dans le tableau.
        public int[] Positionner(int ligne, int colonne, char jeton )
        {
            //positionne le jeton dans l'array à l'index ligne et à l'index colonne
            array[ligne, colonne] = jeton;
            // on créé un tableau ligne colonne qu'on va return afin de s'en servir dans TestGagner afin de récupérer à récupérer la ligne et colonne du dernière pion placé
            int[] ligneColonne = { ligne, colonne};
            return ligneColonne;
        }


        public Joueur TestGagner(Joueur joueur, int[] ligneColonne) {
            // for sur les lignes
            bool gagner = false;
            for (int i = 1; i <= 3; i++)
            {
                if (ligneColonne[0] + i <= 5 && Array[ligneColonne[0],ligneColonne[1]] == Array[ligneColonne[0]+i,ligneColonne[1]]) {
                    if (i == 3) {
                        gagner = true;
                    }
                }
                else { break; }

            }
            for (int i = -2; i <= 1; i++)
            {
                for (int j = -1; j <= 2; j++)
                {
                    if (ligneColonne[1]+i+j >= 0 && ligneColonne[1]+i+j <= 6 && Array[ligneColonne[0],ligneColonne[1]] == Array[ligneColonne[0],ligneColonne[1]+i+j]) {
                        if (j == 2) {
                            gagner = true;
                        }
                    }
                    else {break;}
                }
            }
            for (int i = -2; i <= 1; i++)
            {
                for (int j = -1; j <= 2; j++)
                {
                    if (ligneColonne[1]+i+j >= 0 && ligneColonne[1]+i+j <= 6 && ligneColonne[0]+i+j > 0 && ligneColonne[0]+i+j <= 5 && Array[ligneColonne[0],ligneColonne[1]] == Array[ligneColonne[0]+i+j,ligneColonne[1]+i+j]) {
                        if (j == 2) {
                            gagner = true;
                        }
                    }
                    else {break;}
                }
            }
            //bas à droite
            for (int i = -2; i <= 1; i++)
            {
                for (int j = -1; j <= 2; j++)
                {
                    if (ligneColonne[1]-i-j >= 0 && ligneColonne[1]-i-j <=6 && ligneColonne[0]+(i+j) >= 0 && ligneColonne[0]+(i+j) <= 5 && Array[ligneColonne[0],ligneColonne[1]] == Array[ligneColonne[0]+i+j,ligneColonne[1]-i-j]) {
                        if (j == 2) {
                            gagner = true;
                        }
                    }
                    else {break;}
                }
            }
            if (gagner)
            {
                Console.WriteLine("GAGNER !!!!!!!!!!!!!!!!!!!!!!!!!");
                play = false;
                return joueur;

            }
            else
            {
                return null;
            }
            
        }
    }
}
