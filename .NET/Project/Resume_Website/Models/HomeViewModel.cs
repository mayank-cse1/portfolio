using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Resume_Entities;
using Resume_Service;
namespace Resume_Website
{
    public class HomeViewModel
    {
        public List<MyService> MyServices
        {
            get; set;
        }
        public List<Config> Clients
        {
            get; set;
        }
        public List<Testimonials> Testimonials
        { get; set; }

        public List<Offer> Offers
        { get; set; }
        public List<OfferDetails> OffersDetails
        { get; set; }

        public List<Skill> Skills
        { get; set; }
        public List<SkillDetails> SkillDetails
        { get; set; }
    }
}