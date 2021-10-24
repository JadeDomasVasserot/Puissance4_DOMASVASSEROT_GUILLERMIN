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
        private string nom;
        private char typeJeton;

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


       
    }
}
