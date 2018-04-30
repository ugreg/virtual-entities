using System;
using System.ComponentModel.DataAnnotations;

namespace VirutalEntityDemo.Models
{
    public class WebOrder
    {
        private Guid _id;
        private DateTime _dateTime;
        private Guid _customerId;
        private float _total;
        private float _tax;

        public WebOrder(Guid id, DateTime dateTime, Guid customerId, float total, float tax)
        {
            _id = id;
            _dateTime = dateTime;
            _customerId = customerId;
            _total = total;
            _tax = tax;
        }

        [Key]
        public Guid Id { get; private set; }

        [Required]
        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        [Required]
        public Guid CusomterId { get; private set; }

        [Required]
        public float Total
        {
            get { return _total; }
            set { _total = value; }
        }

        [Required]
        public float Tax
        {
            get { return _tax; }
            set { _tax = value; }
        }
    }
}
