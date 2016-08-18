using Newtonsoft.Json;

namespace Ders6
{
    public static class Helper
    {
        static public string ToJson(this object item)
        {
            var value = JsonConvert.SerializeObject(item);
            return value;
        }

        static public T FromJson<T>(string item)
        {
            return JsonConvert.DeserializeObject<T>(item);
        }
    }
}