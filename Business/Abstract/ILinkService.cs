using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ILinkService
    {
        IDataResult<List<Link>> GetAll();
        IResult Add(Link link);
        IResult Update(Link link);
    }
}
