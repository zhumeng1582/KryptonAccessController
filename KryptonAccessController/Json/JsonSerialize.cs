using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace KryptonAccessController.Json
{
    public class JsonSerialize
    {
        public static string jsonSerialize(Object json)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            return jss.Serialize(json);

            /*
            var serializer = new JavaScriptSerializer();
            
            var ret = serializer.Deserialize<JsonObject>(json);

            string key = ret.Key;
            string value = ret.Value;*/
        }
        public static Object jsonDeserialize(string jsonStr)
        {
            var serializer = new JavaScriptSerializer();

            Object json = serializer.Deserialize<Object>(jsonStr);
            return json;
        }
    }
}
