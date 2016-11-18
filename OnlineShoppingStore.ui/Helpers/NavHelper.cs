using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace OnlineShoppingStore.ui.Helpers
{
	public static class NavHelper
	{
        public static string isSelected(this HtmlHelper html, 
                                      string controller,
                                      string action,
                                      string classToAdd)
        {
            var currAction = (string)html.ViewContext.RouteData.Values["action"];
            var currController = (string)html.ViewContext.RouteData.Values["controller"];

            if (String.IsNullOrEmpty(action))
            {
                action = currAction;
            }

            if (String.IsNullOrEmpty(controller))
            {
                controller = currController;
            }

            return (action == currAction) && (controller == currController) ? classToAdd : "";
        }
	}
}