using ApiMicrosservicesProduct.Dtos;

using ApiMicrosservicesProduct.Services.Interfaces;

using Microsoft.AspNetCore.Mvc;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace ApiMicrosservicesProduct.Endpoints;

public static class ProductServiceEndpoint
{


    public static void MapProductServiceEndpoint(this WebApplication app)
    {


        var apiGroup = app.MapGroup("/api/v1/products");

        apiGroup.MapGet("/", async (IProductService service
         ) =>
        {

            var products = await service.GetItemsAsync();

            if (products == null || !products.Any()) 
                    Results.NotFound("No products found.");

            return Results.Ok(products);


        });

        apiGroup.MapGet("/{id}", async (
           [FromServices] IProductService service, int? id)
           =>
        {
            var product = await service.GetByIdAsync(id);
            if (product == null) return Results.NotFound("Product  Not Found");
            return Results.Ok(product);
        });

        apiGroup.MapGet("search/{keyword}", async (
        [FromServices] IProductService servive, string keyword
            ) =>
        {
            return Results.Ok(await servive.GetSearchProductsAsync(keyword));
        });

    }
}
