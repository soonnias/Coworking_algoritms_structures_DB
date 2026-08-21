using Coworking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoworkingV
{
    public partial class MainForm : Form
    {
        private Form activeForm;
        //масив
        public static Position[] positions = new Position[30];
        //зв'язний список
        public static LinkedList<Plan> plans = new LinkedList<Plan>();

        //черги
        internal static Queue<Desk> queueDesk = new Queue<Desk>();
        internal static ArrayQueue queueArrayDesk = new ArrayQueue(10);
        internal static LinkedListQueue queueListDesk = new LinkedListQueue();

        //стеки
        internal static Stack<Company> stackC = new Stack<Company>();
        internal static ArrayStack<Company> stackArrayC = new ArrayStack<Company>(10);
        internal static LinkedListStack<Company> stackListC = new LinkedListStack<Company>();

        //граф
        internal static Graph graphDesk = new Graph();

        //бінарне дерево
        internal static EmployeeBST bst;

        //хеш-таблиця
        internal static UserHashTable hashTableUser;
        internal static UserDictionary userDictionary;



        //витягнуті з бд
        internal static List<Employee> employeesList = new List<Employee>();
        internal static List<Position> positionList = new List<Position>();
        internal static List<Company> companiesList = new List<Company>();
        internal static List<User> usersList = new List<User>();
        internal static List<Plan> plansList = new List<Plan>();
        internal static List<Contract> contractsList = new List<Contract>(); 
        internal static List<Desk> desksList = new List<Desk>();

        internal static Graph graphDeskD = new Graph();

        public MainForm() 
        {
            InitializeComponent();
            DatabaseManager.OpenConnection();
            //DatabaseManager.InsertCompanies();
            //DatabaseManager.InsertDesks();
            //DatabaseManager.InsertPositions();
            //DatabaseManager.InsertPlans();
            //DatabaseManager.InsertEmployees();
            //DatabaseManager.InsertUsers();
            //DatabaseManager.InsertContracts();
            generateSomePosition();
            generateSomePlans();
            
            PositionForm nf = new PositionForm();
            OpenChildForm(nf);
            employeesList = DatabaseManager.LoadEmployeesFromDatabase();
           

            bst = new EmployeeBST();

            foreach (var employee in employeesList)
            {
                bst.Insert(employee);
            }

            positionList = DatabaseManager.LoadPositionsFromDatabase();
            companiesList = DatabaseManager.LoadCompaniesFromDatabase();
            usersList = DatabaseManager.LoadUsersFromDatabase();

            hashTableUser = new UserHashTable();
            userDictionary = new UserDictionary();
            foreach (User user in usersList)
            { 
                hashTableUser.Insert(user);
                userDictionary.Add(user);
            }

            plansList = DatabaseManager.LoadPlansFromDatabase();
            contractsList = DatabaseManager.LoadContractsFromDatabase();
            
            // ваговий граф
            desksList = DatabaseManager.LoadDesksFromDatabase();
            graphDeskD = GraphHelper.CreateWeightedGraph(desksList);

            Debug.WriteLine("QQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQq");
            Debug.WriteLine("QQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQq");
        }

        private void generateSomePosition()
        {
            positions[0] = new Position(0, "Community Manager");
            positions[1] = new Position(1, "Events Coordinator");
            positions[2] = new Position(2, "Technical Support Specialist");
            positions[3] = new Position(3, "Public Relations Manager");
            positions[4] = new Position(4, "Social Media Marketer");
            positions[5] = new Position(5, "Business Development Specialist");
            positions[6] = new Position(6, "Coworking Space Administrator");
        }

        private void generateSomePlans()
        {
            plans.AddLast(new Plan("Basic", "Доступ до відкритих робочих місць", 50.0));
            plans.AddLast(new Plan("Professional", "Особисте робоче місце та доступ до додаткових сервісів", 100.0));
            plans.AddLast(new Plan("Flex", "Гнучкий графік роботи та доступ до всіх зон коворкінгу", 75.0));
            plans.AddLast(new Plan("Startup", "Підтримка для починаючих стартапів", 120.0));
            plans.AddLast(new Plan("Corporate", "Розширені можливості для корпоративних клієнтів", 150.0));
            plans.AddLast(new Plan("Innovation", "Доступ до інноваційних пристроїв та лабораторій", 90.0));
            plans.AddLast(new Plan("Creativity", "Стимулювання творчих процесів", 80.0));
            plans.AddLast(new Plan("Custom", "Індивідуально налаштований план для специфічних потреб", 200.0));
        }

        private void посадиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PositionForm nf = new PositionForm();
            OpenChildForm(nf);
        }

        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void планиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plans nf = new Plans();
            OpenChildForm(nf);

        }

        private void столиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDesk nf = new FormDesk();
            OpenChildForm(nf);
        }

        private void компаніїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompany nf = new FormCompany();
            OpenChildForm(nf);
        }

        private void графToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void деревоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTree nf = new FormTree();
            OpenChildForm(nf);
        }

        public static int FindPositionIdByName(string name)
        {
            Position position = positionList.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (position != null)
            {
                return position.Id;
            }
            else
            {
                return -1;
            }
        }

        public static bool IsPhoneNumberUnique(string phoneNumber)
        {
            foreach (var item in employeesList)
            {
                if (item.Phone.Equals(phoneNumber))
                {
                    return false;
                }
            }
            return true;
        }

        private void хештаблиціToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HashTablesForm nf = new HashTablesForm();
            OpenChildForm(nf);
        }

        private void запитиБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FromDB nf = new FromDB();
            OpenChildForm(nf);
        }

        private void рекурсіяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecursioncs nf = new FormRecursioncs();
            OpenChildForm(nf);
        }

        private void сортуванняКвToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSort1 nf = new FormSort1();
            OpenChildForm(nf);
        }

        private void сортуванняЛлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSort2 nf = new FormSort2();
            OpenChildForm(nf);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void лінійнийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchL nf = new SearchL();
            OpenChildForm(nf);
        }

        private void bFSDFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBfsDfs nf = new SearchBfsDfs();
            OpenChildForm(nf);
        }

        private void бінарнийПошукToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void логарифмічнийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogarifmSearch nf = new LogarifmSearch();
            OpenChildForm(nf);
        }

        private void квадратнийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchK nf = new SearchK();
            OpenChildForm(nf);
        }

        private void пошукBSTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearchInBST nf  = new FormSearchInBST();
            OpenChildForm(nf);
        }

        private void інтерполяційнийПошукToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterpolationSearch nf = new InterpolationSearch();
            OpenChildForm(nf);
        }

        private void граф1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGraphs nf = new FormGraphs();
            OpenChildForm(nf);
        }

        private void граф2ДейкстраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGraphDejkstra nf = new FormGraphDejkstra();
            OpenChildForm(nf);
        }

        private void ширToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRSA nf = new FormRSA();
            OpenChildForm(nf);
        }
    }
}
