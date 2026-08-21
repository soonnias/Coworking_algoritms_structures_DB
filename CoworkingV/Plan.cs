using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking
{
    public class Plan
    {
        private int _id;
        private string _name;
        private string _description;
        private double _price;

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

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Plan(int id, string name, string description, double price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }

        public Plan(string name, string description, double price)
        {
            Id = 0;
            Name = name;
            Description = description;
            Price = price;
        }

        public Plan() { }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Plan other = (Plan)obj;

            return Id == other.Id && Name == other.Name && Description == other.Description && Price == other.Price;
        }
    }
}
