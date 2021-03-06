using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetById(int brandId);
        IDataResult<List<Brand>> GetAllWithCars();
        IResult Add(BrandAddDto brandAddDto); 
        IResult Delete(Brand brand);
        IResult Update(BrandUpdateDto brandUpdateDto);   
    }   
}
