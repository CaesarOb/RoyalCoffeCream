using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.Entity
{
    public class BUser
    {
        public int UserId { get; set; }
        public string Passcode { get; set; }
        public string Nick { get; set; }
        public int EmployeeId { get; set; }
        public int UserTypeId { get; set; }
        public int StatusId { get; set; }
    }
}
