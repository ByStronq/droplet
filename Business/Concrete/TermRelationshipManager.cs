using Business.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class TermRelationshipManager : ITermRelationshipService
    {
        ITermRelationshipDal _termRelationshipDal;

        public TermRelationshipManager(ITermRelationshipDal termRelationshipDal)
        {
            _termRelationshipDal = termRelationshipDal;
        }

        public IResult Add(TermRelationship termRelationship)
        {
            _termRelationshipDal.Add(termRelationship);
            return new SuccessResult();
        }

        [CacheAspect]
        public IDataResult<List<TermRelationship>> GetAll()
        {
            return new SuccessDataResult<List<TermRelationship>>(_termRelationshipDal.GetAll());
        }

        public IResult Update(TermRelationship termRelationship)
        {
            _termRelationshipDal.Update(termRelationship);
            return new SuccessResult();
        }
    }
}
