using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserMetaService
    {
        IDataResult<List<UserMeta>> GetAll();
        IResult Add(UserMeta userMeta);
        IResult Update(UserMeta userMeta);
    }
}
