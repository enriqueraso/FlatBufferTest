using FlatBuffers;
using FlatBufferTest.Enums;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;
using OMTLS.FlatBuffers;

namespace FlatBufferTest.Commands
{
    [Command(Name = "serializeVectorOfUnion", Description = "Revert changes in testdata to a previous version")]
    internal sealed class SerializeVectorOfUnionCommand
    {
        public SerializeVectorOfUnionCommand(ILogger<SerializeVectorOfUnionCommand> logger)
        {
            Logger = logger;
        }

        [Option("-o|--output", Description = "Output file with serialization")]
        public string OutputFile { get; }

        [Option("-t|--type", Description = "Type of vector of union to serialize")]
        public VectorOfUnionEnum Type { get; }

        [Option("-v|--value", Description = "A list of values. A string value for DetailedException2 type and unsigned long value for DetailedException1 type.")]
        public string[] Values { get; }

        public async Task OnExecuteAsync()
        {
            byte[] bytes;
            
            if (Type == VectorOfUnionEnum.DetailedException3VectorOfOneType)
            {
                bytes = BuildDetailedException3VectorOfOneType();
            }
            else if (Type == VectorOfUnionEnum.DetailedException3VectorOfMultipleTypes)
            {
                bytes = BuildDetailedException3VectorOfMultipleTypes();
            }
            else
            {
                bytes = BuildDetailedException4Vector();
            }

            var fileName = $"{OutputFile}.{Type}.VectorOfUnion";
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

        private byte[] BuildDetailedException3VectorOfOneType()
        {
            var builder = new FlatBufferBuilder(1);
            var detailedException2Offsets = new Offset<DetailedException2>[Values.Length];
            var types = new OverallLikelyExceptionUnion[Values.Length];

            for (int i = 0; i < Values.Length; i++)
            {
                var exceptionValueOffset = builder.CreateString(Values[i]);
                detailedException2Offsets[i] = DetailedException2.CreateDetailedException2(builder, exceptionValueOffset);

                types[i] = OverallLikelyExceptionUnion.DetailedException2;
            }

            var typesOffset = DetailedException3Vector.CreateATypeVector(builder, types);
            var tablesOffset = builder.CreateVectorOfTables(detailedException2Offsets);

            var detailedException3VectorOffset = DetailedException3Vector.CreateDetailedException3Vector(builder, typesOffset, tablesOffset);
            builder.Finish(detailedException3VectorOffset.Value);

            return builder.SizedByteArray();
        }

        private byte[] BuildDetailedException3VectorOfMultipleTypes()
        {
            var builder = new FlatBufferBuilder(1);
            var detailedExceptionOffsets = new int[Values.Length];
            var types = new OverallLikelyExceptionUnion[Values.Length];

            for (int i = 0; i < Values.Length; i++)
            {
                if (ulong.TryParse(Values[i], out var exceptionValue))
                {
                    var detailedException1Offset = DetailedException1.CreateDetailedException1(builder, exceptionValue);
                    detailedExceptionOffsets[i] = detailedException1Offset.Value;

                    types[i] = OverallLikelyExceptionUnion.DetailedException1;
                }
                else
                {
                    var exceptionValueOffset = builder.CreateString(Values[i]);
                    var detailedException2Offset = DetailedException2.CreateDetailedException2(builder, exceptionValueOffset);
                    detailedExceptionOffsets[i] = detailedException2Offset.Value;

                    types[i] = OverallLikelyExceptionUnion.DetailedException2;
                }
            }

            var typesOffset = DetailedException3Vector.CreateATypeVector(builder, types);
            var tablesOffset = DetailedException3Vector.CreateAVector(builder, detailedExceptionOffsets);

            var detailedException3VectorOffset = DetailedException3Vector.CreateDetailedException3Vector(builder, typesOffset, tablesOffset);
            builder.Finish(detailedException3VectorOffset.Value);

            return builder.SizedByteArray();
        }

        private byte[] BuildDetailedException4Vector()
        {
            var builder = new FlatBufferBuilder(1);
            var detailedException4Offsets = new Offset<DetailedException4>[Values.Length];
            
            for (int i = 0; i < Values.Length; i++)
            {
                var messageOffset = builder.CreateString(Values[i]);
                detailedException4Offsets[i] = DetailedException4.CreateDetailedException4(builder, (ulong)i + 1, messageOffset);
            }

            var tablesOffset = DetailedException4Vector.CreateBVector(builder, detailedException4Offsets);

            var detailedException4VectorOffset = DetailedException4Vector.CreateDetailedException4Vector(builder, BOffset: tablesOffset);
            builder.Finish(detailedException4VectorOffset.Value);

            return builder.SizedByteArray();
        }

        private readonly ILogger<SerializeVectorOfUnionCommand> Logger;
    }
}
