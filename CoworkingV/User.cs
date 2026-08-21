using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking
{
    internal class User
    {
        private int _id;
        private string _name;
        private string _surname;
        private string _email;
        private string _phone;
        private DateTime _dateOfBirth;
        private int _companyId;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
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

        public string Email
        {
            get { return _email; }
            set { _email = value; }
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

        public int CompanyId
        {
            get { return _companyId; }
            set { _companyId = value; }
        }

        public User(int id, string name, string surname, string email, string phone, DateTime dateOfBirth, int companyId)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            DateOfBirth = dateOfBirth;
            CompanyId = companyId;
        }

        public User(string name, string surname, string email, string phone, DateTime dateOfBirth, int companyId)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            DateOfBirth = dateOfBirth;
            CompanyId = companyId;
        }

        public User() { }
    }
}
