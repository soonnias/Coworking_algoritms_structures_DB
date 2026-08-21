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
    public partial class PositionForm : Form
    {
        
        static Stopwatch stopwatch = new Stopwatch();
        public PositionForm()
        {
            InitializeComponent();
           
            dataGridViewPosition.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridViewPosition.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewPosition.ReadOnly = true; 

            dataGridViewPosition.Columns[0].ReadOnly = true;
            //dataGridViewPosition.Columns[1].ReadOnly = true;
            updateDataGrid(MainForm.positions);

        }

        private void buttonDeleteFromStart_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();

            if (MainForm.positions[0] != null)
            {
                MessageBox.Show($"Вилучено посаду '{MainForm.positions[0].Name}' з початку масиву.");

                for (int i = 0; i < MainForm.positions.Length - 1; i++)
                {
                    MainForm.positions[i] = MainForm.positions[i + 1];
                    //if (MainForm.positions[i] != null)
                    //{
                    //    MainForm.positions[i].Id = i;
                    //}
                }

                MainForm.positions[MainForm.positions.Length - 1] = null;
            }
            else
            {
                MessageBox.Show("Масив посад порожнiй. Неможливо вилучити елемент.");
            }

            stopwatch.Stop();
            labelTimePositionArray.Text = ($"Час виконання операцiї: {stopwatch.Elapsed.TotalMilliseconds:F5} мс");
            updateDataGrid(MainForm.positions);
            clearAll();
        }

        private void buttonDeleteFromEnd_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = MainForm.positions.Length - 1; i >= 0; i--)
            {
                if (MainForm.positions[i] != null)
                {
                    MessageBox.Show($"Вилучено посаду '{MainForm.positions[i].Name}' з кiнця масиву.");
                    MainForm.positions[i] = null;
                    stopwatch.Stop();
                    labelTimePositionArray.Text = ($"Час виконання операцiї: {stopwatch.Elapsed.TotalMilliseconds:F5} мс");
                    updateDataGrid(MainForm.positions); clearAll();
                    return;
                }
            }

            MessageBox.Show("Масив посад порожнiй. Неможливо вилучити елемент.");
            stopwatch.Stop();
            labelTimePositionArray.Text = ($"Час виконання операцiї: {stopwatch.Elapsed.TotalMilliseconds:F5} мс");
            clearAll();
        }


        private void updateDataGrid(Position[] arr)
        {
            dataGridViewPosition.Rows.Clear();

            foreach (var position in arr)
            {
                if (position != null)
                {
                    dataGridViewPosition.Rows.Add(position.Name);
                }
            }
        }

        private void buttonInsertStart_Click(object sender, EventArgs e)
        {
            string name = textBoxForAddPosition.Text;
            if (name == null || name == "")
            {
                MessageBox.Show("Заповніть поле", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MainForm.positions.Any(p => p != null && p.Name == name))
            {
                MessageBox.Show($"Посада з назвою '{name}' вже iснує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            stopwatch.Reset();
            stopwatch.Start();
            bool arrayFull = true;
            foreach (var position in MainForm.positions)
            {
                if (position == null)
                {
                    arrayFull = false;
                    break;
                }
            }
            if (arrayFull)
            {
                Position[] newPositions = new Position[MainForm.positions.Length + 1];
                Array.Copy(MainForm.positions, 0, newPositions, 1, MainForm.positions.Length);

                //////////////////////
                //newPositions[0] = new Position(0, name);
                newPositions[0] = new Position(name);
                MainForm.positions = newPositions;
                MessageBox.Show($"Посада '{name}' успiшно додана на початок.");
            }
            else
            {
                for (int i = MainForm.positions.Length - 1; i > 0; i--)
                {
                    MainForm.positions[i] = MainForm.positions[i - 1];
                    //if (MainForm.positions[i] != null)
                    //{
                    //    MainForm.positions[i].Id = i;
                    //}
                }

                //////////
                //MainForm.positions[0] = new Position(0, name);
                MainForm.positions[0] = new Position(name);
                MessageBox.Show($"Посада '{name}' успiшно додана на початок.");
            }

            stopwatch.Stop();
            labelTimePositionArray.Text = ($"Час виконання операцiї: {stopwatch.Elapsed.TotalMilliseconds:F5} мс");
            updateDataGrid(MainForm.positions);
            clearAll(); 

        }

        private void buttonInsertEnd_Click(object sender, EventArgs e)
        {
            string name = textBoxForAddPosition.Text;
            if (name == null || name == "")
            {
                MessageBox.Show("Заповніть поле", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MainForm.positions.Any(p => p != null && p.Name == name))
            {
                MessageBox.Show($"Посада з назвою '{name}' вже iснує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool inserted = false;

            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < MainForm.positions.Length; i++)
            {
                if (MainForm.positions[i] == null)
                {
                    MessageBox.Show($"Посада '{name}' успiшно додана.");

                    /////////
                    MainForm.positions[i] = new Position(name);
                    inserted = true;
                    break;
                }
            }

            if (!inserted)
            {
                Position[] newPositions = new Position[MainForm.positions.Length + 1];
                Array.Copy(MainForm.positions, newPositions, MainForm.positions.Length);
                newPositions[MainForm.positions.Length] = new Position(MainForm.positions.Length, name);
                MainForm.positions = newPositions;
                MessageBox.Show($"Посада '{name}' успiшно додана.");
            }

            stopwatch.Stop();
            labelTimePositionArray.Text = ($"Час виконання операцiї: {stopwatch.Elapsed.TotalMilliseconds:F5} мс");
            updateDataGrid(MainForm.positions);
            clearAll();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int index = (int)numericUpDownIndexPosition.Value;

            stopwatch.Reset();
            stopwatch.Start();

            if (index >= 0 && index < MainForm.positions.Length)
            {
                Position position = MainForm.positions[index];
                if (position != null)
                {
                    labelFindByIndexPosition.Text = ($"Посада з iндексом {index}: {position.Name}");
                }
                else
                {
                    MessageBox.Show("Посада з цим iндексом вiдсутня.");
                }
            }
            else
            {
                MessageBox.Show("Неправильний iндекс.");
            }

            stopwatch.Stop();
            labelTimePositionArray.Text = ($"Час виконання операцiї: {stopwatch.Elapsed.TotalMilliseconds:F5} мс");
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (MainForm.positions.All(p => p == null))
            {
                MessageBox.Show("Масив посад порожнiй. Сортування не можливе.");
                return;
            }

            stopwatch.Reset();
            stopwatch.Start();
            //Position[] positionsCopy = new Position[MainForm.positions.Length];
            //Array.Copy(MainForm.positions, positionsCopy, MainForm.positions.Length);

            /*Array.Sort(positionsCopy, (x, y) =>*/
            Array.Sort(MainForm.positions, (x, y) => {
                if (x == null && y == null)
                    return 0;
                if (x == null)
                    return 1;
                if (y == null)
                    return -1;
                return x.Name.CompareTo(y.Name);
            });
            stopwatch.Stop();
            labelTimePositionArray.Text = ($"Час виконання операцiї: {stopwatch.Elapsed.TotalMilliseconds:F5} мс");

            updateDataGrid(MainForm.positions);
            //updateDataGrid(positionsCopy);

        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    if (MainForm.positions.All(p => p == null))
        //    {
        //        MessageBox.Show("Масив посад порожнiй. Сортування не можливе.");
        //        return;
        //    }

        //    stopwatch.Reset();
        //    stopwatch.Start();
        //    Position[] positionsCopy = new Position[MainForm.positions.Length];
        //    Array.Copy(MainForm.positions, positionsCopy, MainForm.positions.Length);

        //    Array.Sort(positionsCopy, (x, y) => {
        //        if (x == null && y == null)
        //            return 0;
        //        if (x == null)
        //            return -1;
        //        if (y == null)
        //            return 1;
        //        return x.Id.CompareTo(y.Id);
        //    });
        //    stopwatch.Stop();
        //    labelTimePositionArray.Text = ($"Час виконання операцiї: {stopwatch.Elapsed.TotalMilliseconds:F5} мс");

        //    updateDataGrid(positionsCopy);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string name = textBoxItemForSearchPosition.Text;
            if (name == null || name == " ")
            {
                MessageBox.Show("Заповніть поле", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool found = false;
            stopwatch.Reset();
            stopwatch.Start();
            labelSearchedItemPosition.Text = "Знайдені значення: ";
            //for (int i = 0; i < MainForm.positions.Length; i++)
            //{
            //    if (MainForm.positions[i] != null && MainForm.positions[i].Name == name)
            //    {
            //        labelSearchedItemPosition.Text = ($"Знайдено посаду '{name}' з iндексом {i}.");
            //        found = true;
            //    }
            //}

            //if (!found)
            //{
            //    labelSearchedItemPosition.Text = ($"Посада з назвою '{name}' не знайдена.");
            //}
            int index = -1;
            foreach (var position in MainForm.positions)
            {
                index++;

                if (position != null && position.Name.ToLowerInvariant().Contains(name.ToLowerInvariant()))
                {
                    labelSearchedItemPosition.Text += ($"Знайдено посаду '{position.Name}' з індексом {index}.\n\n");
                    found = true;
                    //break;
                }
            }

            if (!found)
            {
                labelSearchedItemPosition.Text = ($"Посада з назвою '{name}' не знайдена.");
            }

            stopwatch.Stop();
            labelTimePositionArray.Text = ($"Час виконання операцiї: {stopwatch.Elapsed.TotalMilliseconds:F5} мс");
        }

        private void buttonMediana_Click(object sender, EventArgs e)
        {
            if (MainForm.positions.All(p => p == null))
            {
                MessageBox.Show("Масив посад порожнiй. Пошук медiани не можливий.");
                return;
            }

            stopwatch.Reset();
            stopwatch.Start();

            var sortedPositions = MainForm.positions.Where(p => p != null).OrderBy(p => p.Id).ToArray();
            int n = sortedPositions.Length;
            //int median;

            //if (n % 2 == 0)
            //{
            //    median = (sortedPositions[n / 2 - 1].Id + sortedPositions[n / 2].Id) / 2;
            //}
            //else
            //{
            //    median = sortedPositions[n / 2].Id;
            //}
            Position median;

            median = sortedPositions[n / 2];

            labelMediana.Text = ($"Медiана: {n/2} : {median.Name}");

            stopwatch.Stop();
            labelTimePositionArray.Text = ($"Час виконання операцiї: {stopwatch.Elapsed.TotalMilliseconds:F5} мс");

        }

        private void clearAll()
        {
            textBoxItemForSearchPosition.Text = "";
            labelSearchedItemPosition.Text = "Знайдене значення:";
            labelMediana.Text = "Медіана";
            textBoxForAddPosition.Text = "";
            labelFindByIndexPosition.Text = "Знайдене значення";
            numericUpDownIndexPosition.Value = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonSortId_Click(object sender, EventArgs e)
        {

            if (MainForm.positions.All(p => p == null))
            {
                MessageBox.Show("Масив посад порожнiй. Сортування не можливе.");
                return;
            }

            stopwatch.Reset();
            stopwatch.Start();
            //Position[] positionsCopy = new Position[MainForm.positions.Length];
            //Array.Copy(MainForm.positions, positionsCopy, MainForm.positions.Length);

            /*Array.Sort(positionsCopy, (x, y) =>*/
            Array.Sort(MainForm.positions, (x, y) => {
                if (x == null && y == null)
                    return 0;
                if (x == null)
                    return 1;
                if (y == null)
                    return -1;
                return x.Id.CompareTo(y.Id);
            });
            stopwatch.Stop();
            labelTimePositionArray.Text = ($"Час виконання операцiї: {stopwatch.Elapsed.TotalMilliseconds:F5} мс");

            updateDataGrid(MainForm.positions);
            //updateDataGrid(positionsCopy);

        }
    }  
}
