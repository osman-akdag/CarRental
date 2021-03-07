using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalAddDto : IDto
    {
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
    }
}
