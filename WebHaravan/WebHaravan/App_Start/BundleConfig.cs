using System.Web;
using System.Web.Optimization;

namespace WebHaravan
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                        "~/Content/plugins/bootstrap.min.css"));

            bundles.Add(new ScriptBundle("~/Scripts/bootstrapJs").Include(
                     "~/Scripts/libs/bootstrap/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Jquery").Include(
                      "~/Scripts/jquery-3.5.1.min.js"));
            bundles.Add(new StyleBundle("~/Style/bundles").Include(
                      "~/Content/css/style.css"));
        }
    }
}
