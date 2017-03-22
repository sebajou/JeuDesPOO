using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDesPOO
{
    class Joueur
    {
        public int PointDeVie { get; private set; }

        public Joueur()
        {
            PointDeVie = 150; 
        }

        private bool EstVouM;

        public bool EtatVouM
        {
            get { return EstVouM; }
            private set
                {
                if (PointDeVie==0)
                    {
                    EstVouM = false;
                    }
                else
                    {
                    EstVouM = true;
                    }
                EstVouM = value;
                }
        }

        static int Attaque(object Monstre)
        {
            De JoueurDe = new De();
            JoueurDe.LancerLeDe();

            MonstresFaciles MonstreFacileAtt = new MonstresFaciles();
            MonstresFaciles.MonstreFacileAttaque();
        }

        static SubitDegat(int degat)
        {

        }

    }
}
