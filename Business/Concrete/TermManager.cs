using Business.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class TermManager : ITermService
    {
        ITermDal _termDal;

        public TermManager(ITermDal termDal)
        {
            _termDal = termDal;
        }

        public IResult Add(Term term)
        {
            _termDal.Add(term);
            return new SuccessResult();
        }

        [CacheAspect]
        public IDataResult<List<Term>> GetAll()
        {
            return new SuccessDataResult<List<Term>>(_termDal.GetAll());
        }

        public IResult Update(Term term)
        {
            _termDal.Update(term);
            return new SuccessResult();
        }
    }
}
