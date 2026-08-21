using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking
{
    public class Employee
    {
        private int _id;
        private int _positionId;
        private string _name;
        private string _surname;
        private string _phone;
        private DateTime _dateOfBirth;
        private double _salary;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int PositionId
        {
            get { return _positionId; }
            set { _positionId = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public Employee(int id, int positionId, string name, string surname, string phone, DateTime dateOfBirth, double salary)
        {
            Id = id;
            PositionId = positionId;
            Name = name;
            Surname = surname;
            Phone = phone;
            DateOfBirth = dateOfBirth;
            Salary = salary;
        }

        public Employee (int positionId, string name, string surname, string phone, DateTime dateOfBirth, double salary)
        {
            Id = 0;
            PositionId = positionId;
            Name = name;
            Surname = surname;
            Phone = phone;
            DateOfBirth = dateOfBirth;
            Salary = salary;
        }

        public Employee() { }
    }
}
