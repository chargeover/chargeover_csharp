using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ChargeOver
{
	public class CODateConverter : DateTimeConverterBase
	{
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return Date.Parse(reader.Value.ToString());
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			writer.WriteValue( ((Date)value).ToString("yyyy-MM-dd") );
		}
	}
}

