using Coworking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoworkingV
{
    public partial class InterpolationSearch : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        public InterpolationSearch()
        {
            InitializeComponent();
        }

        private void buttonSearch1_Click(object sender, EventArgs e)
        {
            string name = textBoxUserName.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Заповніть всі поля для пошуку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<User> users = MainForm.usersList;
            users.Sort((user1, user2) => user1.Name.CompareTo(user2.Name));


            stopwatch.Restart();
            List<User> results1 = users.Where(u => u.Name == name).ToList();
            stopwatch.Stop();
            labelTime.Text = $"Час вбудованого пошуку: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayUsers(dataGridView1, results1.ToList());

            stopwatch.Restart();
            List<User> results2 = InterpolationSearchMy.Search(users.ToArray(), name, (user, key) => user.Name.CompareTo(key));
            stopwatch.Stop();
            labelTimeMy.Text = $"Час мого пошуку: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayUsers(dataGridView2, results2.ToList());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string surname = textBoxEmployeeSalary.Text;
            if (string.IsNullOrEmpty(surname) || string.IsNullOrWhiteSpace(surname))
            {
                MessageBox.Show("Заповніть всі поля для пошуку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Employee> employees = MainForm.employeesList;
            employees.Sort((e1, e2) => e1.Surname.CompareTo(e2.Surname));


            stopwatch.Restart();
            List<Employee> results1 = employees.Where(u => u.Surname == surname).ToList();
            stopwatch.Stop();
            labelTime.Text = $"Час вбудованого пошуку: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayEmployees(dataGridView1, results1.ToList());

            stopwatch.Restart();
            List<Employee> results2 = InterpolationSearchMy.Search(employees.ToArray(), surname, (employee, key) => employee.Surname.CompareTo(key));
            stopwatch.Stop();
            labelTimeMy.Text = $"Час мого пошуку: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayEmployees(dataGridView2, results2.ToList());

        }

        private void buttonSearch3_Click(object sender, EventArgs e)
        {
            string name = textBoxPlanNAme.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Заповніть всі поля для пошуку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Plan> plans = MainForm.plansList;
            plans.Sort((plan1, plan2) => plan1.Name.CompareTo(plan2.Name));


            stopwatch.Restart();
            List<Plan> results1 = plans.Where(u => u.Name == name).ToList();
            stopwatch.Stop();
            labelTime.Text = $"Час вбудованого пошуку: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayPlans(dataGridView1, results1.ToList());

            stopwatch.Restart();
            List<Plan> results2 = InterpolationSearchMy.Search(plans.ToArray(), name, (plan, key) => plan.Name.CompareTo(key));
            stopwatch.Stop();
            labelTimeMy.Text = $"Час мого пошуку: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayPlans(dataGridView2, results2.ToList());
        }
    }


    public class InterpolationSearchMy
    {
        public static List<T> Search<T>(T[] array, string key, Func<T, string, int> comparison)
        {
            List<T> results = new List<T>();
            int low = 0;
            int high = array.Length - 1;

            while (low <= high && comparison(array[low], key) <= 0 && comparison(array[high], key) >= 0)
            {
                if (low == high)
                {
                    if (comparison(array[low], key) == 0)
                    {
                        results.Add(array[low]);
                    }
                    break;
                }

                // інтерполяційна формула
                int position = low + ((comparison(array[low], key) - comparison(array[low], key)) * (high - low)) /
                                  (comparison(array[high], key) - comparison(array[low], key));

                if (position < low || position > high)
                    break;

                int posComparison = comparison(array[position], key);

                if (posComparison == 0)
                {
                    results.Add(array[position]);

                    int left = position - 1;
                    while (left >= low && comparison(array[left], key) == 0)
                    {
                        results.Add(array[left]);
                        left--;
                    }

                    int right = position + 1;
                    while (right <= high && comparison(array[right], key) == 0)
                    {
                        results.Add(array[right]);
                        right++;
                    }

                    break;
                }

                // > шукаємо в правій частині
                if (posComparison < 0)
                    low = position + 1;
                // у лівій частині
                else
                    high = position - 1;
            }
            return results;
        }
    }


}
