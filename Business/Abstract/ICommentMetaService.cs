using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICommentMetaService
    {
        IDataResult<List<CommentMeta>> GetAll();
        IResult Add(CommentMeta commentMeta);
        IResult Update(CommentMeta commentMeta);
    }
}
