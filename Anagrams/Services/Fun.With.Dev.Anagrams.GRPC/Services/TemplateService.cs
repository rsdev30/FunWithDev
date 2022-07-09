using Fun.With.Dev.Anagrams.GRPC;
using Grpc.Core;

namespace Fun.With.Dev.Anagrams.GRPC.Services
{
    public class AnagramsService   
    {
        private readonly ILogger<AnagramsService> _logger;
        public AnagramsService(ILogger<AnagramsService> logger)
        {
            _logger = logger;
        }

        public Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
}