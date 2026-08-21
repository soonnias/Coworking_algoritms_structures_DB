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
    public partial class FormSort2 : Form
    {
        List<User> forSortUser;
        //List<Plan> forSortPlans;
        List<Contract> forSortContracts;
        List<Employee> forSortEmployees;

        Stopwatch stopwatch = new Stopwatch();

        public FormSort2()
        {
            InitializeComponent();
            forSortUser = MainForm.usersList.ToList();
            //forSortPlans = MainForm.plansList.ToList();
            forSortContracts = MainForm.contractsList.ToList();
            forSortEmployees = MainForm.employeesList.ToList();
        }

        
       

        private void buttonQuickSort1_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            QuickS.QuickSort(forSortUser, (x, y) => x.Name.CompareTo(y.Name));
            stopwatch.Stop();
            labelQuickSort1.Text = $"Швидке сортування: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayUsers(dataGridView1, forSortUser);
            forSortUser = MainForm.usersList.ToList();
        }

        private void buttonSelectAll1_Click(object sender, EventArgs e)
        {
            DisplayIntoDataGrid.DisplayUsers(dataGridView1, forSortUser);
        }

        //private void buttonSelectAll2_Click(object sender, EventArgs e)
        //{
        //    DisplayPlans(dataGridView1, forSortPlans);
        //}

        private void buttonSelectAll2_Click(object sender, EventArgs e)
        {
            DisplayIntoDataGrid.DisplayContracts(dataGridView1, forSortContracts);
        }

        private void buttonSelectAll3_Click(object sender, EventArgs e)
        {
            DisplayIntoDataGrid.DisplayEmployees(dataGridView1, forSortEmployees);
        }

        private void buttonSort1_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            forSortUser.Sort((user1, user2) => user1.Name.CompareTo(user2.Name));
            stopwatch.Stop();
            labelSort1.Text = $"Метод sort вбудований: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayUsers(dataGridView1, forSortUser);
            forSortUser = MainForm.usersList.ToList();
        }

        //private void buttonQuickSort2_Click(object sender, EventArgs e)
        //{
        //    stopwatch.Restart();
        //    QuickSort(forSortPlans, (x, y) => x.Name.CompareTo(y.Name));
        //    stopwatch.Stop();
        //    labelQuickSort2.Text = $"Швидке сортування: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
        //    DisplayPlans(dataGridView1, forSortPlans);
        //    forSortPlans = MainForm.plansList.ToList();
        //}

        //private void buttonSort2_Click(object sender, EventArgs e)
        //{
        //    stopwatch.Restart();
        //    forSortPlans.Sort((plan1, plan2) => plan1.Name.CompareTo(plan2.Name));
        //    stopwatch.Stop();
        //    labelSort2.Text = $"Метод sort вбудований: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
        //    DisplayPlans(dataGridView1, forSortPlans);
        //    forSortPlans = MainForm.plansList.ToList();
        //}
        private void buttonQuickSort2_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            QuickS.QuickSort(forSortContracts, (x, y) => x.Price.CompareTo(y.Price));
            stopwatch.Stop();
            labelQuickSort2.Text = $"Швидке сортування: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayContracts(dataGridView1, forSortContracts);
            forSortContracts = MainForm.contractsList.ToList();
        }

        private void buttonSort2_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            forSortContracts.Sort((contract1, contract2) => contract1.Price.CompareTo(contract2.Price));
            stopwatch.Stop();
            labelSort2.Text = $"Метод sort вбудований: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayContracts(dataGridView1, forSortContracts);
            forSortContracts = MainForm.contractsList.ToList();
        }
        private void buttonQuickSort3_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            QuickS.QuickSort(forSortEmployees, (x, y) => x.Salary.CompareTo(y.Salary));
            stopwatch.Stop();
            labelQuickSort3.Text = $"Швидке сортування: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayEmployees(dataGridView1, forSortEmployees);
            forSortEmployees = MainForm.employeesList.ToList();
        }

        private void buttonSort3_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            forSortEmployees.Sort((employee1, employee2) => employee1.Salary.CompareTo(employee2.Salary));
            stopwatch.Stop();
            labelSort3.Text = $"Метод sort вбудований: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayEmployees(dataGridView1, forSortEmployees);
            forSortEmployees = MainForm.employeesList.ToList();
        }

        private void buttonMergeSort1_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            MergeS.MergeSort(forSortUser, (x, y) => x.Name.CompareTo(y.Name));
            stopwatch.Stop();
            labelMergeSort1.Text = $"Об'єднане сортування: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayUsers(dataGridView1, forSortUser);
            forSortUser = MainForm.usersList.ToList();
        }

        private void buttonMergeSort2_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            MergeS.MergeSort(forSortContracts, (x, y) => x.Price.CompareTo(y.Price));
            stopwatch.Stop();
            labelMergeSort2.Text = $"Об'єднане сортування: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayContracts(dataGridView1, forSortContracts);
            forSortContracts = MainForm.contractsList.ToList();
        }

        private void buttonMergeSort3_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            MergeS.MergeSort(forSortEmployees, (x, y) => x.Salary.CompareTo(y.Salary));
            stopwatch.Stop();
            labelMergeSort3.Text = $"Об'єднане сортування: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayEmployees(dataGridView1, forSortEmployees);
            forSortEmployees = MainForm.employeesList.ToList();
        }

        private void buttonHeapSort1_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            HeapSort<User>.Sort(forSortUser, (x, y) => x.Name.CompareTo(y.Name));
            stopwatch.Stop();
            labelHeapSort1.Text = $"Heap sort: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayUsers(dataGridView1, forSortUser);
            forSortUser = MainForm.usersList.ToList();
        }

        private void buttonHeapSort2_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            HeapSort<Contract>.Sort(forSortContracts, (x, y) => x.Price.CompareTo(y.Price));
            stopwatch.Stop();
            labelHeapSort2.Text = $"Heap sort: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayContracts(dataGridView1, forSortContracts);
            forSortContracts = MainForm.contractsList.ToList();
        }

        private void buttonHeapSort3_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            HeapSort<Employee>.Sort(forSortEmployees, (x, y) => x.Salary.CompareTo(y.Salary));
            stopwatch.Stop();
            labelHeapSort3.Text = $"Heap sort: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayEmployees(dataGridView1, forSortEmployees);
            forSortEmployees = MainForm.employeesList.ToList();
        }

        private void buttonTimSort1_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            TimSort<User>.Sort(forSortUser, (x, y) => x.Name.CompareTo(y.Name));
            stopwatch.Stop();
            labelTimSort1.Text = $"Tim sort: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayUsers(dataGridView1, forSortUser);
            forSortUser = MainForm.usersList.ToList();
        }

        private void buttonTimSort2_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            TimSort<Contract>.Sort(forSortContracts, (x, y) => x.Price.CompareTo(y.Price));
            stopwatch.Stop();
            labelTimSort2.Text = $"Tim sort: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayContracts(dataGridView1, forSortContracts);
            forSortContracts = MainForm.contractsList.ToList();
        }

        private void buttonTimSort3_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            TimSort<Employee>.Sort(forSortEmployees, (x, y) => x.Salary.CompareTo(y.Salary));
            stopwatch.Stop();
            labelTimSort3.Text = $"Tim sort: {stopwatch.Elapsed.TotalMilliseconds:F5} мс";
            DisplayIntoDataGrid.DisplayEmployees(dataGridView1, forSortEmployees);
            forSortEmployees = MainForm.employeesList.ToList();
        }
    }

    public static class HeapSort<T>
    {
        public static void Sort(List<T> list, Func<T, T, int> comparison)
        {
            int n = list.Count;

            // побудова купи, перегрупування списку
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(list, n, i, comparison);

            // вилучаємо елемент з купи
            for (int i = n - 1; i > 0; i--)
            {
                // переміщення поточного кореня в кінець
                T temp = list[0];
                list[0] = list[i];
                list[i] = temp;

                // виклик функції Heapify на скороченій купі
                Heapify(list, i, 0, comparison);
            }
        }

        // функція для вузла i
        private static void Heapify(List<T> list, int n, int i, Func<T, T, int> comparison)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            // перевірка існування лівого дочірнього елементу та його порівняння
            if (l < n && comparison(list[l], list[largest]) > 0)
                largest = l;

            // перевірка існування правого дочірнього елементу та його порівняння
            if (r < n && comparison(list[r], list[largest]) > 0)
                largest = r;

            // якщо найбільший елемент не корінь
            if (largest != i)
            {
                // обмін значеннями між коренем та найбільшим елементом
                T swap = list[i];
                list[i] = list[largest];
                list[largest] = swap;

                Heapify(list, n, largest, comparison);
            }
        }
    }

    public class DisplayIntoDataGrid {
        internal static void DisplayUsers(DataGridView dataGridView, List<User> usersList)
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

        internal static void DisplayPlans(DataGridView dataGridView, List<Plan> plansList)
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

        internal static void DisplayCompanies(DataGridView dataGridView, List<Company> companiesList)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            dataGridView.Columns.Add("Id", "ID");
            dataGridView.Columns.Add("Name", "Name");

            foreach (var company in companiesList)
            {
                dataGridView.Rows.Add(company.Id, company.Name);
            }
        }

        internal static void DisplayContracts(DataGridView dataGridView, List<Contract> contractsList)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            dataGridView.Columns.Add("Id", "ID");
            dataGridView.Columns.Add("UserId", "User ID");
            dataGridView.Columns.Add("PlanId", "Plan ID");
            dataGridView.Columns.Add("DateStart", "Start Date");
            dataGridView.Columns.Add("DateEnd", "End Date");
            dataGridView.Columns.Add("Price", "Price");
            dataGridView.Columns.Add("Status", "Status");
            dataGridView.Columns.Add("EmployeeId", "Employee ID");

            foreach (var contract in contractsList)
            {
                dataGridView.Rows.Add(
                    contract.Id,
                    contract.UserId,
                    contract.PlanId,
                    contract.DateStart.ToString("yyyy-MM-dd"),
                    contract.DateEnd.ToString("yyyy-MM-dd"),
                    contract.Price.ToString("C2"),
                    contract.Status,
                    contract.EmployeeId);
            }
        }

        internal static void DisplayEmployees(DataGridView dataGridView, List<Employee> employeesList)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            dataGridView.Columns.Add("Id", "ID");
            dataGridView.Columns.Add("Name", "Name");
            dataGridView.Columns.Add("Surname", "Surname");
            dataGridView.Columns.Add("Phone", "Phone");
            dataGridView.Columns.Add("DateOfBirth", "Date Of Birth");
            dataGridView.Columns.Add("Salary", "Salary");
            dataGridView.Columns.Add("PositionId", "Position Id");

            foreach (var employee in employeesList)
            {
                dataGridView.Rows.Add(employee.Id, employee.Name, employee.Surname, employee.Phone, employee.DateOfBirth.ToShortDateString(), employee.Salary, employee.PositionId);
            }
        }

    }

    public static class MergeS
    {
        //public static void Merge<T>(IList<T> array, int lowIndex, int middleIndex, int highIndex, Func<T, T, int> comparison)
        //{
        //    int left = lowIndex;
        //    int right = middleIndex + 1;
        //    T[] tempArray = new T[highIndex - lowIndex + 1];
        //    int index = 0;

        //    while (left <= middleIndex && right <= highIndex)
        //    {
        //        if (comparison(array[left], array[right]) < 0)
        //        {
        //            tempArray[index] = array[left];
        //            left++;
        //        }
        //        else
        //        {
        //            tempArray[index] = array[right];
        //            right++;
        //        }

        //        index++;
        //    }

        //    while (left <= middleIndex)
        //    {
        //        tempArray[index] = array[left];
        //        left++;
        //        index++;
        //    }

        //    while (right <= highIndex)
        //    {
        //        tempArray[index] = array[right];
        //        right++;
        //        index++;
        //    }

        //    for (int i = 0; i < tempArray.Length; i++)
        //    {
        //        array[lowIndex + i] = tempArray[i];
        //    }
        //}

        //public static void Merge<T>(IList<T> array, int lowIndex, int middleIndex, int highIndex, Func<T, T, int> comparison)
        //{
        //    int left = lowIndex;
        //    int right = middleIndex + 1;
        //    T[] tempArray = new T[highIndex - lowIndex + 1];
        //    int index = 0;

        //    while (left <= middleIndex && right <= highIndex)
        //    {
        //        if (comparison(array[left], array[right]) < 0)
        //        {
        //            tempArray[index] = array[left];
        //            left++;
        //        }
        //        else
        //        {
        //            tempArray[index] = array[right];
        //            right++;
        //        }

        //        index++;
        //    }

        //    while (left <= middleIndex)
        //    {
        //        tempArray[index] = array[left];
        //        left++;
        //        index++;
        //    }

        //    while (right <= highIndex)
        //    {
        //        tempArray[index] = array[right];
        //        right++;
        //        index++;
        //    }

        //    // Копіюємо тимчасовий масив назад в оригінальний, починаючи з lowIndex
        //    for (int i = 0; i < tempArray.Length; i++)
        //    {
        //        array[lowIndex + i] = tempArray[i];
        //    }
        //}

        public static void Merge<T>(IList<T> list, int left, int mid, int right, Func<T, T, int> comparison)
        {
            int leftLength = mid - left + 1;
            int rightLength = right - mid;

            T[] leftArray = new T[leftLength];
            T[] rightArray = new T[rightLength];

            for (int i = 0; i < leftLength; i++)
                leftArray[i] = list[left + i];

            for (int j = 0; j < rightLength; j++)
                rightArray[j] = list[mid + 1 + j];

            int mergedIndex = left, leftIndex = 0, rightIndex = 0;

            while (leftIndex < leftLength && rightIndex < rightLength)
            {
                if (comparison(leftArray[leftIndex], rightArray[rightIndex]) <= 0)
                    list[mergedIndex++] = leftArray[leftIndex++];
                else
                    list[mergedIndex++] = rightArray[rightIndex++];
            }

            while (leftIndex < leftLength)
                list[mergedIndex++] = leftArray[leftIndex++];

            while (rightIndex < rightLength)
                list[mergedIndex++] = rightArray[rightIndex++];
        }

        private static IList<T> MergeSort<T>(IList<T> array, int lowIndex, int highIndex, Func<T, T, int> comparison)
        {
            if (lowIndex < highIndex)
            {
                int middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(array, lowIndex, middleIndex, comparison);
                MergeSort(array, middleIndex + 1, highIndex, comparison);
                Merge(array, lowIndex, middleIndex, highIndex, comparison);
            }

            return array;
        }

        public static IList<T> MergeSort<T>(IList<T> array, Func<T, T, int> comparison)
        {
            return MergeSort(array, 0, array.Count - 1, comparison);
        }
    }

    public static class QuickS {
        internal static void QuickSort<T>(IList<T> list, Func<T, T, int> comparison)
        {
            QuickSort(list, 0, list.Count - 1, comparison);
        }

        private static void QuickSort<T>(IList<T> list, int left, int right, Func<T, T, int> comparison)
        {
            if (left < right)
            {
                int partitionIndex = Partition(list, left, right, comparison);

                QuickSort(list, left, partitionIndex - 1, comparison);
                QuickSort(list, partitionIndex + 1, right, comparison);
            }
        }

        private static int Partition<T>(IList<T> list, int left, int right, Func<T, T, int> comparison)
        {
            T pivot = list[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (comparison(list[j], pivot) <= 0)
                {
                    i++;
                    Swap(list, i, j);
                }
            }

            Swap(list, i + 1, right);
            return i + 1;
        }

        private static void Swap<T>(IList<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }

    public static class TimSort<T>
    {
        private const int MIN_MERGE = 32;

        public static void Sort(List<T> list, Func<T, T, int> comparison)
        {
            int n = list.Count;
            if (n < 2)
                return;

            int minRun = ComputeMinRun(n);

            for (int i = 0; i < n; i += minRun)
            {
                int end = Math.Min(i + minRun, n);
                InsertionSort(list, i, end, comparison);
            }

            // послідовне об'єднання сортованих підмасивів
            for (int size = minRun; size < n; size *= 2)
            {
                // вибираємо початковий інлекс для об'єднання двої підмасивів
                for (int left = 0; left < n; left += 2 * size)
                {
                    int mid = left + size - 1;
                    int right = Math.Min(left + 2 * size - 1, n - 1);
                    Merge(list, left, mid, right, comparison);
                }
            }
        }

        private static int ComputeMinRun(int n)
        {
            int r = 0;
            while (n >= MIN_MERGE)
            {
                r |= n & 1;
                n >>= 1;
            }
            return n + r;
        }

        private static void InsertionSort(List<T> list, int left, int right, Func<T, T, int> comparison)
        {
            for (int i = left + 1; i < right; i++)
            {
                T key = list[i];
                int j = i - 1;

                while (j >= left && comparison(list[j], key) > 0)
                {
                    list[j + 1] = list[j];
                    j--;
                }

                list[j + 1] = key;
            }
        }

        private static void Merge(List<T> list, int left, int mid, int right, Func<T, T, int> comparison)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            T[] leftArray = new T[n1];
            T[] rightArray = new T[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = list[left + i];

            for (int j = 0; j < n2; j++)
                rightArray[j] = list[mid + 1 + j];

            int k = left, l = 0, r = 0;

            while (l < n1 && r < n2)
            {
                if (comparison(leftArray[l], rightArray[r]) <= 0)
                    list[k++] = leftArray[l++];
                else
                    list[k++] = rightArray[r++];
            }

            while (l < n1)
                list[k++] = leftArray[l++];

            while (r < n2)
                list[k++] = rightArray[r++];
        }
    }





    //public class HeapSort<T>
    //{
    //    public static void Sort(T[] array, Func<T, T, int> comparison)
    //    {
    //        int n = array.Length;

    //        // Будуємо купу (Heap)
    //        for (int i = n / 2 - 1; i >= 0; i--)
    //        {
    //            Heapify(array, n, i, comparison);
    //        }

    //        // Поступово вилучаємо найбільший (або найменший) елемент з купи та додаємо його до відсортованого масиву
    //        for (int i = n - 1; i > 0; i--)
    //        {
    //            Swap(array, 0, i);
    //            Heapify(array, i, 0, comparison);
    //        }
    //    }

    //    private static void Heapify(T[] array, int n, int i, Func<T, T, int> comparison)
    //    {
    //        int largest = i;
    //        int left = 2 * i + 1;
    //        int right = 2 * i + 2;

    //        if (left < n && comparison(array[left], array[largest]) > 0)
    //        {
    //            largest = left;
    //        }

    //        if (right < n && comparison(array[right], array[largest]) > 0)
    //        {
    //            largest = right;
    //        }

    //        if (largest != i)
    //        {
    //            Swap(array, i, largest);
    //            Heapify(array, n, largest, comparison);
    //        }
    //    }

    //    private static void Swap(T[] array, int i, int j)
    //    {
    //        T temp = array[i];
    //        array[i] = array[j];
    //        array[j] = temp;
    //    }
    //}


}
