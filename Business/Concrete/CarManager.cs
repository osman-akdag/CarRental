using AutoMapper;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;
        private readonly IMapper _mapper;

        public CarManager(ICarDal carDal, IMapper mapper)
        {
            _carDal = carDal;
            _mapper = mapper;
        }

        #region Listeleme metotları

        [SecuredOperation("Admin")]
        [LogAspect(typeof(FileLogger))]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }
        [SecuredOperation("Admin")]
        [LogAspect(typeof(FileLogger))]
        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == carId));
        }
        [SecuredOperation("Admin")]
        [LogAspect(typeof(FileLogger))]
        public IDataResult<List<CarDetailDto>> GetAllByCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetAllByCarDetails());
        }

        #endregion

        #region Temel Ekleme-Silme-Güncelleme
        [SecuredOperation("Admin")]
        [LogAspect(typeof(FileLogger))]
        public IResult Add(CarAddDto carAddDto)
        {
            // mapping
            Car car = _mapper.Map<Car>(carAddDto);
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }
        [SecuredOperation("Admin")]
        [LogAspect(typeof(FileLogger))]
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }
        [SecuredOperation("Admin")]
        [LogAspect(typeof(FileLogger))]
        public IResult Update(CarUpdateDto carUpdateDto)
        {
            //mapping
            Car car = _mapper.Map<Car>(carUpdateDto);
            _carDal.Add(car);
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        #endregion

    }
}
