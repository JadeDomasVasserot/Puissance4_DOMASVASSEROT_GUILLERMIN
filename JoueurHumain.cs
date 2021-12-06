/*Cette classe héritera de la classe Joueur. Elle devra implémenter la méthode Jouer qui doit permettre à un
joueur de choisir la colonne à jouer, de gérer les erreurs si un joueur choisi un mauvais numéro de colonne ou
si la colonne choisie est déjà pleine, et de positionner le jeton. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPuissance4
{
    class JoueurHumain : Joueur
    {
        public JoueurHumain(string nom, char typeJeton) : base(nom, typeJeton) { }
        //méthodes
        public override void Jouer(Grille grille)
        {

            base.Jouer(grille);
            int colonnechoix = GetColonne() - 1;
            int ligne = grille.GetLigne(colonnechoix);
            if ( ligne == -1)
            {

                Console.WriteLine("La colonne choisie est déja pleine !");
                Jouer(grille);
            }
            else
            {
                grille.TestGagner(this,grille.Positionner(grille.GetLigne(colonnechoix), colonnechoix, TypeJeton));
            }
            
           
        }
    }
}
