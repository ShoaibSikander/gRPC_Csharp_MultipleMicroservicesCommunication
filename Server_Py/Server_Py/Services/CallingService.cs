using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server_Py
{
    public class CallingService : Calling.CallingBase
    {
        private readonly ILogger<CallingService> _logger;
        public CallingService(ILogger<CallingService> logger)
        {
            _logger = logger;
        }

        public override Task<CallResp> CallService(CallReq request, ServerCallContext context)
        {
            Console.WriteLine("Service received operation request ...");
            string rcvd_caller_name = request.CallerName;
            int rcvd_caller_id = request.CallerId;
            Console.WriteLine($"Received Caller Name: {rcvd_caller_name}, Received Caller ID: {rcvd_caller_id}");

            Console.WriteLine("Service is preparing data to respond operation request ...");
            CallResp sent_caller = new CallResp();
            sent_caller.ReceiverName = "Shoaib";
            sent_caller.ReceiverId = 24680;

            Console.WriteLine("Servíce sent the operation response successfully ...");
            return Task.FromResult(sent_caller);
        }
    }
}
