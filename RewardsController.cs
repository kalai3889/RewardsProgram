using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using static WebApplication1.Models.CustomerTransaction;

namespace WebApplication1.Controllers
{
    public class RewardsController : ApiController
    {
        //GET: api/Rewards
        public List<CustomerTransaction> Get()
        {
            CustomerDataList cdlist = new CustomerDataList();
            return cdlist.customerTransactions;

        }

        // GET: api/Rewards/5
        public CustomerTransaction Get(int id)
        {
            CustomerTransaction ctreturn = null;
            CustomerDataList cdlist = new CustomerDataList();
            foreach (CustomerTransaction ct in cdlist.customerTransactions)
            {
                if(ct.TransactionId == id)
                {
                    ctreturn = ct;
                }
            }
            return ctreturn;
        }

        // POST: api/Rewards
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Rewards/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Rewards/5
        public void Delete(int id)
        {
        }
    }
}
