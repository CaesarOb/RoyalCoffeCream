﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCoffeCream.Entity
{
    public class DrinkBill
    {
        public int DrinkBillId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime BillDate { get; set; }
        public string ClientName { get; set; }
        public int DetailsSellDrinkId { get; set; }
        public int EmployeeId { get; set; }
    }
}
