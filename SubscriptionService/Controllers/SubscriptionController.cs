using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SubscriptionService.Logic;

namespace SubscriptionService.Controllers
{
    [Route("[controller]")]
    public class SubscriptionController : Controller
    {
        private readonly SubscriptionLogic _subscriptionLogic;

        public SubscriptionController()
        {
            _subscriptionLogic = new SubscriptionLogic();
        }


        public async Task<IActionResult> Index()
        {
            var subscriptions = await _subscriptionLogic.GetAllSubscriptions();
            return Ok(subscriptions);
        }
    }
}
