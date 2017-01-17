using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace TTF.Api
{
	public class JsonForHtmlMediaTypeFormatter : JsonMediaTypeFormatter
	{
		public JsonForHtmlMediaTypeFormatter()
			: base()
		{
			SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

			// set some defaults
			SerializerSettings.DefaultValueHandling = DefaultValueHandling.Ignore;
			SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
			SerializerSettings.Converters.Add(new StringEnumConverter());
		}

		public override void SetDefaultContentHeaders(Type type, HttpContentHeaders headers, MediaTypeHeaderValue mediaType)
		{
			base.SetDefaultContentHeaders(type, headers, mediaType);
			headers.ContentType = new MediaTypeHeaderValue("application/json") { CharSet = mediaType == null ? "utf-8" : mediaType.CharSet };
		}
	}
}