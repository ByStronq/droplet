using Business.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class TermTaxonomyManager : ITermTaxonomyService
    {
        ITermTaxonomyDal _termTaxonomyDal;

        public TermTaxonomyManager(ITermTaxonomyDal termTaxonomyDal)
        {
            _termTaxonomyDal = termTaxonomyDal;
        }

        public IResult Add(TermTaxonomy termTaxonomy)
        {
            _termTaxonomyDal.Add(termTaxonomy);
            return new SuccessResult();
        }

        [CacheAspect]
        public IDataResult<List<TermTaxonomy>> GetAll()
        {
            return new SuccessDataResult<List<TermTaxonomy>>(_termTaxonomyDal.GetAll());
        }

        public IResult Update(TermTaxonomy termTaxonomy)
        {
            _termTaxonomyDal.Update(termTaxonomy);
            return new SuccessResult();
        }
    }
}
