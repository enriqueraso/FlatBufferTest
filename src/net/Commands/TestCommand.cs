using McMaster.Extensions.CommandLineUtils;

namespace FlatBufferTest.Commands
{
    [Command(Name = "Test"), Subcommand(typeof(SerializeCommand)), Subcommand(typeof(DeserializeCommand)),
        Subcommand(typeof(SerializeVectorOfUnionCommand)), Subcommand(typeof(DeserializeVectorOfUnionCommand))]
    internal class TestCommand
    {
        public TestCommand(CommandLineApplication app)
        {
            App = app;
        }

        public Task OnExecuteAsync()
        {
            App.ShowHelp();

            return Task.CompletedTask;
        }

        private readonly CommandLineApplication App;
    }
}
