using System;
using System.Collections.Generic;
using System.Text;

namespace Bartolini.Liam._4H.ClasseQuadrato.Models
{
    class Q
    {
        int _lato;
        int _posx;
        int _posy;
        double _area;
        double _perimetro;
        double _diagonale;

        public int Lato
        {
            get => _lato;

            set => _lato = value;
        }
        
        public int PosX
        {
            get => _posx;

            set => _posx = value;
        }
        
        public int PosY
        {
            get => _posy;

            set => _posy = value;
        }

        public double Area
        {
            get => _area;

            private set => _area = value * Lato;
        }

        public double Perimetro
        {
            get => _perimetro;

            private set => _perimetro = value * 4;
        }

        public double Diagonale
        {
            get => _diagonale;

            private set => _diagonale = value * Math.Sqrt(2);
        }

        static public bool operator > (Q q1, Q q2)
        {
            if (q1.Area > q2.Area)
                return true;
            else
                return false;
        }
       
        static public bool operator < (Q q1, Q q2)
        {
            if (q1.Area < q2.Area)
                return true;
            else
                return false;
        }

        static public Q Intersezione(Q q1, Q q2)
        {
            Q qInt = new Q();

            if (q2.PosX < q1.PosX + q1.Lato && q2.PosY > q1.PosY - q1.Lato && q2.PosY < q1.PosY)
            {
                qInt.Lato = q2.Lato - (q1.PosX - q2.PosX);
                int altezza = q1.Lato - (q1.PosY - q2.PosY);

                qInt.Area = altezza;

                return qInt; //ritorna un oggetto con l'area del quadrato interessato
            }
            else if (q1.PosX + q1.Lato > q2.PosX && q1.PosY > q2.PosY - q2.Lato && q1.PosY < q2.PosY && q1.PosY < q2.PosY)
            {
                qInt.Lato = q1.Lato - (q2.PosX - q1.PosX);
                int altezza = q2.Lato - (q2.PosY - q1.PosY);

                qInt.Area = altezza;

                return qInt; //ritorna un poligono nullo
            }
            else
                return qInt;
        }

        public Q(int l, int px, int py)
        {
            Lato = l;
            PosX = px;
            PosY = py;

            
            Area = Lato;
            Perimetro = Lato;
            Diagonale = Lato;
        }

        public Q()
        {

        }

        public override string ToString() => $"Area: {Area:n2} cm^2";
    }
}