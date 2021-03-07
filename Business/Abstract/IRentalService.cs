using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int rentalId);  
        IResult Add(RentalAddDto rentalAddDto);
        IResult Update(RentalUpdateDto rentalUpdateDto);
        IResult Delete(Rental rental);
        
    }
}
