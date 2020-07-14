## Protocol Buffers
In order to use Protocol buffers, we need to first define a schema in a .proto file.
Once we have the schema ready, we need to compile the .proto file using a protoc compiler to generate a code based on the language of choice. In our case, it's CSharp.

## Compiler command
protoc generates a .cs file which contains classes that can be used within our program.

>.\protoc.exe --csharp_out=.\ \<filename>.proto

## Install nuget packages for protobuf support in C#. <br/>
<b>Google.ProtocolBuffers</b> uses packages that was developed by Google. 
>Install-Package Google.Protobuf <br/>Install-Package Google.Protobuf.Tools <br/>

<b>DotNet.ProtocolBuffers</b> uses packages that built in .net, this package is just a port of original google package rewritten in C#. 
>Install-Package protobuf-net

