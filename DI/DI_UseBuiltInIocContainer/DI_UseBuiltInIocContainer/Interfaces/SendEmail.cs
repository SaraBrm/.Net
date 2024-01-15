namespace DI_UseBuiltInIocContainer.Interfaces
{
    public class SendEmail : ISendMessage
    {
        private readonly IScopedService _scopedService;
        private readonly ITransientService _transientService;
        private readonly ISingletonService _singletonService;
        public SendEmail(
             IScopedService scopedService
            , ITransientService transientService
            , ISingletonService singletonService)
        {
            _scopedService = scopedService;
            _transientService = transientService;
            _singletonService = singletonService;
        }

        public void Send(string message)
        {
            //------
        }
    }
}
