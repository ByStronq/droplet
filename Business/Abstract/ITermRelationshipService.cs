using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ITermRelationshipService
    {
        IDataResult<List<TermRelationship>> GetAll();
        IResult Add(TermRelationship termRelationship);
        IResult Update(TermRelationship termRelationship);
    }
}
