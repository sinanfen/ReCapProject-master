/*Created By Engin Yenice
enginyenice2626@gmail.com*/

using Core.Entities;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
    }
}