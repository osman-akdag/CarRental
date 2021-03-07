using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarAddDto : IDto
    {
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
    }
}
