using Coworking;
using Org.BouncyCastle.Asn1.Nist;
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
    public partial class LogarifmSearch : Form
    {
        Stopwatch stopwatch = new Stopwatch();  
        public LogarifmSearch()
        {
            InitializeComponent();
        }

        private void buttonBinarySearch1_Click(object sender, EventArgs e)
        {
            string userName = textBoxNameUserBS.Text;
            if (String.IsNullOrEmpty(userName) || String.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Помилка, введіть дані для пошуку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;   
            }


            List<User> users = MainForm.usersList;
            users.Sort((users1, users2) => users1.Name.CompareTo(users2.Name));

            stopwatch.Start();
            List<User> results = BinarySearch.BinarySearchAll(users.ToArray(), userName, (user, key) => user.Name.CompareTo(key));
            stopwatch.Stop();

            labelTimeBS.Text = $"Час бінарного пошуку: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayUsers(dataGridView1, results);
            if (results.Count() == 0) {
                MessageBox.Show("Відсутні користувачі з таким іменем", "Помилка(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonBinarySearch2_Click(object sender, EventArgs e)
        {
            string planName = textBoxNamePlansBS.Text;
            if (String.IsNullOrEmpty(planName) || String.IsNullOrWhiteSpace(planName))
            {
                MessageBox.Show("Помилка, введіть дані для пошуку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Plan> plans = MainForm.plansList;
            plans.Sort((plan1, plan2) => plan1.Name.CompareTo(plan2.Name));

            stopwatch.Start();
            List<Plan> results = BinarySearch.BinarySearchAll(plans.ToArray(), planName, (plan, key) => plan.Name.CompareTo(key));
            stopwatch.Stop();

            labelTimeBS.Text = $"Час бінарного пошуку: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayPlans(dataGridView1, results);
            if (results.Count() == 0)
            {
                MessageBox.Show("Відсутні плани з таким іменем", "Помилка(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBinarySearch3_Click(object sender, EventArgs e)
        {
            string employeeSurname = textBoxSurnameEmployeeBS.Text;
            if (String.IsNullOrEmpty(employeeSurname) || String.IsNullOrWhiteSpace(employeeSurname))
            {
                MessageBox.Show("Помилка, введіть дані для пошуку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Employee> employees = MainForm.employeesList;
            employees.Sort((employee1, employee2) => employee1.Surname.CompareTo(employee2.Surname));

            stopwatch.Start();
            List<Employee> results = BinarySearch.BinarySearchAll(employees.ToArray(), employeeSurname, (employee, key) => employee.Surname.CompareTo(key));
            stopwatch.Stop();

            labelTimeBS.Text = $"Час бінарного пошуку: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayEmployees(dataGridView1, results);
            if (results.Count() == 0)
            {
                MessageBox.Show("Відсутні працівники з таким прізвищем", "Помилка(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSeacrhBST_Click(object sender, EventArgs e)
        {
            string employeeName = textBoxNameEmployeeBST.Text;
            if (String.IsNullOrEmpty(employeeName) || String.IsNullOrWhiteSpace(employeeName))
            {
                MessageBox.Show("Помилка, введіть дані для пошуку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            stopwatch.Start();
            List<Employee> results = BSTSearch.SearchByName(MainForm.bst, employeeName);
            stopwatch.Stop();

            labelTimeBSTSearch.Text = $"Час пошуку в BST: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayEmployees(dataGridView1, results);
            if (results.Count() == 0)
            {
                MessageBox.Show("Відсутні працівники з таким прізвищем", "Помилка(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

    public class BSTSearch
    {
        public static List<Employee> SearchByName(EmployeeBST employees, string name)
        {
            List<Employee> results = new List<Employee>();
            SearchRecursive(employees.Root(), name, results);
            return results;
        }

        private static void SearchRecursive(EmployeeNode node, string name, List<Employee> results)
        {
            if (node == null) return;

            if (node.Data.Name == name)
            {
                results.Add(node.Data);
            }

            if (string.Compare(name, node.Data.Name) <= 0)
            {
                SearchRecursive(node.Left, name, results);
            }

            if (string.Compare(name, node.Data.Name) >= 0)
            {
                SearchRecursive(node.Right, name, results);
            }
        }
    }

    public class BinarySearch
    {
        public static List<T> BinarySearchAll<T>(T[] array, string key, Func<T, string, int> comparison)
        { 
            List<T> result = new List<T>();
            int left = 0; 
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int cmp = comparison(array[mid], key);

                if (cmp == 0)
                {
                    int leftIndex = mid;
                    while (leftIndex >= left && comparison(array[leftIndex], key) == 0)
                    {
                        result.Add(array[leftIndex]);
                        leftIndex--;
                    }

                    int rightIndex = mid + 1;
                    while (rightIndex <= right && comparison(array[rightIndex], key) == 0)
                    {
                        result.Add(array[rightIndex]);
                        rightIndex++;
                    }

                    return result;
                }

                else if (cmp < 0)
                {
                    left = mid + 1;
                }

                else 
                {
                    right = mid - 1;    
                }    
            }

            return result;
        }
    
    }
}
