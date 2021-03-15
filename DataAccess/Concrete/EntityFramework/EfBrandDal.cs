/*Created By Engin Yenice
enginyenice2626@gmail.com*/

/*
Created By Engin Yenice
enginyenice2626@gmail.com
*/

using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfRepositoryBase<Brand, ReCapProjectContext>, IBrandDal
    {
    }
}