using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using Resume_Service;
using Resume_Entities;

namespace Resume_Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeViewModel index = new HomeViewModel();
            index.MyServices= MyServicesService.Instance.MyServices();
            index.Clients = ConfigService.Instance.Clients();
            index.Testimonials = TestimonialService.Instance.Testimonials();
            index.Offers = OfferService.Instance.Offers();
            index.OffersDetails = OfferService.Instance.OffersDetails();
            index.Skills = SkillsService.Instance.Skills();
            index.SkillDetails = SkillsService.Instance.SkillDetails();
            return View(index);
        }
        [HttpPost]
        public ActionResult Contact(SendMeAMessage aMessage)
        {
            aMessage.Id = Guid.NewGuid();
            if(ModelState.IsValid)
            {
                using (SendMeMessageService service = new SendMeMessageService())
                {
                    service.Create(aMessage);
                    ModelState.Clear();
                }
            }
            
            return View("Index");

        }
        public FileResult Download()
        {
            string filepath = HostingEnvironment.MapPath("~" + ConfigService.Instance.GetValue("ResumePath").Value);
            byte[] fileBytes = System.IO.File.ReadAllBytes(filepath);
            var response = new FileContentResult(fileBytes, "application/octet-stream");
            response.FileDownloadName = ConfigService.Instance.GetValue("FullName").Value + ".pdf";
            return response;
        }
    }
}