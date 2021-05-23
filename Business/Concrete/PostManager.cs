using Business.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class PostManager : IPostService
    {
        IPostDal _postDal;

        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }

        public IResult Add(Post post)
        {
            _postDal.Add(post);
            return new SuccessResult();
        }

        [CacheAspect]
        public IDataResult<List<Post>> GetAll()
        {
            return new SuccessDataResult<List<Post>>(_postDal.GetAll());
        }

        public IResult Update(Post post)
        {
            _postDal.Update(post);
            return new SuccessResult();
        }
    }
}
