using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionService.Models
{
    public class Subscription
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        public Subscription(Guid id, string title, double price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public Subscription()
        {
            
        }
    }
}
