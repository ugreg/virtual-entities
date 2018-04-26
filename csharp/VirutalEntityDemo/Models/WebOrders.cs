using System;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace VirutalEntityDemo.Models
{
    public class WebOrders
    {
        [Key]
        private Guid _id;
        [Required]
        private DateTime _dateTime;
        [Required]
        private Guid _customerId;
        [Required]
        private float _total;
        [Required]
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
