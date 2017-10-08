using Newtonsoft.Json;

namespace Serialisation
{
    class JsonSerializer : ISerializer
    {
        public T Deserialize<T>(string serialisedStr)
        {
            return JsonConvert.DeserializeObject<T>(serialisedStr);
        }

        public string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}