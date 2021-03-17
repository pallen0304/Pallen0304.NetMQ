namespace Pallen0304.Common
{
    public interface ISerializer<T>
    {
        public string Serialize(T value);

        public T Deserialize(string value);
    }
}
