using Coworking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoworkingV
{
    public partial class FormGraphDejkstra : Form
    {
        public FormGraphDejkstra()
        {
            InitializeComponent();
        }

        private void FormGraphDejkstra_Load(object sender, EventArgs e)
        {
            updateGraphsList();
        }

        private void updateGraphsList()
        {
            richTextBox1.Text = "";
            richTextBox1.Text = GraphHelper.GetGraphConnectionsString(MainForm.graphDeskD);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int first = Int32.Parse(numericUpDown1.Value.ToString());
            //int second = Int32.Parse(numericUpDown2.Value.ToString());

            //Desk fDesks = MainForm.desksList.FirstOrDefault(desk => desk.Number == first);
            //Desk sDesks = MainForm.desksList.FirstOrDefault(desk => desk.Number == second);

            //if (fDesks != null || sDesks !=null) {
            //   richTextBox2.Text = MainForm.graphDeskD.PrintPathWithWeights(fDesks, sDesks) + "\n";
            //}

            int first = Int32.Parse(numericUpDown1.Value.ToString());

            Desk fDesks = MainForm.desksList.FirstOrDefault(desk => desk.Number == first);

            if (fDesks != null)
            {
                richTextBox2.Text = MainForm.graphDeskD.GetAllPathsAsString(fDesks) + "\n";
            }
        }
    }

    public class GraphHelper
    {
        public static Graph CreateWeightedGraph(List<Desk> desksList, int maxConnections = 3)
        {
            Graph graph = new Graph();
            Random random = new Random();

            foreach (var desk in desksList)
            {
                graph.AddVertex(desk);
            }

            foreach (var desk in desksList)
            {
                List<Desk> potentialNeighbors = new List<Desk>(desksList);
                potentialNeighbors.Remove(desk);
                int connections = random.Next(1, Math.Min(maxConnections, potentialNeighbors.Count) + 1);

                for (int i = 0; i < connections; i++)
                {
                    int randomIndex = random.Next(potentialNeighbors.Count);
                    Desk neighbor = potentialNeighbors[randomIndex];
                    potentialNeighbors.RemoveAt(randomIndex);

                    double weight = random.NextDouble() * 10;
                    graph.AddEdge(desk, neighbor, Math.Round(weight, 2));
                }
            }

            return graph;
        }

        public static string GetGraphConnectionsString(Graph graph)
        {
            var graphList = graph.getList();
            string result = "";

            foreach (var vertex in graphList)
            {
                result += $"Desk number {vertex.Key.Number}:\n";
                foreach (var edge in vertex.Value)
                {
                    result += $"-> Desk {edge.EndDesk.Number}: {edge.Weight} m\n";
                }
                result += "\n";
            }

            return result;
        }

        
    }
}
