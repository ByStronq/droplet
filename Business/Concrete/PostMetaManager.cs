using Business.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class PostMetaManager : IPostMetaService
    {
        IPostMetaDal _postMetaDal;

        public PostMetaManager(IPostMetaDal postMetaDal)
        {
            _postMetaDal = postMetaDal;
        }

        public IResult Add(PostMeta postMeta)
        {
            _postMetaDal.Add(postMeta);
            return new SuccessResult();
        }

        [CacheAspect]
        public IDataResult<List<PostMeta>> GetAll()
        {
            return new SuccessDataResult<List<PostMeta>>(_postMetaDal.GetAll());
        }

        public IResult Update(PostMeta postMeta)
        {
            _postMetaDal.Update(postMeta);
            return new SuccessResult();
        }
    }
}
