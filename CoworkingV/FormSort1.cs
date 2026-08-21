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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CoworkingV
{
    public partial class FormSort1 : Form
    {

        List<User> forSortUser;
        List<Plan> forSortPlans;

        Stopwatch stopwatch = new Stopwatch();

        public FormSort1()
        {
            InitializeComponent();
            forSortUser = MainForm.usersList.ToList();
            forSortPlans = MainForm.plansList.ToList();
        }

        private void buttonSelectAllUsers_Click(object sender, EventArgs e)
        {
            DisplayUsers(dataGridView1, forSortUser);
        }

        internal void DisplayUsers(DataGridView dataGridView, List<User> usersList)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            dataGridView.Columns.Add("Id", "ID");
            dataGridView.Columns.Add("Name", "Name");
            dataGridView.Columns.Add("Surname", "Surname");
            dataGridView.Columns.Add("Email", "Email");
            dataGridView.Columns.Add("Phone", "Phone");
            dataGridView.Columns.Add("DateOfBirth", "Date Of Birth");
            dataGridView.Columns.Add("CompanyId", "Company ID");

            foreach (var user in usersList)
            {
                dataGridView.Rows.Add(user.Id, user.Name, user.Surname, user.Email, user.Phone, user.DateOfBirth.ToShortDateString(), user.CompanyId);
            }
        }

        internal void DisplayPlans(DataGridView dataGridView, List<Plan> plansList)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            dataGridView.Columns.Add("Id", "ID");
            dataGridView.Columns.Add("Name", "Name");
            dataGridView.Columns.Add("Description", "Description");
            dataGridView.Columns.Add("Price", "Price");

            foreach (var plan in plansList)
            {
                dataGridView.Rows.Add(plan.Id, plan.Name, plan.Description, plan.Price.ToString("C2"));
            }
        }

        private void buttonSelectAllPlans_Click(object sender, EventArgs e)
        {
            DisplayPlans(dataGridView1, forSortPlans);
        }
        private void buttonUserSort1_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            BubbleS.BubbleSort(forSortUser, (x, y) => x.Name.CompareTo(y.Name));
            stopwatch.Stop();
            labelSort1User.Text = $"Сортування бульбашкою: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayUsers(dataGridView1, forSortUser);
            forSortUser = MainForm.usersList.ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            BubbleS.BubbleSort(forSortPlans, (x, y) => x.Name.CompareTo(y.Name));
            stopwatch.Stop();
            labelSort1Plans.Text = $"Сортування бульбашкою: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayPlans(dataGridView1, forSortPlans);
            forSortPlans = MainForm.plansList.ToList();
        }
        private void buttonUserSort2_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            InsertionS.InsertionSort(forSortUser, (x, y) => x.Name.CompareTo(y.Name));
            stopwatch.Stop();
            labelUsersSortInsert.Text = $"Сортування вставкою: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayUsers(dataGridView1, forSortUser);
            forSortUser = MainForm.usersList.ToList();
        }

        private void buttonSort2Plans_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            InsertionS.InsertionSort(forSortPlans, (x, y) => x.Name.CompareTo(y.Name));
            stopwatch.Stop();
            labelSort2Plans.Text = $"Сортування вставкою: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayPlans(dataGridView1, forSortPlans);
            forSortPlans = MainForm.plansList.ToList();
        }
        private void buttonUserSort3_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            SelectionS.SelectionSort(forSortUser, (x, y) => x.Name.CompareTo(y.Name));
            stopwatch.Stop();
            labelUsersSortS.Text = $"Сортування вибором: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayUsers(dataGridView1, forSortUser);
            forSortUser = MainForm.usersList.ToList();
        }

        private void buttonSort3Plans_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            SelectionS.SelectionSort(forSortPlans, (x, y) => x.Name.CompareTo(y.Name));
            stopwatch.Stop();
            labelSort3Plans.Text = $"Сортування вибором: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayPlans(dataGridView1, forSortPlans);
            forSortPlans = MainForm.plansList.ToList();
        }

        private void buttonUserSort4_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            forSortUser.Sort((user1, user2) => user1.Name.CompareTo(user2.Name));
            stopwatch.Stop();
            labelUsersSortDef.Text = $"Метод sort вбудований: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayUsers(dataGridView1, forSortUser);
            forSortUser = MainForm.usersList.ToList();
        }

        private void buttonSort4Plans_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            forSortPlans.Sort((plan1, plan2) => plan1.Name.CompareTo(plan2.Name));
            stopwatch.Stop();
            labelSort4Plans.Text = $"Метод sort вбудований: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayPlans(dataGridView1, forSortPlans);
            forSortPlans = MainForm.plansList.ToList();
        }
    }

    public static class BubbleS
    {
        internal static void BubbleSort<T>(IList<T> list, Func<T, T, int> comparison)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (comparison(list[i], list[i + 1]) > 0)
                    {
                        T temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }
    }

    public static class InsertionS
    {
        internal static void InsertionSort<T>(IList<T> list, Func<T, T, int> comparison)
        {
            for (int i = 1; i < list.Count; i++)
            {
                T temp = list[i];
                int j;

                // пересуваємо list[j] на одну позицію вправо.
                for (j = i - 1; j >= 0 && comparison(list[j], temp) > 0; j--)
                {
                    list[j + 1] = list[j];
                }

                // після виходу з циклу - знайшли правильне місце для temp,
                // встановлюємо temp на позицію j + 1.
                list[j + 1] = temp;
            }
        }

        internal static void InsertionSort<T>(IList<T> list, Func<T, T, int> comparison, int left, int right)
        {
            for (int i = left + 1; i <= right; i++)
            {
                T temp = list[i];
                int j;

                for (j = i - 1; j >= left && comparison(list[j], temp) > 0; j--)
                {
                    list[j + 1] = list[j];
                }

                list[j + 1] = temp;
            }
        }

    }
    public static class SelectionS {
        internal static void SelectionSort<T>(IList<T> list, Func<T, T, int> comparison)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                // перший елемент мінімальний
                int minIndex = i;

                // чи існує елемент менший за вже знайдений
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (comparison(list[j], list[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                // якщо знайдений елемент менший, ніж елемент на позиції i, міняємо їх місцями.
                if (minIndex != i)
                {
                    T temp = list[i];
                    list[i] = list[minIndex];
                    list[minIndex] = temp;
                }
            }
        }
    }
}
