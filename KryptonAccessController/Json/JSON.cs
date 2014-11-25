using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json.Converters;

namespace KryptonAccessController.Json
{
    public static class JSON
    {

        public static T parse<T>(string jsonString)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonString);

            //using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString)))
            //{
            //    return (T)new DataContractJsonSerializer(typeof(T)).ReadObject(ms);
            //}
        }

        public static string stringify(object jsonObject)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject
                , Newtonsoft.Json.Formatting.None
                , new Newtonsoft.Json.JsonSerializerSettings() { MaxDepth = int.MaxValue , NullValueHandling= Newtonsoft.Json.NullValueHandling.Include });

            //using (var ms = new MemoryStream())
            //{
            //    new DataContractJsonSerializer(jsonObject.GetType()).WriteObject(ms, jsonObject);
            //    return Encoding.UTF8.GetString(ms.ToArray());
            //}
        }
    }
}
