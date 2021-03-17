namespace Pallen0304.DocumentReader
{
    using FileHelpers;
    using NetMQ;
    using NetMQ.Sockets;
    using Pallen0304.Common;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var engine = new FileHelperEngine<Person>();

            var people = engine.ReadFileAsList("./Input/People.csv");

            using (var client = new RequestSocket(">tcp://127.0.0.1:5556"))
            {
                var serializer = StrategySerializer.GetSerializer<Person>(SerializerType.JSON);
                people.ForEach((person) =>
                {

                    // client sends message consisting of two frames

                    var serializedItem = serializer.Serialize(person);

                    Console.WriteLine("Client sending...");

                    client.SendFrame(serializedItem);

                    // client receives signal
                    if (client.ReceiveSignal())
                    {
                        Console.WriteLine("Received OK Signal, message was received.");
                    }
                    else
                    {
                        Console.WriteLine("Received ERROR Signal, message was not received.");
                    }
                });
                Console.ReadKey(true);
            }
        }
    }
}
