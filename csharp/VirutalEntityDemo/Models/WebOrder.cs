using System;
using System.ComponentModel.DataAnnotations;

namespace VirutalEntityDemo.Models
{
    public class WebOrder
    {
        private Guid _id;           // sqlite type BLOB
        private string _date;       // sqlite type TEXT
        private Guid _customerId;   // sqlite type BLOB
        private double _total;       // sqlite type REAL
        private double _tax;         // sqlite type REAL
        private string _status;     // sqlite type TEXT
        private string _name;       // sqlite type TEXT

        public WebOrder() { }
        public WebOrder(Guid id, string date, Guid customerId, double total, double tax, string name, string status)
        {
            _id = id;
            _date = date;
            _customerId = customerId;
            _total = total;
            _tax = tax;
            _name = name;
            _status = status;
        }

        [Key]
        public Guid Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        [Required]
        public string Date       { get => _date;       set => _date = value; }
        [Required]
        public Guid CustomerId   { get => _customerId; set => _customerId = value; }
        [Required]
        public double Total      { get => _total;      set => _total = value; }
        [Required]
        public double Tax        { get => _tax;        set => _tax = value; }
        [Required]
        public string Status     { get => _status;     set => _status = value; }
        [Required]
        public string Name       { get => _name;       set => _name = value; }        
    }
}
