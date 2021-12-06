/*Cette classe héritera de la classe Joueur. Elle devra implémenter la méthode Jouer qui doit mettre en place
l'algorithme IA afin de permettre à l'ordinateur de choisir une colonne ou jouer et de positionner le jeton.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPuissance4
{
    class JoueurIA : Joueur
    {
        public JoueurIA(string nom, char typeJeton) : base(nom, typeJeton) { }
        public override void Jouer(Grille grille)
        {
            base.Jouer(grille);
            int[] valeurs = new int[] { 0, 0, 0, 0, 0, 0, 0 }; //on initialise le tableau de valeurs de chaque colonne
            for (int i = 0; i < 7; i++) //pour chaque colonne
            {
                
                if (grille.GetLigne(i) < 5) { //si la ligne est inférieur à 5 alors on peut regarder la ligne en dessous 
                    while (grille.Array[grille.GetLigne(i)+1, i] == grille.Array[grille.GetLigne(i) + valeurs[i]+1, i] ) //tant que la ligne d'en dessous est egale aux lignes encore en dessous
                    {
                        valeurs[i]++; //on ajoute 1 a la valeur de la colonne 
                        if (grille.GetLigne(i) + valeurs[i] >= 5) { break; }//Si on sort du tableau on break
                    }
                    if (grille.GetLigne(i) == -1){ valeurs[i] = -1; }//si la colonne est pleine la valeur de la colonne est de moins 1
                }
                
            }
            List<int> choix = new List<int>();//on instancie un tableau des choix possible
            choix.Add(Array.IndexOf(valeurs,valeurs.Max()));//on ajoute l'index de la valeur maximal du tableau de valeur
            while (Array.IndexOf(valeurs, valeurs.Max(), choix.Last()+1) != -1)//on fait ca tant pour toute les valeurs maximales du tableau
            {
                choix.Add(Array.IndexOf(valeurs, valeurs.Max(),choix.Last()+1));
            }
            int colonnechoix = choix[new Random().Next(choix.Count)]; //l'ordi choisira un des index alèatoirement
            grille.TestGagner(this,grille.Positionner(grille.GetLigne(colonnechoix), colonnechoix, TypeJeton));//on positionne le piont et on test la victoire
        }
    }
}
