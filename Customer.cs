using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CustomerTransaction
    {
        public int TransactionId { get; set; }
        public string CustmomerName { get; set; }
        public int Price { get; set; }
        public DateTime TransactionDate { get; set; }
        public int RewardPoints { get; set; } 
        public int TotalRewards { get; set; }

         public class CustomerDataList
        {
            public List<CustomerTransaction> customerTransactions { get; set; } = null;
            public CustomerDataList()
            {
                customerTransactions = new List<CustomerTransaction>();
                CustomerTransaction cd = new CustomerTransaction();
                cd.TransactionId = 1;
                cd.CustmomerName = "David";
                cd.Price = 85;
                cd.TransactionDate = new DateTime(2022, 03, 01);
                cd.RewardPoints = CalcuateRewards(cd.Price);
                cd.TotalRewards = TotalRewards();
                customerTransactions.Add(cd);

                cd = new CustomerTransaction();
                cd.TransactionId = 2;
                cd.CustmomerName = "David";
                cd.Price = 120;
                cd.TransactionDate = new DateTime(2022, 03, 02);
                cd.RewardPoints = CalcuateRewards(cd.Price);
                cd.TotalRewards = TotalRewards();
                customerTransactions.Add(cd);

                cd = new CustomerTransaction();
                cd.TransactionId = 3;
                cd.CustmomerName = "Mike";
                cd.Price = 165;
                cd.TransactionDate = new DateTime(2022, 03, 01);
                cd.RewardPoints = CalcuateRewards(cd.Price);
                cd.TotalRewards = TotalRewards();
                customerTransactions.Add(cd);

                cd = new CustomerTransaction();
                cd.TransactionId = 4;
                cd.CustmomerName = "Tim";
                cd.Price = 250;
                cd.TransactionDate = new DateTime(2022, 03, 01);
                cd.RewardPoints = CalcuateRewards(cd.Price);
               /cd.TotalRewards = TotalRewards();
                customerTransactions.Add(cd);
            }
            public int CalcuateRewards (int Price)
            {
                if (Price >= 50 && Price< 100)
                {
                    return Price - 50;
                }
                else if (Price>100)
                {
                    return (2 * (Price - 100) + 50);
                }
                return 0;
            }
            public int TotalRewards()
            {
                string custname;
                CustomerTransaction ctreturn = null;
                CustomerDataList cdlist = new CustomerDataList();
                foreach (CustomerTransaction ct in cdlist.customerTransactions)
                {
                    custname = ct.CustmomerName;
                    if (ct.TransactionDate <= DateTime.Now.AddMonths(-3))
                    {
                        ctreturn.RewardPoints += ct.RewardPoints;
                        if (custname == ct.CustmomerName)
                        {
                            ctreturn.RewardPoints += ct.RewardPoints;
                        }
                    }
                }
                return ctreturn.RewardPoints;
            }
        }

    }
}