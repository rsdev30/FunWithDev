using Fun.With.Dev.Template.GRPC;
using Grpc.Core;

namespace Fun.With.Dev.Template.GRPC.Services
{
    public class TemplateService   
    {
        private readonly ILogger<TemplateService> _logger;
        public TemplateService(ILogger<TemplateService> logger)
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