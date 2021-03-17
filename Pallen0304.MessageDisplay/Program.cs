namespace Pallen0304.MessageDisplay
{
    using NetMQ;
    using NetMQ.Sockets;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            using (var server = new ResponseSocket("@tcp://127.0.0.1:5556"))
            {
                while (true)
                {
                    string frame = server.ReceiveFrameString();
                    Console.WriteLine(frame);

                    server.SignalOK();
                }
            }
        }
    }
}
