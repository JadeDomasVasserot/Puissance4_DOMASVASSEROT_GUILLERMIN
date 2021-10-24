using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPuissance4
{
    class Grille
    {
        //Attributs
        private int[,,] array;
        //Getter et Setter
        public int[,,] Array { get => array; set => array = value; }
        // Constructeur
        public Grille()
        {
        }

        public Grille(int[,,] array)
        {
            this.array = array;
        }


        //Méthode


    }
}
