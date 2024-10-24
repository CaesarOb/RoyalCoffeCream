using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RoyalCoffeCream.DataAccess
{
    public class Connection
    {
        protected string _cadena = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
    }
}
