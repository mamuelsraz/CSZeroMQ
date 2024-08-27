using System.Text;
using CSZeroMQ;
using CSZeroMQ.Constants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace CSZeroMQPublisher
{
    internal static class PubProgram
    {
        private static void Main(string[] args)
        {
            const string uri = "ipc:///zmq/zmq-socket";
            ZMQContext context = new ZMQContext();
            ZMQSocket pubSocket = new ZMQSocket(SocketType.Pub, context);

            pubSocket.Bind(uri);
            Console.WriteLine("Publisher bound to " + uri);

            while (true)
            {
                ReadOnlySpan<byte> msg = Encoding.UTF8.GetBytes("Hello world");
                pubSocket.Send(msg);
                Console.WriteLine("Sent: Hello world");
                Thread.Sleep(1);  // Send a message every second
            }
        }
    }
}