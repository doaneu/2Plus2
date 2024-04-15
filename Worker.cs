namespace _2Plus2
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {

                Console.WriteLine("Running Calculation");

                int result = 2 + 2 + 1;

                Console.WriteLine("2 + 2 = " + result); ;
                
                await Task.Delay(2000, stoppingToken);
            }
        }
    }
}
