using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macaco.Infraestructure.Infra
{
	public class Serializer
	{
		public static string Serialize(dynamic objeto)
		{
			return ServiceStack.Text.JsonSerializer.SerializeToString(objeto, objeto.GetType());
		}

		public static T Deserialize<T>(string serialized)
		{
			return ServiceStack.Text.JsonSerializer.DeserializeFromString<T>(serialized);
		}
	}
}
