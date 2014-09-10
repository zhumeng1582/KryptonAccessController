using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace KryptonAccessController.Json
{
    public class TestJson
    {
        public static string  jsonSerialize()
        {
            
            JsonObject json = new JsonObject 
            {
                Key="1",
                Value="diyi"
            };
            JavaScriptSerializer jss = new JavaScriptSerializer();
            return jss.Serialize(json);

            /*
            var serializer = new JavaScriptSerializer();
            
            var ret = serializer.Deserialize<JsonObject>(json);

            string key = ret.Key;
            string value = ret.Value;*/
        }
        public static JsonObject jsonDeserialize(string jsonStr)
        {
            var serializer = new JavaScriptSerializer();

            var ret = serializer.Deserialize<JsonObject>(jsonStr);
            JsonObject json = new JsonObject();

            json.Key = ret.Key;
            json.Value = ret.Value;

            return json;
        }
    }

    
}
