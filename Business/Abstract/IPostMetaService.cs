using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IPostMetaService
    {
        IDataResult<List<PostMeta>> GetAll();
        IResult Add(PostMeta postMeta);
        IResult Update(PostMeta postMeta);
    }
}
