using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IOptionService
    {
        IDataResult<List<Option>> GetAll();
        IResult Add(Option option);
        IResult Update(Option option);
    }
}
