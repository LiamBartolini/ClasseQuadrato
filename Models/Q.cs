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

        // Per calcolo dell'Area, Perimetro e Diagonale utilizzo le proprietà
        public double Area
        {
            get => _area;

            // Passo un valore e lo moltiplico per il lato, in modo da calcolare anche l'area dei rettangoli
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

        // Sovrascrivo l'operatore '>'
        static public bool operator > (Q q1, Q q2)
        {
            if (q1.Area > q2.Area)
                return true;
            else
                return false;
        }
       
        // Si deve sovrascrivere anche il suo opposto
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

            // Controllo se uno dei due quadrati è completamente integrato all'altro
            if (q2.PosX + q2.Lato >= q1.PosX && q2.PosX + q2.Lato <= q1.PosX + q1.Lato && q2.PosY >= q1.PosY - q1.Lato && q2.PosY <= q1.PosY)
                return q2;

            if (q1.PosX + q1.Lato > q2.PosX && q1.PosX + q1.Lato < q2.PosX + q2.Lato && q1.PosY - q1.Lato > q2.PosY - q2.Lato && q1.PosY < q2.PosY)
                return q1;

            // Controllo se il secondo quadrato interseca il primo
            if (q2.PosX > q1.PosX + q1.Lato && q2.PosX < q1.PosX && q2.PosY > q1.PosY - q1.Lato && q2.PosY < q1.PosY)
            {
                //qInt.Lato = q2.Lato - (q1.PosX - q2.PosX);
                qInt.Lato = q2.Lato - (q1.PosX + q1.Lato);
                int altezza = q1.Lato - (q1.PosY - q2.PosY);

                qInt.Area = altezza;

                return qInt; // Ritorna un oggetto con l'area del quadrato interessato
            }
            else if (q1.PosX + q1.Lato > q2.PosX && q1.PosY > q2.PosY - q2.Lato && q1.PosY < q2.PosY && q1.PosY < q2.PosY) // Controllo se il primo quadrato interseca il secondo
            {
                qInt.Lato = q1.Lato - (q2.PosX - q1.PosX);
                int altezza = q2.Lato - (q2.PosY - q1.PosY);

                qInt.Area = altezza;

                return qInt; // Ritorna un poligono nullo
            }
            else
                return qInt; // Ritorna un poligono nullo
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

        // Sovrascrivo il metodo ToString per formattare l'output
        public override string ToString() => $"Area: {Area:n2} cm^2";
    }
}