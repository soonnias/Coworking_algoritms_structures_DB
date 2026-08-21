using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking
{
    internal class Contract
    {
        private int _id;
        private int _userId;
        private int _deskId;
        private int _planId;
        private DateTime _dateStart;
        private DateTime _dateEnd;
        private string _status;
        private double _price;
        private int _employeeId;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public int DeskId
        {
            get { return _deskId; }
            set { _deskId = value; }
        }

        public int PlanId
        {
            get { return _planId; }
            set { _planId = value; }
        }

        public DateTime DateStart
        {
            get { return _dateStart; }
            set { _dateStart = value; }
        }

        public DateTime DateEnd
        {
            get { return _dateEnd; }
            set { _dateEnd = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }

        public Contract(int id, int userId, int deskId, int planId, DateTime dateStart, DateTime dateEnd, string status, double price, int employeeId)
        {
            Id = id;
            UserId = userId;
            DeskId = deskId;
            PlanId = planId;
            DateStart = dateStart;
            DateEnd = dateEnd;
            Status = status;
            Price = price;
            EmployeeId = employeeId;
        }

        public Contract() { }
    }
}
