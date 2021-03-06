﻿using System.Web.Mvc;

namespace NHibernate.CMS.MVC.Areas.Systems
{
    public class SystemsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Systems";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Systems_default",
                "Systems/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "NHibernate.CMS.MVC.Areas.Systems.Controllers" }
            );
        }
    }
}
