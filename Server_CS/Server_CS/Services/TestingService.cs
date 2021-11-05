using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace Server_CS
{
    public class TestingService : Testing.TestingBase
    {
        private readonly ILogger<TestingService> _logger;
        public TestingService(ILogger<TestingService> logger)
        {
            _logger = logger;
        }

        public override async Task<TestResp> TestService(TestReq request, ServerCallContext context)
        {
            Console.WriteLine("Service received operation request ...");
            Int32 rcvd_user_id = request.UserId;
            Console.WriteLine($"Received User ID: {rcvd_user_id}");

            Console.WriteLine("Communicating ...");
            var channel = GrpcChannel.ForAddress("https://localhost:5011");
            var callClient = new Calling.CallingClient(channel);
            var callRequest = new CallReq { CallerName = "Caller Name", CallerId = 67890 };
            var reply = await callClient.CallServiceAsync(callRequest);
            Console.WriteLine($"{reply.ReceiverName} {reply.ReceiverId}");
            Console.WriteLine("Communication finished ...");


            Console.WriteLine("Service is preparing data to respond operation request ...");
            TestResp sent_data = new TestResp();
            sent_data.FirstName = "First Name";
            sent_data.LastName = "Last Name";
            sent_data.Age = 30;

            Console.WriteLine("Servíce sent the operation response successfully ...");
            return await Task.FromResult(sent_data);
        }
    }
}
