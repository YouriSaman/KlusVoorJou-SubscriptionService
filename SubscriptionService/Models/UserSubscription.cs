using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionService.Models
{
    public class UserSubscription
    {
        public Subscription Subscription { get; set; }
        public string UserId { get; set; }
        public int Duration { get; set; }
    }
}
