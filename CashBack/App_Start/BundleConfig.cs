﻿using System.Web;
using System.Web.Optimization;

namespace CashBack
{
    public class BundleConfig
    {
        //Дополнительные сведения об объединении см. по адресу: http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/jquery.simplyscroll.css",
                      "~/Content/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Content/Slick").Include(
                      "~/Content/Slick/slick.css",
                      "~/Content/Slick/slick-theme.css"));

            bundles.Add(new StyleBundle("~/Content/Custom").Include(
                      "~/Content/custom.css"));

            bundles.Add(new ScriptBundle("~/bundles/simplyscroll").Include(
                        "~/Scripts/jquery.simplyscroll.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/Slick").Include(
                        "~/Scripts/Slick/slick.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/CustomJs").Include(
                        "~/Scripts/site.js"));


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
            // используйте средство сборки на сайте http://modernizr.com, чтобы выбрать только нужные тесты.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
        }
    }
}
