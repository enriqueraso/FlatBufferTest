# FlatBufferTest 

This repostiory contains an example of fbs schema that defines a union of a struct and a table. The aim is demonstrate it is possible to serialize and deserialize this type in Python. For this reason, SupportsAdvancedUnion feature was enabled in [idl_parser.cpp of a fork of Google FlatBuffers repository](https://github.com/enriqueraso/flatbuffers/blob/master/src/idl_parser.cpp), and flatc.exe was able to generate Python code.

## Content of this repository
* **deploy** folder contains different versions of flatc.exe and a PowerShell script to generate code from a fbs schema.
* **src** folder contains a C# and Python projects to do serialization and deseralization of a union type.
* **tests** folder contatins fbs schemas and generated code in C++, C# and Python using different versions of flatc.exe.

## Get started

Open [FlatBufferTest.sln](/src/net/FlatBufferTest.sln) and run it for each command line in [launchSettings.json](/src/net/Properties/launchSettings.json) that contains a serialize argument.

Run [test-deserialize-union.py](/src/python/test-deserialize-union.py) and you will obtain value serialized in each file from C# language.
