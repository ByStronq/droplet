using Business.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class LinkManager : ILinkService
    {
        ILinkDal _linkDal;

        public LinkManager(ILinkDal linkDal)
        {
            _linkDal = linkDal;
        }

        public IResult Add(Link link)
        {
            _linkDal.Add(link);
            return new SuccessResult();
        }

        [CacheAspect]
        public IDataResult<List<Link>> GetAll()
        {
            return new SuccessDataResult<List<Link>>(_linkDal.GetAll());
        }

        public IResult Update(Link link)
        {
            _linkDal.Update(link);
            return new SuccessResult();
        }
    }
}
