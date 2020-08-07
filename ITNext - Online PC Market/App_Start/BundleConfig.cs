using System.Web;
using System.Web.Optimization;

namespace ITNext___Online_PC_Market
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Scripts/js/bootstrap.min.js",
                      "~/Scripts/js/custom.js",
                      "~/Scripts/bootbox.js",
                      "~/Scripts/js/jquery.min.js",
                      "~/Scripts/js/menumaker.js",
                      "~/Scripts/js/wow.js",
                      "~/Scripts/js/jplist.core.min.js",
                      "~/Scripts/js/jplist.filter-dropdown-bundle.min.js",
                      "~/Scripts/js/jplist.pagination-bundle.min.js",
                      "~/Scripts/js/jplist.sort-bundle.min.js",
                      "~/Scripts/js/jplist.textbox-filter.min.js",
                      "~/Scripts/js/jquery.themepunch.revolution.min.js",
                      "~/Scripts/js/jquery.themepunch.tools.min.js",
                      "~/Scripts/js/extensions/revolution.extension.actions.min.js",
                      "~/Scripts/js/extensions/revolution.extension.carousel.min.js",
                      "~/Scripts/js/extensions/revolution.extension.kenburn.min.js",
                      "~/Scripts/js/extensions/revolution.extension.layeranimation.min.js",
                      "~/Scripts/js/extensions/revolution.extension.migration.min.js",
                      "~/Scripts/js/extensions/revolution.extension.navigation.min.js",
                      "~/Scripts/js/extensions/revolution.extension.parallax.min.js",
                      "~/Scripts/js/extensions/revolution.extension.slideanims.min.js",
                      "~/Scripts/js/extensions/revolution.extension.video.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/bootstrap.css",
                     "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/stil").Include(
                      "~/Content/ItNextTheme/bootstrap.min.css",
                      "~/Content/ItNextTheme/animate.css",
                      "~/Content/ItNextTheme/style.css",
                      "~/Content/ItNextTheme/responsive.css",
                      "~/Content/ItNextTheme/colors1.css",
                      "~/Content/ItNextTheme/custom.css",
                      "~/Content/ItNextTheme/settings.css",
                      "~/Content/ItNextTheme/layers.css",
                      "~/Content/ItNextTheme/navigation.css",
                      "~/Content/jplist.core.min.css",
                      "~/Content/jplist.textbox-filter.min.css",
                      "~/Content/font-awesome.css",
                      "~/Content/font-awesome.min.css"));
        }
    }
}
