﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Color:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // 1 renk 1 den fazla arabada olabilir
        public List<Car> Cars { get; set; }
    }
}
