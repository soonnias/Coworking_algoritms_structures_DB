using Bogus.DataSets;
using Coworking;
using Mysqlx.Datatypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CoworkingV
{
    public partial class SearchL : Form
    {
        Stopwatch stopwatch = new Stopwatch();

        public SearchL()
        {
            InitializeComponent();
        }

        private void buttonFind1_Click(object sender, EventArgs e)
        {
            string name = textBoxUsersNameSearch.Text.Trim();
            if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введіть ім'я для пошуку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            User[] users = MainForm.usersList.ToArray(); 

            stopwatch.Restart();
            User[] findedUsers1 = System.Array.FindAll(users, u => u.Name == name);
            stopwatch.Stop();
            labelTime.Text = $"Час вбудованого пошуку: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            //if (findedUsers1 != null)
                DisplayIntoDataGrid.DisplayUsers(dataGridViewFind, findedUsers1.ToList());

            stopwatch.Restart();
            //List<User> findedUsers2 = LinearSearch.SearchByName(users, name);
            List<User> findedUsers2 = LinearSearch<User>.SearchItems(users, u => u.Name == name ? 0 : 1);
            stopwatch.Stop();
            labelTimeMy.Text = $"Час мого пошуку: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            //if(findedUsers2!=null)
                DisplayIntoDataGrid.DisplayUsers(dataGridViewFindMy, findedUsers2.ToList());

        }

        private void buttonFind2_Click(object sender, EventArgs e)
        {
            double salary;
            if (!double.TryParse(textBoxEmployeesSalaryHigherThan.Text, out salary))
            {
                MessageBox.Show("Введіть зарплату в правильному форматі", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Employee[] employees = MainForm.employeesList.ToArray();

            stopwatch.Restart();
            Employee[] finded1 = System.Array.FindAll(employees, ee => ee.Salary > salary);
            stopwatch.Stop();
            labelTime.Text = $"Час вбудованого пошуку: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayEmployees(dataGridViewFind, finded1.ToList());

            //stopwatch.Restart();
            //List<Employee> finded2 = LinearSearch.SearchSalaryHigherThan(employees, salary);
            stopwatch.Restart();
            List<Employee> finded2 = LinearSearch<Employee>.SearchItems(employees, ee => ee.Salary > salary ? 0:1);
            stopwatch.Stop();
            labelTimeMy.Text = $"Час мого пошуку: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayEmployees(dataGridViewFindMy, finded2.ToList());
        }

        private void buttonFind3_Click(object sender, EventArgs e)
        {
            string startWith = textBoxNameCompanyStartWith.Text.Trim();
            if (String.IsNullOrEmpty(startWith) || String.IsNullOrWhiteSpace(startWith))
            {
                MessageBox.Show("Введіть дані для пошуку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Coworking.Company[] companies = MainForm.companiesList.ToArray();

            stopwatch.Restart();
            Coworking.Company[] finded1 = System.Array.FindAll(companies, c => c.Name.StartsWith(startWith));
            stopwatch.Stop();
            labelTime.Text = $"Час вбудованого пошуку: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayCompanies(dataGridViewFind, finded1.ToList());

            stopwatch.Restart();
            //List<Coworking.Company> finded2 = LinearSearch.CompaniesStartWith(companies, startWith);
            List<Coworking.Company> finded2 = LinearSearch<Coworking.Company>.SearchItems(companies, c => c.Name.StartsWith(startWith) ? 0:1);
            stopwatch.Stop();
            labelTimeMy.Text = $"Час мого пошуку: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayCompanies(dataGridViewFindMy, finded2.ToList());
        }
    }

    internal class LinearSearch<T> {

        public static List<T> SearchItems(T[] allItems, Func<T, int> comparison)
        {
            List<T> items = new List<T>();

            foreach (var item in allItems)
            {
                if (comparison(item) == 0)
                {
                    items.Add(item);
                }
            }
            return items;
        }
        //public static List<User> SearchByName(User[] allUsers, string name)
        //{
        //    List<User> users = new List<User>();
        //    //int k = 0;

        //    for (int i = 0; i < allUsers.Length; i++)
        //    {
        //        if (allUsers[i].Name == name)
        //        {
        //            //users[k++] = allUsers[i];
        //            users.Add(allUsers[i]);
        //        }
        //    }

        //    return users;
        //}

        //public static List<Employee> SearchSalaryHigherThan(Employee[] allEmployees, double salary)
        //{
        //    List<Employee> employees = new List<Employee>();

        //    for (int i = 0; i < allEmployees.Length; i++)
        //    {
        //        if (allEmployees[i].Salary > salary)
        //        {
        //            employees.Add(allEmployees[i]);
        //        }
        //    }
        //    return employees;
        //}

        //public static List<Coworking.Company> CompaniesStartWith(Coworking.Company[] allCompanies, string startWith)
        //{
        //    List<Coworking.Company> companies = new List<Coworking.Company>();

        //    for (int i = 0; i < allCompanies.Length; i++)
        //    {
        //        if (allCompanies[i].Name.StartsWith(startWith))
        //        {
        //            companies.Add(allCompanies[i]);
        //        }
        //    }
        //    return companies;
        //}

    }
}
