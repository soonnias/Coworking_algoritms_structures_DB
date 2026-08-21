using Bogus.DataSets;
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
    public partial class FormSearchInBST : Form
    {
        EmployeeBST EmployeeBST;
        Stopwatch stopwatch = new Stopwatch();  
        public FormSearchInBST()
        {
            InitializeComponent();
            EmployeeBST = MainForm.bst;
            FormTree.DisplayEmployeeBSTInTreeView(treeView1, EmployeeBST);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNameFoeSearch.Text) || string.IsNullOrEmpty(textBoxNameFoeSearch.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            stopwatch.Restart();

            List<Employee> found = new List<Employee>();
            found.Add(SearchBST.SearchByName(textBoxNameFoeSearch.Text, EmployeeBST));

            stopwatch.Stop();

            if (found.First() != null) DisplayIntoDataGrid.DisplayEmployees(dataGridView1, found);
            else dataGridView1.Rows.Clear();
            labelTime.Text = $"Час пошуку: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";


            stopwatch.Restart();

            List<Employee> found2 = new List<Employee>();
            found2 = SearchBST.SearchByNameWithDublicate(textBoxNameFoeSearch.Text, EmployeeBST);

            stopwatch.Stop();

            if (found2.Count != 0) DisplayIntoDataGrid.DisplayEmployees(dataGridView2, found2);
            else dataGridView2.Rows.Clear();
            labelTime2.Text = $"Час пошуку з дублікатами: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";

        }
    }

    public class SearchBST {

        public static Employee SearchByName(string name, EmployeeBST bst) { 
            
            List<Employee> list = new List<Employee>();
            Employee employee = new Employee();
            employee = searchRecoursion(name, bst.Root());
            return employee;
        
        }

        private static Employee searchRecoursion(string name, EmployeeNode node)
        {
            if (node == null)
            {
                return null; 
            }

            int comparison = string.Compare(name, node.Data.Name, StringComparison.OrdinalIgnoreCase);

            if (comparison == 0)
            {
                return node.Data; 
            }
            else if (comparison < 0)
            {
                return searchRecoursion(name, node.Left);
            }
            else
            {
                return searchRecoursion(name, node.Right); 
            }

        }



        public static List<Employee> SearchByNameWithDublicate(string name, EmployeeBST bst)
        {
            List<Employee> list = new List<Employee>();
            searchRecursion2(name, bst.Root(), list);
            return list;
        }

        private static void searchRecursion2(string name, EmployeeNode node, List<Employee> list)
        {
            if (node == null)
            {
                return;
            }

            int comparison = string.Compare(name, node.Data.Name, StringComparison.OrdinalIgnoreCase);

            if (comparison == 0)
            {
                list.Add(node.Data);
            }

            if (comparison <= 0)
            {
                searchRecursion2(name, node.Left, list);
            }

            if (comparison >= 0)
            {
                searchRecursion2(name, node.Right, list);
            }
        }
    }
}
