using Coworking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoworkingV
{
    public partial class FormTree : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        public FormTree()
        {
            InitializeComponent();
            DisplayEmployeeBSTInTreeView(treeView1, MainForm.bst);
            dateTimePicker1.MaxDate = DateTime.Now;
            updateCB();
        }

        private void updateCB()
        {
            comboBox1.Items.Clear();
            foreach (Position position in MainForm.positionList)
            {
                comboBox1.Items.Add(position.Name);
            }
        }

        public static void DisplayEmployeeBSTInTreeView(TreeView treeView, EmployeeBST bst)
        {
            treeView.Nodes.Clear();
            if (bst.Root() != null)
            {
                TreeNode rootNode = new TreeNode(bst.Root().Data.Name);
                AddChildrenToNode(rootNode, bst.Root());
                treeView.Nodes.Add(rootNode);
            }
        }

        private static void AddChildrenToNode(TreeNode parentNode, EmployeeNode node)
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
            string name = textBoxName.Text.Trim();
            string surname = textBoxSurname.Text.Trim();
            string position = comboBox1.Text.Trim();
            string phone = textBoxPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(position) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime dateOfBirth;
            if (!DateTime.TryParse(dateTimePicker1.Text, out dateOfBirth))
            {
                MessageBox.Show("Неправильний формат дати народження.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double salary;
            if (!double.TryParse(textBoxSalary.Text, out salary))
            {
                MessageBox.Show("Неправильний формат заробітної плати.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!MainForm.IsPhoneNumberUnique(phone))
            {
                MessageBox.Show("Працівник з таким номером телефону вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id_position = MainForm.FindPositionIdByName(position);

            Employee n = new Employee(id_position, name, surname, phone, dateOfBirth, salary);
            MainForm.employeesList.Add(n);

            stopwatch.Restart();
            MainForm.bst.Insert(n);
            stopwatch.Stop();
            labelTime.Text = $"Час: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";


            DisplayEmployeeBSTInTreeView(treeView1, MainForm.bst);
            MessageBox.Show("Новий працівник успішно додано.", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearchName.Text))
            {
                MessageBox.Show("Введіть ім'я для пошуку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nameForSearch = textBoxSearchName.Text;
            stopwatch.Restart();
            Employee searched = MainForm.bst.Search(nameForSearch);
            stopwatch.Stop();
            labelTime.Text = $"Час: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";

            if (searched == null) richTextBox1.Text = $"Відсутні дані про працівника з іменем '{nameForSearch}'";
            else richTextBox1.Text = $"Працівник: {searched.Name}  {searched.Surname}  {searched.DateOfBirth.ToShortDateString()}  {searched.Phone}  {searched.Salary}";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDeleteName.Text))
            {
                MessageBox.Show("Введіть ім'я для пошуку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            stopwatch.Restart();
            string nameForDelete = textBoxDeleteName.Text;
            if (!MainForm.bst.DeleteEmployee(nameForDelete))
            {
                MessageBox.Show("Такого імені в дереві не існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stopwatch.Stop();
                labelTime.Text = $"Час: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
                return;
            }

            MessageBox.Show("Працівник успішно видалено.", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stopwatch.Stop();
            labelTime.Text = $"Час: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayEmployeeBSTInTreeView(treeView1, MainForm.bst);

            int lastIndex = MainForm.employeesList.FindLastIndex(employee => employee.Name.Equals(nameForDelete));
            if (lastIndex != -1)
            {
                MainForm.employeesList.RemoveAt(lastIndex);
            }
        }
    }


    public class EmployeeNode
    {
        public Employee Data { get; set; }
        public EmployeeNode Left { get; set; }
        public EmployeeNode Right { get; set; }

        public EmployeeNode(Employee employee)
        {
            Data = employee;
            Left = null;
            Right = null;
        }
    }

    public class EmployeeBST
    {
        private EmployeeNode root;
        public EmployeeNode Root()
        {
            return root;
        }

        public EmployeeBST()
        {
            root = null;
        }

        public void Insert(Employee employee)
        {
            root = InsertRecursive(root, employee);
        }

        private EmployeeNode InsertRecursive(EmployeeNode node, Employee employee)
        {
            if (node == null)
            {
                return new EmployeeNode(employee);
            }

            // Порівнюємо за ім'ям 
            int comparisonResult = string.Compare(employee.Name, node.Data.Name);
            if (comparisonResult < 0)
            {
                node.Left = InsertRecursive(node.Left, employee);
            }
            else if (comparisonResult >= 0)
            {
                node.Right = InsertRecursive(node.Right, employee);
            }

            return node;
        }

        public Employee Search(string name)
        {
            EmployeeNode resultNode = SearchRecursive(root, name);
            return resultNode != null ? resultNode.Data : null;
        }

        private EmployeeNode SearchRecursive(EmployeeNode node, string name)
        {
            if (node == null || string.Equals(node.Data.Name, name))
            {
                return node;
            }

            // Порівнюємо за ім'ям
            int comparisonResult = string.Compare(name, node.Data.Name);
            if (comparisonResult < 0)
            {
                return SearchRecursive(node.Left, name);
            }
            else
            {
                return SearchRecursive(node.Right, name);
            }
        }


        public bool DeleteEmployee(string name)
        {
            bool deleted = false;
            root = DeleteRecursive(root, name, ref deleted);
            return deleted;
        }

        private EmployeeNode DeleteRecursive(EmployeeNode node, string name, ref bool deleted)
        {
            if (node == null)
            {
                return null;
            }

            if (string.Equals(node.Data.Name, name))
            {
                deleted = true; 

                //  вузол - листок
                if (node.Left == null && node.Right == null)
                {
                    return null;
                }
                //  вузол має тільки одного нащадка
                else if (node.Left == null)
                {
                    return node.Right;
                }
                else if (node.Right == null)
                {
                    return node.Left;
                }
                //  вузол має обидві дитини
                else
                {
                    // знаходимо наступний вузол за значенням (найменшим) у піддереві правого нащадка
                    EmployeeNode temp = node.Right;
                    while (temp.Left != null)
                    {
                        temp = temp.Left;
                    }
                    node.Data = temp.Data;
                    // видаляємо наступний вузол з піддерева правого нащадка
                    node.Right = DeleteRecursive(node.Right, temp.Data.Name, ref deleted);
                }
            }

            // рекурсивно викликаємо видалення для лівого та правого піддерева
            if (string.Compare(name, node.Data.Name) < 0)
            {
                node.Left = DeleteRecursive(node.Left, name, ref deleted);
            }
            else
            {
                node.Right = DeleteRecursive(node.Right, name, ref deleted);
            }

            return node;
        }
    }
}
