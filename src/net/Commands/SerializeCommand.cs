using FlatBuffers;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;
using OMTLS.FlatBuffers;

namespace FlatBufferTest.Commands
{
    [Command(Name = "serialize", Description = "Revert changes in testdata to a previous version")]
    internal sealed class SerializeCommand
    {
        public SerializeCommand(ILogger<SerializeCommand> logger)
        {
            Logger = logger;
        }

        [Option("-o|--output", Description = "Output file with serialization")]
        public string OutputFile { get; }

        [Option("-t|--type", Description = "Type of object to serialize.")]
        public OverallLikelyExceptionUnion Type { get; }

        [Option("-v|--value", Description = "A string value for DetailedException2 type and unsigned long value for DetailedException1 type.")]
        public string Value { get; }

        [Option("-u|--union", Description = "Serialize as DetailedException3 type that contains a union of DetailedException2 and DetailedException1.")]
        public bool Union { get; } = false;

        public async Task OnExecuteAsync()
        {
            byte[] bytes;

            if (Type == OverallLikelyExceptionUnion.DetailedException2)
            {
                bytes = GetDetailedException2();
            }
            else if (Type == OverallLikelyExceptionUnion.DetailedException1)
            {
                bytes = GetDetailedException1();
            }
            else
            {
                bytes = GetNone();
            }

            var fileName = $"{OutputFile}.{Type}{(Union ? "" : ".simple")}";
            EnsurePathExists(fileName);

            await File.WriteAllBytesAsync(fileName, bytes);

            Logger.LogInformation("File '{fileName}' created.", fileName);
        }

        private static void EnsurePathExists(string fileName)
        {
            var path = Path.GetDirectoryName(fileName);
            if (Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private byte[] GetDetailedException2()
        {
            var builder = new FlatBufferBuilder(1);
            var exceptionValueOffset = builder.CreateString(Value);

            var detailedException2Offset = DetailedException2.CreateDetailedException2(builder, exceptionValueOffset);

            if (Union)
            {
                var detailedException3Offset = DetailedException3.CreateDetailedException3(builder, OverallLikelyExceptionUnion.DetailedException2, detailedException2Offset.Value);
                builder.Finish(detailedException3Offset.Value);
            }
            else
            {
                builder.Finish(detailedException2Offset.Value);
            }

            return builder.SizedByteArray();
        }

        private byte[] GetDetailedException1()
        {
            var builder = new FlatBufferBuilder(1);
            if (!ulong.TryParse(Value, out var value))
            {
                throw new ArgumentOutOfRangeException("You should provide an unsigned long value.");
            }

            var detailedException1Offset = DetailedException1.CreateDetailedException1(builder, value);

            if (Union)
            {
                var detailedException3Offset = DetailedException3.CreateDetailedException3(builder, OverallLikelyExceptionUnion.DetailedException2, detailedException1Offset.Value);
                builder.Finish(detailedException3Offset.Value);
            }
            else
            {
                builder.Finish(detailedException1Offset.Value);
            }
            
            return builder.SizedByteArray();
        }

        private byte[] GetNone()
        {
            if (!Union)
            {
                throw new InvalidOperationException($"Specify union argument to serialize {OverallLikelyExceptionUnion.NONE}.");
            }

            var builder = new FlatBufferBuilder(1);

            var detailedException3Offset = DetailedException3.CreateDetailedException3(builder, OverallLikelyExceptionUnion.NONE);

            builder.Finish(detailedException3Offset.Value);
            return builder.SizedByteArray();
        }

        private readonly ILogger<SerializeCommand> Logger;
    }
}
