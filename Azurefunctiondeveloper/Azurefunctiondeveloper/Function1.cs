using Microsoft.Azure.Functions.Worker;   /// Aure func assessemn quese rders     


using Microsoft.Extensions.Logging;



namespace Azurefunctiondeveloper

{

    public class ProcessOrder

    {

        private readonly ILogger<ProcessOrder> _logger;



        public ProcessOrder(ILogger<ProcessOrder> logger)

        {

            _logger = logger;

        }



        [Function("ProcessOrder")]

        public void Run(

            [QueueTrigger("orders", Connection = "AzureWebJobsStorage")]

            string order)

        {

            _logger.LogInformation(

                "New order received: {order}", order);

        }

    }

}
