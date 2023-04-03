using FlatBuffers;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;
using OMTLS.FlatBuffers;

namespace FlatBufferTest.Commands
{
    [Command(Name = "serializeVectorOfUnion", Description = "Revert changes in testdata to a previous version")]
    internal sealed class SerializeVectorOfUnionCommand
    {
        public SerializeVectorOfUnionCommand(ILogger<SerializeCommand> logger)
        {
            Logger = logger;
        }

        [Option("-o|--output", Description = "Output file with serialization")]
        public string OutputFile { get; }

        [Option("-v|--value", Description = "A list of values. A string value for DetailedException2 type and unsigned long value for DetailedException1 type.")]
        public string[] Values { get; }

        public async Task OnExecuteAsync()
        {
            var bytes = GetDetailedException4();
            var fileName = $"{OutputFile}.VectorOfUnions";
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

        private byte[] GetDetailedException4()
        {
            var builder = new FlatBufferBuilder(1);
            var detailedException2Offsets = new Offset<DetailedException2>[Values.Length];
            var types = new Offset<OverallLikelyExceptionUnion>[Values.Length];

            for (int i = 0; i < Values.Length; i++)
            {
                var exceptionValueOffset = builder.CreateString(Values[i]);
                var detailedException2Offset = DetailedException2.CreateDetailedException2(builder, exceptionValueOffset);
                detailedException2Offsets[i] = detailedException2Offset;
                types[i] = new Offset<OverallLikelyExceptionUnion>((int)OverallLikelyExceptionUnion.DetailedException2);
            }
                        
            var vectorOffset = builder.CreateVectorOfTables(detailedException2Offsets);
            var typesOffset = builder.CreateVectorOfTables(types);
            DetailedException3Vector.CreateDetailedException3Vector(builder, typesOffset, vectorOffset);

            return builder.SizedByteArray();
        }

        private readonly ILogger<SerializeCommand> Logger;
    }
}
