using System.Web;
using System.Web.Optimization;

namespace ProcessAlgorithm.App_Start
{
    class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Contents/bootstrap/js/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Contents/js/script.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Contents/css/font-awesome.min.css",
                        "~/Contents/bootstrap/css/bootstrap.min.css",
                        "~/Contents/css/site.css"));
        }
    }
}
