using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using AuroraVPN.Core.DTOs;
using AuroraVPN.DataLayer.Context;

namespace AuroraVPN.Core.Services
{
    public interface INewsletter
    {
        void SubscribeToNewsletter(string emailAddress);
    }

    public class Newsletter : INewsletter
    {
        private AuroraContext _context;
        public INotyfService _notyfService;

        public Newsletter(AuroraContext context,INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        public void SubscribeToNewsletter(string emailAddress)
        {
            DataLayer.Entities.Newsletter news = new DataLayer.Entities.Newsletter()
            {
                EmailAddress = emailAddress
            };
            _context.Newsletter.Add(news);
            _context.SaveChanges();
            _notyfService.Success("Successfully Subscribed !");
        }
    }
}
