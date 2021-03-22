using AutoMapper;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Extensions;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        private readonly IColorDal _colorDal;
        private readonly IMapper _mapper;       

        public ColorManager(IColorDal colorDal, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _colorDal = colorDal;
            _mapper = mapper;            
        }

        #region Listeleme metotları

        [SecuredOperation("Admin")]
        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }
        [SecuredOperation("Admin")]
        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(p => p.Id == colorId));
        }

        #endregion

        #region Temel Ekleme-Silme-Güncelleme
        //[SecuredOperation("Admin")]
        [ValidationAspect(typeof(ColorAddDtoValidator))]
        public IResult Add(ColorAddDto colorAddDto)
        {
            //mapping
            Color color = _mapper.Map<Color>(colorAddDto);
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }
        [SecuredOperation("Admin")]
        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }
        [SecuredOperation("Admin")]
        public IResult Update(ColorUpdateDto colorUpdateDto)
        {
            //mapping
            Color color = _mapper.Map<Color>(colorUpdateDto);
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorDeleted);
        }
        #endregion

    }
}
