using Coworking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoworkingV
{
    public partial class FormRecursioncs : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        public FormRecursioncs()
        {
            InitializeComponent();
            DisplayEmployeeBSTInTreeView(treeView1, MainForm.bst);
        }

        public void DisplayEmployeeBSTInTreeView(TreeView treeView, EmployeeBST bst)
        {
            treeView.Nodes.Clear();
            if (bst.Root() != null)
            {
                TreeNode rootNode = new TreeNode(bst.Root().Data.Name);
                AddChildrenToNode(rootNode, bst.Root());
                treeView.Nodes.Add(rootNode);
            }
        }
        private void AddChildrenToNode(TreeNode parentNode, EmployeeNode node)
        {
            if (node.Left != null)
            {
                TreeNode leftNode = new TreeNode(node.Left.Data.Name);
                parentNode.Nodes.Add(leftNode);
                AddChildrenToNode(leftNode, node.Left);
            }
            if (node.Right != null)
            {
                TreeNode rightNode = new TreeNode(node.Right.Data.Name);
                parentNode.Nodes.Add(rightNode);
                AddChildrenToNode(rightNode, node.Right);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            Employee find = FindMinimumRec(MainForm.bst.Root());
            labelRec1.Text = $"Рекурсивний пошук: {find.Name}  {find.Surname}";
            stopwatch.Stop();
            labelTimeRec.Text = $"Час рекурсивної: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";

            stopwatch.Restart();
            Employee find2 = FindMinimum(MainForm.bst.Root());
            labelJust1.Text = $"Звичайний пошук: {find2.Name}  {find2.Surname}";
            stopwatch.Stop();
            labelTimeJust.Text = $"Час звичайної: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
        }


        //1

        public Employee FindMinimumRec(EmployeeNode node)
        {
            if (node.Left == null)
            {
                return node.Data;
            }
            return FindMinimumRec(node.Left);
        }
        public Employee FindMinimum(EmployeeNode node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node.Data;
        }
        
        private void buttonGo_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            PreOrderTraversalRec(MainForm.bst.Root());
            labelRec2.Text = $"Рекурсивний обхід: пройдено";
            stopwatch.Stop();
            labelTimeRec.Text = $"Час рекурсивної: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";

            stopwatch.Restart();
            PreOrderTraversal(MainForm.bst.Root());
            labelJust2.Text = $"Звичайний обхід: пройдено";
            stopwatch.Stop();
            labelTimeJust.Text = $"Час звичайної: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
        }

        private static int count1 = 0;
        private static int count2 = 0;


        //2
        public void PreOrderTraversalRec(EmployeeNode node)
        {
            if (node == null)
            {
                return;
            }
            count1++;
            Console.WriteLine(node.Data);
            PreOrderTraversalRec(node.Left);
            PreOrderTraversalRec(node.Right);
        }

        public void PreOrderTraversal(EmployeeNode root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine("Звичайний обхід");

            Stack<EmployeeNode> stack = new Stack<EmployeeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                count2++;
                EmployeeNode current = stack.Pop();
                Console.WriteLine(current.Data);

                if (current.Right != null)
                {
                    stack.Push(current.Right);
                }
                if (current.Left != null)
                {
                    stack.Push(current.Left);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            stopwatch.Restart();
            int c1 = CountNodesRec(MainForm.bst.Root());
            labelRec3.Text = $"Рекурсивний обрахунок к-ть: {c1}";
            stopwatch.Stop();
            labelTimeRec.Text = $"Час рекурсивної: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";

            stopwatch.Restart();
            int c2 = CountNodesRec(MainForm.bst.Root());
            labelJust3.Text = $"Звичайний обрахунок к-ть: {c2}";
            stopwatch.Stop();
            labelTimeJust.Text = $"Час звичайної: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
        }

        public int CountNodesRec(EmployeeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            return 1 + CountNodesRec(node.Left) + CountNodesRec(node.Right);
        }

        public int CountNodesIterative(EmployeeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int count = 0;
            Stack<EmployeeNode> stack = new Stack<EmployeeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                EmployeeNode current = stack.Pop();
                count++;

                if (current.Right != null)
                {
                    stack.Push(current.Right);
                }

                if (current.Left != null)
                {
                    stack.Push(current.Left);
                }
            }

            return count;
        }
    }
}
