using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generador_de_Grafos
{
    class Vertice
    {
        Point coordenadas;
        int Id;
        public Vertice(int X, int Y,int id) 
        {
            coordenadas.X = X;
            coordenadas.Y = Y;
            Id = id;
        }
        public Point GetCoordenadas()
        {
            return coordenadas;
        }
        public int GetCoordenadaX()
        {
            return coordenadas.X;
        }
        public int GetCoordenadaY()
        {
            return coordenadas.Y;
        }
        public int GetID()
        {
            return Id;
        }
    }
}
