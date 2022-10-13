// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Sample.Connector
{
    using System.Web.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.Add(
                "DefaultViews", 
                new Route("views/{*path}", new DefaultRouteHandler())
            );
            
            ///routes.Add(
            ///    "Default", 
            ///    new Route("{*path}", new DefaultRouteHandler())
            ///);
            
            // should be last, after any custom route definition
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            
        }
    }
}
