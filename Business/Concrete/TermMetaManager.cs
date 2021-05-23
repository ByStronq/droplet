using Business.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class TermMetaManager : ITermMetaService
    {
        ITermMetaDal _termMetaDal;

        public TermMetaManager(ITermMetaDal termMetaDal)
        {
            _termMetaDal = termMetaDal;
        }

        public IResult Add(TermMeta termMeta)
        {
            _termMetaDal.Add(termMeta);
            return new SuccessResult();
        }

        [CacheAspect]
        public IDataResult<List<TermMeta>> GetAll()
        {
            return new SuccessDataResult<List<TermMeta>>(_termMetaDal.GetAll());
        }

        public IResult Update(TermMeta termMeta)
        {
            _termMetaDal.Update(termMeta);
            return new SuccessResult();
        }
    }
}
