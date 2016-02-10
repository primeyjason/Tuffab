using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;



namespace TuffabLibrary.CustomUI.Attributes
{
    public class AdminOnlyAuthorizeAttribute  : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            base.HandleUnauthorizedRequest(filterContext);

            HttpContext.Current.Response.Write("INVALLID AUTH");
        }
        protected override bool AuthorizeCore(System.Web.HttpContextBase httpContext)
        {
            return (System.Web.HttpContext.Current.Session["Administrator"] != null && (bool)System.Web.HttpContext.Current.Session["Administrator"] == true); 
        }
    }
}
