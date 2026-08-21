using Coworking;
using Org.BouncyCastle.Asn1.Cmp;
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

    //    stopwatch.Reset();
    //    stopwatch.Start();

    //    stopwatch.Stop();
    //    labelTimeQueue.Text = $"Час черга: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
    //    updateDGQ();


    //    stopwatch.Reset();
    //    stopwatch.Start();

    //    stopwatch.Stop();
    //    labelTimeQueueArray.Text = $"Час черга/масив: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
    //    updateDGQA();


    //    stopwatch.Reset();
    //    stopwatch.Start();

    //    stopwatch.Stop();
    //    labelTimeQueueList.Text = $"Час черга/список: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
    //    updateDGQL();

    public partial class FormDesk : Form
    {
        static Stopwatch stopwatch = new Stopwatch();

        public FormDesk()
        {
            InitializeComponent();
            dataGridViewDesk1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewDesk1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewDesk1.ReadOnly = true;

            dataGridViewDesk2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewDesk2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewDesk2.ReadOnly = true;

            dataGridViewDesk3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewDesk3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewDesk3.ReadOnly = true;

            comboBox1.SelectedIndex = 0;

            updateDGQ();
            updateDGQA();
            updateDGQL();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int number = (int)numericUpDown1.Value;
            string ac = comboBox1.Text;

            if (MainForm.queueListDesk.isExist(number))
            {
                MessageBox.Show("З таким номером стіл вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Desk newDesk = new Desk(number, ac);
            addQ(newDesk);
            addQA(newDesk);
            addQL(newDesk);
        }

        private void updateDGQ()
        {
            dataGridViewDesk1.Rows.Clear();
            if (MainForm.queueDesk.Count > 0)
            {
                foreach (var desk in MainForm.queueDesk)
                {
                    dataGridViewDesk1.Rows.Add(desk.Number, desk.Accessibility);
                }
            }
        }

        private void updateDGQA()
        {
            dataGridViewDesk2.Rows.Clear();
            if (!MainForm.queueArrayDesk.IsEmpty())
            {
                Desk[] desks = MainForm.queueArrayDesk.ToArray();

                foreach (var desk in desks)
                {
                    dataGridViewDesk2.Rows.Add(desk.Number, desk.Accessibility);
                }

            }
        }

        private void updateDGQL()
        {
            dataGridViewDesk3.Rows.Clear();
            if (!MainForm.queueListDesk.IsEmpty())
            {
                Node current = MainForm.queueListDesk.GetFront();
                while (current != null)
                {
                    dataGridViewDesk3.Rows.Add(current.data.Number, current.data.Accessibility);
                    current = current.next;
                }
            }
        }
    
        private void addQ(Desk desk)
        { 
            stopwatch.Reset();
            stopwatch.Start();

            MainForm.queueDesk.Enqueue(desk);
            
            stopwatch.Stop();
            labelTimeQueue.Text = $"Час черга: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            updateDGQ() ;
        }
        private void addQA(Desk desk)
        {
            stopwatch.Reset();
            stopwatch.Start();

            MainForm.queueArrayDesk.Enqueue(desk);

            stopwatch.Stop();
            labelTimeQueueArray.Text = $"Час черга/масив: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            updateDGQA();
        }
        private void addQL(Desk desk)
        {
            stopwatch.Reset();
            stopwatch.Start();

            MainForm.queueListDesk.Enqueue(desk);

            stopwatch.Stop();
            labelTimeQueueList.Text = $"Час черга/список: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            updateDGQL() ;
        }

        private void deleteQ() {
            stopwatch.Reset();
            stopwatch.Start();

            if(MainForm.queueDesk.Count!=0)
            MainForm.queueDesk.Dequeue();

            stopwatch.Stop();
            labelTimeQueue.Text = $"Час черга: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            updateDGQ();
        }
        private void deleteQA() {
            stopwatch.Reset();
            stopwatch.Start();

            MainForm.queueArrayDesk.Dequeue();

            stopwatch.Stop();
            labelTimeQueueArray.Text = $"Час черга/масив: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            updateDGQA();
        }
        private void deleteQL()
        {
            stopwatch.Reset();
            stopwatch.Start();

            MainForm.queueListDesk.Dequeue();

            stopwatch.Stop();
            labelTimeQueueList.Text = $"Час черга/список: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            updateDGQL();
        }

        private void buttonDeleteFirst_Click(object sender, EventArgs e)
        {
            deleteQ();
            deleteQA();
            deleteQL();
        }

        private void buttonLookFirst_Click(object sender, EventArgs e)
        {
            lookFirstQ();
            lookFirstQA();
            lookFirstQL();
        }

        private void lookFirstQ()
        {
            stopwatch.Reset();
            stopwatch.Start();
            Desk desk = null;
            if (MainForm.queueDesk.Count!=0) desk = MainForm.queueDesk.Peek();
            stopwatch.Stop();
            labelTimeQueue.Text = $"Час черга: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            if (desk == null) labelDesk1q.Text = "Черга пуста";
            else labelDesk1q.Text = $"Черга: Number {desk.Number}  {desk.Accessibility}";
        }

        private void lookFirstQA()
        {
            stopwatch.Reset();
            stopwatch.Start();
            Desk desk = MainForm.queueArrayDesk.Peek();
            stopwatch.Stop();
            labelTimeQueueArray.Text = $"Час черга/масив: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            if (desk == null) label1q2.Text = "Черга/масив пуста";
            else label1q2.Text = $"Черга/масив: Number {desk.Number}  {desk.Accessibility}";
        }

        private void lookFirstQL()
        {
            stopwatch.Reset();
            stopwatch.Start();
            Desk desk = MainForm.queueListDesk.Peek();
            stopwatch.Stop();
            labelTimeQueueList.Text = $"Час черга/список: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            if (desk == null) label1q3.Text = "Черга/список пуста";
            else label1q3.Text = $"Черга/список: Number {desk.Number}  {desk.Accessibility}";
        }

        private void buttonCheckIsEmptyQueue_Click(object sender, EventArgs e)
        {
            checkIsEmptyQ();
            checkIsEmptyQA();
            checkIsEmptyQL();
        }

        private void checkIsEmptyQ()
        {
            stopwatch.Reset();
            stopwatch.Start();
            bool isE = MainForm.queueDesk.Count == 0;
            stopwatch.Stop();
            labelTimeQueue.Text = $"Час черга: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            labelIsEmptyQueue.Text = isE ? "Черга пуста" : "Черга не пуста";
        }
        private void checkIsEmptyQA()
        {
            stopwatch.Reset();
            stopwatch.Start();
            bool isE = MainForm.queueArrayDesk.IsEmpty();
            stopwatch.Stop();
            labelTimeQueueArray.Text = $"Час черга/масив: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            labelIsEmptyQueueA.Text = isE ? "Черга/масив пуста" : "Черга/масив не пуста";
        }
        private void checkIsEmptyQL()
        {
            stopwatch.Reset();
            stopwatch.Start();
            bool isE = MainForm.queueListDesk.IsEmpty();
            stopwatch.Stop();
            labelTimeQueueList.Text = $"Час черга/список: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            labelIsEmptyQueueL.Text = isE ? "Черга/список пуста" : "Черга/список не пуста";
        }

        private void buttonIsFullArray_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();

            bool isE = MainForm.queueArrayDesk.IsFull();
            stopwatch.Stop();
            labelTimeQueueArray.Text = $"Час черга/масив: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            labelTimeQueue.Text = "Час черга: -";
            labelTimeQueueList.Text = "Час черга/список: -";
            labelArrayIsFull.Text = isE ? "Черга/масив заповнена" : "Черга/масив не заповнена";
        }

        private void buttonCountSizeQueue_Click(object sender, EventArgs e)
        {
            sizeQ();
            sizeQA();
            sizeQL();
        }

        private void sizeQ()
        {
            stopwatch.Reset();
            stopwatch.Start();
            int c = MainForm.queueDesk.Count();
            stopwatch.Stop();
            labelTimeQueue.Text = $"Час черга: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            labelSizeQueue.Text = "Черга: "+c.ToString();
        }

        private void sizeQA()
        {
            stopwatch.Reset();
            stopwatch.Start();
            int c = MainForm.queueArrayDesk.Size();
            stopwatch.Stop();
            labelTimeQueueArray.Text = $"Час черга/масив: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            labelSizeQueueA.Text = "Черга/масив: " + c.ToString();
        }

        private void sizeQL()
        {
            stopwatch.Reset();
            stopwatch.Start();
            int c = MainForm.queueListDesk.Size();
            stopwatch.Stop();
            labelTimeQueueList.Text = $"Час черга/стек: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            labelSizeQueueL.Text = "Черга/список: " + c.ToString();
        }
    }

    internal class ArrayQueue
    {
        private Desk[] array;
        private int front;
        private int rear;
        private int capacity;

        public ArrayQueue(int size)
        {
            capacity = size;
            array = new Desk[capacity];
            front = rear = -1;
        }

        public bool isExist(int number)
        {
            if (IsEmpty())
            {
                return false;
            }
            for (int i = front; i <= rear; i++)
            {
                if (array[i].Number == number)
                {
                    return true;
                }
            }
            return false;
        }
        public Desk[] ToArray()
        {
            Desk[] result = new Desk[Size()];
            int index = 0;
            for (int i = front; i <= rear; i++)
            {
                result[index++] = array[i];
            }
            return result;
        }
        public void Enqueue(Desk item)
        {
            if (rear == capacity - 1)
            {
                Console.WriteLine("Черга переповнена");
                return;
            }

            if (front == -1)
                front = 0;

            array[++rear] = item;
        }

        public Desk Dequeue()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Черга порожня");
                return null;
            }

            Desk item = array[front];
            for (int i = front; i < rear; i++)
            {
                array[i] = array[i + 1];
            }
            rear--;
            if (front == rear && array[front] == null)
            {
                front = rear = -1;
            }
            return item;
        }

        public Desk Peek()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Черга порожня");
                return null;
            }

            return array[front];
        }

        public bool IsEmpty()
        {
            return front == -1 || front > rear;
        }

        public bool IsFull()
        {
            return rear == capacity - 1;
        }

        public int Size()
        {
            if (front == -1) return 0;
            return rear - front + 1;
        }
    }


    class Node
    {
        public Desk data;
        public Node next;

        public Node(Desk data)
        {
            this.data = data;
            next = null;
        }

        public Desk getData()
        {
            return data;
        }
    }

    internal class LinkedListQueue
    {
        private Node front;
        private Node rear;

        public Node GetFront()
        {
            return front;
        }
        public bool isExist(int number)
        {
            Node current = front;
            while (current != null)
            {
                if (current.data.Number == number)
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        public LinkedListQueue()
        {
            front = rear = null;
        }

        public void Enqueue(Desk item)
        {
            Node newNode = new Node(item);

            if (rear == null)
            {
                front = rear = newNode;
                return;
            }

            rear.next = newNode;
            rear = newNode;
        }

        public Desk Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Черга порожня");
                return null;
            }

            Desk item = front.data;
            front = front.next;

            if (front == null)
                rear = null;

            return item;
        }

        public Desk Peek()
        {
            if (front == null)
            {
                Console.WriteLine("Черга порожня");
                return null;
            }

            return front.data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public int Size()
        {
            int count = 0;
            Node current = front;
            while (current != null)
            {
                count++;
                current = current.next;
            }
            return count;
        }
    }





    //internal class ArrayQueue<T>
    //{
    //    private T[] array;
    //    private int front;
    //    private int rear;
    //    private int capacity;

    //    public ArrayQueue(int size)
    //    {
    //        capacity = size;
    //        array = new T[capacity];
    //        front = rear = -1;
    //    }

    //    public bool isExistDesk(int number)
    //    {
    //        if (IsEmpty())
    //        {
    //            return false;
    //        }

    //        for (int i = front; i <= rear; i++)
    //        {

    //            if (array[i].Number == number)
    //            {
    //                return true;
    //            }
    //        }
    //        return false;
    //    }

    //    public T[] ToArray()
    //    {
    //        T[] result = new T[Size()];
    //        int index = 0;
    //        for (int i = front; i <= rear; i++)
    //        {
    //            result[index++] = array[i];
    //        }
    //        return result;
    //    }

    //    public void Enqueue(T item)
    //    {
    //        if (rear == capacity - 1)
    //        {
    //            Console.WriteLine("Черга переповнена");
    //            return;
    //        }

    //        if (front == -1)
    //            front = 0;

    //        array[++rear] = item;
    //    }

    //    public T Dequeue()
    //    {
    //        if (front == -1 || front > rear)
    //        {
    //            Console.WriteLine("Черга порожня");
    //            return default(T);
    //        }

    //        T item = array[front];
    //        for (int i = front; i < rear; i++)
    //        {
    //            array[i] = array[i + 1];
    //        }
    //        rear--;
    //        if (front == rear && array[front] == null)
    //        {
    //            front = rear = -1;
    //        }
    //        return item;
    //    }

    //    public T Peek()
    //    {
    //        if (front == -1 || front > rear)
    //        {
    //            Console.WriteLine("Черга порожня");
    //            return default(T);
    //        }

    //        return array[front];
    //    }

    //    public bool IsEmpty()
    //    {
    //        return front == -1 || front > rear;
    //    }

    //    public bool IsFull()
    //    {
    //        return rear == capacity - 1;
    //    }

    //    public int Size()
    //    {
    //        if (front == -1) return 0;
    //        return rear - front + 1;
    //    }
    //}

    //internal class Node<T>
    //{
    //    public T data;
    //    public Node<T> next;

    //    public Node(T data)
    //    {
    //        this.data = data;
    //        next = null;
    //    }

    //    public T getData()
    //    {
    //        return data;
    //    }
    //}

    //internal class LinkedListQueue<T>
    //{
    //    private Node<T> front;
    //    private Node<T> rear;

    //    public Node<T> GetFront()
    //    {
    //        return front;
    //    }

    //    public bool isExistDesk(int number)
    //    {
    //        Node<Desk> current = front as Node<Desk>;
    //        while (current != null)
    //        {
    //            if (current.data.Number == number)
    //            {
    //                return true;
    //            }
    //            current = current.next;
    //        }
    //        return false;
    //    }

    //    public LinkedListQueue()
    //    {
    //        front = rear = null;
    //    }

    //    public void Enqueue(T item)
    //    {
    //        Node<T> newNode = new Node<T>(item);

    //        if (rear == null)
    //        {
    //            front = rear = newNode;
    //            return;
    //        }

    //        rear.next = newNode;
    //        rear = newNode;
    //    }

    //    public T Dequeue()
    //    {
    //        if (front == null)
    //        {
    //            Console.WriteLine("Черга порожня");
    //            return default(T);
    //        }

    //        T item = front.data;
    //        front = front.next;

    //        if (front == null)
    //            rear = null;

    //        return item;
    //    }

    //    public T Peek()
    //    {
    //        if (front == null)
    //        {
    //            Console.WriteLine("Черга порожня");
    //            return default(T);
    //        }

    //        return front.data;
    //    }

    //    public bool IsEmpty()
    //    {
    //        return front == null;
    //    }

    //    public int Size()
    //    {
    //        int count = 0;
    //        Node<T> current = front;
    //        while (current != null)
    //        {
    //            count++;
    //            current = current.next;
    //        }
    //        return count;
    //    }
    //}

}
