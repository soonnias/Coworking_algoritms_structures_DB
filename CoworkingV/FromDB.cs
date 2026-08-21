using Coworking;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoworkingV
{
    public partial class FromDB : Form
    {
        public FromDB()
        {
            InitializeComponent();
            updateCBCompany();
            comboBoxDeskUpdate.SelectedIndex = 0;
            comboBoxCompanyUpdateUser.SelectedIndex = 0;
        }

        private void updateCBCompany()
        {
            comboBoxCompanyUpdateUser.Items.Clear();
            
            foreach (Coworking.Company item in MainForm.companiesList)
            {
                comboBoxCompanyUpdateUser.Items.Add(item.Name);
            }
        }
        private void selectAllDesks_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM desks";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewDesks.DataSource = dataTable;
        }

        private void buttonUpdateDesk_Click(object sender, EventArgs e)
        {
            int number = (int)numericUpDownUpdateDesk.Value;
            string ac = comboBoxDeskUpdate.Text;
            string query = $"update desks set accessibility = '{ac}' where number = {number}";

            DatabaseManager.ExecuteQuery(query);

            selectAllDesks_Click(sender, e);
        }

        private void buttonDeletDesk_Click(object sender, EventArgs e)
        {
            int number = (int)numericUpDownDeleteDesk.Value;
            string query = $"update contracts\r\nset id_desk = null\r\nwhere id_desk = {number};\r\ndelete from desks where number = {number};";

            DatabaseManager.ExecuteQuery(query);
            selectAllDesks_Click(sender, e);
        }

        private void buttonFiltr1Desk_Click(object sender, EventArgs e)
        {
            string query = "select * from desks where number like '1%'";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewDesks.DataSource = dataTable;
        }
        
        private void buttonFiltr2Desk_Click(object sender, EventArgs e)
        {
            string query = "select * from desks where accessibility = \"Доступний\" and number in (1,5,10,13,20)";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewDesks.DataSource = dataTable;
        }

        private void buttonFiltr3Desk_Click(object sender, EventArgs e)
        {
            string query = "select * from desks where number between 10 and 20 or id<5";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewDesks.DataSource = dataTable;
        }

        private void buttonSortDesk_Click(object sender, EventArgs e)
        {
            string query = "select * from desks order by number desc limit 5 offset 5";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewDesks.DataSource = dataTable;
        }

        private void buttonCountDesk_Click(object sender, EventArgs e)
        {
            string query = "select count(*) from desks";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewDesks.DataSource = dataTable;
        }

        private void buttonMaxDesk_Click(object sender, EventArgs e)
        {
            string query = "select max(number) from desks";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewDesks.DataSource = dataTable;
        }

        private void buttonGroupDesk_Click(object sender, EventArgs e)
        {
            string query = "select accessibility, count(*) as CountDesks from desks group by accessibility";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewDesks.DataSource = dataTable;
        }

        private void buttonSubDesk1_Click(object sender, EventArgs e)
        {
            string query = "select * from desks where number = (select MAX(number) from desks)";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewDesks.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select id_desk, countDesk from( select id_desk, count(*) as countDesk from contracts group by id_desk )as deskCounts;";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewDesks.DataSource = dataTable;
        }

        private void buttonSubDesk3_Click(object sender, EventArgs e)
        {
            string query = "select *, (\nselect count(*)\nfrom contracts\nwhere desks.id = contracts.id_desk\ngroup by id_desk\n) as countDesk\nfrom desks;";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewDesks.DataSource = dataTable;
        }

        private void buttonExistDesk_Click(object sender, EventArgs e)
        {
            string query = "select *\r\nfrom desks d\r\nwhere exists (\r\n    select 1\r\n    from contracts c\r\n    where c.id_desk = d.id\r\n);";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewDesks.DataSource = dataTable;
        }

        private void buttonSelectAllPlans_Click(object sender, EventArgs e)
        {
            string query = "select * from plans";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewPlans.DataSource = dataTable;
        }

        private void buttonUpdatePlans_Click(object sender, EventArgs e)
        {
            int number = (int)numericUpDownIdPlansUpdate.Value;
            string name = textBoxUpdateName.Text;
            string description = richTextBoxUpdateDescription.Text;
            double price;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Заповніть всі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                price = double.Parse(textBoxPriceUpdatePlans.Text);
                if (price <= 0) {
                    MessageBox.Show("Ціна неправильна", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch {
                MessageBox.Show("Ціна неправильна", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        

            string query = $"update plans\r\nset name = '{name}', description = '{description}', price = {price} where id = {number};";
            DatabaseManager.ExecuteQuery(query);

            buttonSelectAllPlans_Click(sender, e);
        }

        private void buttonDeletePlans_Click(object sender, EventArgs e)
        {
            int number = (int)numericUpDownIdDeletePlans.Value;
            string query = $"update contracts set id_plan = null where id_plan = {number};delete from plans where id = {number};";
            DatabaseManager.ExecuteQuery(query);

            buttonSelectAllPlans_Click(sender, e);
        }

        private void buttonFiltrPlans1_Click(object sender, EventArgs e)
        {
            string query = "select * from plans where name like \"a%\";";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewPlans.DataSource = dataTable;
        }

        private void buttonFiltrsPlans3_Click(object sender, EventArgs e)
        {
            string query = "select* from plans where price between 190 and 210 or id<5;";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewPlans.DataSource = dataTable;
        }

        private void buttonFiltrPlans2_Click(object sender, EventArgs e)
        {
            string query = "select* from plans where price < 200 and name not like \"%й\"";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewPlans.DataSource = dataTable;
        }

        private void buttonPlansSort_Click(object sender, EventArgs e)
        {
            string query = "select* from plans\r\norder by price desc\r\nlimit 5\r\noffset 1;";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewPlans.DataSource = dataTable;

        }

        private void buttonAFPlans1_Click(object sender, EventArgs e)
        {
            string query = "select count(*) as countAllPlans from plans";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewPlans.DataSource = dataTable;
        }

        private void buttonAFPlans2_Click(object sender, EventArgs e)
        {
            string query = "select max(name) as maxPlansName from plans";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewPlans.DataSource = dataTable;
        }

        private void buttonAFPlans3_Click(object sender, EventArgs e)
        {
            string query = "select avg(price) as averagePlansPrice from plans";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewPlans.DataSource = dataTable;
        }

        private void buttonGroupPlans_Click(object sender, EventArgs e)
        {
            string query = "select left(plans.name, 1) as first_letter, count(*) as count_plans\r\nfrom plans\r\ngroup by left(plans.name, 1)\r\norder by left(plans.name, 1);";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewPlans.DataSource = dataTable;
        }

        private void buttonSubPlans1_Click(object sender, EventArgs e)
        {
            string query = "select * from plans\r\nwhere name = (select max(name) from plans);";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewPlans.DataSource = dataTable;
        }

        private void buttonGroupPlans2_Click(object sender, EventArgs e)
        {
            string query = "select left(plans.name, 1) as first_letter, count(*) as count_plans\r\nfrom plans\r\ngroup by left(plans.name, 1)\r\nhaving count(*)>10\r\norder by left(plans.name, 1);";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewPlans.DataSource = dataTable;
        }

        private void buttonSubPlans2_Click(object sender, EventArgs e)
        {
            string query = "select id_plan, countPlan\r\nfrom (\r\n    select id_plan, count(*) as countPlan\r\n    from contracts\r\n    group by id_plan\r\n) as planCounts;";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewPlans.DataSource = dataTable;
        }

        private void buttonSubPlans3_Click(object sender, EventArgs e)
        {
            string query = "select *, (\r\nselect count(*) from contracts\r\nwhere plans.id = contracts.id_plan\r\ngroup by id_plan\r\n) as countPlan\r\nfrom plans;";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewPlans.DataSource = dataTable;
        }

        private void buttonExistPlans_Click(object sender, EventArgs e)
        {
            string query = "select *\r\nfrom plans p\r\nwhere exists(\r\nselect 1\r\nfrom contracts c\r\nwhere c.id_plan = p.id\r\n);";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewPlans.DataSource = dataTable;
        }

        private void buttonUsersSelectAll_Click(object sender, EventArgs e)
        {
            string query = "select * from users";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewUsers.DataSource = dataTable;
        }

        private void buttonUsersUpdate_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDownIDUpdateUser.Value;
            string name = textBoxNAmeUpdateUser.Text;
            string surname = textBoxSurnameUpdateUser.Text;
            string phone = textBoxPhoneUpdateUser.Text;
            string email = textBoxEMailUpdateUser.Text;
            int company = comboBoxCompanyUpdateUser.SelectedIndex;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Заповніть всі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            string query = $"update users\r\nset name = '{name}', surname = '{surname}', phone = '{phone}', email = '{email}', id_company = {company} where id = {id};";
            DatabaseManager.ExecuteQuery(query);
            buttonUsersSelectAll_Click(sender, e);
        }

        private void buttonUsersFiltr1_Click(object sender, EventArgs e)
        {
            string query = "select * from users where name like 'Я%' or surname like '%ий'";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewUsers.DataSource = dataTable;
        }

        private void buttonUsersFiltr2_Click(object sender, EventArgs e)
        {
            string query = "select * from users where id_company in(110,120,130,140) or year(date_of_birth)=1985;";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewUsers.DataSource = dataTable;
        }

        private void buttonUsersFiltr3_Click(object sender, EventArgs e)
        {
            string query = "select * from users where id_company not between 90 and 400";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewUsers.DataSource = dataTable;
        }

        private void buttonUsersSort_Click(object sender, EventArgs e)
        {
            string query = "select * from users \r\norder by date_of_birth asc \r\nlimit 100 \r\noffset 1;";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewUsers.DataSource = dataTable;
        }

        private void buttonUsersAF1_Click(object sender, EventArgs e)
        {
            string query = "select count(*) as countUsers from users";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewUsers.DataSource = dataTable;
        }

        private void buttonUsersAF2_Click(object sender, EventArgs e)
        {
            string query = "select max(surname) as minSurname from users";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewUsers.DataSource = dataTable;
        }

        private void buttonUsersAF3_Click(object sender, EventArgs e)
        {
            string query = "select round(avg(year(date_of_birth))) as avgYearOfBirth from users;";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewUsers.DataSource = dataTable;
        }

        private void buttonUsersGroup1_Click(object sender, EventArgs e)
        {
            string query = "select year(date_of_birth) as birth_year, count(*) AS user_count\r\nfrom users\r\ngroup by year(date_of_birth);";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewUsers.DataSource = dataTable;
        }

        private void buttonUsersGroup2_Click(object sender, EventArgs e)
        {
            string query = "select year(date_of_birth) as birth_year, count(*) AS user_count\r\nfrom users\r\ngroup by year(date_of_birth) having count(*)=1;";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewUsers.DataSource = dataTable;
        }

        private void buttonUsersSub1_Click(object sender, EventArgs e)
        {
            string query = "select * from users where year(date_of_birth) = (select max(year(date_of_birth)) from users)";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewUsers.DataSource = dataTable;
        }

        private void buttonUsersSub2_Click(object sender, EventArgs e)
        {
            string query = "select name, surname, phone, id_company\r\nfrom(\r\nselect * from users\r\nwhere id_company = 165\r\n)as sub;";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewUsers.DataSource = dataTable;
        }

        private void buttonUsersSub3_Click(object sender, EventArgs e)
        {
            string query = "select id, name, surname, phone, \r\n(\r\nselect count(*) from contracts\r\nwhere contracts.id_user = users.id\r\n)as countContracts\r\nfrom users;";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewUsers.DataSource = dataTable;
        }

        private void buttonUsersExist_Click(object sender, EventArgs e)
        {
            string query = "select * from users u\r\nwhere exists\r\n(\r\nselect 1\r\nfrom contracts c\r\nwhere c.id_user = u.id\r\n);";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewUsers.DataSource = dataTable;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void buttonPositionInner_Click(object sender, EventArgs e)
        {
            string query = "select positions.id, positions.name, count(employees.position_id) as countPositions\r\nfrom positions\r\ninner join employees on positions.id = employees.position_id\r\ngroup by positions.id, positions.name;";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewJoin.DataSource = dataTable;
        }

        private void buttonSACompanies_Click(object sender, EventArgs e)
        {
            string query = "select * from positions";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewJoin.DataSource = dataTable;
        }

        private void buttonPositionLeft_Click(object sender, EventArgs e)
        {
            string query = "select positions.id, positions.name, count(employees.position_id) as countPositions\r\nfrom positions\r\nleft join employees on positions.id = employees.position_id\r\ngroup by positions.id, positions.name;";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewJoin.DataSource = dataTable;
        }

        private void buttonPositionRight_Click(object sender, EventArgs e)
        {
            string query = "select distinct positions.name, employees.position_id\r\nfrom positions\r\nright join employees on positions.id = employees.position_id;";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewJoin.DataSource = dataTable;
        }

        private void buttonPositionFull_Click(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCT positions.id, positions.name, employees.position_id\r\nFROM positions\r\nLEFT JOIN employees ON positions.id = employees.position_id\r\nUNION\r\nSELECT DISTINCT positions.id, positions.name,employees.position_id\r\nFROM positions\r\nRIGHT JOIN employees ON positions.id = employees.position_id";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewJoin.DataSource = dataTable;
        }

        private void buttonSAUsers_Click(object sender, EventArgs e)
        {
            string query = "select * from users";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewJoin.DataSource = dataTable;
        }

        private void buttonUsersInner_Click(object sender, EventArgs e)
        {
            string query = "select users.id, users.name, users.surname, users.email, count(contracts.id_user) as countContracts\r\nfrom users\r\ninner join contracts on users.id = contracts.id_user\r\ngroup by users.id, users.name, users.surname, users.email;";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewJoin.DataSource = dataTable;
        }

        private void buttonUsersLeft_Click(object sender, EventArgs e)
        {
            string query = "select users.id, users.name, users.surname, users.email, count(contracts.id_user) as countContracts\r\nfrom users\r\nleft join contracts on users.id = contracts.id_user\r\ngroup by users.id, users.name, users.surname, users.email;";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewJoin.DataSource = dataTable;
        }

        private void buttonUsersRight_Click(object sender, EventArgs e)
        {
            string query = "\r\nselect distinct users.name, users.surname, users.email, contracts.id_user\r\nfrom users\r\nright join contracts on users.id = contracts.id_user;";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewJoin.DataSource = dataTable;
        }

        private void buttonUsersFull_Click(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCT users.id, users.name, users.surname, users.email, contracts.id_user\r\nFROM users\r\nLEFT JOIN contracts ON users.id = contracts.id_user\r\nUNION\r\nSELECT DISTINCT users.id, users.name, users.surname, users.email, contracts.id_user\r\nFROM users\r\nRIGHT JOIN contracts ON users.id = contracts.id_user\r\nWHERE users.id IS NULL;";
            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            this.dataGridViewJoin.DataSource = dataTable;
        }





        //VARIABLES AND VIEWS
        private void buttonVariablesPosition_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@endNamePosition", "адміністратор" }
            };

            DataTable result = DatabaseManager.ExecuteParametrizedSelectQuery("SELECT * FROM positions WHERE name LIKE CONCAT('%', @endNamePosition)", parameters);
            this.dataGridViewVariablesAndViews.DataSource = result;
        }

        private void buttonCreateViewPosition_Click(object sender, EventArgs e)
        {
            string name_view = textBoxCreateViewPosition.Text.Trim();
            if (String.IsNullOrWhiteSpace(name_view))
            {
                MessageBox.Show("Заповніть всі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"create view {name_view} as\r\nselect name\r\nfrom positions;";

            DatabaseManager.ExecuteQuery(query);
        }

        private void buttonSelectFromViewPosition_Click(object sender, EventArgs e)
        {
            string name_view = textBoxSelectFromViewPosition.Text.Trim();
            if (String.IsNullOrWhiteSpace(name_view))
            {
                MessageBox.Show("Заповніть всі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"select * from {name_view}";

            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            dataGridViewVariablesAndViews.DataSource = dataTable;
        }

        private void buttonUpdateViewPosition_Click(object sender, EventArgs e)
        {
            string name_view = textBoxUpdateViewPosition.Text.Trim();
            if (String.IsNullOrWhiteSpace(name_view))
            {
                MessageBox.Show("Заповніть всі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"update {name_view} \r\nset name = 'Посада №13'\r\nwhere name = 'Посада №23';";
            DatabaseManager.ExecuteQuery(query);
        }

        private void buttonDeleteFromViewPosition_Click(object sender, EventArgs e)
        {
            string name_view = textBoxDeleteFromViewPosition.Text.Trim();
            if (String.IsNullOrWhiteSpace(name_view))
            {
                MessageBox.Show("Заповніть всі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"delete from {name_view} \r\nwhere name = 'positionForDelete';";
            DatabaseManager.ExecuteQuery(query);
        }

        private void buttonDropViewPosition_Click(object sender, EventArgs e)
        {
            string name_view = textBoxDropViewPosition.Text.Trim();
            if (String.IsNullOrWhiteSpace(name_view))
            {
                MessageBox.Show("Заповніть всі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"drop view {name_view};";
            DatabaseManager.ExecuteQuery(query);
        }

        private void buttonVariablesEmployees_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@age", 30 }
            };

            DataTable result = DatabaseManager.ExecuteParametrizedSelectQuery("select * \r\nfrom employees\r\nwhere TIMESTAMPDIFF(YEAR, date_of_birth, CURDATE()) > @age;", parameters);
            this.dataGridViewVariablesAndViews.DataSource = result;
        }

        private void buttonCreateViewEmployees_Click(object sender, EventArgs e)
        {
            string name_view = textBoxCreateViewEmployees.Text.Trim();
            if (String.IsNullOrWhiteSpace(name_view))
            {
                MessageBox.Show("Заповніть всі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"CREATE VIEW {name_view} AS\r\nSELECT e.id, e.name, e.surname, e.phone, e.salary, p.name AS position_name\r\nFROM employees e\r\nJOIN positions p ON e.position_id = p.id;";
            DatabaseManager.ExecuteQuery(query);
        }

        private void buttonSelectFromViewEmployees_Click(object sender, EventArgs e)
        {
            string name_view = textBoxSelectFromViewEmployees.Text.Trim();
            if (String.IsNullOrWhiteSpace(name_view))
            {
                MessageBox.Show("Заповніть всі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"select * from {name_view}";

            DataTable dataTable = DatabaseManager.ExecuteSelectQuery(query);
            dataGridViewVariablesAndViews.DataSource = dataTable;
        }

        private void buttonDropViewEmployees_Click(object sender, EventArgs e)
        {
            string name_view = textBoxDropViewEmployees.Text.Trim();
            if (String.IsNullOrWhiteSpace(name_view))
            {
                MessageBox.Show("Заповніть всі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"drop view {name_view};";
            DatabaseManager.ExecuteQuery(query);
        }

        private void buttonUpdateViewEmployees_Click(object sender, EventArgs e)
        {
            string name_view = textBoxUpdateViewEmployees.Text.Trim();
            int id = (int)numericUpDownIdEmployees.Value;
            string salary = textBoxSalaryEmployee.Text.Trim(); 
            if (String.IsNullOrWhiteSpace(name_view)|| String.IsNullOrWhiteSpace(salary))
            {
                MessageBox.Show("Заповніть всі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float salaryF;
            try
            {
                salaryF = float.Parse(salary);
                if (salaryF <= 0)
                {
                    MessageBox.Show("Введіть коректну ціну", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = $"update {name_view} \r\nset salary = {salaryF}\r\nwhere id = {id};";
                DatabaseManager.ExecuteQuery(query);
            }
            catch {
                MessageBox.Show("Введіть коректну ціну", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
