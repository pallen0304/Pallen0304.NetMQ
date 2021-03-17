using System;

namespace Pallen0304.Common
{
    public static class StrategySerializer
    {
        public static ISerializer<T> GetSerializer<T>(SerializerType serializerType)
        {
            switch (serializerType) {
                case SerializerType.JSON:
                    return new JSONSerializer<T>();
                default:
                    throw new NotImplementedException($"{Enum.GetName(typeof(SerializerType), serializerType)} not implemented in StrategySerializer.");
            }
        }
    }
}
