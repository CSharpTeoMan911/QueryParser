using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QueryParser.Formatters
{
    internal class JsonSerializer
    {
        private static DefaultContractResolver contractResolver = new DefaultContractResolver();
        private static Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer()
        {
            ContractResolver = contractResolver
        };

        public string? AsyncJsonSerialiser<InsertType>(InsertType? item)
        {
            string? return_item = null;

            try
            {
                using (StringWriter tw = new StringWriter())
                {
                    using (JsonWriter writer = new JsonTextWriter(tw))
                    {
                        writer.Formatting = Formatting.Indented;
                        serializer.Serialize(writer, item);
                        return_item = tw.ToString();
                    }

                    tw?.Dispose();
                }
            }
            catch { }

            return return_item;
        }

        public string? SynchronousJsonSerialiser<InsertType>(InsertType? item)
        {
            string? return_item = null;

            try
            {
                using (StringWriter tw = new StringWriter())
                {
                    using (JsonWriter writer = new JsonTextWriter(tw))
                    {
                        writer.Formatting = Formatting.Indented;
                        serializer.Serialize(writer, item);
                        return_item = tw.ToString();
                    }

                    tw?.Dispose();
                }
            }
            catch { }

            return return_item;
        }
    }
}
