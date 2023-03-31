using FlatBuffers;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;
using OMTLS.FlatBuffers;

namespace FlatBufferTest.Commands
{
    [Command(Name = "deserialize", Description = "Revert changes in testdata to a previous version")]
    internal sealed class DeserializeCommand
    {
        public DeserializeCommand(ILogger<DeserializeCommand> logger)
        {
            Logger = logger;
        }

        [Option("-i|--input", Description = "Input serialized file")]
        public string InputFile { get; }

        [Option("-t|--type", Description = "Type of object to deserialize")]
        public OverallLikelyExceptionUnion Type { get; }

        public async Task OnExecuteAsync()
        {
            var bytes = await File.ReadAllBytesAsync(InputFile);
            var buffer = new ByteBuffer(bytes);
            
            var detailedException3 = DetailedException3.GetRootAsDetailedException3(buffer);
            Logger.LogInformation("DetailedException3 contains type {Type}", detailedException3.AType);
            
            if (detailedException3.AType == OverallLikelyExceptionUnion.DetailedException2)
            {
                var detailedException2 = detailedException3.A<DetailedException2>().Value;
                Logger.LogInformation("_exceptionValue = {Value} ({Type})", detailedException2._exceptionValue, detailedException2._exceptionValue.GetType());
            }
            else if (detailedException3.AType == OverallLikelyExceptionUnion.DetailedException1)
            {
                var detailedException1 = detailedException3.A<DetailedException1>().Value;
                Logger.LogInformation("_exceptionValue = {Value} ({Type})", detailedException1._exceptionValue, detailedException1._exceptionValue.GetType());
            }
            else if (detailedException3.AType == OverallLikelyExceptionUnion.NONE)
            {
                Logger.LogInformation("No content in enum.");
            }
            else
            {
                Logger.LogError("Type not supported.");
            }

            return;
        }
        
        private readonly ILogger<DeserializeCommand> Logger;
    }
}
