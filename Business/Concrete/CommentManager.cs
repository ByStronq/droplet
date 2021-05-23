using Business.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public IResult Add(Comment comment)
        {
            _commentDal.Add(comment);
            return new SuccessResult();
        }

        [CacheAspect]
        public IDataResult<List<Comment>> GetAll()
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll());
        }

        public IResult Update(Comment comment)
        {
            _commentDal.Update(comment);
            return new SuccessResult();
        }
    }
}
