using Coworking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoworkingV
{
    public partial class FormGraphs : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        public FormGraphs()
        {
            InitializeComponent();
            comboBox1Add.SelectedIndex = 0;
            updateDGDesk();
            updateCBForDelete();
            updateCBForEdge();
            updateEdges();
        }

        private void buttonAddV_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            int number = (int)numericUpDown1.Value;
            string ac = comboBox1Add.Text;

            Desk nevV = new Desk(number, ac);
            MainForm.graphDesk.AddVertex(nevV);
            stopwatch.Stop();
            labelTime.Text = $"Час: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            updateDGDesk();
            updateCBForDelete();
            updateCBForEdge();
            updateEdges();
        }

        private void updateCBForDelete()
        {
            comboBoxForDeleteV.Items.Clear();
            foreach (var desk in MainForm.graphDesk.getList())
            {
                comboBoxForDeleteV.Items.Add(desk.Key.Number);
            }
            textBoxAcDelete.Text = "";
            comboBoxForDeleteV.Text = "";

        }

        private void updateCBForEdge()
        {
            comboBoxFirstV.Items.Clear();
            comboBoxSecondV.Items.Clear();
            comboBoxDeleteF.Items.Clear();
            comboBoxDeleteS.Items.Clear();
            textBoxFisrtA.Text = "";
            textBoxSecondA.Text = "";
            comboBoxFirstV.Text = "";
            comboBoxSecondV.Text = "";

            var desks = MainForm.graphDesk.getList().Select(desk => desk.Key);

            foreach (var desk in desks)
            {
                comboBoxFirstV.Items.Add(desk.Number);
                comboBoxSecondV.Items.Add(desk.Number);
                comboBoxDeleteF.Items.Add(desk.Number);
                comboBoxDeleteS.Items.Add(desk.Number);
            }
        }

        private void updateDGDesk() {
            dataGridViewVertex.Rows.Clear();
            foreach (var desk in MainForm.graphDesk.getList())
            {
                dataGridViewVertex.Rows.Add(desk.Key.Number, desk.Key.Accessibility);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = int.Parse(comboBoxForDeleteV.SelectedItem.ToString());
            if (i >= 0)
            {
                string accessability = MainForm.graphDesk.getList().FirstOrDefault(vertex => vertex.Key.Number == i).Key.Accessibility;
                textBoxAcDelete.Text = accessability;
            }
            else
            {
                textBoxAcDelete.Text = "";
            }
        }

        private void buttonDeleteV_Click(object sender, EventArgs e)
        {
            int number;
            try
            {
                number = int.Parse(comboBoxForDeleteV.Text);
            }
            catch {
                MessageBox.Show("Оберіть вершину", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ac = textBoxAcDelete.Text;

            stopwatch.Restart();
            Desk nevV = new Desk(number, ac);
            MainForm.graphDesk.RemoveVertex(nevV);
            stopwatch.Stop();
            labelTime.Text = $"Час: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            updateDGDesk();
            updateCBForDelete();
            updateCBForEdge();
            updateEdges();
        }

        private void comboBoxFirstV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = int.Parse(comboBoxFirstV.SelectedItem.ToString());
            if (i >= 0)
            {
                string accessability = MainForm.graphDesk.getList().FirstOrDefault(vertex => vertex.Key.Number == i).Key.Accessibility;
                textBoxFisrtA.Text = accessability;
            }
            else
            {
                textBoxFisrtA.Text = "";
            }
        }

        private void comboBoxSecondV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = int.Parse(comboBoxSecondV.SelectedItem.ToString());
            if (i >= 0)
            {
                string accessability = MainForm.graphDesk.getList().FirstOrDefault(vertex => vertex.Key.Number == i).Key.Accessibility;
                textBoxSecondA.Text = accessability;
            }
            else
            {
                textBoxSecondA.Text = "";
            }
        }

        private void buttonAddEdge_Click(object sender, EventArgs e)
        {
            int numberDesk1, numberDesk2;
            double weight;
            try
            {
                numberDesk1 = int.Parse(comboBoxFirstV.Text);
                numberDesk2 = int.Parse(comboBoxSecondV.Text);
                weight = Math.Abs(double.Parse(textBoxWeight.Text));
            }
            catch
            {
                MessageBox.Show("Заповніть всі поля правильно", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            stopwatch.Restart();
            string ac1 = textBoxFisrtA.Text;
            string ac2 = textBoxSecondA.Text;

            Desk nevV1 = new Desk(numberDesk1, ac1);
            Desk nevV2 = new Desk(numberDesk2, ac2);
            MainForm.graphDesk.AddEdge(nevV1, nevV2, weight);

            stopwatch.Stop();
            labelTime.Text = $"Час: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";

            updateEdges();
        }

        private void updateEdges()
        {
            richTextBox1.Clear();
            richTextBox1.Text+=MainForm.graphDesk.PrintGraph();
        }

        private void FormGraphs_Load(object sender, EventArgs e)
        {

        }

        private void buttonDeketeEdge_Click(object sender, EventArgs e)
        {
            int numberDesk1, numberDesk2;
           
            try
            {
                numberDesk1 = int.Parse(comboBoxDeleteF.Text);
                numberDesk2 = int.Parse(comboBoxDeleteS.Text);
               
            }
            catch
            {
                MessageBox.Show("Заповніть всі поля правильно", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            stopwatch.Restart();
            string accessability1 = MainForm.graphDesk.getList().FirstOrDefault(vertex => vertex.Key.Number == numberDesk1).Key.Accessibility;
            string accessability2 = MainForm.graphDesk.getList().FirstOrDefault(vertex => vertex.Key.Number == numberDesk2).Key.Accessibility;
            Desk nevV1 = new Desk(numberDesk1, accessability1);
            Desk nevV2 = new Desk(numberDesk2, accessability2);
            MainForm.graphDesk.RemoveEdge(nevV1, nevV2);
            stopwatch.Stop();
            labelTime.Text = $"Час: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";

            updateEdges();
        }
    }


    public class Graph
    {
        public class Edge
        {
            public Desk StartDesk { get; set; }
            public Desk EndDesk { get; set; }
            public double Weight { get; set; } // (відстань між столами у метрах)

            public Edge(Desk startDesk, Desk endDesk, double weight)
            {
                StartDesk = startDesk;
                EndDesk = endDesk;
                Weight = weight;
            }
        }
        private Dictionary<Desk, List<Edge>> graphsList;

        public Dictionary<Desk, List<Edge>> getList()
        { 
             return graphsList;
        }

        public Graph()
        {
            graphsList = new Dictionary<Desk, List<Edge>>();
        }

        public void AddVertex(Desk vertex)
        {
            var existingDesk = graphsList.Keys.FirstOrDefault(d => d.Number == vertex.Number);
            if (existingDesk == null)
            {
                graphsList[vertex] = new List<Edge>();
               // MessageBox.Show("Вершину додано", "Додано", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           // else MessageBox.Show("Така вершина вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void RemoveVertex(Desk vertex)
        {
            if (graphsList.ContainsKey(vertex))
            {
                graphsList.Remove(vertex);
                foreach (var list in graphsList.Values)
                {
                    list.RemoveAll(edge => edge.StartDesk.Equals(vertex) || edge.EndDesk.Equals(vertex));
                }

                //MessageBox.Show("Вершину та всі ребра з цією вершиною видалені", "Видалено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           // else MessageBox.Show("Такої вершини не існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        //public void AddEdge(Desk startDesk, Desk endDesk, double weight)
        //{
        //    if (!graphsList.ContainsKey(startDesk))
        //    {
        //        AddVertex(startDesk);
        //    }
        //    if (!graphsList.ContainsKey(endDesk))
        //    {
        //        AddVertex(endDesk);
        //    }

        //    bool edgeExists = false;
        //    foreach (var edge in graphsList[startDesk])
        //    {
        //        if (edge.EndDesk == endDesk)
        //        {
        //            edge.Weight = weight;
        //            edgeExists = true;
        //            MessageBox.Show("Інформація пор ребро оновлена", "Оновлено", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            break;

        //        }
        //    }

        //    if (!edgeExists)
        //    {
        //        graphsList[startDesk].Add(new Edge(startDesk, endDesk, weight));
        //        graphsList[endDesk].Add(new Edge(endDesk, startDesk, weight));
        //        MessageBox.Show("Нові ребра додані", "Додано", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //}

        public void AddEdge(Desk startDesk, Desk endDesk, double weight)
        {
            if (!graphsList.ContainsKey(startDesk))
            {
                AddVertex(startDesk);
            }
            if (!graphsList.ContainsKey(endDesk))
            {
                AddVertex(endDesk);
            }

            bool edgeExists = false;
            foreach (var edge in graphsList[startDesk])
            {
                if (edge.EndDesk.Equals(endDesk))
                {
                    edge.Weight = weight;
                    edgeExists = true;
                    //MessageBox.Show("Інформація про ребро оновлена", "Оновлено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
            if (edgeExists)
            {
                foreach (var edge in graphsList[endDesk])
                {
                    if (edge.EndDesk.Equals(startDesk))
                    {
                        edge.Weight = weight;
                        edgeExists = true;
                        //MessageBox.Show("Інформація пор ребро оновлена", "Оновлено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }

            if (!edgeExists)
            {       
                graphsList[startDesk].Add(new Edge(startDesk, endDesk, weight));
                if (startDesk.Number != endDesk.Number)
                graphsList[endDesk].Add(new Edge(endDesk, startDesk, weight));
                
                //MessageBox.Show("Нові ребра додані", "Додано", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void RemoveEdge(Desk startDesk, Desk endDesk)
        {
            if (graphsList.ContainsKey(startDesk) && graphsList.ContainsKey(endDesk))
            {
                graphsList[startDesk].RemoveAll(edge => edge.EndDesk.Equals(endDesk));
                graphsList[endDesk].RemoveAll(edge => edge.EndDesk.Equals(startDesk));
                //MessageBox.Show("Ребра видалені", "Видалено", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           // else MessageBox.Show("Такого ребра не існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public string PrintGraph()
        {
            string s = "";
            foreach (var vertex in graphsList)
            {
                s+=("Стіл " + vertex.Key.Number + ":\n");
                foreach (var edge in vertex.Value)
                {
                    s+=("-> Стіл " + edge.EndDesk.Number + " (Відстань: " + edge.Weight + "м)\n");
                }
                s += "\n";
            }
            return s;
        }



        // ДЕЙКСТРА

        public List<Desk> Dijkstra(Desk startDesk, Desk endDesk)
        {
            var distances = new Dictionary<Desk, double>();
            var previous = new Dictionary<Desk, Desk>();
            var priorityQueue = new SortedSet<(double distance, Desk desk)>();

            foreach (var desk in graphsList.Keys)
            {
                distances[desk] = double.MaxValue;
                previous[desk] = null;
                priorityQueue.Add((double.MaxValue, desk));
            }

            distances[startDesk] = 0;
            priorityQueue.Remove((double.MaxValue, startDesk));
            priorityQueue.Add((0, startDesk));

            while (priorityQueue.Count > 0)
            {
                var (currentDistance, currentDesk) = priorityQueue.Min;
                priorityQueue.Remove(priorityQueue.Min);

                if (currentDesk.Equals(endDesk))
                    break;

                foreach (var edge in graphsList[currentDesk])
                {
                    var neighbor = edge.EndDesk;
                    var newDist = currentDistance + edge.Weight;

                    if (newDist < distances[neighbor])
                    {
                        priorityQueue.Remove((distances[neighbor], neighbor));
                        distances[neighbor] = newDist;
                        previous[neighbor] = currentDesk;
                        priorityQueue.Add((newDist, neighbor));
                    }
                }
            }

            var path = new List<Desk>();
            for (var at = endDesk; at != null; at = previous[at])
                path.Add(at);
            path.Reverse();

            return path.Count == 0 || !path.First().Equals(startDesk) ? null : path;
        }

        public Dictionary<Desk, (double distance, List<Desk> path)> Dijkstra(Desk startDesk)
        {
            var distances = new Dictionary<Desk, double>();
            var previous = new Dictionary<Desk, Desk>();
            var priorityQueue = new SortedSet<(double distance, Desk desk)>();

            foreach (var desk in graphsList.Keys)
            {
                distances[desk] = double.MaxValue;
                previous[desk] = null;
                priorityQueue.Add((double.MaxValue, desk));
            }

            distances[startDesk] = 0;
            priorityQueue.Remove((double.MaxValue, startDesk));
            priorityQueue.Add((0, startDesk));

            while (priorityQueue.Count > 0)
            {
                // вибір вершини з найменшою відстанню
                var (currentDistance, currentDesk) = priorityQueue.Min;

                // видаленняи з пріоритетної черги
                priorityQueue.Remove(priorityQueue.Min);

                // проходження через всі ребра 
                foreach (var edge in graphsList[currentDesk])
                {
                    var neighbor = edge.EndDesk;
                    var newDist = currentDistance + edge.Weight;

                    if (newDist < distances[neighbor])
                    {
                        priorityQueue.Remove((distances[neighbor], neighbor));
                        distances[neighbor] = newDist;
                        previous[neighbor] = currentDesk;
                        priorityQueue.Add((newDist, neighbor));
                    }
                }
            }

            var shortestPaths = new Dictionary<Desk, (double distance, List<Desk> path)>();

            // відновлення шляху для кожної вершини
            foreach (var desk in graphsList.Keys)
            {
                var path = new List<Desk>();
                for (var at = desk; at != null; at = previous[at])
                    path.Add(at);
                path.Reverse();

                if (path.Count > 0 && path.First().Equals(startDesk))
                {
                    shortestPaths[desk] = (distances[desk], path);
                }
                else
                {
                    shortestPaths[desk] = (double.MaxValue, new List<Desk>()); 
                }
            }
            return shortestPaths;
        }


        public string GetAllPathsAsString(Desk startDesk)
        {
            var shortestPaths = Dijkstra(startDesk);
            var result = new StringBuilder();

            foreach (var desk in shortestPaths.Keys)
            {
                var (distance, path) = shortestPaths[desk];

                if (distance == double.MaxValue)
                {
                    result.AppendLine($"Desk {startDesk.Number} -> Desk {desk.Number}: No path found");
                }
                else
                {
                    result.Append($"Desk {startDesk.Number} -> Desk {desk.Number}: {distance} m (Path: ");
                    for (int i = 0; i < path.Count; i++)
                    {
                        result.Append($"Desk {path[i].Number}");
                        if (i < path.Count - 1)
                        {
                            result.Append(" -> ");
                        }
                    }
                    result.AppendLine(")");
                }
            }
            return result.ToString();
        }













        public string PrintPathWithWeights(Desk startDesk, Desk endDesk)
        {
            string message = "";
            List<Desk> path = Dijkstra(startDesk, endDesk);
            double sumW = 0;

            if (path != null)
            {
                message += $"Шлях від столу {startDesk.Number} до столу {endDesk.Number}:";
                for (int i = 0; i < path.Count - 1; i++)
                {
                    Desk currentDesk = path[i];
                    Desk nextDesk = path[i + 1];

                    double weight = GetEdgeWeight(currentDesk, nextDesk);

                    message += ($"\nСтіл {currentDesk.Number} -> Стіл {nextDesk.Number} (Вага: {weight} метрів)");
                    sumW += weight;
                }
                message += "\nЗагальна вага " + sumW + " м";
            }
            else
            {
                message += ("Шляху не існує.");
            }
            return message;
        }

        public double GetEdgeWeight(Desk startDesk, Desk endDesk)
        {
            if (graphsList.ContainsKey(startDesk))
            {
                foreach (Edge edge in graphsList[startDesk])
                {
                    if (edge.EndDesk.Equals(endDesk))
                    {
                        return edge.Weight;
                    }
                }
            }
            return double.MaxValue; // Ребро не знайдено
        }
    }
    }
