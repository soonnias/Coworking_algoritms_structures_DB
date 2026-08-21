using Coworking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CoworkingV
{
    public partial class Plans : Form
    {
        static Stopwatch stopwatch = new Stopwatch();
        public Plans()
        {
            InitializeComponent();
            dataGridViewPlans.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewPlans.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewPlans.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewPlans.ReadOnly = true;

            dataGridViewPlans.Columns[0].ReadOnly = true;
            dataGridViewPlans.Columns[1].ReadOnly = true;
            dataGridViewPlans.Columns[2].ReadOnly = true;

            updateDGPlan();
        }

        private void buttonAddToEndPlan_Click(object sender, EventArgs e)
        {
            insertToPosition(MainForm.plans.Count);
        }
        private void buttonAddToStartPlan_Click(object sender, EventArgs e)
        {
            insertToPosition(0);
        }
        private void insertToPosition(int pos) {
            
            if (string.IsNullOrEmpty(textBoxNamePlan.Text)|| string.IsNullOrEmpty(textBoxDescriptionPlan.Text)|| string.IsNullOrEmpty(textBoxPricePlan.Text))
            {
                MessageBox.Show("Заповніть всі поля для створення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double price;
            try
            {
                price = Double.Parse(textBoxPricePlan.Text);
            }
            catch
            {
                MessageBox.Show("Неправильний формат даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MainForm.plans.Any(p => p.Name == textBoxNamePlan.Text && p.Description == textBoxDescriptionPlan.Text))
            {
                MessageBox.Show("Такий план вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            stopwatch.Reset();
            stopwatch.Start();
           
            if(pos==0) MainForm.plans.AddFirst(new Coworking.Plan(textBoxNamePlan.Text, textBoxDescriptionPlan.Text, price));
            else MainForm.plans.AddLast(new Coworking.Plan(textBoxNamePlan.Text, textBoxDescriptionPlan.Text, price));
            stopwatch.Stop();
            MessageBox.Show("Новий план додано", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            labelTimePlan.Text = ($"Час виконання операцiї: {stopwatch.Elapsed.TotalMilliseconds:F5} мс");
            updateDGPlan();
            clearAllTB();
        }
        private void updateDGPlan()
        {
            dataGridViewPlans.Rows.Clear();

            foreach (var plan in MainForm.plans)
            {
                dataGridViewPlans.Rows.Add(plan.Name, plan.Description, plan.Price);
            }
        }

        private void comboBoxSortPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainForm.plans == null) return;
            int sorted = comboBoxSortPlan.SelectedIndex;

            stopwatch.Reset();
            stopwatch.Start();

            switch (sorted)
            {
                case 0:
                    {
                        MainForm.plans = new LinkedList<Plan>(MainForm.plans.OrderBy(p => p.Name));
                        break;
                    }

                case 1:
                    {
                        MainForm.plans = new LinkedList<Plan>(MainForm.plans.OrderByDescending(p => p.Name));
                        break;
                    }

                case 2:
                    {
                        MainForm.plans = new LinkedList<Plan>(MainForm.plans.OrderBy(p => p.Price));
                        break;
                    }

                case 3:
                    {
                        MainForm.plans = new LinkedList<Plan>(MainForm.plans.OrderByDescending(p => p.Price));
                        break;
                    }
            }

            stopwatch.Stop();
            labelTimePlan.Text = ($"Час виконання операцiї: {stopwatch.Elapsed.TotalMilliseconds:F5} мс");
            clearAllTB();
            updateDGPlan();
        }

        private void clearAllTB()
        {
            textBoxNamePlan.Text = textBoxDescriptionPlan.Text = textBoxPricePlan.Text = "";
            textBoxForSearchPlan.Text = "";
            labelSearchedPlan.Text = "Знайдене значення:";
            labelMedianaPlan.Text = "Медіана";

            labelFindedIndexPlan.Text = "Знайдене значення";
            numericUpDownPlan.Value = 0;
        
        }

        private void buttonSerachPlanByName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxForSearchPlan.Text))
            {
                MessageBox.Show("Заповніть всі поля для створення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string find = "";
            stopwatch.Reset();
            stopwatch.Start();
            foreach (Plan plan in MainForm.plans)
            {
                if (plan.Name.ToLowerInvariant().Contains(textBoxForSearchPlan.Text.ToLowerInvariant()))
                {
                    string trimmedDescription = plan.Description.Length > 30 ? plan.Description.Substring(0, 30) + "..." : plan.Description;
                    find += $"Info: {plan.Name}  {trimmedDescription}  {plan.Price}\n\n";
                }       
            }

            if (string.IsNullOrEmpty(find))
            {
                labelSearchedPlan.Text = $"Відсутні назви, які містять в собі '{textBoxForSearchPlan.Text}'";
            }
            else
            {
                labelSearchedPlan.Text = find;
            }
            stopwatch.Stop();
            labelTimePlan.Text = ($"Час виконання операцiї: {stopwatch.Elapsed.TotalMilliseconds:F5} мс");

        }

        private void buttonMedianaPlan_Click(object sender, EventArgs e)
        {
            if (MainForm.plans.All(plan => plan == null))
            {
                MessageBox.Show("Список планів порожній. Пошук медіани не можливий.");
                return;
            }

            stopwatch.Reset();
            stopwatch.Start();

            var sortedPlans = MainForm.plans.Where(plan => plan != null).ToArray();
            int n = sortedPlans.Length;
            Plan medianPlan;

            medianPlan = sortedPlans[n / 2];

            labelMedianaPlan.Text = $"{n/2} : {medianPlan.Name}  {medianPlan.Description}  {medianPlan.Price}";

            stopwatch.Stop();
            labelTimePlan.Text = $"Час виконання операції: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
        }

        private void buttonDeleteFromStartStartPlan_Click(object sender, EventArgs e)
        {
            if (MainForm.plans.Count == 0)
            {
                MessageBox.Show("Масив планів порожнiй. Неможливо вилучити елемент.");
                return;
            }

            string name = MainForm.plans.First.Value.Name;
            stopwatch.Reset();
            stopwatch.Start();
            
            MainForm.plans.RemoveFirst();
            stopwatch.Stop();
            MessageBox.Show($"Вилучено план '{name}' з початку списку.");
            labelTimePlan.Text = $"Час виконання операції: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            updateDGPlan();
        }

        private void buttonDeleteFromEndPlan_Click(object sender, EventArgs e)
        {
            if (MainForm.plans.Count == 0)
            {
                MessageBox.Show("Масив планів порожнiй. Неможливо вилучити елемент.");
                return;
            }
            string name = MainForm.plans.Last.Value.Name;

            stopwatch.Reset();
            stopwatch.Start();

            MainForm.plans.RemoveLast();
            stopwatch.Stop();
            MessageBox.Show($"Вилучено план '{name}' з кінця списку.");
            labelTimePlan.Text = $"Час виконання операції: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            updateDGPlan();
        }

        private void buttonByIndexPlan_Click(object sender, EventArgs e)
        {
            int index = (int)numericUpDownPlan.Value;
            int currentIndex = 0;
            Plan foundPlan = null;

            stopwatch.Reset();
            stopwatch.Start();

            foreach (Plan plan in MainForm.plans)
            {
                if (currentIndex == index)
                {
                    foundPlan = plan;
                    break;
                }
                currentIndex++;
            }

            if (foundPlan != null)
            {
                labelFindedIndexPlan.Text = $"{index} : {foundPlan.Name}  {foundPlan.Description}  {foundPlan.Price}";
            }
            else
            {
                MessageBox.Show("План з таким індексом не існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            stopwatch.Stop();
            labelTimePlan.Text = ($"Час виконання операцiї: {stopwatch.Elapsed.TotalMilliseconds:F5} мс");

        }

        private void видалитиПланToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви дійсно хочете видалити?", "Видалення плану", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                stopwatch.Reset();
                stopwatch.Start();
                if (dataGridViewPlans.RowCount > 0)
                {
                    int selectedRowIndex = dataGridViewPlans.SelectedCells[0].RowIndex;
                    if (selectedRowIndex == dataGridViewPlans.RowCount) return;
                    string name = dataGridViewPlans.Rows[selectedRowIndex].Cells[0].Value.ToString();
                    string description = dataGridViewPlans.Rows[selectedRowIndex].Cells[1].Value.ToString();
                    double price = Convert.ToDouble(dataGridViewPlans.Rows[selectedRowIndex].Cells[2].Value);

                    Plan planToRemove = new Plan(name, description, price);

                    MainForm.plans.Remove(planToRemove);
                    updateDGPlan();

                    MessageBox.Show("План видалено успішно", "Видалення плану", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Будь ласка, виберіть клітинку для видалення", "Вибір клітинки", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                stopwatch.Stop();
                labelTimePlan.Text = ($"Час виконання операцiї: {stopwatch.Elapsed.TotalMilliseconds:F5} мс");
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
         }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
