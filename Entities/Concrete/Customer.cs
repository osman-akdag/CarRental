using Core.Entities;
using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string CompanyName { get; set; }

        public User User { get; set; }

        // 1 müşteri 1 den fazla kiralama yapabilir.
        public List<Rental> Rentals { get; set; }   
    }
}
