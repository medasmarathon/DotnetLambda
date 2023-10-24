using Amazon.Lambda.Annotations.APIGateway;
using Amazon.Lambda.Annotations;
using Amazon.Lambda.Core;
using DotnetLambda;
using DotnetLambda.Persistence;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace RandomProductFunction
{
    public class Functions
    {

        [LambdaFunction]
        [HttpApi(LambdaHttpMethod.Get, "/randomproduct/{id}")]
        public IHttpResult GetProduct([FromServices] RandomProductStore store, string id)
        {
            // Just a fake store, it will never return anything because the store is reset for every request (AWS Lambda is stateless)
            var product = store.GetRandomProduct(int.Parse(id));

            if (product == null)
            {
                return HttpResults.NotFound(new
                {
                    Error = $"Random product {id} not found"
                });
            }

            return HttpResults.Ok(product);
        }

        [LambdaFunction]
        [HttpApi(LambdaHttpMethod.Post, "/randomproduct")]
        public IHttpResult SetProduct([FromBody] RandomProduct info, [FromServices] RandomProductStore store, ILambdaContext context)
        {
            var result = store.UpsertRandomProduct(info);
            context.Logger.Log($"info id: {info.Id}, info summary: {info.Summary}");
            return HttpResults.Created($"/randomproduct/{result.Id}", result);
        }
    }
}