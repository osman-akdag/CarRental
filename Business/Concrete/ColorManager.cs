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
    public class ColorManager : IColorService
    {
        private readonly IColorDal _colorDal;
        private readonly IMapper _mapper;

        public ColorManager(IColorDal colorDal, IMapper mapper)
        {
            _colorDal = colorDal;
            _mapper = mapper;
        }

        #region Listeleme metotları

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(p => p.Id == colorId));
        }

        #endregion

        #region Temel Ekleme-Silme-Güncelleme
        public IResult Add(ColorAddDto colorAddDto)
        {
            //mapping
            Color color = _mapper.Map<Color>(colorAddDto);
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

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
