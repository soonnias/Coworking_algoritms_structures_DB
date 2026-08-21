using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking
{
    public class Desk : IComparable<Desk>
    {
        private int _id;
        private int _number;
        private string _accessibility;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string Accessibility
        {
            get { return _accessibility; }
            set { _accessibility = value; }
        }

        public Desk(int id, int number, string accessibility)
        {
            Id = id;
            Number = number;
            Accessibility = accessibility;
        }

        public Desk() { }

        public Desk(int number, string accessibility)
        {
            Id = 0;
            Number = number;
            Accessibility = accessibility;
        }


        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Desk other = (Desk)obj;
            return Number == other.Number; 
        }

        public override int GetHashCode()
        {
            return Number.GetHashCode(); 
        }

        public int CompareTo(Desk other)
        {
            if (other == null) return 1;
            return Number.CompareTo(other.Number);
        }
    }
}
