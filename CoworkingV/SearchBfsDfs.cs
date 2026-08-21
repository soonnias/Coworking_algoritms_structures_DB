using Coworking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoworkingV
{
    public partial class SearchBfsDfs : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        public SearchBfsDfs()
        {
            InitializeComponent();
        }

        private void SearchBfsDfs_Load(object sender, EventArgs e)
        {

        }

        private void buttonBFS_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введіть ім'я для пошуку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EmployeeBST employeeBST = MainForm.bst;

            stopwatch.Restart();
            List<Employee> findedEmployees = new List<Employee>();
            findedEmployees = SearchTree.SearchAllBFS(employeeBST, name);
            stopwatch.Stop();
            labelTimeBFS.Text = $"Час пошуку BFS: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayEmployees(dataGridView1, findedEmployees);
            DisplayIntoDataGrid.DisplayEmployees(dataGridView2, SearchTree.VisitedBFS);
        }

        private void buttonDFS_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введіть ім'я для пошуку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EmployeeBST employeeBST = MainForm.bst;

            stopwatch.Restart();
            List<Employee> findedEmployees = new List<Employee>();
            findedEmployees = SearchTree.SearchAllDFS(employeeBST, name);
            stopwatch.Stop();
            labelTimeDFS.Text = $"Час пошуку DFS: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayEmployees(dataGridView1, findedEmployees);
            DisplayIntoDataGrid.DisplayEmployees (dataGridView2, SearchTree.VisitedDFS);
        }
    }



    public class SearchTree {

        private static List<Employee> visitedBFS = new List<Employee>();
        public static List<Employee> VisitedBFS {  get { return visitedBFS; }}

        private static List<Employee> visitedDFS = new List<Employee>();
        public static List<Employee> VisitedDFS { get { return visitedDFS; } }

        public static List<Employee> SearchAllBFS(EmployeeBST bst, string name)
        {
            List<Employee> foundEmployees = new List<Employee>();
            visitedBFS = new List<Employee>();

            if (bst.Root() == null)
            {
                MessageBox.Show("Дерево порожнє.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return foundEmployees;
            }

            Queue<EmployeeNode> queue = new Queue<EmployeeNode>();
            queue.Enqueue(bst.Root());

            while (queue.Count > 0)
            {
                EmployeeNode node = queue.Dequeue();
                visitedBFS.Add(node.Data);
                if (node.Data.Name == name)
                {
                    foundEmployees.Add(node.Data);
                }

                if (node.Left != null)
                    queue.Enqueue(node.Left);
                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }

            if (foundEmployees.Count == 0)
            {
               //MessageBox.Show($"Елементи з ім'ям {name} не знайдені у дереві.", "Відсутні елементи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return foundEmployees;
        }


        public static List<Employee> SearchAllDFS(EmployeeBST bst, string name)
        {
            List<Employee> foundEmployees = new List<Employee>();
            visitedDFS = new List<Employee>();

            if (bst.Root() == null)
            {
                MessageBox.Show("Дерево порожнє.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return foundEmployees;
            }

            DFSHelper(bst.Root(), name, foundEmployees);

            if (foundEmployees.Count == 0)
            {
                //MessageBox.Show($"Елементи з ім'ям {name} не знайдені у дереві.", "Відсутні елементи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return foundEmployees;
        }

        private static void DFSHelper(EmployeeNode node, string name, List<Employee> foundEmployees)
        {
            if (node == null)
                return;

            if (node.Data.Name == name)
            {
                foundEmployees.Add(node.Data);
            }

            visitedDFS.Add(node.Data);

            DFSHelper(node.Left, name, foundEmployees);
            DFSHelper(node.Right, name, foundEmployees);
        }



    }
}
