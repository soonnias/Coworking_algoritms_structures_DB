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
    public partial class SearchK : Form
    {
        public SearchK()
        {
            InitializeComponent();
        }

        Stopwatch stopwatch = new Stopwatch();

        private void buttonSearchESalary_Click(object sender, EventArgs e)
        {
            List<Employee> employees = MainForm.employeesList;
            List<Employee> founded = new List<Employee>();

            stopwatch.Restart();
            BubbleS.BubbleSort(employees, (x, y) => x.Salary.CompareTo(y.Salary));
            double minSalary = employees.First().Salary;
            double maxSalary = employees.Last().Salary;

            int i = 0;
            while (i < employees.Count && employees[i].Salary == minSalary)
            {
                founded.Add(employees[i]);
                i++;
            }

            i = employees.Count - 1;
            while (i >= 0 && employees[i].Salary == maxSalary)
            {
                founded.Add(employees[i]);
                i--;
            }

            stopwatch.Stop();
            labelTimeMy.Text = $"Час мого пошуку: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayEmployees(dataGridView1, founded);
        }

        private void buttonSearchPlans_Click(object sender, EventArgs e)
        {
            List<Plan> plans = MainForm.plansList;
            List<Plan> founded = new List<Plan>();

            stopwatch.Restart();
            BubbleS.BubbleSort(plans, (x, y) => x.Price.CompareTo(y.Price));
            double minPrice = plans.First().Price;
            double maxPrice = plans.Last().Price;

            int i = 0;
            while (i < plans.Count && plans[i].Price == minPrice)
            {
                founded.Add(plans[i]);
                i++;
            }

            i = plans.Count - 1;
            while (i >= 0 && plans[i].Price == maxPrice)
            {
                founded.Add(plans[i]);
                i--;
            }

            stopwatch.Stop();
            labelTimeMy.Text = $"Час мого пошуку: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayPlans(dataGridView1, founded);
        }

        private void buttonSearchUser_Click(object sender, EventArgs e)
        {
            List<User> users = MainForm.usersList;
            List<User> founded = new List<User>();

            stopwatch.Restart();
            BubbleS.BubbleSort(users, (x, y) => x.Surname.Length.CompareTo(y.Surname.Length));
            int minLength = users.First().Surname.Length;
            int maxLength = users.Last().Surname.Length;

            int i = 0;
            while (i < users.Count && users[i].Surname.Length == minLength)
            {
                founded.Add(users[i]);
                i++;
            }

            i = users.Count - 1;
            while (i >= 0 && users[i].Surname.Length == maxLength)
            {
                founded.Add(users[i]);
                i--;
            }

            stopwatch.Stop();
            labelTimeMy.Text = $"Час мого пошуку: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayUsers(dataGridView1, founded);
        }

        private void buttonSearchContractsPr_Click(object sender, EventArgs e)
        {
            List<Contract> contracts = MainForm.contractsList;
            List<Contract> founded = new List<Contract>();

            stopwatch.Restart();
            BubbleS.BubbleSort(contracts, (x, y) => x.Price.CompareTo(y.Price));
            double minPrice = contracts.First().Price;
            double maxPrice = contracts.Last().Price;

            int i = 0;
            while (i < contracts.Count && contracts[i].Price == minPrice)
            {
                founded.Add(contracts[i]);
                i++;
            }

            i = contracts.Count - 1;
            while (i >= 0 && contracts[i].Price == maxPrice)
            {
                founded.Add(contracts[i]);
                i--;
            }

            stopwatch.Stop();
            labelTimeMy.Text = $"Час мого пошуку: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayContracts(dataGridView1, founded);
        }

    }
}
