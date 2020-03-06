using System.Web;
using System.Web.Optimization;

namespace WheelsOnDeal.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/assets/css/vendors.css",
                      "~/assets/css/style.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/assets/js/vendors.js",
                        "~/assets/js/app.js"));



            
        }
    }
}
