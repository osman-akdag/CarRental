using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetAllByCarDetails();
        IDataResult<Car> GetById(int carId);
        IResult Add(CarAddDto carAddDto);
        IResult Delete(Car car);
        IResult Update(CarUpdateDto carUpdateDto);  
    }       
}
