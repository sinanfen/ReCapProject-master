/*Created By Engin Yenice
enginyenice2626@gmail.com*/

using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfRepositoryBase<CarImage, ReCapProjectContext>, ICarImageDal
    {
    }
}