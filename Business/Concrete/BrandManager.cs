using AutoMapper;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;
        private readonly IMapper _mapper;

        public BrandManager(IBrandDal brandDal, IMapper mapper)
        {
            _brandDal = brandDal;
            _mapper = mapper;
        }

        #region Listeleme Metotları
        [SecuredOperation("Admin")]
        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        [SecuredOperation("Admin")]
        public IDataResult<Brand> GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(p => p.Id == brandId));
        }

        [SecuredOperation("Admin")]
        public IDataResult<List<Brand>> GetAllWithCars()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAllWithCars());
        }

        #endregion

        #region Temel Ekleme-Silme-Güncelleme

        [SecuredOperation("Admin")]
        [ValidationAspect(typeof(BrandAddDtoValidator))]
        public IResult Add(BrandAddDto brandAddDto)
        {
            //mapping
            Brand brand = _mapper.Map<Brand>(brandAddDto);
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }
        [SecuredOperation("Admin")]
        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }
        [SecuredOperation("Admin")]
        public IResult Update(BrandUpdateDto brandUpdateDto)
        {
            //mapping
            Brand brand = _mapper.Map<Brand>(brandUpdateDto);
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }

        
        #endregion

    }
}
