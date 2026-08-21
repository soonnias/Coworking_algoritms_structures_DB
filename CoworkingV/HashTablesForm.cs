using Bogus.DataSets;
using Bogus;
using Coworking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml.Linq;
using Mysqlx.Crud;

namespace CoworkingV
{
    public partial class HashTablesForm : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        public HashTablesForm()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2Update.MaxDate = DateTime.Now;       
            updateCBCompany();
            comboBoxCompany.SelectedIndex = 0;
            comboBoxCompanyUpdate.SelectedIndex = 0;
            updatDG();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) ||
        string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime date = dateTimePicker1.Value.Date;
            int company_id = comboBoxCompany.SelectedIndex;

            User user = new User(name, surname, email, phone, date, company_id);
            addUserD(user);
            addUserT(user);
            updatDG();
        }
        private void addUserD(User user) {
            stopwatch.Restart();
            bool added =  MainForm.userDictionary.Add(user);
            stopwatch.Stop();
            if (!added) MessageBox.Show("Користувач з таким email та телефоном вже існує.1", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else MessageBox.Show("Успішно додано нового користувача 1");
            labelTimeIn.Text = $"Час вбудованої:{stopwatch.Elapsed.TotalMilliseconds:F5} мс;";
        }
        private void addUserT(User user)
        {
            bool added;
            stopwatch.Restart();
            added = MainForm.hashTableUser.Insert(user);
            stopwatch.Stop();
            if (!added) MessageBox.Show("Користувач з таким email та телефоном вже існує.2", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else MessageBox.Show("Успішно додано нового користувача 2");
            labelTimeMy.Text = $"Час моєї:{stopwatch.Elapsed.TotalMilliseconds:F5} мс;";
        }       

        private void updateCBCompany()
        {
            comboBoxCompany.Items.Clear();
            comboBoxCompanyUpdate.Items.Clear();
            foreach (Coworking.Company item in MainForm.companiesList)
            {
                comboBoxCompany.Items.Add(item.Name);
                comboBoxCompanyUpdate.Items.Add(item.Name);
            }
        }

        private void updatDG()
        {
            var users = MainForm.userDictionary.getD().Values;
            dataGridViewUsers.Rows.Clear();
            foreach (var user in users)
            {
                dataGridViewUsers.Rows.Add(user.Name, user.Surname, user.Email, user.Phone, user.DateOfBirth.ToShortDateString(), user.CompanyId);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string phone = textBoxPhoneForDelete.Text;
            string email = textBoxEmailForDelete.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            deleteD(phone, email);
            deleteT(phone, email);
            updatDG();
        }
        private void deleteD(string phone, string email)
        {
            bool deleted;
            stopwatch.Restart();
            deleted = MainForm.userDictionary.Delete(phone, email);
            stopwatch.Stop();
            labelTimeIn.Text = $"Час вбудованої:{stopwatch.Elapsed.TotalMilliseconds:F5} мс;";
            if (deleted) MessageBox.Show("Успішно видалено 1");
            else MessageBox.Show("Помилка при видаленні 1");
        }
        private void deleteT(string phone, string email)
        {
            bool deleted;
            stopwatch.Restart();
            deleted = MainForm.hashTableUser.Delete(phone, email);
            stopwatch.Stop();
            labelTimeMy.Text = $"Час моєї:{stopwatch.Elapsed.TotalMilliseconds:F5} мс;";
            if (deleted) MessageBox.Show("Успішно видалено 2");
            else MessageBox.Show("Помилка при видаленні 2");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string phone = textBoxPhoneForSearch.Text;
            string email = textBoxEmailForSearch.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            searchD(phone, email);
            searchT(phone, email);

        }
        private void searchD(string phone, string email)
        {
            stopwatch.Restart();
            User user = MainForm.userDictionary.Search(phone, email);
            if (user != null) { richTextBoxFinded1.Text = $"Знайдено: {user.Name}  {user.Surname}  {user.Phone}  {user.Email}  {user.CompanyId}"; }
            else richTextBoxFinded1.Text = $"Не знайдено користувача з такими даними";
            stopwatch.Stop();
            labelTimeIn.Text = $"Час вбудованої:{stopwatch.Elapsed.TotalMilliseconds:F5} мс;";
        }
        private void searchT(string phone, string email)
        {
            stopwatch.Restart();
            User user = MainForm.hashTableUser.Search(phone, email);
            if (user != null) { richTextBoxFinded2.Text = $"Знайдено: {user.Name}  {user.Surname}  {user.Phone}  {user.Email}  {user.CompanyId}"; }
            else richTextBoxFinded2.Text = $"Не знайдено користувача з такими даними";
            stopwatch.Stop();
            labelTimeMy.Text = $"Час моєї:{stopwatch.Elapsed.TotalMilliseconds:F5} мс;";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string name = textBoxNameUpdate.Text;
            string surname = textBoxSurnameUpdate.Text;
            string email = textBoxEmailUpdate.Text;
            string phone = textBoxPhoneUpdate.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) ||
        string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime date = dateTimePicker2Update.Value.Date;
            int company_id = comboBoxCompanyUpdate.SelectedIndex;
            User user = new User(name, surname, email, phone, date, company_id);

            updateD(user);
            updateT(user);
            updatDG();

        }
        private void updateD(User user)
        {
            bool updated;
            stopwatch.Restart();
            updated = MainForm.userDictionary.Update(user);
            stopwatch.Stop();
            labelTimeIn.Text = $"Час вбудованої:{stopwatch.Elapsed.TotalMilliseconds:F5} мс;";
            if (updated) MessageBox.Show("Успішно оновлено 1");
            else MessageBox.Show("Помилка при оновлені 1");
        }
        private void updateT(User user)
        {
            bool updated;
            stopwatch.Restart();
            updated = MainForm.hashTableUser.Update(user);
            stopwatch.Stop();
            labelTimeMy.Text = $"Час моєї:{stopwatch.Elapsed.TotalMilliseconds:F5} мс;";
            if (updated) MessageBox.Show("Успішно оновлено 2");
            else MessageBox.Show("Помилка при оновлені 2");
        }

        private void buttonIsExist_Click(object sender, EventArgs e)
        {
            string phone = textBoxPhoneForIsExist.Text;
            string email = textBoxEmailForIsExist.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            isExistD(phone, email);
            isExistT(phone, email);
        }

        private void isExistD(string phone, string email)
        {
            stopwatch.Restart();
            bool isExist = MainForm.userDictionary.Contains(phone, email);
            stopwatch.Stop();
            labelTimeIn.Text = $"Час вбудованої:{stopwatch.Elapsed.TotalMilliseconds:F5} мс;";

            if (isExist) labelInIsExist.Text = "Вбудована: існує таке значення";
            else labelInIsExist.Text = "Вбудована: не існує такого значення";
        }

        private void isExistT(string phone, string email)
        {
            stopwatch.Restart();
            bool isExist = MainForm.userDictionary.Contains(phone, email);
            stopwatch.Stop();
            labelTimeMy.Text = $"Час моєї:{stopwatch.Elapsed.TotalMilliseconds:F5} мс;";

            if (isExist) labelMyIsExist.Text = "Власна: існує таке значення";
            else labelMyIsExist.Text = "Власна: не існує такого значення";
        }

        private void buttonLook_Click(object sender, EventArgs e)
        {
            int c;
            stopwatch.Restart();
            c = MainForm.userDictionary.IterateAllValues();
            stopwatch.Stop();
            labelTimeIn.Text = $"Час вбудованої:{stopwatch.Elapsed.TotalMilliseconds:F5} мс     {c};";

            stopwatch.Restart();
            c = MainForm.hashTableUser.Iterate();
            stopwatch.Stop();
            labelTimeMy.Text = $"Час моєї:{stopwatch.Elapsed.TotalMilliseconds:F5} мс           {c};";

        }
    }



    internal class UserHashTable
    {
        private const int TableSize = 10000; // розмір хеш-таблиці
        private LinkedList<User>[] table; // масив списків для кожного елемента таблиці

        public UserHashTable()
        {
            table = new LinkedList<User>[TableSize];
            for (int i = 0; i < TableSize; i++)
            {
                table[i] = new LinkedList<User>();
            }
        }

        // генерує хеш для користувача на основі телефону та пошти
        //private int HashFunction(string phone, string email)
        //{
        //    int hash = 17;
        //    hash = hash * 23 + phone.GetHashCode();
        //    hash = hash * 23 + email.GetHashCode();
        //    return hash % TableSize;
        //}

        private ulong HashFunction(string phone, string email)
        {
            string str = phone + email;
            ulong hash = 5381;

            foreach (char c in str)
            {
                hash = ((hash << 5) + hash) + (ulong)c; // hash * 33 + c
            }

            return hash;
        }


        public bool Insert(User user)
        {
            // перевірка унікальність комбінації email та телефону
            if (!Contains(user.Email, user.Phone))
            {
                ulong index = HashFunction(user.Phone, user.Email) % (ulong)TableSize;
                table[index].AddLast(user);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Iterate()
        {
            int c = 0;
            for (int i = 0; i < TableSize; i++)
            {
                foreach (var user in table[i])
                {
                    c++;
                    Console.WriteLine(user.Email);
                }
            }
            return c;
        }

        public User Search(string phone, string email)
        {
            ulong index = HashFunction(phone, email) % (ulong)TableSize;
            foreach (User user in table[index])
            {
                if (user.Phone == phone && user.Email == email)
                {
                    return user;
                }
            }
            return null;
        }

        public bool Delete(string phone, string email)
        {
            ulong index = HashFunction(phone, email) % (ulong)TableSize;
            LinkedList<User> list = table[index];
            foreach (User user in list)
            {
                if (user.Phone == phone && user.Email == email)
                {
                    list.Remove(user);
                    return true;
                }
            }
            return false;
        }

        public bool Update(User updatedUser)
        {
            ulong index = HashFunction(updatedUser.Phone, updatedUser.Email) % (ulong)TableSize;
            LinkedList<User> list = table[index];
            foreach (User user in list)
            {
                if (user.Phone == updatedUser.Phone && user.Email == updatedUser.Email)
                {
                    user.Name = updatedUser.Name;
                    user.Surname = updatedUser.Surname;
                    user.DateOfBirth = updatedUser.DateOfBirth;
                    user.CompanyId = updatedUser.CompanyId;
                    return true;
                }
            }
            return false;
        }

        public bool Contains(string phone, string email)
        {
            ulong index = HashFunction(phone, email) % (ulong)TableSize;

            if (table[index].Count != 0) return true;
            //foreach (User user in table[index])
            //{
            //    if (user.Phone == phone && user.Email == email)
            //    {
            //        return true;
            //    }
            //}
            return false;
        }
    }
        internal class UserDictionary
        {
            private Dictionary<string, User> dictionary; //ключ - комбінований email та телефон

            public UserDictionary()
            {
                dictionary = new Dictionary<string, User>();
            }

            public Dictionary<string, User> getD()
            {
                return dictionary;
            }

            public bool Add(User user)
            {
                // перевірка унікальності комбінації email та телефону
                string key = user.Email + "_" + user.Phone;
                if (!dictionary.ContainsKey(key))
                {
                    dictionary.Add(key, user);
                    return true;
                }
                else
                {
                    MessageBox.Show("Користувач з таким email та телефоном вже існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            public User Search(string email, string phone)
            {
                string key = phone + "_" + email ;
                if (dictionary.ContainsKey(key))
                {
                    return dictionary[key];
                }
                else
                {
                    return null;
                }
            }

            public bool Delete(string email, string phone)
            {
            string key = phone + "_" + email;
            if (dictionary.ContainsKey(key))
                {
                    dictionary.Remove(key);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool Contains(string email, string phone)
            {
                string key = phone + "_" + email;
                return dictionary.ContainsKey(key);
            }

            public bool Update(User updatedUser)
            {
                string key = updatedUser.Email + "_" +updatedUser.Phone;
                if (dictionary.ContainsKey(key))
                    {
                        dictionary[key] = updatedUser;
                        return true; 
                    }
                    else
                    {
                        return false; 
                    }
            }

            public int GetCount()
            {
                return dictionary.Count;
            }

        public int IterateAllValues()
        {
            int c = 0;
            foreach (User user in dictionary.Values)
            {
                Console.WriteLine(user.Email);
                c++;
            }
            return c;
        }
    }
    
}

