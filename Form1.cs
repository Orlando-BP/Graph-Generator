using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador_de_Grafos
{
    public partial class Form1 : Form
    {
        List<Vertice> Grafo;
        List<Arista> AristasGrafo;
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
            Grafo = new List<Vertice>();
            AristasGrafo = new List<Arista>();
            bmp = new Bitmap(1000, 1000);
            pictureBoxGrafo.Image = bmp;
        }
        
        private void pictureBoxGrafo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Vertice NewVertice = new Vertice(e.X, e.Y,Grafo.Count);
            Grafo.Add(NewVertice);
            DibujarVertices();
            pictureBoxGrafo.Refresh();
        }
        void DibujarVertices()
        {
            foreach(Vertice V in Grafo)
            {
                int X = V.GetCoordenadaX();
                int Y = V.GetCoordenadaY();
                int D = 60;
                Graphics G = Graphics.FromImage(bmp);
                Brush Brocha = new SolidBrush(Color.Black);
                G.FillEllipse(Brocha, X - D / 2, Y - D / 2, D, D);

                Brush brochaNumero = new SolidBrush(Color.Red);
                G.DrawString(V.GetID().ToString(), new Font("Arial", 15), brochaNumero, X + D / 3, Y + D / 3);
            }
        }
        void DibujarAristas()
        {
            foreach (Arista Ar in AristasGrafo)
            {
                Point A = Ar.GetVerA().GetCoordenadas();
                Point B = Ar.GetVerB().GetCoordenadas();
                Graphics G = Graphics.FromImage(bmp);
                Pen pluma = new Pen(Color.DarkGray, 5);
                G.DrawLine(pluma, A, B);
                Point F = new Point((B.X + A.X)/2, (B.Y + A.Y)/2);//Punto medio de la arista
                Brush brochaNumero = new SolidBrush(Color.DarkGray);
                G.DrawString(Ar.GetDistancia().ToString(), new Font("Arial", 15), brochaNumero, F);
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Doble Click en PictureBox (1000px X 1000px) para crear vertices\n" +
                "Cada vertice tiene un numero.\n" +
                "Para crear Aristas 'no dirigidas' \n" +
                "ingresa el numero de los vertices en los numeric UpDown de la parte derecha de la ventana, \n" +
                "agrega un numero de vertice para A y B para crear una arista que los une.\n" +
                "Cada Arista tiene un numero/peso en este caso representa distacia en pixeles entre vertices.\n" +
                "Para ver como se genera un arbol de expansion minima con el algoritmo de Kruskal \n" +
                "Presiona el boton 'Kruskal' de la parte derecha de la ventana");
        }
        Vertice BuscarVertice(int id)
        {
            foreach(Vertice ver in Grafo)
            {
                if(ver.GetID() == id)
                {
                    return ver;
                }
            }
            
                return null;
        }
        private void buttonArista_Click(object sender, EventArgs e)
        {
            Vertice verA = BuscarVertice((int)numericUpDownA.Value);
            Vertice verB = BuscarVertice((int)numericUpDownB.Value);
            Arista NewArista = new Arista(verA, verB);
            AristasGrafo.Add(NewArista);
            DibujarAristas();
            DibujarVertices();
            pictureBoxGrafo.Refresh();
        }

        private void buttonKruskal_Click(object sender, EventArgs e)
        {
            Kruskal kruskal = new Kruskal(AristasGrafo, Grafo);
            DubujarKruskal(kruskal.GetAristasArbol());
            pictureBoxGrafo.Refresh();
        }
        void DubujarKruskal(List<Arista> AristasArbol)
        {
            foreach (Arista Ar in AristasArbol)
            {
                Point A = Ar.GetVerA().GetCoordenadas();
                Point B = Ar.GetVerB().GetCoordenadas();
                Graphics G = Graphics.FromImage(bmp);
                Pen pluma = new Pen(Color.LightGreen, 3);
                G.DrawLine(pluma, A, B);
                pictureBoxGrafo.Refresh();
                Thread.Sleep(1000);
            }
        }
    }
}
