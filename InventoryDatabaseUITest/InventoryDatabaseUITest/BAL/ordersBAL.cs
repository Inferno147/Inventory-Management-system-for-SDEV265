﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDatabaseUITest.BAL
{
   public class ordersBAL
    {
        public int Order_ID { get; set; }
        public int Customer_ID { get; set; }
        public DateTime Order_Date { get; set; }


        public  string orderInfofull
        {   //25 3 10/11/2020 this displays requested order information
            get { return $"{ Order_ID } { Customer_ID } { Order_Date }"; }
        }

    }
}