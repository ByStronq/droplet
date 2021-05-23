using Business.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class UserMetaManager : IUserMetaService
    {
        IUserMetaDal _userMetaDal;

        public UserMetaManager(IUserMetaDal userMetaDal)
        {
            _userMetaDal = userMetaDal;
        }

        public IResult Add(UserMeta userMeta)
        {
            _userMetaDal.Add(userMeta);
            return new SuccessResult();
        }

        [CacheAspect]
        public IDataResult<List<UserMeta>> GetAll()
        {
            return new SuccessDataResult<List<UserMeta>>(_userMetaDal.GetAll());
        }

        public IResult Update(UserMeta userMeta)
        {
            _userMetaDal.Update(userMeta);
            return new SuccessResult();
        }
    }
}
