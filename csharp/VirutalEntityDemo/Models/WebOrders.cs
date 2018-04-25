using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirutalEntityDemo.Models
{
    public class WebOrders
    {
        private Guid _id;
        private DateTime _dateTime;
        private Guid _customerId;
        private float _total;
        private float _tax;

        public WebOrders() { }

        public Guid Id { get { return _id; } }

        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        public Guid CusomterId { get { return _customerId; } }

        public float Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public float Tax
        {
            get { return _tax; }
            set { _tax = value; }
        }
    }
}
