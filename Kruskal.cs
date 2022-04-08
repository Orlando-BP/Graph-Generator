using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generador_de_Grafos
{
    class Kruskal
    {
        List<Arista> AristasGrafo;
        List<List<Vertice>> Conjuntos;
        List<Arista> AristasArbol;//Aristas sseleccionadas para dibujar el arbol minimo

        public Kruskal(List<Arista> AristasGrafo, List<Vertice> vertices)
        {
            Conjuntos = new List<List<Vertice>>();
            this.AristasGrafo = AristasGrafo;
            InicializacionConjuntos(vertices);
            AristasArbol = new List<Arista>();
            OrdenarDistanciaAristas();
            EncontrarAristasArbol();
        }

        void InicializacionConjuntos(List<Vertice> vertices)
        {
            foreach (Vertice ver in vertices)
            {
                List<Vertice> ListVer = new List<Vertice>();
                ListVer.Add(ver);
                Conjuntos.Add(ListVer);
            }
        }

        void OrdenarDistanciaAristas()//bubbleSort
        {
            int n = AristasGrafo.Count -1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= n - 1; j++)
                {
                    int a = AristasGrafo[j].GetDistancia();
                    int b = AristasGrafo[j + 1].GetDistancia();
                    if (a > b)
                    {
                        IntercambiarPosicion(AristasGrafo, j, j + 1);
                    }

                }
            }
        }
        void IntercambiarPosicion(List<Arista> AristasGrafo, int a, int b)
        {
            Arista aux;
            aux = AristasGrafo[a];
            AristasGrafo[a] = AristasGrafo[b];
            AristasGrafo[b] = aux;
        }

        bool MismoConjunto(Vertice A, Vertice B)
        {
            int index = 0;
            int indexB = 0;
            int indexA = 0;
            foreach (List<Vertice> conjunto in Conjuntos)
            {
                if (conjunto.Contains(A) && conjunto.Contains(B))
                {
                    return true;//arista no valida
                }
                if (conjunto.Contains(A))
                {
                    indexA = index;
                }
                if (conjunto.Contains(B))
                {
                    indexB = index;
                }
                index++;
            }
            foreach (Vertice ver in Conjuntos[indexB])
            {
                Conjuntos[indexA].Add(ver);
            }
            Conjuntos.Remove(Conjuntos[indexB]);
            return false;//arista valida, los conjuntos de los vertices se unen
        }
        void EncontrarAristasArbol()
        {
            foreach(Arista ar in AristasGrafo)
            {
                if (MismoConjunto(ar.GetVerA(),ar.GetVerB() ) == false)
                {
                    AristasArbol.Add(ar);
                }
            }
        }
        public List<Arista> GetAristasArbol()
        {
            return AristasArbol;
        }
        public int GetConjuntoscount()
        {
            return Conjuntos.Count;
        }
    }
}
