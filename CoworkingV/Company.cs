using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking
{
    internal class Company
    {
        private int _id;
        private string _name;

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

        public Company(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Company(string name)
        {
            Id = 0;
            Name = name;
        }

        public Company() { }    
    }
}
