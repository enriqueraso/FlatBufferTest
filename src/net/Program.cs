using FlatBufferTest.Commands;
using FlatBufferTest.Handlers;
using McMaster.Extensions.CommandLineUtils;
using McMaster.Extensions.Hosting.CommandLine;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace FlatBufferTest
{
    public static class Program
    {
        static Task<int> Main(string[] args)
        {
            try
            {
                var configuration = BuildConfiguration();

                return new HostBuilder().ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton(configuration);
                    services.AddSingleton<IUnhandledExceptionHandler, StoreExceptionHandler>();

                    services.AddLogging(logging =>
                    {
                        logging.ClearProviders();
                        //logging.AddConfiguration(configuration.GetSection("Logging"));
                        logging.AddNLog(new NLogLoggingConfiguration(configuration.GetSection("NLog")));
                    });

                }).RunCommandLineApplicationAsync<TestCommand>(args);
            }
            catch (CommandParsingException parsingEx)
            {
                Console.WriteLine(parsingEx.Message);
                return Task.FromResult(1);
            }
        }

        private static IConfiguration BuildConfiguration()
        {
            // Build configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", false, true)
                .Build();

            return configuration;
        }
    }
}
