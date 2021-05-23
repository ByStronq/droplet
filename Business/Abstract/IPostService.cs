using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IPostService
    {
        IDataResult<List<Post>> GetAll();
        IResult Add(Post post);
        IResult Update(Post post);
    }
}
