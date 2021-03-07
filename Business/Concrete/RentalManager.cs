using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private readonly IRentalDal _rentalDal;
        private readonly IMapper _mapper;

        public RentalManager(IRentalDal rentalDal, IMapper mapper)
        {
            _rentalDal = rentalDal;
            _mapper = mapper;
        }

        #region Listeleme Metotları
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.Id == rentalId));
        }

        #endregion

        #region Temel Ekleme-Silme-Güncelleme
        public IResult Add(RentalAddDto rentalAddDto)
        {
            var result = _rentalDal.GetAll(p => p.CarId == rentalAddDto.CarId && p.ReturnDate == null);
            if (result.Count > 0)
            {
                return new ErrorResult(Messages.RentalReturnDateError);
            }
            //mapper
            Rental rental = _mapper.Map<Rental>(rentalAddDto);
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);

        }

        public IResult Update(RentalUpdateDto rentalUpdateDto)
        {
            //mapper
            Rental rental = _mapper.Map<Rental>(rentalUpdateDto);
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        #endregion

    }
}
