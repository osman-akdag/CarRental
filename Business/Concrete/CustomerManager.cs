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
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly IMapper _mapper;

        public CustomerManager(ICustomerDal customerDal, IMapper mapper)
        {
            _customerDal = customerDal;
            _mapper = mapper;
        }

        #region Listeleme Metotları
        [SecuredOperation("Admin")]
        [LogAspect(typeof(FileLogger))]
        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }
        [SecuredOperation("Admin")]
        [LogAspect(typeof(FileLogger))]
        public IDataResult<Customer> GetById(int customerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.Id == customerId));
        }
        #endregion

        #region Temel Ekleme-Silme-Güncelleme
        [SecuredOperation("Admin")]
        [LogAspect(typeof(FileLogger))]
        public IResult Add(CustomerAddDto customerAddDto)
        {
            //mapping
            Customer customer = _mapper.Map<Customer>(customerAddDto);
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }
        [SecuredOperation("Admin")]
        [LogAspect(typeof(FileLogger))]
        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }
        [SecuredOperation("Admin")]
        [LogAspect(typeof(FileLogger))]
        public IResult Update(CustomerUpdateDto customerUpdateDto)
        {
            //mapping
            Customer customer = _mapper.Map<Customer>(customerUpdateDto);
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
        #endregion

    }
}
