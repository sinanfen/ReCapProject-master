/*Created By Engin Yenice
enginyenice2626@gmail.com*/

using Core.Entities;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}