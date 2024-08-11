using Yelp.Entities.BusinessEntities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;

namespace Yelp.Repositories.BusinessRepos
{
    public interface IBusinessRepo
    {
 
        public void AddBusiness(Business business);
        public Business GetBusiness(Guid id);
        public void UpdateBusiness(Business business);
        public void DeleteBusiness(Guid id);
    }
}


/*
public static class BusinessEndpoints
{
	public static void MapBusinessEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Business").WithTags(nameof(Business));

        group.MapGet("/", () =>
        {
            return new [] { new Business() };
        })
        .WithName("GetAllBusinesses")
        .WithOpenApi();

        group.MapGet("/{id}", (int id) =>
        {
            //return new Business { ID = id };
        })
        .WithName("GetBusinessById")
        .WithOpenApi();

        group.MapPut("/{id}", (int id, Business input) =>
        {
            return TypedResults.NoContent();
        })
        .WithName("UpdateBusiness")
        .WithOpenApi();

        group.MapPost("/", (Business model) =>
        {
            //return TypedResults.Created($"/api/Businesses/{model.ID}", model);
        })
        .WithName("CreateBusiness")
        .WithOpenApi();

        group.MapDelete("/{id}", (int id) =>
        {
            //return TypedResults.Ok(new Business { ID = id });
        })
        .WithName("DeleteBusiness")
        .WithOpenApi();
    }
}
*/