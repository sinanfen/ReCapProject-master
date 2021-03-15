/*Created By Engin Yenice
enginyenice2626@gmail.com*/

using Core.Entities;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        //UserId,CompanyName
        public int Id { get; set; }

        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}