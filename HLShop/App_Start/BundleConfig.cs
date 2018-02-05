﻿using System.Web;
using System.Web.Optimization;

namespace HLShop
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

            //bundles.Add(new ScriptBundle("~/bundles/map").Include(
            //           "~/Scripts/map.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/common").Include(
            //           "~/Scripts/smooth.scroll.min.js",
            //           "~/Scripts/lightbox.min.js",
            //           "~/Scripts/lightbox.min.js"
            //           ));

            //bundles.Add(new ScriptBundle("~/bundles/datetime").Include(
            //          "~/Scripts/datepicker.en.min.js",
            //          "~/Scripts/datepicker.min.js",
            //          "~/Scripts/timepicki.min.js"
                      //));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      //"~/Content/bootstrap.min.css",
                      "~/Content/datepicker.min.css",
                      "~/Content/lightbox.min.css",
                      "~/Content/owl.carousel.min.css",
                      "~/Content/slider.min.css",
                      "~/Content/style.default.css",
                      "~/Content/timepicki.min.css",
                      "~/Content/site.css"));
        }
    }
}
