using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generador_de_Grafos
{
    class Arista
    {
        Vertice VerA;
        Vertice VerB;
        int Distancia;
        public Arista(Vertice VerA, Vertice VerB)
        {
            this.VerA = VerA;
            this.VerB = VerB;
            Distancia = obtenerDistancia();
        }
        int obtenerDistancia()
        {
            double OperacionX = Math.Pow(VerA.GetCoordenadaX() - VerB.GetCoordenadaX(), 2);
            double OperacionY = Math.Pow(VerA.GetCoordenadaY() - VerB.GetCoordenadaY(), 2);
            double OperacionR = Math.Sqrt(OperacionX + OperacionY);

            return (int)OperacionR;
        }
        public Vertice GetVerA()
        {
            return VerA;
        }
        public Vertice GetVerB()
        {
            return VerB;
        }
        public int GetDistancia()
        {
            return Distancia;
        }
    }
}
