using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ITermMetaService
    {
        IDataResult<List<TermMeta>> GetAll();
        IResult Add(TermMeta termMeta);
        IResult Update(TermMeta termMeta);
    }
}
