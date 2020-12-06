using System;
using System.Web.Http;

namespace Shop
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(ShopConfig.Register);
        }
    }
}