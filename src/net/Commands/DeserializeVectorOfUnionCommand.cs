﻿using System.Collections.Generic;
using System.Diagnostics;
using FlatBuffers;
using FlatBufferTest.Enums;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;
using OMTLS.FlatBuffers;

namespace FlatBufferTest.Commands
{
    [Command(Name = "deserializeVectorOfUnion", Description = "Revert changes in testdata to a previous version")]
    internal sealed class DeserializeVectorOfUnionCommand
    {
        public DeserializeVectorOfUnionCommand(ILogger<DeserializeVectorOfUnionCommand> logger)
        {
            Logger = logger;
        }

        [Option("-i|--input", Description = "Input serialized file")]
        public string InputFile { get; }

        [Option("-t|--type", Description = "Type of serialized vector of union")]
        public VectorOfUnionEnum Type { get; }

        public async Task OnExecuteAsync()
        {
            var fileName = InputFile.Replace("{type}", Type.ToString());

            var bytes = await File.ReadAllBytesAsync(fileName);
            var buffer = new ByteBuffer(bytes);

            if (Type == VectorOfUnionEnum.DetailedException3VectorOfOneType)
            {
                DeserializeDetailedException3VectorOfOneType(buffer, fileName);
            }
            else if (Type == VectorOfUnionEnum.DetailedException3VectorOfMultipleTypes)
            {
                DeserializeDetailedException3VectorOfMultipleTypes(buffer, fileName);
            }
            else
            {
                DeserializeDetailedException4Vector(buffer);
            }

            return;
        }

        private void DeserializeDetailedException3VectorOfOneType(ByteBuffer buffer, string fileName)
        {
            var detailedException3Vector = DetailedException3Vector.GetRootAsDetailedException3Vector(buffer);
            Logger.LogInformation("DetailedException3Vector contains {length} items", detailedException3Vector.ATypeLength);

            Debug.Assert(detailedException3Vector.ATypeLength == detailedException3Vector.ALength, $"{fileName} is corrupt.");

            // Cannot use as it thrown an exception
            //var list = detailedException3Vector.GetATypeArray();
            
            for (int i = 0; i < detailedException3Vector.ALength; i++)
            {
                Logger.LogInformation("Item of type {Type}", detailedException3Vector.AType(i));
                var detailedException2 = detailedException3Vector.A<DetailedException2>(i);
                Logger.LogInformation("{exceptionValue}", detailedException2.Value._exceptionValue);
            }
        }

        private void DeserializeDetailedException3VectorOfMultipleTypes(ByteBuffer buffer, string fileName)
        {
            var detailedException3Vector = DetailedException3Vector.GetRootAsDetailedException3Vector(buffer);
            Logger.LogInformation("DetailedException3Vector contains {length} items", detailedException3Vector.ATypeLength);

            Debug.Assert(detailedException3Vector.ATypeLength == detailedException3Vector.ALength, $"{fileName} is corrupt.");

            // Cannot use as it thrown an exception
            //var list = detailedException3Vector.GetATypeArray();

            for (int i = 0; i < detailedException3Vector.ALength; i++)
            {
                var type = detailedException3Vector.AType(i);
                Logger.LogInformation("Item of type {Type}", type);

                if (type == OverallLikelyExceptionUnion.DetailedException1)
                {
                    var detailedException1 = detailedException3Vector.A<DetailedException1>(i);
                    Logger.LogInformation("{exceptionValue}", detailedException1.Value._exceptionValue);
                }
                else if (type == OverallLikelyExceptionUnion.DetailedException2)
                {
                    var detailedException2 = detailedException3Vector.A<DetailedException2>(i);
                    Logger.LogInformation("{exceptionValue}", detailedException2.Value._exceptionValue);
                }
                else
                {
                    throw new InvalidOperationException($"{type} not supported.");
                }
            }
        }

        private void DeserializeDetailedException4Vector(ByteBuffer buffer)
        {
            var detailedException4Vector = DetailedException4Vector.GetRootAsDetailedException4Vector(buffer);
            Logger.LogInformation("DetailedException4Vector contains {length} `B` items", detailedException4Vector.BLength);

            for (int i = 0; i < detailedException4Vector.BLength; i++)
            {
                var detailedException4 = detailedException4Vector.B(i);
                Logger.LogInformation("`B` item - {code} {message}", detailedException4.Value._code, detailedException4.Value._message);                
            }
        }

        private readonly ILogger<DeserializeVectorOfUnionCommand> Logger;
    }
}
