using System.Web.Optimization;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(DoctorDrive.API.App_Start.BootstrapBundleConfig), "RegisterBundles")]

namespace DoctorDrive.API.App_Start
{
	public class BootstrapBundleConfig
	{
		public static void RegisterBundles()
		{
			// Add @Styles.Render("~/Content/bootstrap") in the <head/> of your _Layout.cshtml view
			// Add @Scripts.Render("~/bundles/bootstrap") after jQuery in your _Layout.cshtml view
			// When <compilation debug="true" />, MVC4 will render the full readable version. When set to <compilation debug="false" />, the minified version will be rendered automatically
            BundleTable.Bundles.Add(new ScriptBundle("~/Content/js/jquery").Include("~/Content/js/jquery-1.9.1.js"));
            BundleTable.Bundles.Add(new StyleBundle("~/Content/css/bootstrap").Include("~/Content/css/bootstrap.css", "~/Content/bootstrap-responsive.css"));
            BundleTable.Bundles.Add(new ScriptBundle("~/Content/js/bootstrap").Include("~/Content/js/bootstrap*"));

		}
	}
}
