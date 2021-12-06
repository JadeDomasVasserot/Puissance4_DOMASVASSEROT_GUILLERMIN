/*Cette classe héritera de la classe Jeu et implémentera le jeu Puissance 4 avec une méthode Démarrer
permettant de démarrer le jeu et de proposer au joueur de recommencer une nouvelle partie. Elle permettra
aussi de demander au joueur si celui-ci veux jouer contre l'ordinateur ou contre un autre joueur humain. Elle
indiquera enfin le résultat de la partie. Une boucle permettra de faire jouer les deux joueurs jusqu'à ce qu'il y ai
un gagnant ou que la grille soit totalement remplie sans avoir de gagnant. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPuissance4
{
    class Puissance4 : Jeu
    {
        //Attributs
        public Puissance4(string nom){}
        //Méthodes 
        public void Demarrer() { 
        bool enCours = true;
        string txt = "";
        int choix = 0;
            while (enCours == true)
            {
            Console.WriteLine("Bienvenue dans le puissance 4 \npour commencer une partie appuyer sur une touche ! :)\n");
            Console.ReadKey();
            Console.WriteLine("-----------------  MENU  ------------------- \n" +
            "1)Jouer contre une IA \n" +
            "2)Jouer contre une autre joueur \n" +
            "Veuillez choisir votre mode de jeu \n");
               
                bool okey = int.TryParse(txt, out choix);
            while (choix < 1 || choix > 2 || okey == false)
            {
                Console.WriteLine("Rentrez seulement 1 ou 2 \n");
                 txt = Console.ReadLine();
                 okey = int.TryParse(txt, out choix);
            }
            choix = Convert.ToInt32(txt);
            Console.WriteLine("La partie peut commencer  \n");
            Grille grille = new Grille();
            grille.Play = true;
            grille.Init();
            grille.Afficher();
            
            while (choix == 1 && grille.Play == true) //mode de jeu avec l'ordi
            {
                JoueurHumain Humain = new JoueurHumain("Pac", 'X');
                JoueurIA Ordi = new JoueurIA("OrdiJade", 'O');
                Humain.Jouer(grille);
                grille.Afficher();
                    if (grille.Play == true)
                    {
                        Ordi.Jouer(grille);
                        grille.Afficher();
                    }
                    
            }
            while (choix == 2 && grille.Play == true) // mode de jeu avec un autre joueur
            {
                JoueurHumain Jade = new JoueurHumain("Jade", 'X');
                JoueurHumain Pac = new JoueurHumain("Pac", 'O');
                Jade.Jouer(grille);
                grille.Afficher();
                    if (grille.Play == true)
                    {
                        Pac.Jouer(grille);
                        grille.Afficher();
                    }
            }
            enCours = false;
            Console.WriteLine("Fin de la partie  \n" +
            "Souhaitez-vous rejouer ? \n");
                string rejouer = "";
                int choixRejouer = 0;
                bool rejoue  = int.TryParse(rejouer, out choixRejouer);
                while (choixRejouer < 1 || choixRejouer > 2 || rejoue == false)
                {
                    Console.WriteLine("Rentrez seulement 1 (rejouer) ou 2 (quitter)\n");
                    rejouer = Console.ReadLine();
                    rejoue = int.TryParse(rejouer, out choixRejouer);
                }
                choixRejouer = Convert.ToInt32(rejouer);
                if (choixRejouer == 1) {
                    enCours = true;
                }
                else
                {
                    enCours = false;
                }

            }
            Console.WriteLine("Bye bye :)\n");
            Console.ReadKey();





        }



    }
}
