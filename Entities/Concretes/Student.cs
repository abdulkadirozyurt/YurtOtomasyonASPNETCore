using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string University { get; set; }
        public string Department { get; set; }
        public string Grade { get; set; }
        public string Email { get; set; }
        public int RoomId { get; set; }

        public Room Room { get; set; } 

    }
}
