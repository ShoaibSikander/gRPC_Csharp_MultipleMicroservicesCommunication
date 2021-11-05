using System;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Client started !");
            
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var testClient = new Testing.TestingClient(channel);
            var testRequest = new TestReq { UserId = 12345 };
            var reply = await testClient.TestServiceAsync(testRequest);
            Console.WriteLine($"{reply.FirstName} {reply.LastName} {reply.Age}");
            /*
            var channel = GrpcChannel.ForAddress("https://localhost:5011");
            var callClient = new Calling.CallingClient(channel);
            var callRequest = new CallReq { CallerName = "Zohaib", CallerId = 159753 };
            var reply = await callClient.CallServiceAsync(callRequest);
            Console.WriteLine($"{reply.ReceiverName} {reply.ReceiverId}");
            */
        }
    }
}
