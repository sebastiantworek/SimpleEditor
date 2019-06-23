using System;
using System.Collections.Generic;
using System.Text;
using DataModel.Elements;
using DrawingEngine.Primitives;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DrawingEngine
{
    public class DataJsonConverter: JsonConverter<Primitive>
    {
        public override void WriteJson(JsonWriter writer, Primitive value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
        
        public override Primitive ReadJson(JsonReader reader, Type objectType, Primitive existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            var jObject = JToken.ReadFrom(reader);
            string type = jObject["type"].ToString();

            Primitive primitive = null;

            switch (type)
            {
                case "line":
                    primitive = new Line();
                    break;
                case "circle":
                    primitive = new Circle();
                    break;
                case "triangle":
                    primitive = new Triangle();
                    break;
                default:
                    throw new InvalidCastException();
            }
            
            serializer.Populate(reader, primitive);

            return primitive;
        }
    }
}
