using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLabaDm
{
    public partial class Form1 : Form 
    {
        Graph GRAPH;
        List<Vertex> V;
        List<Edge> E;
        public int sumEdge = 0;
        public int a = 0;

        public int chosen1, chosen2;

        public Form1()
        {
            InitializeComponent();
            GRAPH = new Graph(pictureBox1.Width, pictureBox1.Height);
            V = new List<Vertex>();
            E = new List<Edge>();
            pictureBox1.Image = GRAPH.GetBitmap();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void VertexButton_Click(object sender, EventArgs e)
        {
            VertexDraw.Enabled = false;
            EdgeDraw.Enabled = true;
            GRAPH.Picturebox1Clear();
            GRAPH.DRAWGRAF(V, E);
            pictureBox1.Image = GRAPH.GetBitmap();
            
        }

        private void EdgeButton_Click(object sender, EventArgs e)
        {
            EdgeDraw.Enabled = false;
            VertexDraw.Enabled = true;
            GRAPH.Picturebox1Clear();
            GRAPH.DRAWGRAF(V, E);
            pictureBox1.Image = GRAPH.GetBitmap();
            chosen1 = -1;
            chosen2 = -1;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateGraph_Click(object sender, EventArgs e)
        {
            //List<Vertex> vershini = new List<Vertex>();
            //List<Edge> rebra = new List<Edge>();
            //button1.Enabled = false;
            //VertexDraw.Enabled = true;
            //EdgeDraw.Enabled = true;
            //GRAPH.Picturebox1Clear();
            //GRAPH.DRAWGRAF(vershini, rebra);
            //pictureBox1.Image = GRAPH.GetBitmap();

        }

        private void SumEdge_Click(object sender, EventArgs e)
        {
            int b = 0;
            for (int i = 0; i < sumEdge; i++)
            {
                b = b + 1;
                a = a + 1;

            }
            
            label1.Text ="Сумма всех степеней вершин графа " +b.ToString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Sviaznii_Click(object sender, EventArgs e)
        {
            

        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
          
            //рисую вершину
            if (VertexDraw.Enabled==false)
            {
                V.Add(new Vertex(e.X,e.Y));
                GRAPH.DrawVertex(e.X, e.Y, V.Count.ToString());
                pictureBox1.Image = GRAPH.GetBitmap();
                
            }

            //рисую ребро
            if (EdgeDraw.Enabled==false)
            {
                if (e.Button==MouseButtons.Left)
                {
                    for (int i = 0; i < V.Count; i++)
                    {
                        if (Math.Pow(V[i].x - e.X, 2) + Math.Pow(V[i].y - e.Y, 2) <= GRAPH.R * GRAPH.R)
                        {
                            if (chosen1 == -1)
                            {
                                GRAPH.DrawSelectedVertex(V[i].x, V[i].y);
                                chosen1 = i;
                                pictureBox1.Image = GRAPH.GetBitmap();
                                sumEdge += 1;
                                break;
                            }
                            
                            if (chosen2 == -1)
                            {
                                GRAPH.DrawSelectedVertex(V[i].x, V[i].y);
                                chosen2 = i;
                                E.Add(new Edge(chosen1, chosen2));
                                GRAPH.DrawEdge(V[chosen1], V[chosen2], E[E.Count - 1]);
                                chosen1 = -1;
                                chosen2 = -1;
                                pictureBox1.Image = GRAPH.GetBitmap();
                                sumEdge += 1;
                                break;
                            }
                           
                        }
                        
                    }
                }
                //if (e.Button==MouseButtons.Right)
                //{
                //    if ((chosen1!=-1)&& Math.Pow(V[chosen1].x-e.X,2)+ Math.Pow(V[chosen1].y-e.Y,2)<=GRAPH.R*GRAPH.R)
                //    {
                //        GRAPH.DrawVertex(V[chosen1].x, V[chosen1].y, (chosen1 + 1).ToString());
                //        chosen1 = -1;
                //        pictureBox1.Image = GRAPH.GetBitmap();

                //    }
                //}
            }



        }
    }
}
