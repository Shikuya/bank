using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class Customerdata
    {
      public String Name { get; }
      public  uint Id { get; }
      public  double Balance { get; set; }


        public Customerdata(String name, uint id, double balance)
        {
            Name = name;
            Id = id;
            Balance = balance;
        }
    }
}
