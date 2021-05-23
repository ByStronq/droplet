using Business.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CommentMetaManager : ICommentMetaService
    {
        ICommentMetaDal _commentMetaDal;

        public CommentMetaManager(ICommentMetaDal commentMetaDal)
        {
            _commentMetaDal = commentMetaDal;
        }

        public IResult Add(CommentMeta commentMeta)
        {
            _commentMetaDal.Add(commentMeta);
            return new SuccessResult();
        }

        [CacheAspect]
        public IDataResult<List<CommentMeta>> GetAll()
        {
            return new SuccessDataResult<List<CommentMeta>>(_commentMetaDal.GetAll());
        }

        public IResult Update(CommentMeta commentMeta)
        {
            _commentMetaDal.Update(commentMeta);
            return new SuccessResult();
        }
    }
}
