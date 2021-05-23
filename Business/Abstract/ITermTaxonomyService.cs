using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ITermTaxonomyService
    {
        IDataResult<List<TermTaxonomy>> GetAll();
        IResult Add(TermTaxonomy termTaxonomy);
        IResult Update(TermTaxonomy termTaxonomy);
    }
}
