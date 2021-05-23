using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICommentService
    {
        IDataResult<List<Comment>> GetAll();
        IResult Add(Comment comment);
        IResult Update(Comment comment);
    }
}
