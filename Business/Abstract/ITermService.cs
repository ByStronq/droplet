using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ITermService
    {
        IDataResult<List<Term>> GetAll();
        IResult Add(Term term);
        IResult Update(Term term);
    }
}
