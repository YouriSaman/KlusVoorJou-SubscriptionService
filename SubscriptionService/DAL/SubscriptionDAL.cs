using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SubscriptionService.Logic;
using SubscriptionService.Models;

namespace SubscriptionService.DAL
{
    public class SubscriptionDAL
    {
        public async Task<List<Subscription>> GetAllSubscriptions()
        {
            Random r = new Random();
            return new List<Subscription>
            {
                new Subscription(Guid.NewGuid(), await LoremTextLogic.GetWord(), RandomNumberBetween(r, 5.0, 50.0)),
                new Subscription(Guid.NewGuid(), await LoremTextLogic.GetWord(), RandomNumberBetween(r, 5.0, 50.0)),
                new Subscription(Guid.NewGuid(), await LoremTextLogic.GetWord(), RandomNumberBetween(r, 5.0, 50.0)),
                new Subscription(Guid.NewGuid(), await LoremTextLogic.GetWord(), RandomNumberBetween(r, 5.0, 50.0)),
                new Subscription(Guid.NewGuid(), await LoremTextLogic.GetWord(), RandomNumberBetween(r, 5.0, 50.0))
            };
        }

        private static double RandomNumberBetween(Random random, double minValue, double maxValue)
        {
            var next = random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }
    }
}
