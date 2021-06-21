using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SubscriptionService.DAL;
using SubscriptionService.Models;

namespace SubscriptionService.Logic
{
    public class SubscriptionLogic
    {
        private readonly SubscriptionDAL _subscriptionDal;

        public SubscriptionLogic()
        {
            _subscriptionDal = new SubscriptionDAL();
        }

        public List<Subscription> GetAllSubscriptions()
        {
            return _subscriptionDal.GetAllSubscriptions();
        }
    }
}
