using System.Web.Configuration;
using System.Web.Mvc;
using System.Xml.XPath;

namespace OnlineShop1.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "OnlineShop1.Areas.Admin.Controllers" }
            );
        }
    }
}