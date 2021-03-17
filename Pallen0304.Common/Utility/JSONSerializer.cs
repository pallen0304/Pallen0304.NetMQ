namespace Pallen0304.Common
{
    using System.Text.Json;

    public class JSONSerializer<T> : ISerializer<T>
    {
        public string Serialize(T value)
        {
            return JsonSerializer.Serialize(value);
        }

        public T Deserialize(string value)
        {
            return JsonSerializer.Deserialize<T>(value);
        }
    }
}
