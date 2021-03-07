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
        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.Id == customerId));
        }
        #endregion

        #region Temel Ekleme-Silme-Güncelleme
        public IResult Add(CustomerAddDto customerAddDto)
        {
            //mapping
            Customer customer = _mapper.Map<Customer>(customerAddDto);
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }
        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

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
