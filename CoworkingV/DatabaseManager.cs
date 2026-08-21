using Bogus;
using Bogus.DataSets;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Coworking
{
    internal class DatabaseManager
    {
        private static readonly string connectionString = "Server=127.0.0.1;Database=coworking;Uid=root;Pwd=R02061982r;";
        //private static readonly string connectionString = "Server=127.0.0.1;Database=probna;Uid=root;Pwd=R02061982r;";

        private static readonly MySqlConnection connection = new MySqlConnection(connectionString);

        public static void OpenConnection()
        {
            try
            {
                connection.Open();
                MessageBox.Show("Пiдключення до бази даних встановлено.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при встановленнi з'єднання з базою даних: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для закриття з'єднання з базою даних
        public static void CloseConnection()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Пiдключення до бази даних закрито.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка при закриттi з'єднання з базою даних: " + ex.Message);
            }
        }

        // Приклад методу для виконання SQL-запиту
        public static void ExecuteQuery(string query)
        {
            //OpenConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
               MessageBox.Show("Запит успiшно виконано.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при виконаннi SQL-запиту: " + ex.Message);
            }
            finally
            {
                //CloseConnection();
            }
        }

        public static DataTable ExecuteSelectQuery(string query)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    //connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                    MessageBox.Show("Запит успішно виконано.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при виконанні SQL-запиту: " + ex.Message);
                }
                finally
                {
                    //CloseConnection();
                }
            }

            return dataTable;
        }

        public static void ExecuteParametrizedQuery(string query, Dictionary<string, object> parameters)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Додавання параметрів до команди
                    foreach (var parameter in parameters)
                    {
                        cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Запит успішно виконано.");
                }
            }
        }

        public static DataTable ExecuteParametrizedSelectQuery(string query, Dictionary<string, object> parameters)
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Додавання параметрів до команди
                    foreach (var parameter in parameters)
                    {
                        cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                        MessageBox.Show("Запит успішно виконано.");
                    }
                }
            }
            return dataTable;
        }


        public static void ExecuteNonQuery(string query)
        {
            //OpenConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Запит успiшно виконано.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка при виконаннi SQL-запиту: " + ex.Message);
            }
            finally
            {
                //CloseConnection();
            }
        }

        public static void InsertCompanies()
        {
            var faker = new Faker("uk");

            for (int i = 1; i <= 300; i++)
            {
                //string companyName = $"Company{i}";
                string companyName = faker.Company.CompanyName();
                string insertQuery = "INSERT INTO Companies (name) VALUES (@CompanyName)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@CompanyName", companyName);
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Дані для компанії '{companyName}' успішно вставлено.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Помилка під час вставки даних для компанії '{companyName}'.");
                    }
                }
            }
        }

        public static void InsertDesks()
        {
            var faker = new Faker("uk");

            for (int i = 6; i <= 250; i++)
            {
                int deskNumber = i;
                string accessibility = faker.PickRandom("Доступний", "Недоступний");

                string insertQuery = "INSERT INTO Desks (number, accessibility) VALUES (@DeskNumber, @Accessibility)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@DeskNumber", deskNumber);
                    command.Parameters.AddWithValue("@Accessibility", accessibility);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Дані для столу {deskNumber} (доступність: {accessibility}) успішно вставлено.");
                        }
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine($"Помилка під час вставки даних для столу {deskNumber}: {ex.Message}");
                    }
                }
            }
        }

        public static void InsertPositions()
        {
            var faker = new Faker("uk");
            for (int i = 1; i <= 250; i++)
            {
                //string positionName = $"Посада{i}";
                string positionName = faker.Name.JobTitle();

                string insertQuery = "INSERT INTO Positions (name) VALUES (@PositionName)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@PositionName", positionName);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Дані для посади '{positionName}' успішно вставлено.");
                        }

                    }
                    catch
                    {
                        Console.WriteLine($"Помилка під час вставки даних для посади '{positionName}'.");
                    }

                }
            }

        }

        public static void InsertPlans()
        {
            var faker = new Faker("uk");

            for (int i = 1; i <= 300; i++)
            {
                //string planName = $"План{i}";
                //string description = $"Опис плану {i}";

                string planName = faker.Lorem.Word();
                string description = faker.Lorem.Sentence();

                double price = 100.00 + i * 0.7; // Ціна збільшується на 0.05 з кожним планом


                string insertQuery = "INSERT INTO Plans (name, description, price) VALUES (@PlanName, @Description, @Price)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@PlanName", planName);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Price", price);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Дані для плану '{planName}' успішно вставлено.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine($"Помилка під час вставки даних для плану '{planName}'.");
                    }
                }
            }
        }

        public static void InsertEmployees()
        {

            var faker = new Faker("uk");
            Random random = new Random();

            for (int i = 1; i <= 300; i++)
            {
                int positionId = random.Next(0, 251); // Генерує випадкове значення position_id від 100 до 180
                //string name = $"Name{i}";
                //string surname = $"Surname{i}";
                //string phone = $"+123456{i.ToString().PadLeft(6, '0')}"; // Генерує унікальний номер телефону
                string name = faker.Name.FirstName();
                string surname = faker.Name.LastName();
                string phone = faker.Phone.PhoneNumber("+123456#######");

                DateTime dateOfBirth = new DateTime(random.Next(1970, 2000), random.Next(1, 13), random.Next(1, 29)); // Генерує випадкову дату народження
                double salary = Math.Round(4000 + random.NextDouble() * 2000, 2);

                string insertQuery = "INSERT INTO Employees (position_id, name, surname, phone, date_of_birth, salary) " +
                                        "VALUES (@PositionId, @Name, @Surname, @Phone, @DateOfBirth, @Salary)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@PositionId", positionId);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Surname", surname);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@Salary", salary);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Дані для співробітника '{name} {surname}' успішно вставлено.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine($"Помилка під час вставки даних для співробітника '{name} {surname}'.");
                    }
                }
            }
        }

        public static void InsertUsers()
        {
            var faker = new Faker("uk");
            string insertQuery = "INSERT INTO Users (name, surname, email, phone, date_of_birth, id_company) VALUES ";

            for (int i = 1; i <= 500; i++)
            {
                string name = faker.Name.FirstName();
                string surname = faker.Name.LastName();
                string phone = faker.Phone.PhoneNumber("+123456#######");
                string email = faker.Internet.Email(name, surname);

                DateTime dateOfBirth = new DateTime(1990 + i % 10, i % 12 + 1, i % 28 + 1); 
                int companyId = 80 + i % 101; 

                string singleInsertQuery = $"('{name}', '{surname}', '{email}', '{phone}', '{dateOfBirth:yyyy-MM-dd}', {companyId})";

                using (MySqlCommand command = new MySqlCommand(insertQuery + singleInsertQuery, connection))
                {
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Дані для користувача {i} успішно вставлено.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Помилка під час вставки даних для користувача {i}: {ex.Message}");
                    }
                }
            }
        }

        public static void InsertContracts()
        {
            Random random = new Random();
            var faker = new Faker("uk");

            for (int i = 1; i <= 1000; i++)
            {
                int userId = random.Next(0, 501);
                int deskId = random.Next(0, 250);
                int planId = random.Next(0, 301);
                int employeeId = random.Next(0, 301);

                DateTime startDate = DateTime.Now.AddMonths(-random.Next(1, 13)).AddDays(-random.Next(1, 30)); // Генерація початкової дати в межах останніх 12 місяців
                DateTime endDate = startDate.AddDays(random.Next(1, 30)); // Генерація кінцевої дати в межах двох тижнів від початкової дати

                string status = (endDate >= DateTime.Now) ? "Активний" : "Неактивний"; // Встановлення статусу контракту в залежності від дати

                double price = random.Next(50, 1000); // Генерація випадкової ціни контракту

                string insertQuery = $"INSERT INTO Contracts (id_user, id_desk, id_plan, date_start, date_end, status, price, id_employee) VALUES " +
                                     $"({userId}, {deskId}, {planId}, '{startDate:yyyy-MM-dd}', '{endDate:yyyy-MM-dd}', '{status}', {price}, {employeeId})";

                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Дані для контракту {i} успішно вставлено.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Помилка під час вставки даних для контракту {i}: {ex.Message}");
                    }
                }
            }
        }

        internal static List<Employee> LoadEmployeesFromDatabase()
        {
            List<Employee> employees = new List<Employee>();

            string query = "SELECT id, position_id, name, surname, phone, date_of_birth, salary FROM Employees";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    //connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.Id = Convert.ToInt32(reader["id"]);
                            employee.PositionId = Convert.ToInt32(reader["position_id"]);
                            employee.Name = reader["name"].ToString();
                            employee.Surname = reader["surname"].ToString();
                            employee.Phone = reader["phone"].ToString();
                            employee.DateOfBirth = Convert.ToDateTime(reader["date_of_birth"]);
                            employee.Salary = Convert.ToDouble(reader["salary"]);

                            employees.Add(employee);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка під час завантаження даних з бази даних: " + ex.Message);
            }
            finally
            {
                //connection.Close();
            }

            return employees;
        }
        internal static List<User> LoadUsersFromDatabase()
        {
            List<User> users = new List<User>();

            //string query = "SELECT id, name, surname, email, phone, date_of_birth, id_company FROM Users";
            string query = "SELECT * FROM Users";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    //connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User();
                            user.Id = Convert.ToInt32(reader["id"]);
                            user.Name = reader["name"].ToString();
                            user.Surname = reader["surname"].ToString();
                            user.Email = reader["email"].ToString();
                            user.Phone = reader["phone"].ToString();
                            user.DateOfBirth = Convert.ToDateTime(reader["date_of_birth"]);
                            if (reader["id_company"] != DBNull.Value)
                            {
                                user.CompanyId = Convert.ToInt32(reader["id_company"]);
                            }
                            else
                            {
                                user.CompanyId = -1; // Або якесь інше значення, яке ви хочете використовувати для вказівки на відсутність компанії
                            }

                            users.Add(user);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час завантаження даних з бази даних: " + ex.Message);
            }
            finally
            {
                //connection.Close();
            }

            return users;
        }
        internal static List<Company> LoadCompaniesFromDatabase()
        {
            List<Company> companies = new List<Company>();

            string query = "SELECT id, name FROM Companies";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    //connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Company company = new Company();
                            company.Id = Convert.ToInt32(reader["id"]);
                            company.Name = reader["name"].ToString();


                            companies.Add(company);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка під час завантаження даних з бази даних: " + ex.Message);
            }
            finally
            {
                //connection.Close();
            }

            return companies;
        }
        internal static List<Position> LoadPositionsFromDatabase()
        {
            List<Position> positions = new List<Position>();

            string query = "SELECT id, name FROM Positions";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Position position = new Position();
                            position.Id = Convert.ToInt32(reader["id"]);
                            position.Name = reader["name"].ToString();

                            positions.Add(position);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка під час завантаження даних з бази даних: " + ex.Message);
            }

            return positions;
        }
        internal static List<Plan> LoadPlansFromDatabase()
        {
            List<Plan> plans = new List<Plan>();

            string query = "SELECT id, name, description, price FROM Plans";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // connection.Open(); // Переконайтесь, що відкриваєте з'єднання, якщо це не зроблено автоматично в іншому місці
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Plan plan = new Plan();
                            plan.Id = Convert.ToInt32(reader["id"]);
                            plan.Name = reader["name"].ToString();
                            plan.Description = reader["description"].ToString();
                            if (!reader.IsDBNull(reader.GetOrdinal("price"))) // Перевірка на NULL, якщо колонка може містити NULL
                            {
                                plan.Price = reader.GetDouble(reader.GetOrdinal("price"));
                            }
                            else
                            {
                                plan.Price = 0; // або інше значення за замовчуванням
                            }

                            plans.Add(plan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка під час завантаження даних з бази даних: " + ex.Message);
            }
            finally
            {
                // connection.Close(); // Переконайтесь, що закриваєте з'єднання, якщо це не зроблено автоматично в іншому місці
            }

            return plans;
        }
        internal static List<Contract> LoadContractsFromDatabase()
        {
            List<Contract> contracts = new List<Contract>();

            string query = "SELECT id, id_user, id_plan, date_start, date_end, price, status, id_employee FROM Contracts";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Contract contract = new Contract();
                            contract.Id = Convert.ToInt32(reader["id"]);
                            contract.UserId = reader["id_user"] != DBNull.Value ? Convert.ToInt32(reader["id_user"]) : 0;
                            contract.PlanId = reader["id_plan"] != DBNull.Value ? Convert.ToInt32(reader["id_plan"]) : 0;
                            contract.DateStart = Convert.ToDateTime(reader["date_start"]);
                            contract.DateEnd = Convert.ToDateTime(reader["date_end"]);
                            contract.Price = reader["price"] != DBNull.Value ? Convert.ToDouble(reader["price"]) : 0.0;
                            contract.Status = reader["status"] != DBNull.Value ? reader["status"].ToString() : "";
                            contract.EmployeeId = reader["id_employee"] != DBNull.Value ? Convert.ToInt32(reader["id_employee"]) : 0;

                            contracts.Add(contract);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка під час завантаження даних з бази даних: " + ex.Message);
            }
            finally
            {
                // Переконайтесь, що закриваєте з'єднання, якщо це не зроблено автоматично в іншому місці
            }

            return contracts;
        }

        internal static List<Desk> LoadDesksFromDatabase()
        {
            List<Desk> desks = new List<Desk>();

            string query = "select * from desks limit 5;";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    //connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Desk desk = new Desk();
                            desk.Id = Convert.ToInt32(reader["id"]);
                            desk.Number = Convert.ToInt32(reader["number"]);
                            desk.Accessibility = reader["accessibility"].ToString();

                            desks.Add(desk);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка під час завантаження даних з бази даних: " + ex.Message);
            }
            finally
            {
                //connection.Close();
            }

            return desks;
        }


    }

}
