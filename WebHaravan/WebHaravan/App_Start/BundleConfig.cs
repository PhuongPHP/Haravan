using System.Web;
using System.Web.Optimization;

namespace WebHaravan
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // CSS style (bootstrap)
            bundles.Add(new StyleBundle("~/Content/bootstrapCss").Include(
                       "~/Content/plugins/bootstrap.min.css"));

            // jQuery boostrap
            bundles.Add(new ScriptBundle("~/Scripts/bootstrapJs").Include(
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/jquery.unobtrusive-ajax.min.js",
                        "~/Scripts/jquery-3.5.1.min.js"));

            bundles.Add(new StyleBundle("~/Content/Style").Include(
                        "~/Content/plugins/PagedList.css",
                        "~/Content/css/style.css"));

            // Plugins Layout css
            bundles.Add(new StyleBundle("~/Content/pluginsLayout").Include(
                       "~/libs/plugins/fontawesome-free/css/all.min.css",
                       //"~/libs/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
                       //"~/libs/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
                       "~/libs/plugins/jqvmap/jqvmap.min.css",
                       "~/libs/dist/css/adminlte.min.css",
                       "~/Content/plugins/bootstrap.min.css"));
        }
    }
}
