using System.Threading.Tasks;
using Grpc.Net.Client;
using Aserto.Directory.Reader.V3;
using Aserto.Directory.Common.V3;


var handler = new HttpClientHandler();
handler.ServerCertificateCustomValidationCallback = 
    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

using var channel = GrpcChannel.ForAddress("https://localhost:9292", 
  new GrpcChannelOptions { HttpHandler = handler});

var client = new Reader.ReaderClient(channel);

var resp = await client.GetObjectsAsync(new GetObjectsRequest{ObjectType = "user", Page = new PaginationRequest{Size = 10}});

foreach (var r in resp.Results) {
  Console.WriteLine($"type: {r.Type} id: {r.Id}");
}
