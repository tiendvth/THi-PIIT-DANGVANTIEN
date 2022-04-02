using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using THi_PIIT_DANGVANTIEN.Models;

namespace THi_PIIT_DANGVANTIEN.Data
{
    public class BitCoinDBContext: DbContext
    {
        public  BitCoinDBContext(): base("name = BitCoinDbString")
        {
            
        }

        public DbSet<BitCoin> BitCoins { get; set; }
        public DbSet<Market> Markets { get; set; }
       
    }
}