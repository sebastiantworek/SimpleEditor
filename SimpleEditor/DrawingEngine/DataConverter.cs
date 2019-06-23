using System;
using System.Collections.Generic;
using System.Text;
using DrawingEngine.Primitives;
using Newtonsoft.Json;

namespace DrawingEngine
{
    public class DataConverter
    {
        public Primitive ReadFromJson(string json)
        {
            return JsonConvert.DeserializeObject<Primitive>(json, new DataJsonConverter());
        }
    }
}
