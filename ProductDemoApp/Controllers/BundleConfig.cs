﻿using System.Web;
using System.Web.Optimization;

namespace ProductDemoApp
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angularjs")
                .Include("~/Scripts/ng-infinite-scroll.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/respond.min.js"));

            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/bootstrap.min.css")
                .Include("~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/ProductDemoApp")
                .Include("~/Scripts/ProductDemoApp.js")
                .IncludeDirectory("~/Scripts/Service", "*.js")
                .IncludeDirectory("~/Scripts/Controllers", "*.js"));

        }
    }
}
