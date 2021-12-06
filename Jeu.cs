/*Cette classe est une classe de base permettant de représenter un jeu par son Nom. Prévoir les accesseurs ainsi
que le constructeur de cette classe. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPuissance4
{
    class Jeu
    {
        //Attribut
        protected string nom;
        //Getter / Setter
        public string Nom { get => nom; set => nom = value; }

        //Constructeur
        public Jeu()
        {
        }
        
        public Jeu(string nom)
        {
            this.Nom = nom;
        }
        //Méthodes
        
    }
}
