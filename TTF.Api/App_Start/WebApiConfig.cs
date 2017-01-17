using System.Web.Http;

using Swashbuckle.Application;

namespace TTF.Api
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Web API configuration and services
			config.Formatters.Insert(0, new JsonForHtmlMediaTypeFormatter());

			config
				 .EnableSwagger(c =>
				 {
					 c.SingleApiVersion("v1", "API for TTF");
					 c.DescribeAllEnumsAsStrings();
				 })
				 .EnableSwaggerUi();

			// Web API routes
			config.MapHttpAttributeRoutes();

			//config.Routes.MapHttpRoute(
			//	name: "DefaultApi",
			//	routeTemplate: "api/{controller}/{id}",
			//	defaults: new { id = RouteParameter.Optional }
			//);
		}
	}
}
