using Business.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class OptionManager : IOptionService
    {
        IOptionDal _optionDal;

        public OptionManager(IOptionDal optionDal)
        {
            _optionDal = optionDal;
        }

        public IResult Add(Option option)
        {
            _optionDal.Add(option);
            return new SuccessResult();
        }

        [CacheAspect]
        public IDataResult<List<Option>> GetAll()
        {
            return new SuccessDataResult<List<Option>>(_optionDal.GetAll());
        }

        public IResult Update(Option option)
        {
            _optionDal.Update(option);
            return new SuccessResult();
        }
    }
}
