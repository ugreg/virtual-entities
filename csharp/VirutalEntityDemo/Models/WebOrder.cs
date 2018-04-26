using System;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace VirutalEntityDemo.Models
{
    public class WebOrder
    {                       
        private DateTime _dateTime;
        private float _total;
        private float _tax;

        [Key]
        public Guid Id { get; }

        [Required]
        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        [Required]
        public Guid CusomterId { get; }

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
