using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TTF.Api.Controllers
{
	[RoutePrefix("map")]
	public class MapController : ApiController
	{
		MappingEngineFactory factory = new MappingEngineFactory();

		private MappingResult Evaluate(MappingEngine engine, bool a, bool b, bool c, int d, int e, int f)
		{
			try
			{
				return engine.Map(a, b, c, d, e, f);
			}
			catch (MappingException me)
			{
				throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, me));
			}
		}
		
		[HttpGet]
		[Route("")]
		public MappingResult Base(bool a, bool b, bool c, int d, int e, int f)
		{
			return Evaluate(factory.CreateBase(), a, b, c, d, e, f);
		}

		[HttpGet]
		[Route("specialized1")]
		public MappingResult Specialized1(bool a, bool b, bool c, int d, int e, int f)
		{
			return Evaluate(factory.CreateSpecialized1(), a, b, c, d, e, f);
		}

		[HttpGet]
		[Route("specialized2")]
		public MappingResult Specialized2(bool a, bool b, bool c, int d, int e, int f)
		{
			return Evaluate(factory.CreateSpecialized2(), a, b, c, d, e, f);
		}
	}
}