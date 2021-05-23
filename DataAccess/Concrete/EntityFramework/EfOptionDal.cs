using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOptionDal : EfEntityRepositoryBase<Option, DropletContext>, IOptionDal
    {

    }
}
