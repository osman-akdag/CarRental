using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }

        public User User { get; set; }

        // 1 müşteri 1 den fazla kiralama yapabilir.
        public List<Rental> Rentals { get; set; }   
    }
}
