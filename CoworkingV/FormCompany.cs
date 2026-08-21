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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoworkingV
{
    public partial class FormCompany : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        public FormCompany()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNameCompany.Text))
            {
                MessageBox.Show("Заповніть всі поля для створення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string name = textBoxNameCompany.Text;
            Coworking.Company nc = new Coworking.Company(name);

            bool ex = false;
            for (int i = 0; i < MainForm.stackC.Count; i++)
            {
                if (MainForm.stackC.ToArray()[i].Name.Equals(name))
                {
                    ex = true;
                    break;
                }
            }

            if (ex)
            {
                MessageBox.Show("Така компанія вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            addStack(nc);
            addStackA(nc);
            addStackL(nc);

        }

        private void addStack(Coworking.Company nc) {

            stopwatch.Restart();
            MainForm.stackC.Push(nc);
            stopwatch.Stop();
            labelTimeStack.Text = $"Час стек: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            updateDGC();
        }
        private void addStackA(Coworking.Company nc)
        {
            stopwatch.Restart();
            MainForm.stackArrayC.Push(nc);
            stopwatch.Stop();
            labelTimeStackArray.Text = $"Час стек/масив: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            updateDGCA();
        }
        private void addStackL(Coworking.Company nc)
        {
            stopwatch.Restart();
            MainForm.stackListC.Push(nc);
            stopwatch.Stop();
            labelTimeStackList.Text = $"Час стек/список: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            updateDGCL();
        }

        private void updateDGC()
        {
            dataGridViewCompany1.Rows.Clear();
            if (MainForm.stackC.Count > 0)
            {
                foreach (var company in MainForm.stackC)
                {
                    dataGridViewCompany1.Rows.Add(company.Name);
                }
            }
        }
        private void updateDGCA()
        {
            dataGridViewCompany2.Rows.Clear();
            if (!MainForm.stackArrayC.IsEmpty())
            {
                Coworking.Company[] companies = MainForm.stackArrayC.ToArray();

                for (int i = companies.Length - 1; i >= 0; i--)
                {
                    dataGridViewCompany2.Rows.Add(companies[i].Name);
                }
            }
        }
        private void updateDGCL()
        {
            dataGridViewCompany3.Rows.Clear();
            if (!MainForm.stackListC.IsEmpty())
            {
                Node<Coworking.Company> currentNode = MainForm.stackListC.GetTop();

                while (currentNode != null)
                {
                    dataGridViewCompany3.Rows.Add(currentNode.data.Name);
                    currentNode = currentNode.next;
                }
            }
        }

        private void buttonDeleteLast_Click(object sender, EventArgs e)
        {
            deleteStack();
            deleteStackA();
            deleteStachL();
        }

        private void deleteStack()
        {
            stopwatch.Restart();
            if (MainForm.stackC.Count != 0) MainForm.stackC.Pop();
            stopwatch.Stop();
            labelTimeStack.Text = $"Час стек: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            updateDGC();
        }
        private void deleteStackA()
        {
            stopwatch.Restart();
            MainForm.stackArrayC.Pop();
            stopwatch.Stop();
            labelTimeStackArray.Text = $"Час стек/масив: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            updateDGCA();
        }
        private void deleteStachL()
        {
            stopwatch.Restart();
            MainForm.stackListC.Pop();
            stopwatch.Stop();
            labelTimeStackList.Text = $"Час стек/список: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            updateDGCL();
        }

        private void buttonLookFirst_Click(object sender, EventArgs e)
        {
            lookFirstStack();
            lookFirstStackA();
            lookFirstStackL();
        }

        private void lookFirstStack()
        {
            stopwatch.Restart();

            if (MainForm.stackC.Count == 0) labelFirstStack.Text = "Стек порожній";
            else {
                labelFirstStack.Text = $"Стек: {MainForm.stackC.Peek().Name}";
            }

            stopwatch.Stop();
            labelTimeStack.Text = $"Час стек: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
        }
        private void lookFirstStackA()
        {
            stopwatch.Restart();

            if (MainForm.stackArrayC.Size() == 0) labelFirstStackArray.Text = "Стек/масив порожній";
            else
            {
                labelFirstStackArray.Text = $"Стек/масив: {MainForm.stackArrayC.Peek().Name}";
            }

            stopwatch.Stop();
            labelTimeStackArray.Text = $"Час стек/масив: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
        }
        private void lookFirstStackL()
        {
            stopwatch.Restart();

            if (MainForm.stackListC.Size() == 0) labelFirstStackList.Text = "Стек/список порожній";
            else
            {
                labelFirstStackList.Text = $"Стек/список: {MainForm.stackListC.Peek().Name}";
            }

            stopwatch.Stop();
            labelTimeStackList.Text = $"Час стек/список: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
        }

        private void buttonCheckIsEmptyStack_Click(object sender, EventArgs e)
        {
            isEmptyStack();
            isEmptyStackA();
            isEmptyStackL();
        }

        private void isEmptyStack()
        {
            stopwatch.Restart();
            labelIsEmptyStack.Text = MainForm.stackC.Count==0 ? "Стек пустий" : "Стек не пустий";
            stopwatch.Stop();
            labelTimeStack.Text = $"Час стек: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
        }

        private void isEmptyStackA()
        {
            stopwatch.Restart();
            labelIsEmptyStackA.Text = MainForm.stackArrayC.IsEmpty() ? "Стек/масив пустий" : "Стек/масив не пустий";
            stopwatch.Stop();
            labelTimeStackArray.Text = $"Час стек/масив: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
        }


        private void isEmptyStackL()
        {
            stopwatch.Restart();
            labelIsEmptyStackL.Text = MainForm.stackListC.IsEmpty() ? "Стек/список пустий" : "Стек/список не пустий";
            stopwatch.Stop();
            labelTimeStackList.Text = $"Час стек/список: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
        }

        private void buttonIsFullArray_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            labelArrayIsFull.Text = MainForm.stackArrayC.IsFull() ? "Стек/масив заповнений" : "Стек/масив не заповнений";
            stopwatch.Stop();
            labelTimeStackArray.Text = $"Час стек/масив: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";

            labelTimeStackList.Text = $"Час стек/список: -";
            labelTimeStack.Text = $"Час стек: -";
        }

        private void buttonCountSizeQueue_Click(object sender, EventArgs e)
        {
            sizeStack();
            sizeStackArray();
            sizeStackList();
        }

        private void sizeStack()
        {
            stopwatch.Restart();
            labelSizeStack.Text = "Стек: " + MainForm.stackC.Count.ToString();
            stopwatch.Stop();
            labelTimeStack.Text = $"Час стек: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
        }

        private void sizeStackArray()
        {
            stopwatch.Restart();
            labelSizeStackA.Text = "Стек/масив: " + MainForm.stackArrayC.Size().ToString();
            stopwatch.Stop();
            labelTimeStackArray.Text = $"Час стек/масив: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
        }

        private void sizeStackList()
        {
            stopwatch.Restart();
            labelSizeStackL.Text = "Стек/список: " + MainForm.stackListC.Size().ToString();
            stopwatch.Stop();
            labelTimeStackList.Text = $"Час стек/список: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
        }
    }

    public class ArrayStack<T>
    {
        private T[] stackArray;
        private int top;

        public ArrayStack(int capacity)
        {
            stackArray = new T[capacity];
            top = -1;
        }
        public T[] ToArray()
        {
            T[] result = new T[Size()];
            Array.Copy(stackArray, 0, result, 0, Size());
            return result;
        }
        public void Push(T item)
        {
            if (Contains(item))
            {
                MessageBox.Show($"Елемент {item} вже існує у стеці");
                return;
            }

            if (top == stackArray.Length - 1)
            {
                Console.WriteLine("Стек переповнений");
                return;
            }
            stackArray[++top] = item;
        }
        public bool Contains(T item)
        {
            for (int i = 0; i <= top; i++)
            {
                if (EqualityComparer<T>.Default.Equals(stackArray[i], item))
                {
                    return true;
                }
            }
            return false;
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Стек порожній");
                return default(T);
            }
            return stackArray[top--];
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Стек порожній");
                return default(T);
            }
            return stackArray[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public int Size()
        {
            return top + 1;
        }

        public bool IsFull()
        {
            return top == stackArray.Length - 1;
        }

    }
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node(T data)
        {
            this.data = data;
            next = null;
        }
    }
    public class LinkedListStack<T>
    {
        private Node<T> top;
        public Node<T> GetTop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Стек порожній");
                return null;
            }
            return top;
        }


        public LinkedListStack()
        {
            top = null;
        }

        public void Push(T item)
        {
            if (Contains(item))
            {
                MessageBox.Show($"Елемент {item} вже існує у стеці");
                return;
            }

            Node<T> newNode = new Node<T>(item);
            newNode.next = top;
            top = newNode;
        }

        private bool Contains(T item)
        {
            Node<T> current = top;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.data, item))
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Стек порожній");
                return default(T);
            }
            T item = top.data;
            top = top.next;
            return item;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Стек порожній");
                return default(T);
            }
            return top.data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public int Size()
        {
            int count = 0;
            Node<T> current = top;
            while (current != null)
            {
                count++;
                current = current.next;
            }
            return count;
        }
    }


}
