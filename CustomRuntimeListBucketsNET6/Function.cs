using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Lambda.Core;
using Amazon.Lambda.DynamoDBEvents;
using Amazon.Lambda.RuntimeSupport;
using Amazon.Lambda.Serialization.SystemTextJson;
using System.Text.Json.Nodes;


// Lambda function that returns the list of S3 buckets.
var ConvertJsonOrder2Ordx = async (DynamoDBEvent dynamoDBEvent, ILambdaContext context) =>
{
   try
   {
       context.Logger.LogLine("db event received");

       context.Logger.LogLine($"number of records {dynamoDBEvent.Records.Count()}");

       CustomRuntimeListBucketsNET6.Ordx ordx = new CustomRuntimeListBucketsNET6.Ordx();
       foreach (var record in dynamoDBEvent.Records)
       {
           string orderJson = Document.FromAttributeMap(record.Dynamodb.NewImage).ToJson();
           context.Logger.LogLine(orderJson);



           const string hingeLocation = "L";
           int hinge1Position = 100;
           int hinge2Position = 200;
           int hinge3Position = 300;
           int hinge4Position = 400;
           int hinge5Position = 500;

           var order = JsonNode.Parse(orderJson);
           if (order == null) throw new Exception("Can't parse the order");
           JsonArray products = order["rooms"][0]["products"].AsArray();
           foreach (JsonNode product in order["rooms"][0]["products"].AsArray())
           {
               CustomRuntimeListBucketsNET6.Door door = new()
               {
                   Name = product["name"].GetValue<string>(),
                   Description = "",
                   Width = int.Parse(product["attributes"].AsArray().First(a => a["name"].GetValue<string>() == "width")["value"].GetValue<string>()),
                   Height = int.Parse(product["attributes"].AsArray().First(a => a["name"].GetValue<string>() == "height")["value"].GetValue<string>()),
                   Depth = int.Parse(product["attributes"].AsArray().First(a => a["name"].GetValue<string>() == "depth")["value"].GetValue<string>()),
                   HingeLocation = hingeLocation,
                   Hinge1Position = hinge1Position,
                   Hinge2Position = hinge2Position,
                   Hinge3Position = hinge3Position,
                   Hinge4Position = hinge4Position,
                   Hinge5Position = hinge5Position
               };

               ordx.AddDoor(door);
               context.Logger.LogLine($"door added");
           }
       }

        context.Logger.LogLine("saving to s3");
        var saveResult = await ordx.SaveAsync(context.Logger);
        context.Logger.LogLine($"saved to s3 statusCode:{saveResult.HttpStatusCode}");
        context.Logger.LogLine("sending email SES");
        var sendResult = await ordx.EmailAsync(context.Logger);
        context.Logger.LogLine($"sent email statusCode:{sendResult.HttpStatusCode}");
   }
   catch (Exception ex)
   {
       context.Logger.LogError(ex.Message);
   }

};

// Startup Lambda .NET runtime
using HandlerWrapper handlerWrapper = HandlerWrapper.GetHandlerWrapper(ConvertJsonOrder2Ordx, new DefaultLambdaJsonSerializer());
using var bootstrap = new LambdaBootstrap(handlerWrapper);
await bootstrap.RunAsync(); ;