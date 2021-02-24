using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal:EfEntityRepositoryBase<Brand,ReCapDatabaseContext> ,IBrandDal
    {
        public List<Brand> GetAllWithCars()
        {
            using (ReCapDatabaseContext context = new ReCapDatabaseContext())
            {
                return context.Brands
                    .Include(p => p.Cars)
                    .ThenInclude(p => p.Color)                   
                    .ToListAsync().Result;
            }          
        }
    }
}
