
using Grpc.Net.Client;
using grpcServer;

var channel = GrpcChannel.ForAddress("https://localhost:7151");

var greetClient = new Greeter.GreeterClient(channel);

HelloReply response = await greetClient.SayHelloAsync(new HelloRequest()
{
  Name = "Emre Barış Grpc Öğreniyor!"
});


Console.WriteLine(response);

Console.Read();