using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        private readonly IMapper _mapper;

        public UserManager(IUserDal userDal, IMapper mapper)
        {
            _userDal = userDal;
            _mapper = mapper;
        }

        #region Listeleme Metotları
        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }
        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.Id == userId));   
        }

        #endregion

        #region Temel Ekleme-Silme-Güncelleme
        public IResult Add(UserAddDto userAddDto)
        {
            //mapping
            User user = _mapper.Map<User>(userAddDto);
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IResult Update(UserUpdateDto userUpdateDto)
        {
            //mapping
           User user = _mapper.Map<User>(userUpdateDto);
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }
        #endregion


    }
}
